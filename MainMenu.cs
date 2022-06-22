using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace phd_project_net_framework
{
    public partial class MainMenu : Form
    {// fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        // constructor
        public MainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            // hide border form
            /*this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;*/
        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.RoyalBlue;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }



        private void DisableButton()
        {
            leftBorderBtn.Visible = false;
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.MidnightBlue;
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;

            }
        }

        private void OpenChildForm(Form childForm)
        {
            // open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            // end open only form
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.AutoScroll = true;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            panelDesktop.AutoScroll = true;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnWaveform_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.White);
            OpenChildForm(new Chid_form.Monitoring_Form());
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.White);
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.White);
            OpenChildForm(new Chid_form.Job_Form());
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.White);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.White);
            OpenChildForm(new Chid_form.Waveform_form());
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void paneltitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
