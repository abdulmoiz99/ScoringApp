﻿using System;
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
            lab_TopClock.Text = "00  :  00";
            lab_BottomClock.Text = "00  :  00";
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
                lab_BottomClock.Text = min.ToString("#00") + " : " + sec.ToString("#00");
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
            lab_BottomClock.Text = min.ToString("#00") + " : " + sec.ToString("#00");
            lab_TopClock.Text = min.ToString("#00") + "  :  " + sec.ToString("#00");
        }

        private void btn_DecMin_Click(object sender, EventArgs e)
        {
            if (min>0)
            {
                min--;
            }
            lab_BottomClock.Text = min.ToString("#00") + " : " + sec.ToString("#00");
            lab_TopClock.Text = min.ToString("#00") + "  :  " + sec.ToString("#00");
        }

        private void btn_DecSec_Click(object sender, EventArgs e)
        {
            if (sec>0)
            {
                sec--;
            }
            lab_BottomClock.Text = min.ToString("#00") + " : " + sec.ToString("#00");
            lab_TopClock.Text = min.ToString("#00") + "  :  " + sec.ToString("#00");

        }

        private void btn_StartWatchFromZero_Click(object sender, EventArgs e)
        {
            lab_TopClock.Text = "00  :  00";
            lab_BottomClock.Text = "00  :  00";
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
            lab_BottomClock.Text =  min.ToString("#00") + " : " + sec.ToString("#00");
            lab_TopClock.Text = min.ToString("#00") + "  :  " + sec.ToString("#00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


    }
}
