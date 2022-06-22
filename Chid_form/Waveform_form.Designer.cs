namespace phd_project_net_framework.Chid_form
{
    partial class Waveform_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                if (myTask != null)
                {
                    runningTask = null;
                    myTask.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxDeviceParameters = new System.Windows.Forms.GroupBox();
            this.comboBoxInputCoupling = new System.Windows.Forms.ComboBox();
            this.comboBoxExSource = new System.Windows.Forms.ComboBox();
            this.comboBoxTerminalConfig = new System.Windows.Forms.ComboBox();
            this.labelTerminalConfig = new System.Windows.Forms.Label();
            this.labelInputCoupling = new System.Windows.Forms.Label();
            this.numUpDownExValue = new System.Windows.Forms.NumericUpDown();
            this.labelExSource = new System.Windows.Forms.Label();
            this.labelExValue = new System.Windows.Forms.Label();
            this.groupBoxAcceleroParameters = new System.Windows.Forms.GroupBox();
            this.numUpDownSensitivity = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSensiUnits = new System.Windows.Forms.ComboBox();
            this.labelSensiUnits = new System.Windows.Forms.Label();
            this.labelSensitivity = new System.Windows.Forms.Label();
            this.groupBoxTriggerParameters = new System.Windows.Forms.GroupBox();
            this.textBoxTriggerSource = new System.Windows.Forms.TextBox();
            this.comboBoxTriggerSlope = new System.Windows.Forms.ComboBox();
            this.labelTriggerSlope = new System.Windows.Forms.Label();
            this.labelTriggerSource = new System.Windows.Forms.Label();
            this.numUpDownHysteresis = new System.Windows.Forms.NumericUpDown();
            this.numUpDownTiggerLevel = new System.Windows.Forms.NumericUpDown();
            this.labelTriggerLevel = new System.Windows.Forms.Label();
            this.labelHysteresis = new System.Windows.Forms.Label();
            this.groupBoxTimingParameters = new System.Windows.Forms.GroupBox();
            this.numUpDownSamples = new System.Windows.Forms.NumericUpDown();
            this.numUpDownRate = new System.Windows.Forms.NumericUpDown();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelSamples = new System.Windows.Forms.Label();
            this.groupBoxChannelParameters = new System.Windows.Forms.GroupBox();
            this.numUpDownMaximumValue = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMinimumValue = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPhysicalChannel = new System.Windows.Forms.ComboBox();
            this.labelMaximumValue = new System.Windows.Forms.Label();
            this.labelMinimumValue = new System.Windows.Forms.Label();
            this.labelPhysicalChannel = new System.Windows.Forms.Label();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxDeviceParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownExValue)).BeginInit();
            this.groupBoxAcceleroParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSensitivity)).BeginInit();
            this.groupBoxTriggerParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHysteresis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTiggerLevel)).BeginInit();
            this.groupBoxTimingParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRate)).BeginInit();
            this.groupBoxChannelParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaximumValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinimumValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.formsPlot1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(968, 671);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.groupBoxDeviceParameters);
            this.panel1.Controls.Add(this.groupBoxAcceleroParameters);
            this.panel1.Controls.Add(this.groupBoxTriggerParameters);
            this.panel1.Controls.Add(this.groupBoxTimingParameters);
            this.panel1.Controls.Add(this.groupBoxChannelParameters);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(269, 665);
            this.panel1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 634);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Crimson;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStop.Location = new System.Drawing.Point(134, 605);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(113, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Navy;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStart.Location = new System.Drawing.Point(21, 605);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(107, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Run";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxDeviceParameters
            // 
            this.groupBoxDeviceParameters.Controls.Add(this.comboBoxInputCoupling);
            this.groupBoxDeviceParameters.Controls.Add(this.comboBoxExSource);
            this.groupBoxDeviceParameters.Controls.Add(this.comboBoxTerminalConfig);
            this.groupBoxDeviceParameters.Controls.Add(this.labelTerminalConfig);
            this.groupBoxDeviceParameters.Controls.Add(this.labelInputCoupling);
            this.groupBoxDeviceParameters.Controls.Add(this.numUpDownExValue);
            this.groupBoxDeviceParameters.Controls.Add(this.labelExSource);
            this.groupBoxDeviceParameters.Controls.Add(this.labelExValue);
            this.groupBoxDeviceParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDeviceParameters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxDeviceParameters.Location = new System.Drawing.Point(5, 457);
            this.groupBoxDeviceParameters.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBoxDeviceParameters.Name = "groupBoxDeviceParameters";
            this.groupBoxDeviceParameters.Size = new System.Drawing.Size(259, 147);
            this.groupBoxDeviceParameters.TabIndex = 4;
            this.groupBoxDeviceParameters.TabStop = false;
            this.groupBoxDeviceParameters.Text = "Device Parameters";
            // 
            // comboBoxInputCoupling
            // 
            this.comboBoxInputCoupling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInputCoupling.FormattingEnabled = true;
            this.comboBoxInputCoupling.Items.AddRange(new object[] {
            "AC",
            "DC",
            "Gnd"});
            this.comboBoxInputCoupling.Location = new System.Drawing.Point(127, 24);
            this.comboBoxInputCoupling.Name = "comboBoxInputCoupling";
            this.comboBoxInputCoupling.Size = new System.Drawing.Size(120, 21);
            this.comboBoxInputCoupling.TabIndex = 19;
            // 
            // comboBoxExSource
            // 
            this.comboBoxExSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExSource.FormattingEnabled = true;
            this.comboBoxExSource.Items.AddRange(new object[] {
            "Internal",
            "External",
            "None"});
            this.comboBoxExSource.Location = new System.Drawing.Point(127, 79);
            this.comboBoxExSource.Name = "comboBoxExSource";
            this.comboBoxExSource.Size = new System.Drawing.Size(120, 21);
            this.comboBoxExSource.TabIndex = 18;
            // 
            // comboBoxTerminalConfig
            // 
            this.comboBoxTerminalConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTerminalConfig.FormattingEnabled = true;
            this.comboBoxTerminalConfig.Items.AddRange(new object[] {
            "Rse",
            "Nrse",
            "Differential",
            "Pseudodifferential",
            "Let NI-DAQ Choose"});
            this.comboBoxTerminalConfig.Location = new System.Drawing.Point(127, 51);
            this.comboBoxTerminalConfig.Name = "comboBoxTerminalConfig";
            this.comboBoxTerminalConfig.Size = new System.Drawing.Size(120, 21);
            this.comboBoxTerminalConfig.TabIndex = 16;
            // 
            // labelTerminalConfig
            // 
            this.labelTerminalConfig.AutoSize = true;
            this.labelTerminalConfig.Location = new System.Drawing.Point(18, 53);
            this.labelTerminalConfig.Name = "labelTerminalConfig";
            this.labelTerminalConfig.Size = new System.Drawing.Size(83, 13);
            this.labelTerminalConfig.TabIndex = 15;
            this.labelTerminalConfig.Text = "Terminal Config:";
            // 
            // labelInputCoupling
            // 
            this.labelInputCoupling.AutoSize = true;
            this.labelInputCoupling.Location = new System.Drawing.Point(18, 27);
            this.labelInputCoupling.Name = "labelInputCoupling";
            this.labelInputCoupling.Size = new System.Drawing.Size(78, 13);
            this.labelInputCoupling.TabIndex = 14;
            this.labelInputCoupling.Text = "Input Coupling:";
            // 
            // numUpDownExValue
            // 
            this.numUpDownExValue.DecimalPlaces = 3;
            this.numUpDownExValue.Location = new System.Drawing.Point(127, 106);
            this.numUpDownExValue.Name = "numUpDownExValue";
            this.numUpDownExValue.Size = new System.Drawing.Size(120, 20);
            this.numUpDownExValue.TabIndex = 13;
            this.numUpDownExValue.Value = new decimal(new int[] {
            4,
            0,
            0,
            196608});
            // 
            // labelExSource
            // 
            this.labelExSource.AutoSize = true;
            this.labelExSource.Location = new System.Drawing.Point(18, 79);
            this.labelExSource.Name = "labelExSource";
            this.labelExSource.Size = new System.Drawing.Size(90, 13);
            this.labelExSource.TabIndex = 10;
            this.labelExSource.Text = "Exication Source:";
            // 
            // labelExValue
            // 
            this.labelExValue.AutoSize = true;
            this.labelExValue.Location = new System.Drawing.Point(18, 105);
            this.labelExValue.Name = "labelExValue";
            this.labelExValue.Size = new System.Drawing.Size(102, 13);
            this.labelExValue.TabIndex = 11;
            this.labelExValue.Text = "Excitation Value (V):";
            // 
            // groupBoxAcceleroParameters
            // 
            this.groupBoxAcceleroParameters.Controls.Add(this.numUpDownSensitivity);
            this.groupBoxAcceleroParameters.Controls.Add(this.comboBoxSensiUnits);
            this.groupBoxAcceleroParameters.Controls.Add(this.labelSensiUnits);
            this.groupBoxAcceleroParameters.Controls.Add(this.labelSensitivity);
            this.groupBoxAcceleroParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAcceleroParameters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxAcceleroParameters.Location = new System.Drawing.Point(5, 369);
            this.groupBoxAcceleroParameters.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBoxAcceleroParameters.Name = "groupBoxAcceleroParameters";
            this.groupBoxAcceleroParameters.Size = new System.Drawing.Size(259, 88);
            this.groupBoxAcceleroParameters.TabIndex = 3;
            this.groupBoxAcceleroParameters.TabStop = false;
            this.groupBoxAcceleroParameters.Text = "Accelerometer Parameters";
            // 
            // numUpDownSensitivity
            // 
            this.numUpDownSensitivity.DecimalPlaces = 2;
            this.numUpDownSensitivity.Location = new System.Drawing.Point(128, 25);
            this.numUpDownSensitivity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownSensitivity.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDownSensitivity.Name = "numUpDownSensitivity";
            this.numUpDownSensitivity.Size = new System.Drawing.Size(120, 20);
            this.numUpDownSensitivity.TabIndex = 17;
            this.numUpDownSensitivity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // comboBoxSensiUnits
            // 
            this.comboBoxSensiUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensiUnits.FormattingEnabled = true;
            this.comboBoxSensiUnits.Items.AddRange(new object[] {
            "mVolts/G",
            "Volts/G"});
            this.comboBoxSensiUnits.Location = new System.Drawing.Point(127, 51);
            this.comboBoxSensiUnits.Name = "comboBoxSensiUnits";
            this.comboBoxSensiUnits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSensiUnits.TabIndex = 16;
            // 
            // labelSensiUnits
            // 
            this.labelSensiUnits.AutoSize = true;
            this.labelSensiUnits.Location = new System.Drawing.Point(18, 53);
            this.labelSensiUnits.Name = "labelSensiUnits";
            this.labelSensiUnits.Size = new System.Drawing.Size(84, 13);
            this.labelSensiUnits.TabIndex = 15;
            this.labelSensiUnits.Text = "Sensitivity Units:";
            // 
            // labelSensitivity
            // 
            this.labelSensitivity.AutoSize = true;
            this.labelSensitivity.Location = new System.Drawing.Point(18, 27);
            this.labelSensitivity.Name = "labelSensitivity";
            this.labelSensitivity.Size = new System.Drawing.Size(57, 13);
            this.labelSensitivity.TabIndex = 14;
            this.labelSensitivity.Text = "Sensitivity:";
            // 
            // groupBoxTriggerParameters
            // 
            this.groupBoxTriggerParameters.Controls.Add(this.textBoxTriggerSource);
            this.groupBoxTriggerParameters.Controls.Add(this.comboBoxTriggerSlope);
            this.groupBoxTriggerParameters.Controls.Add(this.labelTriggerSlope);
            this.groupBoxTriggerParameters.Controls.Add(this.labelTriggerSource);
            this.groupBoxTriggerParameters.Controls.Add(this.numUpDownHysteresis);
            this.groupBoxTriggerParameters.Controls.Add(this.numUpDownTiggerLevel);
            this.groupBoxTriggerParameters.Controls.Add(this.labelTriggerLevel);
            this.groupBoxTriggerParameters.Controls.Add(this.labelHysteresis);
            this.groupBoxTriggerParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTriggerParameters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxTriggerParameters.Location = new System.Drawing.Point(5, 222);
            this.groupBoxTriggerParameters.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBoxTriggerParameters.Name = "groupBoxTriggerParameters";
            this.groupBoxTriggerParameters.Size = new System.Drawing.Size(259, 147);
            this.groupBoxTriggerParameters.TabIndex = 2;
            this.groupBoxTriggerParameters.TabStop = false;
            this.groupBoxTriggerParameters.Text = "Trigger Parameters";
            // 
            // textBoxTriggerSource
            // 
            this.textBoxTriggerSource.Location = new System.Drawing.Point(127, 24);
            this.textBoxTriggerSource.Name = "textBoxTriggerSource";
            this.textBoxTriggerSource.Size = new System.Drawing.Size(120, 20);
            this.textBoxTriggerSource.TabIndex = 17;
            this.textBoxTriggerSource.Text = "APFI0";
            // 
            // comboBoxTriggerSlope
            // 
            this.comboBoxTriggerSlope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTriggerSlope.FormattingEnabled = true;
            this.comboBoxTriggerSlope.Items.AddRange(new object[] {
            "Rising",
            "Falling"});
            this.comboBoxTriggerSlope.Location = new System.Drawing.Point(127, 51);
            this.comboBoxTriggerSlope.Name = "comboBoxTriggerSlope";
            this.comboBoxTriggerSlope.Size = new System.Drawing.Size(120, 21);
            this.comboBoxTriggerSlope.TabIndex = 16;
            // 
            // labelTriggerSlope
            // 
            this.labelTriggerSlope.AutoSize = true;
            this.labelTriggerSlope.Location = new System.Drawing.Point(18, 53);
            this.labelTriggerSlope.Name = "labelTriggerSlope";
            this.labelTriggerSlope.Size = new System.Drawing.Size(73, 13);
            this.labelTriggerSlope.TabIndex = 15;
            this.labelTriggerSlope.Text = "Trigger Slope:";
            // 
            // labelTriggerSource
            // 
            this.labelTriggerSource.AutoSize = true;
            this.labelTriggerSource.Location = new System.Drawing.Point(18, 27);
            this.labelTriggerSource.Name = "labelTriggerSource";
            this.labelTriggerSource.Size = new System.Drawing.Size(74, 13);
            this.labelTriggerSource.TabIndex = 14;
            this.labelTriggerSource.Text = "Triger Source:";
            // 
            // numUpDownHysteresis
            // 
            this.numUpDownHysteresis.DecimalPlaces = 2;
            this.numUpDownHysteresis.Location = new System.Drawing.Point(127, 106);
            this.numUpDownHysteresis.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownHysteresis.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numUpDownHysteresis.Name = "numUpDownHysteresis";
            this.numUpDownHysteresis.Size = new System.Drawing.Size(120, 20);
            this.numUpDownHysteresis.TabIndex = 13;
            // 
            // numUpDownTiggerLevel
            // 
            this.numUpDownTiggerLevel.DecimalPlaces = 2;
            this.numUpDownTiggerLevel.Location = new System.Drawing.Point(127, 79);
            this.numUpDownTiggerLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownTiggerLevel.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numUpDownTiggerLevel.Name = "numUpDownTiggerLevel";
            this.numUpDownTiggerLevel.Size = new System.Drawing.Size(120, 20);
            this.numUpDownTiggerLevel.TabIndex = 12;
            // 
            // labelTriggerLevel
            // 
            this.labelTriggerLevel.AutoSize = true;
            this.labelTriggerLevel.Location = new System.Drawing.Point(18, 79);
            this.labelTriggerLevel.Name = "labelTriggerLevel";
            this.labelTriggerLevel.Size = new System.Drawing.Size(87, 13);
            this.labelTriggerLevel.TabIndex = 10;
            this.labelTriggerLevel.Text = "Trigger Level (g):";
            // 
            // labelHysteresis
            // 
            this.labelHysteresis.AutoSize = true;
            this.labelHysteresis.Location = new System.Drawing.Point(18, 105);
            this.labelHysteresis.Name = "labelHysteresis";
            this.labelHysteresis.Size = new System.Drawing.Size(73, 13);
            this.labelHysteresis.TabIndex = 11;
            this.labelHysteresis.Text = "Hysteresis (g):";
            // 
            // groupBoxTimingParameters
            // 
            this.groupBoxTimingParameters.Controls.Add(this.numUpDownSamples);
            this.groupBoxTimingParameters.Controls.Add(this.numUpDownRate);
            this.groupBoxTimingParameters.Controls.Add(this.labelRate);
            this.groupBoxTimingParameters.Controls.Add(this.labelSamples);
            this.groupBoxTimingParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTimingParameters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxTimingParameters.Location = new System.Drawing.Point(5, 132);
            this.groupBoxTimingParameters.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.groupBoxTimingParameters.Name = "groupBoxTimingParameters";
            this.groupBoxTimingParameters.Size = new System.Drawing.Size(259, 90);
            this.groupBoxTimingParameters.TabIndex = 1;
            this.groupBoxTimingParameters.TabStop = false;
            this.groupBoxTimingParameters.Text = "Timing Parameters";
            // 
            // numUpDownSamples
            // 
            this.numUpDownSamples.Location = new System.Drawing.Point(127, 53);
            this.numUpDownSamples.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDownSamples.Name = "numUpDownSamples";
            this.numUpDownSamples.Size = new System.Drawing.Size(120, 20);
            this.numUpDownSamples.TabIndex = 9;
            this.numUpDownSamples.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numUpDownRate
            // 
            this.numUpDownRate.DecimalPlaces = 2;
            this.numUpDownRate.Location = new System.Drawing.Point(127, 25);
            this.numUpDownRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpDownRate.Name = "numUpDownRate";
            this.numUpDownRate.Size = new System.Drawing.Size(120, 20);
            this.numUpDownRate.TabIndex = 8;
            this.numUpDownRate.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(14, 27);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(55, 13);
            this.labelRate.TabIndex = 6;
            this.labelRate.Text = "Rate (Hz):";
            // 
            // labelSamples
            // 
            this.labelSamples.AutoSize = true;
            this.labelSamples.Location = new System.Drawing.Point(14, 56);
            this.labelSamples.Name = "labelSamples";
            this.labelSamples.Size = new System.Drawing.Size(100, 13);
            this.labelSamples.TabIndex = 7;
            this.labelSamples.Text = "Samples / Channel:";
            // 
            // groupBoxChannelParameters
            // 
            this.groupBoxChannelParameters.Controls.Add(this.numUpDownMaximumValue);
            this.groupBoxChannelParameters.Controls.Add(this.numUpDownMinimumValue);
            this.groupBoxChannelParameters.Controls.Add(this.comboBoxPhysicalChannel);
            this.groupBoxChannelParameters.Controls.Add(this.labelMaximumValue);
            this.groupBoxChannelParameters.Controls.Add(this.labelMinimumValue);
            this.groupBoxChannelParameters.Controls.Add(this.labelPhysicalChannel);
            this.groupBoxChannelParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxChannelParameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxChannelParameters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxChannelParameters.Location = new System.Drawing.Point(5, 5);
            this.groupBoxChannelParameters.Margin = new System.Windows.Forms.Padding(15);
            this.groupBoxChannelParameters.Name = "groupBoxChannelParameters";
            this.groupBoxChannelParameters.Size = new System.Drawing.Size(259, 127);
            this.groupBoxChannelParameters.TabIndex = 0;
            this.groupBoxChannelParameters.TabStop = false;
            this.groupBoxChannelParameters.Text = "Channel Parameters";
            // 
            // numUpDownMaximumValue
            // 
            this.numUpDownMaximumValue.DecimalPlaces = 2;
            this.numUpDownMaximumValue.Location = new System.Drawing.Point(127, 84);
            this.numUpDownMaximumValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownMaximumValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numUpDownMaximumValue.Name = "numUpDownMaximumValue";
            this.numUpDownMaximumValue.Size = new System.Drawing.Size(120, 20);
            this.numUpDownMaximumValue.TabIndex = 5;
            this.numUpDownMaximumValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            // 
            // numUpDownMinimumValue
            // 
            this.numUpDownMinimumValue.DecimalPlaces = 2;
            this.numUpDownMinimumValue.Location = new System.Drawing.Point(127, 56);
            this.numUpDownMinimumValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownMinimumValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numUpDownMinimumValue.Name = "numUpDownMinimumValue";
            this.numUpDownMinimumValue.Size = new System.Drawing.Size(120, 20);
            this.numUpDownMinimumValue.TabIndex = 4;
            this.numUpDownMinimumValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // comboBoxPhysicalChannel
            // 
            this.comboBoxPhysicalChannel.FormattingEnabled = true;
            this.comboBoxPhysicalChannel.Location = new System.Drawing.Point(127, 27);
            this.comboBoxPhysicalChannel.Name = "comboBoxPhysicalChannel";
            this.comboBoxPhysicalChannel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPhysicalChannel.TabIndex = 3;
            this.comboBoxPhysicalChannel.Text = "Dev1/ai0";
            // 
            // labelMaximumValue
            // 
            this.labelMaximumValue.AutoSize = true;
            this.labelMaximumValue.Location = new System.Drawing.Point(14, 87);
            this.labelMaximumValue.Name = "labelMaximumValue";
            this.labelMaximumValue.Size = new System.Drawing.Size(99, 13);
            this.labelMaximumValue.TabIndex = 2;
            this.labelMaximumValue.Text = "Maximum Value (g):";
            // 
            // labelMinimumValue
            // 
            this.labelMinimumValue.AutoSize = true;
            this.labelMinimumValue.Location = new System.Drawing.Point(14, 58);
            this.labelMinimumValue.Name = "labelMinimumValue";
            this.labelMinimumValue.Size = new System.Drawing.Size(96, 13);
            this.labelMinimumValue.TabIndex = 1;
            this.labelMinimumValue.Text = "Minimum Value (g):";
            // 
            // labelPhysicalChannel
            // 
            this.labelPhysicalChannel.AutoSize = true;
            this.labelPhysicalChannel.Location = new System.Drawing.Point(14, 31);
            this.labelPhysicalChannel.Name = "labelPhysicalChannel";
            this.labelPhysicalChannel.Size = new System.Drawing.Size(91, 13);
            this.labelPhysicalChannel.TabIndex = 0;
            this.labelPhysicalChannel.Text = "Physical Channel:";
            // 
            // formsPlot1
            // 
            this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1.Location = new System.Drawing.Point(278, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(687, 625);
            this.formsPlot1.TabIndex = 3;
            // 
            // Waveform_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(968, 671);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(980, 690);
            this.Name = "Waveform_form";
            this.Text = "Waveform";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxDeviceParameters.ResumeLayout(false);
            this.groupBoxDeviceParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownExValue)).EndInit();
            this.groupBoxAcceleroParameters.ResumeLayout(false);
            this.groupBoxAcceleroParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSensitivity)).EndInit();
            this.groupBoxTriggerParameters.ResumeLayout(false);
            this.groupBoxTriggerParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHysteresis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTiggerLevel)).EndInit();
            this.groupBoxTimingParameters.ResumeLayout(false);
            this.groupBoxTimingParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRate)).EndInit();
            this.groupBoxChannelParameters.ResumeLayout(false);
            this.groupBoxChannelParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaximumValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinimumValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxTriggerParameters;
        private System.Windows.Forms.TextBox textBoxTriggerSource;
        private System.Windows.Forms.ComboBox comboBoxTriggerSlope;
        private System.Windows.Forms.Label labelTriggerSlope;
        private System.Windows.Forms.Label labelTriggerSource;
        private System.Windows.Forms.NumericUpDown numUpDownHysteresis;
        private System.Windows.Forms.NumericUpDown numUpDownTiggerLevel;
        private System.Windows.Forms.Label labelTriggerLevel;
        private System.Windows.Forms.Label labelHysteresis;
        private System.Windows.Forms.GroupBox groupBoxTimingParameters;
        private System.Windows.Forms.NumericUpDown numUpDownSamples;
        private System.Windows.Forms.NumericUpDown numUpDownRate;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelSamples;
        private System.Windows.Forms.GroupBox groupBoxChannelParameters;
        private System.Windows.Forms.NumericUpDown numUpDownMaximumValue;
        private System.Windows.Forms.NumericUpDown numUpDownMinimumValue;
        private System.Windows.Forms.ComboBox comboBoxPhysicalChannel;
        private System.Windows.Forms.Label labelMaximumValue;
        private System.Windows.Forms.Label labelMinimumValue;
        private System.Windows.Forms.Label labelPhysicalChannel;
        private System.Windows.Forms.GroupBox groupBoxAcceleroParameters;
        private System.Windows.Forms.NumericUpDown numUpDownSensitivity;
        private System.Windows.Forms.ComboBox comboBoxSensiUnits;
        private System.Windows.Forms.Label labelSensiUnits;
        private System.Windows.Forms.Label labelSensitivity;
        private System.Windows.Forms.GroupBox groupBoxDeviceParameters;
        private System.Windows.Forms.ComboBox comboBoxTerminalConfig;
        private System.Windows.Forms.Label labelTerminalConfig;
        private System.Windows.Forms.Label labelInputCoupling;
        private System.Windows.Forms.NumericUpDown numUpDownExValue;
        private System.Windows.Forms.Label labelExSource;
        private System.Windows.Forms.Label labelExValue;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxExSource;
        private System.Windows.Forms.ComboBox comboBoxInputCoupling;
        private System.Windows.Forms.Button btnSave;
        private ScottPlot.FormsPlot formsPlot1;
    }
}