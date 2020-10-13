using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoringApp
{
    public partial class Form1 : Form
    {
        //
        int Team1Goal = 0, Team2Goal = 0;

        int min = 0, sec = 0;

        //for Time Plenty
        int T1min = 1, T1sec = 60;
        int T2min = 1, T2sec = 60;

        //Timeout
        bool team1Timeout = false, team2Timeout = false;

        bool start = false;
        private void CheckTimeout()
        {
            if (team1Timeout == true && team2Timeout == true)
            {
                StopWatch.Stop();
                Team1TimePlentyTimer.Stop();
                Team2TimePlentyTimer.Stop();

            }
        }

        public void UpdateGoal()
        {
            lab_Goal.Text = Team1Goal + " : " + Team2Goal;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        #region UpdateGoal
        private void btn_Team1Dec_Click(object sender, EventArgs e)
        {
            if (Team1Goal > 0)
            {
                Team1Goal--;
                UpdateGoal();
            }
        }

        private void btn_Team2Dec_Click(object sender, EventArgs e)
        {
            if (Team2Goal > 0)
            {
                Team2Goal--;
                UpdateGoal();
            }
        }

        private void btn_Team2Inc_Click(object sender, EventArgs e)
        {
            Team2Goal++;
            UpdateGoal();

        }

        private void btn_Team1Inc_Click(object sender, EventArgs e)
        {
            UpdateGoal();
            Team1Goal++;

        }
        #endregion;


        private void btn_TopTeam1Timeout_Click(object sender, EventArgs e)
        {
            btn_BottomTeam1Timeout.Visible = true;
            team1Timeout = true;
            CheckTimeout();
        }

        private void btn_TopTeam2Timeout_Click(object sender, EventArgs e)
        {
            btn_BottomTeam2Timeout.Visible = true;
            team2Timeout = true;
            CheckTimeout();

        }
        private void btn_Team1TimePlenty_Click(object sender, EventArgs e)
        {
            if (displayTeam1Stack.Controls.Count < 4) 
            {
                Label penaltyLabel = new Label();
                penaltyLabel.AutoSize = false;
                penaltyLabel.BorderStyle = BorderStyle.FixedSingle;
                penaltyLabel.Size = new Size(122, 29);
                penaltyLabel.BackColor = Color.White;
                penaltyLabel.ForeColor = Color.FromArgb(24, 48, 104);
                penaltyLabel.TextAlign = ContentAlignment.MiddleCenter;
                penaltyLabel.Font = new Font("ITC Avant Garde Std Md", 14f, FontStyle.Bold);
                AssignAddress(penaltyLabel, displayTeam1Stack);
                penaltyLabel.Text = penaltyLabel.Tag.ToString();
                penaltyLabel.Click += new EventHandler(penaltyLabel_Click);
                displayTeam1Stack.Controls.Add(penaltyLabel);

                Timer timer = new Timer();
                timer.Tag = penaltyLabel.Tag.ToString();
                timer.Interval = 1000;
                timer.Tick += new EventHandler(timer_Tick);
            }

            //pnl_Team1TImePlenty.Visible = true;
            //pnl_TopTeam1TImePlenty.Visible = true;
            //btn_Team1StopPlenty.Visible = true;

            //Team1TimePlentyTimer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (T1sec != 0)
            {
                T1sec--;
            }
            else if (T1min != 0)
            {
                T1sec = 59;
                T1min--;
            }
            else if (T1sec == 0 && T1min == 0)
            {
                Team1TimePlentyTimer.Stop();

            }
            lab_Team1TopTimePlenty.Text = T1min.ToString("#00") + " : " + T1sec.ToString("#00");
            lab_Team1BottomTimePlenty.Text = T1min.ToString("#00") + " : " + T1sec.ToString("#00");
        }

        private void penaltyLabel_Click(object sender, EventArgs e)
        {
            displayTeam1Stack.Controls.Remove((Label)sender);
        }

        private void AssignAddress(Label label, FlowLayoutPanel panel)
        {
            bool found = false;
            for (int i = 0; i < 4; i++) 
            {
                foreach (Control control in panel.Controls) 
                {
                    if ((string)control.Tag == i.ToString())
                    {
                        found = true;
                        break;
                    }
                    else found = false;
                }
                if (!found)
                {
                    label.Tag = i.ToString();
                    return;
                }
            }
        }

        private void btn_Team1StopPlenty_Click(object sender, EventArgs e)
        {
            pnl_Team1TImePlenty.Visible = false;
            pnl_TopTeam1TImePlenty.Visible = false;
            btn_Team1StopPlenty.Visible = false;

            Team1TimePlentyTimer.Stop();
            T1min = 1;
            T1sec = 60;
            lab_Team1TopTimePlenty.Text = "02 : 00";
            lab_Team1BottomTimePlenty.Text = "02 : 00";


        }

        private void btn_Team2TimePlenty_Click(object sender, EventArgs e)
        {
            pnl_Team2TImePlenty.Visible = true;
            pnl_TopTeam2TImePlenty.Visible = true;
            btn_Team2StopPlenty.Visible = true;

            Team2TimePlentyTimer.Start();

        }
        private void btn_Team2StopPlenty_Click(object sender, EventArgs e)
        {
            pnl_Team2TImePlenty.Visible = false;
            pnl_TopTeam2TImePlenty.Visible = false;
            btn_Team2StopPlenty.Visible = false;

            Team1TimePlentyTimer.Stop();
            T2min = 1;
            T2sec = 60;
            lab_Team2TopTimePlenty.Text = "02 : 00";
            lab_Team2BottomTimePlenty.Text = "02 : 00";
        }

        private void btn_BottomTeam1Timeout_Click(object sender, EventArgs e)
        {
            btn_BottomTeam1Timeout.Visible = false;
            team1Timeout = false;
        }

        private void btn_BottomTeam2Timeout_Click(object sender, EventArgs e)
        {
            btn_BottomTeam2Timeout.Visible = false;
            team2Timeout = false;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_StartWatchFrom30_Click(object sender, EventArgs e)
        {
            lab_TopClock.Text = "30  :  00";
            min = 30;
            sec = 30;

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            lab_TopClock.Text = "00  :  00";
            lab_BottomClock.Text = "00  :  00";
            min = 0;
            sec = 0;
        }

        private void btn_IncMin_Click(object sender, EventArgs e)
        {
            if (min <= 99)
            {
                min++;
                lab_TopClock.Text = min.ToString("#00") + "  :  " + sec.ToString("#00");
            }
            
        }

        private void btn_IncSec_Click(object sender, EventArgs e)
        {
            if (sec<59)
            {
                sec++;
            }
            else
            {
                min++;
                sec = 0;
            }
            //lab_BottomClock.Text = min.ToString("#00") + " : " + sec.ToString("#00");
            lab_TopClock.Text = min.ToString("#00") + "  :  " + sec.ToString("#00");
        }

        private void btn_DecMin_Click(object sender, EventArgs e)
        {
            if (min>0)
            {
                min--;
            }
            lab_TopClock.Text = min.ToString("#00") + "  :  " + sec.ToString("#00");
        }

        private void btn_DecSec_Click(object sender, EventArgs e)
        {
            if (sec>0)
            {
                sec--;
            }
            lab_TopClock.Text = min.ToString("#00") + "  :  " + sec.ToString("#00");

        }

        private void pnl_Team1Color_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            //MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = pnl_Team1Color.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                pnl_Team1Color.BackColor = MyDialog.Color;
        }

        private void pnl_Team2Color_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Team1LeeresTOR_Click(object sender, EventArgs e)
        {
            btn_BottomTeam1Timeout.Visible = true;
            team1Timeout = true;
            CheckTimeout();
        }

        private void btn_Team2LeeresTOR_Click(object sender, EventArgs e)
        {
            btn_BottomTeam2Timeout.Visible = true;
            team2Timeout = true;
            CheckTimeout();
        }

        private void pnl_Team1Color_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Team2Color_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            //MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = pnl_Team2Color.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                pnl_Team2Color.BackColor = MyDialog.Color;
        }
        private void btn_START_Click(object sender, EventArgs e)
        {
            if (start == true) start = false;
            else if (start == false) start = true;

            if (start == true) StopWatch.Start();
            else StopWatch.Stop();
        }

        private void btn_ToSave_Click(object sender, EventArgs e)
        {
            lab_BottomClock.Text = min.ToString("#00") + " : " + sec.ToString("#00");
        }

        private void btn_StartWatchFromZero_Click(object sender, EventArgs e)
        {
            lab_TopClock.Text = "00  :  00";
            min = 0;
            sec = 0;

        }

        private void Team2TimePlentyTimer_Tick(object sender, EventArgs e)
        {
            if (T2sec != 0)
            {
                T2sec--;
            }
            else if (T2min != 0)
            {
                T2sec = 59;
                T2min--;
            }
            else if (T2sec == 0 && T2min == 0)
            {
                Team2TimePlentyTimer.Stop();

            }
            lab_Team2TopTimePlenty.Text = T2min.ToString("#00") + " : " + T2sec.ToString("#00");
            lab_Team2BottomTimePlenty.Text = T2min.ToString("#00") + " : " + T2sec.ToString("#00");
        }

        private void Team1TimePlentyTimer_Tick(object sender, EventArgs e)
        {
            if (T1sec != 0)
            {
                T1sec--;
            }
            else if (T1min != 0)
            {
                T1sec = 59;
                T1min--;
            }
            else if (T1sec == 0 && T1min == 0)
            {
                Team1TimePlentyTimer.Stop();

            }
            lab_Team1TopTimePlenty.Text = T1min.ToString("#00") + " : " + T1sec.ToString("#00");
            lab_Team1BottomTimePlenty.Text = T1min.ToString("#00") + " : " + T1sec.ToString("#00");

        }

        private void StopWatch_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec >= 60)
            {
                min++;
                sec = 0;
            }
            lab_TopClock.Text = min.ToString("#00") + "  :  " + sec.ToString("#00");
            lab_BottomClock.Text =  min.ToString("#00") + " : " + sec.ToString("#00");
            if (min ==30 && sec == 0 || min == 60 && sec == 0)
            {
                StopWatch.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
