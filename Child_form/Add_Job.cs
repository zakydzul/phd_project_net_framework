using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using phd_project_net_framework.Costum_Class;
using NationalInstruments;
using NationalInstruments.DAQmx;

namespace phd_project_net_framework.Child_form
{
    public partial class Add_Job : Form
    {

        public Add_Job()
        {

            InitializeComponent();

            comboBoxSensiUnits.SelectedIndex = 0;
            comboBoxExSource.SelectedIndex = 0;
            comboBoxTerminalConfig.SelectedIndex = 3;
            comboBoxInputCoupling.SelectedIndex = 0;
            comboBoxPhysicalChannel.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External));
            if (comboBoxPhysicalChannel.Items.Count > 0)
            {
                comboBoxPhysicalChannel.SelectedIndex = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBoxJobName.Text.Trim().Length < 0)
            {
                MessageBox.Show("Job Name si Empty");
                return;
            }

            if (btnSave.Text == "Save")
            {
                Job job = new Job();
                job.Name = txtBoxJobName.Text;
                job.Physical_Channel = comboBoxPhysicalChannel.Text;
                job.MinVal = Convert.ToDecimal(numUpDownMinimumValue.Text);
                job.MaxVal = Convert.ToDecimal(numUpDownMaximumValue.Text);       
                job.Rate = Convert.ToDouble(numUpDownRate.Value);  
                job.Samples = Convert.ToInt32(numUpDownSamples.Value);
                job.Sensitivity = Convert.ToDouble(numUpDownSensitivity.Text);
                job.Sens_Units = comboBoxSensiUnits.Text;
                job.Input_Coupling = comboBoxInputCoupling.Text;
                job.Terminal_Coupling = comboBoxTerminalConfig.Text;
                job.Excitation_Source = comboBoxExSource.Text;
                job.Excitaion_Val = Convert.ToDouble(numUpDownExValue.Text);
                DbJob.AddJob(job);
                txtBoxJobName.Clear();
                
                
            }

        }
    }
}
