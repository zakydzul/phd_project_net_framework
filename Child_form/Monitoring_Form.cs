using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Diagnostics;

using System.Threading;
using ScottPlot;

namespace phd_project_net_framework.Chid_form
{
    public partial class Monitoring_Form : Form
    {
        private int Job=1;
        private Boolean PlotActive = false;
        private IconButton leftBorderBtn;
        private Panel currentChannel;
        Random rand = new Random();
        double[] liveData = new double[400];

        DataGen.Electrocardiogram ecg = new DataGen.Electrocardiogram();
        Stopwatch sw = Stopwatch.StartNew();

        

        /*private Thread cpuThread;
        private double[] cpuArray = new double[30];*/

        public Monitoring_Form()
        {
            InitializeComponent();
            leftBorderBtn = new IconButton();
            
            splitContainer2.Panel1.Controls.Add(leftBorderBtn);
            //leftBorderBtn.Visible = false;
            splitContainer2.SplitterWidth = 10;
            leftBorderBtn.Visible = false;

            //plot the data array only once and we can updates its values later
            var sig =formsPlot1.Plot.AddSignal(liveData);
            sig.FillAboveAndBelow(Color.Green, Color.Transparent,Color.Transparent, Color.Red,alpha:1);
            sig.Color = Color.White;
            //formsPlot1.Configuration.LockHorizontalAxis
            formsPlot1.Plot.AxisAutoX(margin: 0);
            formsPlot1.Plot.SetAxisLimits(yMin: -1, yMax: 2.5);

            //plot a red vertical line and save it so we can move it later

            //formsPlot1.Plot.Style(figureBackground: Color.Transparent, dataBackground: Color.Transparent);
            formsPlot1.Plot.Title("Accelerometer Test Run", true, Color.White, 20);
            formsPlot1.Plot.Style(ScottPlot.Style.Gray1);
            formsPlot1.Plot.Palette = ScottPlot.Drawing.Palette.Nord;
            formsPlot1.Plot.YAxis.TickMarkColor(Color.White);
            formsPlot1.Plot.YAxis.TickLabelStyle(color: Color.White);
            formsPlot1.BackColor = Color.Transparent;
            formsPlot1.Refresh();

            this.FormClosed += (sender, args) =>
            {
                timerUpdateData?.Stop();
                timerRender?.Stop();
            };

        }

        private void ActiveChannel(object senderBtn, Color color)
        {
           
            if (senderBtn != null)
            {
                if (currentChannel != (Panel)senderBtn)
                {
                    DisableForm();
                    currentChannel = (Panel)senderBtn;
                    //currentChannel.BackColor = Color.SlateGray;
                    leftBorderBtn.Size = new Size(20, currentChannel.Height - 10);
                    //left border button
                    leftBorderBtn.FlatStyle = FlatStyle.Flat;
                    leftBorderBtn.FlatAppearance.BorderSize = 0;
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.IconChar = IconChar.Sync;
                    leftBorderBtn.IconColor = Color.White;
                    leftBorderBtn.IconSize = 18;
                    leftBorderBtn.ImageAlign = ContentAlignment.MiddleCenter;
                    leftBorderBtn.Location = new Point(currentChannel.Location.X, currentChannel.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                    PlotActive = true;
                    if (timerRender.Enabled==false)
                    {
                        timerRender.Enabled = true;
                        timerUpdateData.Enabled = true;
                    }
                    
                }
                else
                {
                    if (PlotActive)
                    {
                        leftBorderBtn.IconChar = IconChar.Pause;
                        PlotActive = false;
                        timerRender.Enabled = false;
                        timerUpdateData.Enabled = false;
                    }
                    else
                    {
                        leftBorderBtn.IconChar = IconChar.Sync;
                        PlotActive = true;
                        timerRender.Enabled = true;
                        timerUpdateData.Enabled = true;
                    }  
                }
            }
        }

        private void DisableForm()
        {
            leftBorderBtn.Visible = false;
        }

        private void Plotting(object sender, EventArgs e)
        {
            ActiveChannel(sender, Color.RoyalBlue);
        }

        private void timerUpdateData_Tick(object sender, EventArgs e)
        {
            double nextValue = ecg.GetVoltage(sw.Elapsed.TotalSeconds);
            Array.Copy(liveData, 1, liveData, 0, liveData.Length - 1);
            liveData[liveData.Length - 1] = nextValue;
            //vline.IsVisible = false;
        }

        private void timerRender_Tick(object sender, EventArgs e)
        {
            formsPlot1.Refresh();
        }

        private void buttonRoundedCorners1_Click(object sender, EventArgs e)
        { 
        }


        private void buttonRoundedCorners2_Click(object sender, EventArgs e)
        {
            Custom_Controls.Job_Monitoring_Card job3_card = new Custom_Controls.Job_Monitoring_Card();
            job3_card.Parent = splitContainer2.Panel1;
            job3_card.Card_Name = $"JOB {Job}";
            job3_card.Click += new EventHandler(Plotting);
            Job++;
        }
    }
}
