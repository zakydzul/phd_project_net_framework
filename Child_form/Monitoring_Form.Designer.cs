namespace phd_project_net_framework.Chid_form
{
    partial class Monitoring_Form
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelWave = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.timerUpdateData = new System.Windows.Forms.Timer(this.components);
            this.timerRender = new System.Windows.Forms.Timer(this.components);
            this.panelRoundedCorners1 = new phd_project_net_framework.Custom_Controls.PanelRoundedCorners();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.buttonRoundedCorners2 = new phd_project_net_framework.ButtonRoundedCorners();
            this.buttonRoundedCorners1 = new phd_project_net_framework.ButtonRoundedCorners();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanelWave.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.panelRoundedCorners1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanelWave);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(964, 651);
            this.splitContainer1.SplitterDistance = 745;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanelWave
            // 
            this.tableLayoutPanelWave.ColumnCount = 1;
            this.tableLayoutPanelWave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWave.Controls.Add(this.panelRoundedCorners1, 0, 0);
            this.tableLayoutPanelWave.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanelWave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWave.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelWave.Name = "tableLayoutPanelWave";
            this.tableLayoutPanelWave.RowCount = 2;
            this.tableLayoutPanelWave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelWave.Size = new System.Drawing.Size(745, 651);
            this.tableLayoutPanelWave.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.buttonRoundedCorners2);
            this.panel1.Controls.Add(this.buttonRoundedCorners1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 44);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.splitContainer2.Size = new System.Drawing.Size(215, 651);
            this.splitContainer2.SplitterDistance = 311;
            this.splitContainer2.SplitterWidth = 14;
            this.splitContainer2.TabIndex = 0;
            // 
            // timerUpdateData
            // 
            this.timerUpdateData.Interval = 5;
            this.timerUpdateData.Tick += new System.EventHandler(this.timerUpdateData_Tick);
            // 
            // timerRender
            // 
            this.timerRender.Interval = 20;
            this.timerRender.Tick += new System.EventHandler(this.timerRender_Tick);
            // 
            // panelRoundedCorners1
            // 
            this.panelRoundedCorners1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelRoundedCorners1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelRoundedCorners1.BorderRadius = 10;
            this.panelRoundedCorners1.Controls.Add(this.formsPlot1);
            this.panelRoundedCorners1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoundedCorners1.ForeColor = System.Drawing.Color.White;
            this.panelRoundedCorners1.Location = new System.Drawing.Point(10, 10);
            this.panelRoundedCorners1.Margin = new System.Windows.Forms.Padding(10);
            this.panelRoundedCorners1.Name = "panelRoundedCorners1";
            this.panelRoundedCorners1.Size = new System.Drawing.Size(725, 581);
            this.panelRoundedCorners1.TabIndex = 2;
            // 
            // formsPlot1
            // 
            this.formsPlot1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1.Location = new System.Drawing.Point(0, 0);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(725, 581);
            this.formsPlot1.TabIndex = 1;
            // 
            // buttonRoundedCorners2
            // 
            this.buttonRoundedCorners2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRoundedCorners2.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonRoundedCorners2.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.buttonRoundedCorners2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonRoundedCorners2.BorderRadius = 20;
            this.buttonRoundedCorners2.BorderSize = 0;
            this.buttonRoundedCorners2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRoundedCorners2.FlatAppearance.BorderSize = 0;
            this.buttonRoundedCorners2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoundedCorners2.ForeColor = System.Drawing.Color.White;
            this.buttonRoundedCorners2.Location = new System.Drawing.Point(385, 1);
            this.buttonRoundedCorners2.Name = "buttonRoundedCorners2";
            this.buttonRoundedCorners2.Size = new System.Drawing.Size(150, 40);
            this.buttonRoundedCorners2.TabIndex = 1;
            this.buttonRoundedCorners2.Text = "Power";
            this.buttonRoundedCorners2.TextColor = System.Drawing.Color.White;
            this.buttonRoundedCorners2.UseVisualStyleBackColor = false;
            this.buttonRoundedCorners2.Click += new System.EventHandler(this.buttonRoundedCorners2_Click);
            // 
            // buttonRoundedCorners1
            // 
            this.buttonRoundedCorners1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRoundedCorners1.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonRoundedCorners1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.buttonRoundedCorners1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonRoundedCorners1.BorderRadius = 20;
            this.buttonRoundedCorners1.BorderSize = 0;
            this.buttonRoundedCorners1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRoundedCorners1.FlatAppearance.BorderSize = 0;
            this.buttonRoundedCorners1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoundedCorners1.ForeColor = System.Drawing.Color.White;
            this.buttonRoundedCorners1.Location = new System.Drawing.Point(230, 1);
            this.buttonRoundedCorners1.Name = "buttonRoundedCorners1";
            this.buttonRoundedCorners1.Size = new System.Drawing.Size(150, 40);
            this.buttonRoundedCorners1.TabIndex = 0;
            this.buttonRoundedCorners1.Text = "Vibration";
            this.buttonRoundedCorners1.TextColor = System.Drawing.Color.White;
            this.buttonRoundedCorners1.UseVisualStyleBackColor = false;
            this.buttonRoundedCorners1.Click += new System.EventHandler(this.buttonRoundedCorners1_Click);
            // 
            // Monitoring_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(964, 651);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(980, 690);
            this.Name = "Monitoring_Form";
            this.Text = "Monitoring_Form";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanelWave.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelRoundedCorners1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWave;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Timer timerUpdateData;
        private System.Windows.Forms.Timer timerRender;
        private Custom_Controls.PanelRoundedCorners panelRoundedCorners1;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Panel panel1;
        private ButtonRoundedCorners buttonRoundedCorners2;
        private ButtonRoundedCorners buttonRoundedCorners1;
    }
}