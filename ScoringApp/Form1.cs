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
        int T1min = 0, T1sec = 0;
        int T2min = 0, T2sec = 0;


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
        }

        private void btn_TopTeam2Timeout_Click(object sender, EventArgs e)
        {
            btn_BottomTeam2Timeout.Visible = true;

        }
        private void btn_Team1TimePlenty_Click(object sender, EventArgs e)
        {
            pnl_Team1TImePlenty.Visible = true;
            pnl_TopTeam1TImePlenty.Visible = true;
            btn_Team1StopPlenty.Visible = true;

            Team1TimePlentyTimer.Start();

        }

        private void btn_Team1StopPlenty_Click(object sender, EventArgs e)
        {
            pnl_Team1TImePlenty.Visible = false;
            pnl_TopTeam1TImePlenty.Visible = false;
            btn_Team1StopPlenty.Visible = false;

            Team1TimePlentyTimer.Stop();
            T1min = 0;
            T1sec = 0;

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

            Team2TimePlentyTimer.Stop();
            T2min = 0;
            T2sec = 0;
        }

        private void Team2TimePlentyTimer_Tick(object sender, EventArgs e)
        {
            T2sec++;
            if (T2sec >= 60)
            {
                T2min++;
                T2sec = 0;
            }
            if (T2min < 10 && T2sec < 10)
            {
                lab_Team2TopTimePlenty.Text = "0" + T2min + " : " + "0" + T2sec;
                lab_Team2BottomTimePlenty.Text = "0" + T2min + " : " + "0" + T2sec;
            }
            else if (T2min < 10 && T2sec > 10)
            {
                lab_Team2TopTimePlenty.Text = "0" + T2min + " : " + T2sec;
                lab_Team2BottomTimePlenty.Text = "0" + T2min + " : " + T2sec;

            }
            else if (T2min > 10 && T2sec < 10)
            {
                lab_Team2TopTimePlenty.Text = T2min + " : " + "0" + T2sec;
                lab_Team2BottomTimePlenty.Text = T2min + " : " + "0" + T2sec;
            }
            else
            {
                lab_Team2TopTimePlenty.Text = T2min + " : " + T2sec;
                lab_Team2BottomTimePlenty.Text = T2min + " : " + T2sec;
            }
        }

        private void Team1TimePlentyTimer_Tick(object sender, EventArgs e)
        {
            T1sec++;
            if (T1sec >= 60)
            {
                T1min++;
                T1sec = 0;
            }
            if (T1min < 10 && T1sec < 10)
            {
                lab_Team1TopTimePlenty.Text = "0" + T1min + " : " + "0" + T1sec;
                lab_Team1BottomTimePlenty.Text = "0" + T1min + " : " + "0" + T1sec;
            }
            else if (T1min < 10 && T1sec > 10)
            {
                lab_Team1TopTimePlenty.Text = "0" + T1min + " : " + T1sec;
                lab_Team1BottomTimePlenty.Text = "0" + T1min + " : " + T1sec;

            }
            else if (T1min > 10 && T1sec < 10)
            {
                lab_Team1TopTimePlenty.Text = T1min + " : " + "0" + T1sec;
                lab_Team1BottomTimePlenty.Text = T1min + " : " + "0" + T1sec;
            }
            else
            {
                lab_Team1TopTimePlenty.Text = T1min + " : " + T1sec;
                lab_Team1BottomTimePlenty.Text = T1min + " : " + T1sec;
            }
        }

        private void StopWatch_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec >= 60)
            {
                min++;
                sec = 0;
            }
            if (min < 10 && sec < 10)
            {
                lab_BottomClock.Text = "0" + min + " : " + "0" + sec;
                lab_TopClock.Text = "0" + min + "  :  " + "0" + sec;
            }
            else if (min < 10 && sec > 10)
            {
                lab_BottomClock.Text = "0" + min + " : " + sec;
                lab_TopClock.Text = "0" + min + "  :  " + sec;

            }
            else if (min > 10 && sec < 10)
            {
                lab_BottomClock.Text = min + " : " + "0" + sec;
                lab_TopClock.Text = min + "  :  " + "0" + sec;
            }
            else
            {
                lab_BottomClock.Text = min + " : " + sec;
                lab_TopClock.Text = min + "  :  " + sec;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


    }
}
