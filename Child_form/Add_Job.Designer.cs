namespace phd_project_net_framework.Child_form
{
    partial class Add_Job
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.lblJobName = new System.Windows.Forms.Label();
            this.txtBoxJobName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxChannelParameters = new System.Windows.Forms.GroupBox();
            this.numUpDownMaximumValue = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMinimumValue = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPhysicalChannel = new System.Windows.Forms.ComboBox();
            this.labelMaximumValue = new System.Windows.Forms.Label();
            this.labelMinimumValue = new System.Windows.Forms.Label();
            this.labelPhysicalChannel = new System.Windows.Forms.Label();
            this.groupBoxTimingParameters = new System.Windows.Forms.GroupBox();
            this.numUpDownSamples = new System.Windows.Forms.NumericUpDown();
            this.numUpDownRate = new System.Windows.Forms.NumericUpDown();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelSamples = new System.Windows.Forms.Label();
            this.groupBoxAcceleroParameters = new System.Windows.Forms.GroupBox();
            this.numUpDownSensitivity = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSensiUnits = new System.Windows.Forms.ComboBox();
            this.labelSensiUnits = new System.Windows.Forms.Label();
            this.labelSensitivity = new System.Windows.Forms.Label();
            this.groupBoxDeviceParameters = new System.Windows.Forms.GroupBox();
            this.comboBoxInputCoupling = new System.Windows.Forms.ComboBox();
            this.comboBoxExSource = new System.Windows.Forms.ComboBox();
            this.comboBoxTerminalConfig = new System.Windows.Forms.ComboBox();
            this.labelTerminalConfig = new System.Windows.Forms.Label();
            this.labelInputCoupling = new System.Windows.Forms.Label();
            this.numUpDownExValue = new System.Windows.Forms.NumericUpDown();
            this.labelExSource = new System.Windows.Forms.Label();
            this.labelExValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxChannelParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaximumValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinimumValue)).BeginInit();
            this.groupBoxTimingParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRate)).BeginInit();
            this.groupBoxAcceleroParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSensitivity)).BeginInit();
            this.groupBoxDeviceParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownExValue)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJobName.Location = new System.Drawing.Point(31, 55);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(55, 13);
            this.lblJobName.TabIndex = 0;
            this.lblJobName.Text = "Job Name";
            // 
            // txtBoxJobName
            // 
            this.txtBoxJobName.Location = new System.Drawing.Point(92, 52);
            this.txtBoxJobName.Name = "txtBoxJobName";
            this.txtBoxJobName.Size = new System.Drawing.Size(184, 20);
            this.txtBoxJobName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 571);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBoxChannelParameters
            // 
            this.groupBoxChannelParameters.Controls.Add(this.numUpDownMaximumValue);
            this.groupBoxChannelParameters.Controls.Add(this.numUpDownMinimumValue);
            this.groupBoxChannelParameters.Controls.Add(this.comboBoxPhysicalChannel);
            this.groupBoxChannelParameters.Controls.Add(this.labelMaximumValue);
            this.groupBoxChannelParameters.Controls.Add(this.labelMinimumValue);
            this.groupBoxChannelParameters.Controls.Add(this.labelPhysicalChannel);
            this.groupBoxChannelParameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxChannelParameters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxChannelParameters.Location = new System.Drawing.Point(17, 83);
            this.groupBoxChannelParameters.Margin = new System.Windows.Forms.Padding(15);
            this.groupBoxChannelParameters.Name = "groupBoxChannelParameters";
            this.groupBoxChannelParameters.Size = new System.Drawing.Size(259, 127);
            this.groupBoxChannelParameters.TabIndex = 3;
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
            // groupBoxTimingParameters
            // 
            this.groupBoxTimingParameters.Controls.Add(this.numUpDownSamples);
            this.groupBoxTimingParameters.Controls.Add(this.numUpDownRate);
            this.groupBoxTimingParameters.Controls.Add(this.labelRate);
            this.groupBoxTimingParameters.Controls.Add(this.labelSamples);
            this.groupBoxTimingParameters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxTimingParameters.Location = new System.Drawing.Point(17, 217);
            this.groupBoxTimingParameters.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.groupBoxTimingParameters.Name = "groupBoxTimingParameters";
            this.groupBoxTimingParameters.Size = new System.Drawing.Size(259, 90);
            this.groupBoxTimingParameters.TabIndex = 4;
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
            // groupBoxAcceleroParameters
            // 
            this.groupBoxAcceleroParameters.Controls.Add(this.numUpDownSensitivity);
            this.groupBoxAcceleroParameters.Controls.Add(this.comboBoxSensiUnits);
            this.groupBoxAcceleroParameters.Controls.Add(this.labelSensiUnits);
            this.groupBoxAcceleroParameters.Controls.Add(this.labelSensitivity);
            this.groupBoxAcceleroParameters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxAcceleroParameters.Location = new System.Drawing.Point(17, 317);
            this.groupBoxAcceleroParameters.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBoxAcceleroParameters.Name = "groupBoxAcceleroParameters";
            this.groupBoxAcceleroParameters.Size = new System.Drawing.Size(259, 88);
            this.groupBoxAcceleroParameters.TabIndex = 5;
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
            this.groupBoxDeviceParameters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxDeviceParameters.Location = new System.Drawing.Point(17, 418);
            this.groupBoxDeviceParameters.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBoxDeviceParameters.Name = "groupBoxDeviceParameters";
            this.groupBoxDeviceParameters.Size = new System.Drawing.Size(259, 147);
            this.groupBoxDeviceParameters.TabIndex = 6;
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
            this.labelTerminalConfig.Location = new System.Drawing.Point(18, 55);
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
            2,
            0,
            0,
            196608});
            // 
            // labelExSource
            // 
            this.labelExSource.AutoSize = true;
            this.labelExSource.Location = new System.Drawing.Point(18, 82);
            this.labelExSource.Name = "labelExSource";
            this.labelExSource.Size = new System.Drawing.Size(90, 13);
            this.labelExSource.TabIndex = 10;
            this.labelExSource.Text = "Exication Source:";
            // 
            // labelExValue
            // 
            this.labelExValue.AutoSize = true;
            this.labelExValue.Location = new System.Drawing.Point(18, 109);
            this.labelExValue.Name = "labelExValue";
            this.labelExValue.Size = new System.Drawing.Size(102, 13);
            this.labelExValue.TabIndex = 11;
            this.labelExValue.Text = "Excitation Value (V):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 43);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "       Add Job to Monitor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Add_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(293, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxDeviceParameters);
            this.Controls.Add(this.groupBoxAcceleroParameters);
            this.Controls.Add(this.groupBoxTimingParameters);
            this.Controls.Add(this.groupBoxChannelParameters);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxJobName);
            this.Controls.Add(this.lblJobName);
            this.Name = "Add_Job";
            this.Text = "Add_Job";
            this.groupBoxChannelParameters.ResumeLayout(false);
            this.groupBoxChannelParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaximumValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinimumValue)).EndInit();
            this.groupBoxTimingParameters.ResumeLayout(false);
            this.groupBoxTimingParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRate)).EndInit();
            this.groupBoxAcceleroParameters.ResumeLayout(false);
            this.groupBoxAcceleroParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSensitivity)).EndInit();
            this.groupBoxDeviceParameters.ResumeLayout(false);
            this.groupBoxDeviceParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownExValue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.TextBox txtBoxJobName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBoxChannelParameters;
        private System.Windows.Forms.NumericUpDown numUpDownMaximumValue;
        private System.Windows.Forms.NumericUpDown numUpDownMinimumValue;
        private System.Windows.Forms.ComboBox comboBoxPhysicalChannel;
        private System.Windows.Forms.Label labelMaximumValue;
        private System.Windows.Forms.Label labelMinimumValue;
        private System.Windows.Forms.Label labelPhysicalChannel;
        private System.Windows.Forms.GroupBox groupBoxTimingParameters;
        private System.Windows.Forms.NumericUpDown numUpDownSamples;
        private System.Windows.Forms.NumericUpDown numUpDownRate;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelSamples;
        private System.Windows.Forms.GroupBox groupBoxAcceleroParameters;
        private System.Windows.Forms.NumericUpDown numUpDownSensitivity;
        private System.Windows.Forms.ComboBox comboBoxSensiUnits;
        private System.Windows.Forms.Label labelSensiUnits;
        private System.Windows.Forms.Label labelSensitivity;
        private System.Windows.Forms.GroupBox groupBoxDeviceParameters;
        private System.Windows.Forms.ComboBox comboBoxInputCoupling;
        private System.Windows.Forms.ComboBox comboBoxExSource;
        private System.Windows.Forms.ComboBox comboBoxTerminalConfig;
        private System.Windows.Forms.Label labelTerminalConfig;
        private System.Windows.Forms.Label labelInputCoupling;
        private System.Windows.Forms.NumericUpDown numUpDownExValue;
        private System.Windows.Forms.Label labelExSource;
        private System.Windows.Forms.Label labelExValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}