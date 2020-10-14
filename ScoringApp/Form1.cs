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
        public class penaltyTimerTable 
        {
            public Label label;
            public int min;
            public int sec;
        }

        List<penaltyTimerTable> timerTable1 = new List<penaltyTimerTable>();
        List<penaltyTimerTable> timerTable2 = new List<penaltyTimerTable>();

        int Team1Goal = 0, Team2Goal = 0;

        int min = 0, sec = 0;

        //Timeout
        bool team1Timeout = false, team2Timeout = false;

        bool start = false;
        private void CheckTimeout()
        {
            if (team1Timeout == true && team2Timeout == true)
            {
                StopWatch.Stop();
                stackTimer1.Stop();
                stackTimer2.Stop();
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
                Label controlPenaltyLabel = new Label();
                controlPenaltyLabel.AutoSize = false;
                controlPenaltyLabel.BorderStyle = BorderStyle.FixedSingle;
                controlPenaltyLabel.Size = new Size(122, 29);
                controlPenaltyLabel.BackColor = Color.White;
                controlPenaltyLabel.ForeColor = Color.FromArgb(24, 48, 104);
                controlPenaltyLabel.TextAlign = ContentAlignment.MiddleCenter;
                controlPenaltyLabel.Font = new Font("ITC Avant Garde Std Md", 14f, FontStyle.Bold);
                AssignAddress(controlPenaltyLabel, controlTeam1Stack);
                controlPenaltyLabel.Text = "02 : 00";
                controlPenaltyLabel.Click += new EventHandler(penaltyLabel_Click1);
                controlTeam1Stack.Controls.Add(controlPenaltyLabel);

                Label displayPenaltyLabel = new Label();
                displayPenaltyLabel.AutoSize = false;
                displayPenaltyLabel.BorderStyle = BorderStyle.FixedSingle;
                displayPenaltyLabel.Size = new Size(122, 29);
                displayPenaltyLabel.BackColor = Color.White;
                displayPenaltyLabel.ForeColor = Color.FromArgb(24, 48, 104);
                displayPenaltyLabel.TextAlign = ContentAlignment.MiddleCenter;
                displayPenaltyLabel.Font = new Font("ITC Avant Garde Std Md", 14f, FontStyle.Bold);
                displayPenaltyLabel.Tag = controlPenaltyLabel.Tag;
                displayPenaltyLabel.Text = "02 : 00";
                displayTeam1Stack.Controls.Add(displayPenaltyLabel);

                penaltyTimerTable timerRow = new penaltyTimerTable();
                timerRow.label = controlPenaltyLabel;
                timerRow.sec = 0; 
                timerRow.min = 2;
                timerTable1.Add(timerRow);

                stackTimer1.Enabled = true;
                stackTimer1.Start();
            }
        }

        private void penaltyLabel_Click1(object sender, EventArgs e)
        {
            string tag = (sender as Label).Tag.ToString();
            controlTeam1Stack.Controls.Remove((Label)sender);
            foreach (Control control in displayTeam1Stack.Controls) 
            {
                if (tag == control.Tag.ToString()) 
                {
                    displayTeam1Stack.Controls.Remove(control);
                    break;
                }
            }
            if (controlTeam1Stack.Controls.Count <= 0) 
            {
                stackTimer1.Stop();
                timerTable1.Clear();
            }
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

        private void btn_Team2TimePlenty_Click(object sender, EventArgs e)
        {
            if (displayTeam2Stack.Controls.Count < 4)
            {
                Label controlPenaltyLabel = new Label();
                controlPenaltyLabel.AutoSize = false;
                controlPenaltyLabel.BorderStyle = BorderStyle.FixedSingle;
                controlPenaltyLabel.Size = new Size(122, 29);
                controlPenaltyLabel.BackColor = Color.White;
                controlPenaltyLabel.ForeColor = Color.FromArgb(24, 48, 104);
                controlPenaltyLabel.TextAlign = ContentAlignment.MiddleCenter;
                controlPenaltyLabel.Font = new Font("ITC Avant Garde Std Md", 14f, FontStyle.Bold);
                AssignAddress(controlPenaltyLabel, controlTeam2Stack);
                controlPenaltyLabel.Text = "02 : 00";
                controlPenaltyLabel.Click += new EventHandler(penaltyLabel_Click2);
                controlTeam2Stack.Controls.Add(controlPenaltyLabel);

                Label displayPenaltyLabel = new Label();
                displayPenaltyLabel.AutoSize = false;
                displayPenaltyLabel.BorderStyle = BorderStyle.FixedSingle;
                displayPenaltyLabel.Size = new Size(122, 29);
                displayPenaltyLabel.BackColor = Color.White;
                displayPenaltyLabel.ForeColor = Color.FromArgb(24, 48, 104);
                displayPenaltyLabel.TextAlign = ContentAlignment.MiddleCenter;
                displayPenaltyLabel.Font = new Font("ITC Avant Garde Std Md", 14f, FontStyle.Bold);
                displayPenaltyLabel.Tag = controlPenaltyLabel.Tag;
                displayPenaltyLabel.Text = "02 : 00";
                displayTeam2Stack.Controls.Add(displayPenaltyLabel);

                penaltyTimerTable timerRow = new penaltyTimerTable();
                timerRow.label = controlPenaltyLabel;
                timerRow.sec = 0;
                timerRow.min = 2;
                timerTable2.Add(timerRow);

                stackTimer2.Enabled = true;
                stackTimer2.Start();
            }
        }

        private void penaltyLabel_Click2(object sender, EventArgs e)
        {
            string tag = (sender as Label).Tag.ToString();
            controlTeam2Stack.Controls.Remove((Label)sender);
            foreach (Control control in displayTeam2Stack.Controls)
            {
                if (tag == control.Tag.ToString())
                {
                    displayTeam2Stack.Controls.Remove(control);
                    break;
                }
            }
            if (controlTeam2Stack.Controls.Count <= 0)
            {
                stackTimer2.Stop();
                timerTable2.Clear();
            }
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

        private void stackTimer_Tick(object sender, EventArgs e)
        {
            foreach (penaltyTimerTable timerRow in timerTable1) 
            {
                if (timerRow.sec != 0)
                {
                    timerRow.sec--;
                }
                else if (timerRow.min != 0)
                {
                    timerRow.sec = 59;
                    timerRow.min--;
                }
                else if (timerRow.sec == 0 && timerRow.min == 0)
                {
                    //Do nothing
                }
                timerRow.label.Text = timerRow.min.ToString("#00") + " : " + timerRow.sec.ToString("#00");
                foreach (Control control in displayTeam1Stack.Controls) 
                {
                    if (timerRow.label.Tag.ToString() == control.Tag.ToString()) 
                    {
                        control.Text = timerRow.label.Text;
                        break;
                    }
                }
            }
        }

        private void displayTeam1Stack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stackTimer2_Tick(object sender, EventArgs e)
        {
            foreach (penaltyTimerTable timerRow in timerTable2)
            {
                if (timerRow.sec != 0)
                {
                    timerRow.sec--;
                }
                else if (timerRow.min != 0)
                {
                    timerRow.sec = 59;
                    timerRow.min--;
                }
                else if (timerRow.sec == 0 && timerRow.min == 0)
                {
                    //Do nothing
                }
                timerRow.label.Text = timerRow.min.ToString("#00") + " : " + timerRow.sec.ToString("#00");
                foreach (Control control in displayTeam2Stack.Controls)
                {
                    if (timerRow.label.Tag.ToString() == control.Tag.ToString())
                    {
                        control.Text = timerRow.label.Text;
                        break;
                    }
                }
            }
        }

        private void btn_StartWatchFromZero_Click(object sender, EventArgs e)
        {
            lab_TopClock.Text = "00  :  00";
            min = 0;
            sec = 0;

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
