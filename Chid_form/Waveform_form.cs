using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using NationalInstruments;
using NationalInstruments.DAQmx;

namespace phd_project_net_framework.Chid_form
{
    public partial class Waveform_form : Form
    {
        private AnalogMultiChannelReader analogInReader;
        private AIExcitationSource excitationSource;
        private AIAccelerometerSensitivityUnits sensitivityUnits;
        public AITerminalConfiguration terminalConfiguration;
        private AnalogEdgeStartTriggerSlope triggerSlope;
        private AICoupling inputCoupling;

        private Task myTask;
        private Task runningTask;
        private AsyncCallback analogCallback;
        private AnalogWaveform<double>[] data;
        private DataColumn[] dataColumn = null;
        private DataTable dataTable = null;
        
        private BindingSource bs_table = new BindingSource();
        public Waveform_form()
        {
            InitializeComponent();


            bs_table.DataSource = dataTable;
            buttonStop.Enabled = false;
            dataTable = new DataTable();
            comboBoxTriggerSlope.SelectedIndex = 0;
            comboBoxSensiUnits.SelectedIndex = 0;
            comboBoxExSource.SelectedIndex = 0;
            comboBoxTerminalConfig.SelectedIndex = 3;
            comboBoxInputCoupling.SelectedIndex = 0;

            comboBoxPhysicalChannel.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External));
            if (comboBoxPhysicalChannel.Items.Count>0)
            {
                comboBoxPhysicalChannel.SelectedIndex = 0;
            }
        }

        

        [STAThread]
        /*static void Main()
        {
            Application.EnableVisualStyles();
            Application.DoEvents();
            Application.Run(new Waveform_form());
        }*/

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(runningTask == null)
            {
                try
                {
                    buttonStop.Enabled = true;
                    buttonStart.Enabled = false;
                    
                    // Get slope value
                    switch(comboBoxTriggerSlope.SelectedItem.ToString())
                    {
                        case "Rising":
                            triggerSlope = AnalogEdgeStartTriggerSlope.Rising;
                            break;
                        case "Falling":
                        default:
                            triggerSlope = AnalogEdgeStartTriggerSlope.Falling;
                            break;
                    }
                    
                    // get sensitivity units
                    switch(comboBoxSensiUnits.SelectedItem.ToString())
                    {
                        case "mVolts/G": // Units mVolts/G
                            sensitivityUnits = AIAccelerometerSensitivityUnits.MillivoltsPerG;
                            break;
                        case "Volts/G":
                        default: // Units Volts/G
                            sensitivityUnits = AIAccelerometerSensitivityUnits.VoltsPerG;
                            break;
                    }
                    
                    //get terminal configuration
                    switch(comboBoxTerminalConfig.SelectedItem.ToString())
                    {
                        case "Rse":
                            terminalConfiguration = AITerminalConfiguration.Rse;
                            break;
                        case "Nrse":
                            terminalConfiguration = AITerminalConfiguration.Nrse;
                            break;
                        case "Differential":
                        default:
                            terminalConfiguration = AITerminalConfiguration.Differential;
                            break;
                        case "Pseudodifferential":
                            terminalConfiguration = AITerminalConfiguration.Pseudodifferential;
                            break;
                        case "Let NI-DAQ Choose":
                            terminalConfiguration = (AITerminalConfiguration)(-1);
                            break;
                    }

                    //get ex source
                    switch(comboBoxExSource.SelectedItem.ToString())
                    {
                        case "Internal":
                            excitationSource = AIExcitationSource.Internal;
                            break;
                        case "External":
                            excitationSource = AIExcitationSource.External;
                            break;
                        default:
                            excitationSource = AIExcitationSource.None;
                            break;
                    }

                    //get input coupling
                    switch(comboBoxInputCoupling.SelectedItem.ToString())
                    {
                        case "AC":
                            inputCoupling = AICoupling.AC;
                            break;
                        case "DC":
                            inputCoupling = AICoupling.DC;
                            break;
                        case "Gnd":
                            inputCoupling = AICoupling.Ground;
                            break;
                    }

                    //create new task
                    myTask = new Task();
                    AIChannel aIChannel;

                    //create virtual channel
                    aIChannel = myTask.AIChannels.CreateAccelerometerChannel(comboBoxPhysicalChannel.Text, "",
                        terminalConfiguration, Convert.ToDouble(numUpDownMinimumValue.Value), Convert.ToDouble(numUpDownMaximumValue.Value),
                        Convert.ToDouble(numUpDownSensitivity.Value), sensitivityUnits, excitationSource,
                        Convert.ToDouble(numUpDownExValue.Value), AIAccelerationUnits.G);

                    //setup input coupling
                    aIChannel.Coupling = inputCoupling;

                    //configure the timing parameters
                    myTask.Timing.ConfigureSampleClock("", Convert.ToDouble(numUpDownRate.Value),
                        SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples, 1000);

                    //configure the Analog trigger
                    myTask.Triggers.StartTrigger.ConfigureAnalogEdgeTrigger(textBoxTriggerSource.Text, triggerSlope,
                        Convert.ToDouble(numUpDownTiggerLevel.Value));

                    myTask.Triggers.StartTrigger.AnalogEdge.Hysteresis = Convert.ToDouble(numUpDownHysteresis.Value);

                    //verify the task
                    myTask.Control(TaskAction.Verify);

                    //prepare the table for data
                    InitializeDataTable(myTask.AIChannels, ref dataTable);
                    //chart1.DataSource = bs_table;
                    //chart1.Series["Series1"].XValueMember = "0";

                    runningTask = myTask;
                    analogInReader = new AnalogMultiChannelReader(myTask.Stream);
                    analogCallback = new AsyncCallback(AnalogInCallback);

                    //use synchronizecallbacks to specify that the object
                    //marshals callbacks across threads appropriately
                    analogInReader.SynchronizeCallbacks = true;
                    analogInReader.BeginReadWaveform(Convert.ToInt32(numUpDownSamples.Value), 
                        analogCallback, myTask);


                }
                catch(DaqException exception)
                {
                    //dispaly errors
                    MessageBox.Show(exception.Message);
                    runningTask = null;
                    myTask.Dispose();
                    buttonStop.Enabled = false;
                    buttonStart.Enabled = true;
                }
               }
            
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            // Dispose of the task
            runningTask = null;
            myTask.Dispose();
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
        }
        
        

        private void AnalogInCallback(IAsyncResult ar)
        {
            try
            {
                if (runningTask != null && runningTask == ar.AsyncState)
                {
                    // Read the available data from the channels
                    data = analogInReader.EndReadWaveform(ar);

                    // Plot your data here
                    dataToDataTable(data, ref dataTable);

                    // Check for and report any overloaded channels
                    /*if (overloadDetectionCheckBox.Checked)
                        ReportOverloadedChannels();*/

                    analogInReader.BeginMemoryOptimizedReadWaveform(Convert.ToInt32(numUpDownSamples.Value),
                        analogCallback, myTask, data);
                }
            }
            catch (DaqException exception)
            {
                // Display Errors
                MessageBox.Show(exception.Message);
                runningTask = null;
                myTask.Dispose();
                buttonStop.Enabled = false;
                buttonStart.Enabled = true;
            }
        }
        /*private void ReportOverloadedChannels()
        {
            // Check for and report any overloaded channels
            bool overloaded = myTask.Stream.OverloadedInputChannelsExist;
            overloadedChannelsListBox.Items.Clear();
            if (overloaded)
            {
                string[] chans = myTask.Stream.OverloadedInputChannels;
                overloadedChannelsListBox.Items.AddRange(chans);
            }
            overloadDetectedTextBox.Text = overloaded ? "Yes" : "No";
        }*/

        private void dataToDataTable(AnalogWaveform<double>[] sourceArray, ref DataTable dataTable)
        {
            // Iterate over channels
            int currentLineIndex = 0;
            foreach (AnalogWaveform<double> waveform in sourceArray)
            {
                for (int sample = 0; sample < waveform.Samples.Count; ++sample)
                {
                    if (sample == 10)
                        break;

                    dataTable.Rows[sample][currentLineIndex] = waveform.Samples[sample].Value;
                }
                currentLineIndex++;
            }
        }
        
        public void InitializeDataTable(AIChannelCollection channelCollection, ref DataTable data)
        {
            int numOfChannels = channelCollection.Count;
            data.Rows.Clear();
            data.Columns.Clear();
            dataColumn = new DataColumn[numOfChannels];
            int numOfRows = 10;

            for (int currentChannelIndex = 0; currentChannelIndex < numOfChannels; currentChannelIndex++)
            {
                dataColumn[currentChannelIndex] = new DataColumn();
                dataColumn[currentChannelIndex].DataType = typeof(double);
                dataColumn[currentChannelIndex].ColumnName = channelCollection[currentChannelIndex].PhysicalName;
            }

            data.Columns.AddRange(dataColumn);

            for (int currentDataIndex = 0; currentDataIndex < numOfRows; currentDataIndex++)
            {
                object[] rowArr = new object[numOfChannels];
                data.Rows.Add(rowArr);
            }
        }
        public void SaveSettings()
        {
            //save settings
            Properties.Settings.Default.physicalChannel = comboBoxPhysicalChannel.Text;
            Properties.Settings.Default.Rate = Convert.ToDouble(numUpDownRate.Value);
            Properties.Settings.Default.Samples = Convert.ToInt32(numUpDownSamples.Value);
            Properties.Settings.Default.triggerSource = textBoxTriggerSource.Text;
            Properties.Settings.Default.triggerSlope = triggerSlope;
            Properties.Settings.Default.triggerLevel = Convert.ToDouble(numUpDownTiggerLevel.Value);
            Properties.Settings.Default.Hysteresis = Convert.ToDouble(numUpDownHysteresis.Value);
            Properties.Settings.Default.inputCoupling = inputCoupling;
            Properties.Settings.Default.Sensitivity = Convert.ToDouble(numUpDownSensitivity.Value);
            Properties.Settings.Default.sensitivityUnits = sensitivityUnits;
            Properties.Settings.Default.excitationSource = excitationSource;
            Properties.Settings.Default.excitationValue = Convert.ToDouble(numUpDownExValue.Value);
            Properties.Settings.Default.MinVal = Convert.ToDouble(numUpDownMinimumValue.Value);
            Properties.Settings.Default.MaxVal = Convert.ToDouble(numUpDownMaximumValue.Value);

            Properties.Settings.Default.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}
