using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace phd_project_net_framework.Custom_Controls
{
    //create card panel class
    
    public class Job_Monitoring_Card : Panel
    {
        // fields
        public int Job_ID { get; set; }
        public Button Delete_Btn;
        

        private Color _backColor = Color.FromArgb(58, 65, 73);
        private Color _foreColor = Color.Black;
        private Label card_label = new Label();

        // properties

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Card Name")]
        public string Card_Name
        {
            get { return card_label.Text; }
            set { 
                card_label.Text = value;
                this.Invalidate();
            }
        }

        // method
        public Job_Monitoring_Card()
        {
            this.Size = new Size(195, 100);
            this.BackColor = _backColor;
            this.Dock = DockStyle.Top;
            this.Cursor = Cursors.Hand;

            Panel topHeader = new Panel();
            this.Controls.Add(topHeader);
            topHeader.Size = new Size(this.Width, 30);
            topHeader.BackColor = Color.MidnightBlue;
            topHeader.Dock = DockStyle.Top;
            
            card_label.ForeColor = Color.White;
            card_label.AutoSize = false;
            card_label.Dock = DockStyle.Fill;
            card_label.TextAlign = ContentAlignment.MiddleCenter;
            card_label.Font = new Font(DefaultFont, FontStyle.Bold);
            topHeader.Controls.Add(card_label);

            Panel content = new Panel();
            this.Controls.Add(content);
            content.Dock = DockStyle.Fill;

            Panel bottomPadding = new Panel();
            this.Controls.Add(bottomPadding);
            bottomPadding.Size = new Size(this.Width, 10);
            bottomPadding.BackColor = Color.FromArgb(49, 54, 58);
            bottomPadding.Dock = DockStyle.Bottom;
        }
        
    }  
}
