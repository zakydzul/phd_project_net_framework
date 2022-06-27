namespace phd_project_net_framework.Chid_form
{
    partial class Job_Form
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
            this.panelRoundedCorners1 = new phd_project_net_framework.Custom_Controls.PanelRoundedCorners();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelRoundedCorners1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRoundedCorners1
            // 
            this.panelRoundedCorners1.BackColor = System.Drawing.Color.Transparent;
            this.panelRoundedCorners1.BorderColor = System.Drawing.Color.Transparent;
            this.panelRoundedCorners1.Controls.Add(this.iconButton1);
            this.panelRoundedCorners1.ForeColor = System.Drawing.Color.White;
            this.panelRoundedCorners1.Location = new System.Drawing.Point(12, 12);
            this.panelRoundedCorners1.Name = "panelRoundedCorners1";
            this.panelRoundedCorners1.Size = new System.Drawing.Size(242, 245);
            this.panelRoundedCorners1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(11, 11);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(220, 222);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Job_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(895, 594);
            this.Controls.Add(this.panelRoundedCorners1);
            this.Name = "Job_Form";
            this.Text = "Job_Form";
            this.panelRoundedCorners1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls.PanelRoundedCorners panelRoundedCorners1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}