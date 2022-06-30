using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using phd_project_net_framework.Costum_Class;
using FontAwesome.Sharp;

namespace phd_project_net_framework.Chid_form
{
    public partial class Job_Form : Form
    {
        public Job_Form()
        {
            InitializeComponent();
            this.FormClosed += (sender, args) =>
            {
                RefreshDispTimer?.Stop();
            };
            
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Form New_Job = new Child_form.Add_Job();
            New_Job.Show();
        }

        private void FormShow(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            //get all job from server
            tableLayoutPanel1.Controls.Clear();
            List<Job> all_jobs = DbJob.GetAllJob();
            if (all_jobs.Count > 0)
            {
                foreach (Job job in all_jobs)
                {
                    Custom_Controls.Job_Monitoring_Card job_card = new Custom_Controls.Job_Monitoring_Card();
                    job_card.Parent = tableLayoutPanel1;
                    job_card.Card_Name = $"{job.Name}";
                    job_card.Dock = DockStyle.Fill;
                    job_card.Cursor = Cursors.Arrow;
                    job_card.Margin = new System.Windows.Forms.Padding(20);
                    job_card.Job_ID = job.ID;
                    tableLayoutPanel1.Controls.Add(job_card);
                }
            }
            IconButton add_button = new IconButton();
            add_button.Text = "Add Job";
            add_button.TextAlign = ContentAlignment.BottomCenter;
            add_button.TextImageRelation = TextImageRelation.ImageAboveText;
            add_button.IconChar = IconChar.Plus;
            add_button.IconSize = 56;
            add_button.Cursor = Cursors.Hand;
            add_button.BackColor = Color.White;
            add_button.Dock = DockStyle.Fill;
            add_button.Margin = new System.Windows.Forms.Padding(30);
            add_button.Click += new System.EventHandler(this.iconButton1_Click_1);
            tableLayoutPanel1.Controls.Add(add_button);
        }

        private void RefreshDispTimer_Tick(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            //RefreshDispTimer.Start();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is Custom_Controls.Job_Monitoring_Card)
                {
                    Custom_Controls.Job_Monitoring_Card job_card = c as Custom_Controls.Job_Monitoring_Card;
                    //add delete button to each card, if exist, delete it
                    if (job_card.Delete_Btn == null)
                    {                     
                        IconButton delete_button = new IconButton();
                        delete_button.Text = "";
                        delete_button.TextAlign = ContentAlignment.BottomCenter;
                        delete_button.TextImageRelation = TextImageRelation.ImageAboveText;
                        delete_button.IconChar = IconChar.Trash;
                        delete_button.IconSize = 30;
                        delete_button.Size = new Size(30, 50);
                        delete_button.FlatStyle = FlatStyle.Flat;
                        delete_button.FlatAppearance.BorderSize = 0;
                        delete_button.Cursor = Cursors.Hand;
                        delete_button.BackColor = Color.Red;
                        delete_button.Dock = DockStyle.Bottom;
                        delete_button.Margin = new System.Windows.Forms.Padding(30);                      
                        job_card.Delete_Btn = delete_button;
                        job_card.Controls.Add(delete_button);
                        delete_button.Click += new System.EventHandler(this.DeleteJob);
                    }
                    //if delete button exist, delete it
                    else
                    {
                        job_card.Controls.Remove(job_card.Delete_Btn);
                        job_card.Delete_Btn = null;
                    }
                }
            }
        }
        private void DeleteJob(object sender, EventArgs e)
        {
            //if the delete button is clicked, delete the job from server
            IconButton delete_button = sender as IconButton;
            Custom_Controls.Job_Monitoring_Card job_card = delete_button.Parent as Custom_Controls.Job_Monitoring_Card;
            DbJob.DeleteJob(job_card.Job_ID);
            UpdateDisplay();
        }

    }
}
