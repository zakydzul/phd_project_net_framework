namespace phd_project_net_framework
{
    partial class MainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnEvents = new FontAwesome.Sharp.IconButton();
            this.btnJob = new FontAwesome.Sharp.IconButton();
            this.btnLearn = new FontAwesome.Sharp.IconButton();
            this.btnWaveform = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_title = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnEvents);
            this.panelMenu.Controls.Add(this.btnJob);
            this.panelMenu.Controls.Add(this.btnLearn);
            this.panelMenu.Controls.Add(this.btnWaveform);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(86, 676);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSettings.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 32;
            this.btnSettings.Location = new System.Drawing.Point(0, 283);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnSettings.Size = new System.Drawing.Size(86, 60);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.White;
            this.btnEvents.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnEvents.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnEvents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEvents.IconSize = 30;
            this.btnEvents.Location = new System.Drawing.Point(0, 223);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnEvents.Size = new System.Drawing.Size(86, 60);
            this.btnEvents.TabIndex = 4;
            this.btnEvents.Text = "Events";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnJob
            // 
            this.btnJob.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJob.FlatAppearance.BorderSize = 0;
            this.btnJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJob.ForeColor = System.Drawing.Color.White;
            this.btnJob.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.btnJob.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnJob.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnJob.IconSize = 32;
            this.btnJob.Location = new System.Drawing.Point(0, 163);
            this.btnJob.Name = "btnJob";
            this.btnJob.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnJob.Size = new System.Drawing.Size(86, 60);
            this.btnJob.TabIndex = 3;
            this.btnJob.Text = "Job";
            this.btnJob.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnJob.UseVisualStyleBackColor = true;
            this.btnJob.Click += new System.EventHandler(this.btnJob_Click);
            // 
            // btnLearn
            // 
            this.btnLearn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLearn.FlatAppearance.BorderSize = 0;
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearn.ForeColor = System.Drawing.Color.White;
            this.btnLearn.IconChar = FontAwesome.Sharp.IconChar.HatWizard;
            this.btnLearn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnLearn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLearn.IconSize = 32;
            this.btnLearn.Location = new System.Drawing.Point(0, 103);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnLearn.Size = new System.Drawing.Size(86, 60);
            this.btnLearn.TabIndex = 2;
            this.btnLearn.Text = "Learn";
            this.btnLearn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLearn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnWaveform
            // 
            this.btnWaveform.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWaveform.FlatAppearance.BorderSize = 0;
            this.btnWaveform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaveform.ForeColor = System.Drawing.Color.White;
            this.btnWaveform.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnWaveform.IconColor = System.Drawing.Color.White;
            this.btnWaveform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWaveform.IconSize = 32;
            this.btnWaveform.Location = new System.Drawing.Point(0, 43);
            this.btnWaveform.Name = "btnWaveform";
            this.btnWaveform.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnWaveform.Size = new System.Drawing.Size(86, 60);
            this.btnWaveform.TabIndex = 1;
            this.btnWaveform.Text = "Waveform";
            this.btnWaveform.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWaveform.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWaveform.UseVisualStyleBackColor = true;
            this.btnWaveform.Click += new System.EventHandler(this.btnWaveform_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 43);
            this.panel2.TabIndex = 0;
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_title.Controls.Add(this.iconButton1);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(86, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(992, 43);
            this.panel_title.TabIndex = 1;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitle_MouseDown);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(921, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(71, 43);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "User";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(86, 43);
            this.panelDesktop.MinimumSize = new System.Drawing.Size(980, 690);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(992, 690);
            this.panelDesktop.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1078, 676);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainMenu";
            this.Text = "Project";
            this.panelMenu.ResumeLayout(false);
            this.panel_title.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel_title;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnEvents;
        private FontAwesome.Sharp.IconButton btnJob;
        private FontAwesome.Sharp.IconButton btnLearn;
        private FontAwesome.Sharp.IconButton btnWaveform;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

