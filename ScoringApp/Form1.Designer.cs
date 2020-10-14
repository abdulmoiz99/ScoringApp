namespace ScoringApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayTeam2Stack = new System.Windows.Forms.FlowLayoutPanel();
            this.displayTeam1Stack = new System.Windows.Forms.FlowLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lab_Goal = new System.Windows.Forms.Label();
            this.pnl_Team2Color = new System.Windows.Forms.Panel();
            this.pnl_Team1Color = new System.Windows.Forms.Panel();
            this.btn_BottomTeam2Timeout = new System.Windows.Forms.Button();
            this.btn_BottomTeam1Timeout = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lab_BottomClock = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Team1LeeresTOR = new System.Windows.Forms.Button();
            this.btn_TopTeam1Timeout = new System.Windows.Forms.Button();
            this.btn_Team1Dec = new System.Windows.Forms.Button();
            this.btn_Team1Inc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Team2Inc = new System.Windows.Forms.Button();
            this.btn_Team2Dec = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btn_Team2LeeresTOR = new System.Windows.Forms.Button();
            this.btn_TopTeam2Timeout = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_TopClock = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_DecMin = new System.Windows.Forms.Button();
            this.btn_IncMin = new System.Windows.Forms.Button();
            this.btn_IncSec = new System.Windows.Forms.Button();
            this.btn_DecSec = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.StopWatch = new System.Windows.Forms.Timer(this.components);
            this.btn_Team1TimePlenty = new System.Windows.Forms.Button();
            this.btn_Team2TimePlenty = new System.Windows.Forms.Button();
            this.btn_HalfTime_Results = new System.Windows.Forms.Button();
            this.btn_Results = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.controlTeam2Stack = new System.Windows.Forms.FlowLayoutPanel();
            this.controlTeam1Stack = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_START = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ToSave = new System.Windows.Forms.Button();
            this.btn_StartWatchFrom30 = new System.Windows.Forms.Button();
            this.btn_StartWatchFromZero = new System.Windows.Forms.Button();
            this.stackTimer1 = new System.Windows.Forms.Timer(this.components);
            this.stackTimer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.button1.Location = new System.Drawing.Point(202, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "TIME OUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.displayTeam2Stack);
            this.panel1.Controls.Add(this.displayTeam1Stack);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.pnl_Team2Color);
            this.panel1.Controls.Add(this.pnl_Team1Color);
            this.panel1.Controls.Add(this.btn_BottomTeam2Timeout);
            this.panel1.Controls.Add(this.btn_BottomTeam1Timeout);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 653);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1586, 252);
            this.panel1.TabIndex = 1;
            // 
            // displayTeam2Stack
            // 
            this.displayTeam2Stack.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.displayTeam2Stack.Location = new System.Drawing.Point(1026, 3);
            this.displayTeam2Stack.Name = "displayTeam2Stack";
            this.displayTeam2Stack.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.displayTeam2Stack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayTeam2Stack.Size = new System.Drawing.Size(183, 152);
            this.displayTeam2Stack.TabIndex = 45;
            // 
            // displayTeam1Stack
            // 
            this.displayTeam1Stack.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.displayTeam1Stack.Location = new System.Drawing.Point(380, 3);
            this.displayTeam1Stack.Name = "displayTeam1Stack";
            this.displayTeam1Stack.Size = new System.Drawing.Size(183, 152);
            this.displayTeam1Stack.TabIndex = 44;
            this.displayTeam1Stack.Paint += new System.Windows.Forms.PaintEventHandler(this.displayTeam1Stack_Paint);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.panel10.Controls.Add(this.lab_Goal);
            this.panel10.Location = new System.Drawing.Point(725, 160);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(140, 55);
            this.panel10.TabIndex = 26;
            // 
            // lab_Goal
            // 
            this.lab_Goal.AutoSize = true;
            this.lab_Goal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lab_Goal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.lab_Goal.Location = new System.Drawing.Point(23, -2);
            this.lab_Goal.Name = "lab_Goal";
            this.lab_Goal.Size = new System.Drawing.Size(87, 39);
            this.lab_Goal.TabIndex = 16;
            this.lab_Goal.Text = "0 : 0";
            this.lab_Goal.Click += new System.EventHandler(this.label5_Click);
            // 
            // pnl_Team2Color
            // 
            this.pnl_Team2Color.BackColor = System.Drawing.Color.White;
            this.pnl_Team2Color.Location = new System.Drawing.Point(855, 204);
            this.pnl_Team2Color.Name = "pnl_Team2Color";
            this.pnl_Team2Color.Size = new System.Drawing.Size(354, 10);
            this.pnl_Team2Color.TabIndex = 43;
            this.pnl_Team2Color.Click += new System.EventHandler(this.pnl_Team2Color_Click);
            this.pnl_Team2Color.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Team2Color_Paint);
            // 
            // pnl_Team1Color
            // 
            this.pnl_Team1Color.BackColor = System.Drawing.Color.White;
            this.pnl_Team1Color.Location = new System.Drawing.Point(380, 203);
            this.pnl_Team1Color.Name = "pnl_Team1Color";
            this.pnl_Team1Color.Size = new System.Drawing.Size(354, 10);
            this.pnl_Team1Color.TabIndex = 17;
            this.pnl_Team1Color.Click += new System.EventHandler(this.pnl_Team1Color_Click);
            this.pnl_Team1Color.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Team1Color_Paint);
            // 
            // btn_BottomTeam2Timeout
            // 
            this.btn_BottomTeam2Timeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.btn_BottomTeam2Timeout.FlatAppearance.BorderSize = 0;
            this.btn_BottomTeam2Timeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BottomTeam2Timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn_BottomTeam2Timeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_BottomTeam2Timeout.Location = new System.Drawing.Point(1215, 160);
            this.btn_BottomTeam2Timeout.Name = "btn_BottomTeam2Timeout";
            this.btn_BottomTeam2Timeout.Size = new System.Drawing.Size(172, 43);
            this.btn_BottomTeam2Timeout.TabIndex = 42;
            this.btn_BottomTeam2Timeout.Text = "TIME OUT";
            this.btn_BottomTeam2Timeout.UseVisualStyleBackColor = false;
            this.btn_BottomTeam2Timeout.Visible = false;
            this.btn_BottomTeam2Timeout.Click += new System.EventHandler(this.btn_BottomTeam2Timeout_Click);
            // 
            // btn_BottomTeam1Timeout
            // 
            this.btn_BottomTeam1Timeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.btn_BottomTeam1Timeout.FlatAppearance.BorderSize = 0;
            this.btn_BottomTeam1Timeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BottomTeam1Timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn_BottomTeam1Timeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_BottomTeam1Timeout.Location = new System.Drawing.Point(202, 160);
            this.btn_BottomTeam1Timeout.Name = "btn_BottomTeam1Timeout";
            this.btn_BottomTeam1Timeout.Size = new System.Drawing.Size(172, 43);
            this.btn_BottomTeam1Timeout.TabIndex = 41;
            this.btn_BottomTeam1Timeout.Text = "TIME OUT";
            this.btn_BottomTeam1Timeout.UseVisualStyleBackColor = false;
            this.btn_BottomTeam1Timeout.Visible = false;
            this.btn_BottomTeam1Timeout.Click += new System.EventHandler(this.btn_BottomTeam1Timeout_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.lab_BottomClock);
            this.panel13.Location = new System.Drawing.Point(725, 115);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(140, 44);
            this.panel13.TabIndex = 40;
            // 
            // lab_BottomClock
            // 
            this.lab_BottomClock.AutoSize = true;
            this.lab_BottomClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_BottomClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.lab_BottomClock.Location = new System.Drawing.Point(17, 4);
            this.lab_BottomClock.Name = "lab_BottomClock";
            this.lab_BottomClock.Size = new System.Drawing.Size(103, 31);
            this.lab_BottomClock.TabIndex = 15;
            this.lab_BottomClock.Text = "00 : 00";
            this.lab_BottomClock.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.textBox4.Location = new System.Drawing.Point(862, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(347, 39);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.textBox3.Location = new System.Drawing.Point(380, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(347, 39);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.button2.Location = new System.Drawing.Point(27, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "LEERES TOR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_Team1LeeresTOR
            // 
            this.btn_Team1LeeresTOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btn_Team1LeeresTOR.FlatAppearance.BorderSize = 0;
            this.btn_Team1LeeresTOR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.btn_Team1LeeresTOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Team1LeeresTOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btn_Team1LeeresTOR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_Team1LeeresTOR.Location = new System.Drawing.Point(27, 388);
            this.btn_Team1LeeresTOR.Name = "btn_Team1LeeresTOR";
            this.btn_Team1LeeresTOR.Size = new System.Drawing.Size(165, 47);
            this.btn_Team1LeeresTOR.TabIndex = 4;
            this.btn_Team1LeeresTOR.Text = "LEERES TOR";
            this.btn_Team1LeeresTOR.UseVisualStyleBackColor = false;
            this.btn_Team1LeeresTOR.Click += new System.EventHandler(this.btn_Team1LeeresTOR_Click);
            // 
            // btn_TopTeam1Timeout
            // 
            this.btn_TopTeam1Timeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btn_TopTeam1Timeout.FlatAppearance.BorderSize = 0;
            this.btn_TopTeam1Timeout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.btn_TopTeam1Timeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TopTeam1Timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btn_TopTeam1Timeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_TopTeam1Timeout.Location = new System.Drawing.Point(202, 388);
            this.btn_TopTeam1Timeout.Name = "btn_TopTeam1Timeout";
            this.btn_TopTeam1Timeout.Size = new System.Drawing.Size(165, 47);
            this.btn_TopTeam1Timeout.TabIndex = 3;
            this.btn_TopTeam1Timeout.Text = "TIME OUT";
            this.btn_TopTeam1Timeout.UseVisualStyleBackColor = false;
            this.btn_TopTeam1Timeout.Click += new System.EventHandler(this.btn_TopTeam1Timeout_Click);
            // 
            // btn_Team1Dec
            // 
            this.btn_Team1Dec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.btn_Team1Dec.FlatAppearance.BorderSize = 0;
            this.btn_Team1Dec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Team1Dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Team1Dec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_Team1Dec.Location = new System.Drawing.Point(380, 441);
            this.btn_Team1Dec.Name = "btn_Team1Dec";
            this.btn_Team1Dec.Size = new System.Drawing.Size(74, 47);
            this.btn_Team1Dec.TabIndex = 10;
            this.btn_Team1Dec.Text = "-";
            this.btn_Team1Dec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Team1Dec.UseVisualStyleBackColor = false;
            this.btn_Team1Dec.Click += new System.EventHandler(this.btn_Team1Dec_Click);
            // 
            // btn_Team1Inc
            // 
            this.btn_Team1Inc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.btn_Team1Inc.FlatAppearance.BorderSize = 0;
            this.btn_Team1Inc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Team1Inc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Team1Inc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_Team1Inc.Location = new System.Drawing.Point(653, 441);
            this.btn_Team1Inc.Name = "btn_Team1Inc";
            this.btn_Team1Inc.Size = new System.Drawing.Size(74, 47);
            this.btn_Team1Inc.TabIndex = 11;
            this.btn_Team1Inc.Text = "+";
            this.btn_Team1Inc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Team1Inc.UseVisualStyleBackColor = false;
            this.btn_Team1Inc.Click += new System.EventHandler(this.btn_Team1Inc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(520, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "TOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(751, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "LOGO";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.button7.Location = new System.Drawing.Point(757, 444);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 44);
            this.button7.TabIndex = 15;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1002, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "TOR";
            // 
            // btn_Team2Inc
            // 
            this.btn_Team2Inc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.btn_Team2Inc.FlatAppearance.BorderSize = 0;
            this.btn_Team2Inc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Team2Inc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Team2Inc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_Team2Inc.Location = new System.Drawing.Point(1135, 441);
            this.btn_Team2Inc.Name = "btn_Team2Inc";
            this.btn_Team2Inc.Size = new System.Drawing.Size(74, 47);
            this.btn_Team2Inc.TabIndex = 18;
            this.btn_Team2Inc.Text = "+";
            this.btn_Team2Inc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Team2Inc.UseVisualStyleBackColor = false;
            this.btn_Team2Inc.Click += new System.EventHandler(this.btn_Team2Inc_Click);
            // 
            // btn_Team2Dec
            // 
            this.btn_Team2Dec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.btn_Team2Dec.FlatAppearance.BorderSize = 0;
            this.btn_Team2Dec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Team2Dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Team2Dec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_Team2Dec.Location = new System.Drawing.Point(862, 441);
            this.btn_Team2Dec.Name = "btn_Team2Dec";
            this.btn_Team2Dec.Size = new System.Drawing.Size(74, 47);
            this.btn_Team2Dec.TabIndex = 17;
            this.btn_Team2Dec.Text = "-";
            this.btn_Team2Dec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Team2Dec.UseVisualStyleBackColor = false;
            this.btn_Team2Dec.Click += new System.EventHandler(this.btn_Team2Dec_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.button11.Location = new System.Drawing.Point(862, 388);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(347, 47);
            this.button11.TabIndex = 16;
            this.button11.Text = "TEAM 2";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // btn_Team2LeeresTOR
            // 
            this.btn_Team2LeeresTOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btn_Team2LeeresTOR.FlatAppearance.BorderSize = 0;
            this.btn_Team2LeeresTOR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.btn_Team2LeeresTOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Team2LeeresTOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btn_Team2LeeresTOR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_Team2LeeresTOR.Location = new System.Drawing.Point(1229, 388);
            this.btn_Team2LeeresTOR.Name = "btn_Team2LeeresTOR";
            this.btn_Team2LeeresTOR.Size = new System.Drawing.Size(165, 47);
            this.btn_Team2LeeresTOR.TabIndex = 24;
            this.btn_Team2LeeresTOR.Text = "LEERES TOR";
            this.btn_Team2LeeresTOR.UseVisualStyleBackColor = false;
            this.btn_Team2LeeresTOR.Click += new System.EventHandler(this.btn_Team2LeeresTOR_Click);
            // 
            // btn_TopTeam2Timeout
            // 
            this.btn_TopTeam2Timeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btn_TopTeam2Timeout.FlatAppearance.BorderSize = 0;
            this.btn_TopTeam2Timeout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.btn_TopTeam2Timeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TopTeam2Timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btn_TopTeam2Timeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_TopTeam2Timeout.Location = new System.Drawing.Point(1404, 388);
            this.btn_TopTeam2Timeout.Name = "btn_TopTeam2Timeout";
            this.btn_TopTeam2Timeout.Size = new System.Drawing.Size(165, 47);
            this.btn_TopTeam2Timeout.TabIndex = 23;
            this.btn_TopTeam2Timeout.Text = "TIME OUT";
            this.btn_TopTeam2Timeout.UseVisualStyleBackColor = false;
            this.btn_TopTeam2Timeout.Click += new System.EventHandler(this.btn_TopTeam2Timeout_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.button14.Location = new System.Drawing.Point(1229, 312);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(165, 47);
            this.button14.TabIndex = 22;
            this.button14.Text = "LEERES TOR";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.button15.Location = new System.Drawing.Point(1404, 312);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(165, 47);
            this.button15.TabIndex = 21;
            this.button15.Text = "TIME OUT";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lab_TopClock);
            this.panel2.Location = new System.Drawing.Point(653, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 48);
            this.panel2.TabIndex = 25;
            // 
            // lab_TopClock
            // 
            this.lab_TopClock.AutoSize = true;
            this.lab_TopClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TopClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.lab_TopClock.Location = new System.Drawing.Point(52, 3);
            this.lab_TopClock.Name = "lab_TopClock";
            this.lab_TopClock.Size = new System.Drawing.Size(143, 37);
            this.lab_TopClock.TabIndex = 16;
            this.lab_TopClock.Text = "00  :  00";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_Reset.Location = new System.Drawing.Point(725, 153);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(105, 24);
            this.btn_Reset.TabIndex = 28;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_DecMin
            // 
            this.btn_DecMin.BackColor = System.Drawing.Color.White;
            this.btn_DecMin.FlatAppearance.BorderSize = 0;
            this.btn_DecMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DecMin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DecMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_DecMin.Location = new System.Drawing.Point(663, 153);
            this.btn_DecMin.Name = "btn_DecMin";
            this.btn_DecMin.Size = new System.Drawing.Size(25, 24);
            this.btn_DecMin.TabIndex = 26;
            this.btn_DecMin.Text = "-";
            this.btn_DecMin.UseVisualStyleBackColor = false;
            this.btn_DecMin.Click += new System.EventHandler(this.btn_DecMin_Click);
            // 
            // btn_IncMin
            // 
            this.btn_IncMin.BackColor = System.Drawing.Color.White;
            this.btn_IncMin.FlatAppearance.BorderSize = 0;
            this.btn_IncMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IncMin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IncMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_IncMin.Location = new System.Drawing.Point(694, 153);
            this.btn_IncMin.Name = "btn_IncMin";
            this.btn_IncMin.Size = new System.Drawing.Size(25, 24);
            this.btn_IncMin.TabIndex = 27;
            this.btn_IncMin.Text = "+";
            this.btn_IncMin.UseVisualStyleBackColor = false;
            this.btn_IncMin.Click += new System.EventHandler(this.btn_IncMin_Click);
            // 
            // btn_IncSec
            // 
            this.btn_IncSec.BackColor = System.Drawing.Color.White;
            this.btn_IncSec.FlatAppearance.BorderSize = 0;
            this.btn_IncSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IncSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btn_IncSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_IncSec.Location = new System.Drawing.Point(867, 153);
            this.btn_IncSec.Name = "btn_IncSec";
            this.btn_IncSec.Size = new System.Drawing.Size(25, 24);
            this.btn_IncSec.TabIndex = 30;
            this.btn_IncSec.Text = "+";
            this.btn_IncSec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_IncSec.UseVisualStyleBackColor = false;
            this.btn_IncSec.Click += new System.EventHandler(this.btn_IncSec_Click);
            // 
            // btn_DecSec
            // 
            this.btn_DecSec.BackColor = System.Drawing.Color.White;
            this.btn_DecSec.FlatAppearance.BorderSize = 0;
            this.btn_DecSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DecSec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DecSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_DecSec.Location = new System.Drawing.Point(836, 153);
            this.btn_DecSec.Name = "btn_DecSec";
            this.btn_DecSec.Size = new System.Drawing.Size(25, 24);
            this.btn_DecSec.TabIndex = 29;
            this.btn_DecSec.Text = "-";
            this.btn_DecSec.UseVisualStyleBackColor = false;
            this.btn_DecSec.Click += new System.EventHandler(this.btn_DecSec_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.button9.Location = new System.Drawing.Point(380, 388);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(347, 47);
            this.button9.TabIndex = 9;
            this.button9.Text = "TEAM 1";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // StopWatch
            // 
            this.StopWatch.Interval = 1;
            this.StopWatch.Tick += new System.EventHandler(this.StopWatch_Tick);
            // 
            // btn_Team1TimePlenty
            // 
            this.btn_Team1TimePlenty.BackColor = System.Drawing.Color.White;
            this.btn_Team1TimePlenty.FlatAppearance.BorderSize = 0;
            this.btn_Team1TimePlenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Team1TimePlenty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Team1TimePlenty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_Team1TimePlenty.Location = new System.Drawing.Point(380, 326);
            this.btn_Team1TimePlenty.Name = "btn_Team1TimePlenty";
            this.btn_Team1TimePlenty.Size = new System.Drawing.Size(347, 33);
            this.btn_Team1TimePlenty.TabIndex = 41;
            this.btn_Team1TimePlenty.Text = "NEUE ZEITSTRAFE";
            this.btn_Team1TimePlenty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Team1TimePlenty.UseVisualStyleBackColor = false;
            this.btn_Team1TimePlenty.Click += new System.EventHandler(this.btn_Team1TimePlenty_Click);
            // 
            // btn_Team2TimePlenty
            // 
            this.btn_Team2TimePlenty.BackColor = System.Drawing.Color.White;
            this.btn_Team2TimePlenty.FlatAppearance.BorderSize = 0;
            this.btn_Team2TimePlenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Team2TimePlenty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Team2TimePlenty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_Team2TimePlenty.Location = new System.Drawing.Point(862, 326);
            this.btn_Team2TimePlenty.Name = "btn_Team2TimePlenty";
            this.btn_Team2TimePlenty.Size = new System.Drawing.Size(347, 33);
            this.btn_Team2TimePlenty.TabIndex = 42;
            this.btn_Team2TimePlenty.Text = "NEUE ZEITSTRAFE";
            this.btn_Team2TimePlenty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Team2TimePlenty.UseVisualStyleBackColor = false;
            this.btn_Team2TimePlenty.Click += new System.EventHandler(this.btn_Team2TimePlenty_Click);
            // 
            // btn_HalfTime_Results
            // 
            this.btn_HalfTime_Results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.btn_HalfTime_Results.FlatAppearance.BorderSize = 0;
            this.btn_HalfTime_Results.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HalfTime_Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_HalfTime_Results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_HalfTime_Results.Location = new System.Drawing.Point(653, 63);
            this.btn_HalfTime_Results.Name = "btn_HalfTime_Results";
            this.btn_HalfTime_Results.Size = new System.Drawing.Size(121, 24);
            this.btn_HalfTime_Results.TabIndex = 42;
            this.btn_HalfTime_Results.Text = "HALABZEIT-ERGEBNIS";
            this.btn_HalfTime_Results.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_HalfTime_Results.UseVisualStyleBackColor = false;
            // 
            // btn_Results
            // 
            this.btn_Results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.btn_Results.FlatAppearance.BorderSize = 0;
            this.btn_Results.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_Results.Location = new System.Drawing.Point(781, 63);
            this.btn_Results.Name = "btn_Results";
            this.btn_Results.Size = new System.Drawing.Size(121, 24);
            this.btn_Results.TabIndex = 43;
            this.btn_Results.Text = "ENDERGEBNIS";
            this.btn_Results.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.btn_ToSave);
            this.panel8.Controls.Add(this.controlTeam2Stack);
            this.panel8.Controls.Add(this.controlTeam1Stack);
            this.panel8.Controls.Add(this.btn_START);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.btn_StartWatchFrom30);
            this.panel8.Controls.Add(this.btn_StartWatchFromZero);
            this.panel8.Controls.Add(this.btn_Results);
            this.panel8.Controls.Add(this.btn_HalfTime_Results);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1586, 905);
            this.panel8.TabIndex = 43;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // controlTeam2Stack
            // 
            this.controlTeam2Stack.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.controlTeam2Stack.Location = new System.Drawing.Point(1026, 168);
            this.controlTeam2Stack.Name = "controlTeam2Stack";
            this.controlTeam2Stack.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.controlTeam2Stack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.controlTeam2Stack.Size = new System.Drawing.Size(183, 152);
            this.controlTeam2Stack.TabIndex = 46;
            // 
            // controlTeam1Stack
            // 
            this.controlTeam1Stack.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.controlTeam1Stack.Location = new System.Drawing.Point(380, 168);
            this.controlTeam1Stack.Name = "controlTeam1Stack";
            this.controlTeam1Stack.Size = new System.Drawing.Size(183, 152);
            this.controlTeam1Stack.TabIndex = 45;
            // 
            // btn_START
            // 
            this.btn_START.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btn_START.FlatAppearance.BorderSize = 0;
            this.btn_START.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(19)))));
            this.btn_START.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_START.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_START.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_START.Location = new System.Drawing.Point(1455, 606);
            this.btn_START.Name = "btn_START";
            this.btn_START.Size = new System.Drawing.Size(114, 29);
            this.btn_START.TabIndex = 48;
            this.btn_START.Text = "&START";
            this.btn_START.UseVisualStyleBackColor = false;
            this.btn_START.Click += new System.EventHandler(this.btn_START_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(476, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 31);
            this.label4.TabIndex = 47;
            this.label4.Text = "NEUE ZEIT";
            // 
            // btn_ToSave
            // 
            this.btn_ToSave.BackColor = System.Drawing.Color.White;
            this.btn_ToSave.FlatAppearance.BorderSize = 0;
            this.btn_ToSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ToSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ToSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_ToSave.Location = new System.Drawing.Point(912, 146);
            this.btn_ToSave.Name = "btn_ToSave";
            this.btn_ToSave.Size = new System.Drawing.Size(135, 28);
            this.btn_ToSave.TabIndex = 46;
            this.btn_ToSave.Text = "SPEICHERN";
            this.btn_ToSave.UseVisualStyleBackColor = false;
            this.btn_ToSave.Click += new System.EventHandler(this.btn_ToSave_Click);
            // 
            // btn_StartWatchFrom30
            // 
            this.btn_StartWatchFrom30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.btn_StartWatchFrom30.FlatAppearance.BorderSize = 0;
            this.btn_StartWatchFrom30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartWatchFrom30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_StartWatchFrom30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_StartWatchFrom30.Location = new System.Drawing.Point(912, 110);
            this.btn_StartWatchFrom30.Name = "btn_StartWatchFrom30";
            this.btn_StartWatchFrom30.Size = new System.Drawing.Size(135, 28);
            this.btn_StartWatchFrom30.TabIndex = 45;
            this.btn_StartWatchFrom30.Text = "30 : 00";
            this.btn_StartWatchFrom30.UseVisualStyleBackColor = false;
            this.btn_StartWatchFrom30.Click += new System.EventHandler(this.btn_StartWatchFrom30_Click);
            // 
            // btn_StartWatchFromZero
            // 
            this.btn_StartWatchFromZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.btn_StartWatchFromZero.FlatAppearance.BorderSize = 0;
            this.btn_StartWatchFromZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartWatchFromZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_StartWatchFromZero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.btn_StartWatchFromZero.Location = new System.Drawing.Point(912, 74);
            this.btn_StartWatchFromZero.Name = "btn_StartWatchFromZero";
            this.btn_StartWatchFromZero.Size = new System.Drawing.Size(135, 28);
            this.btn_StartWatchFromZero.TabIndex = 44;
            this.btn_StartWatchFromZero.Text = "00 : 00";
            this.btn_StartWatchFromZero.UseVisualStyleBackColor = false;
            this.btn_StartWatchFromZero.Click += new System.EventHandler(this.btn_StartWatchFromZero_Click);
            // 
            // stackTimer1
            // 
            this.stackTimer1.Interval = 1000;
            this.stackTimer1.Tick += new System.EventHandler(this.stackTimer_Tick);
            // 
            // stackTimer2
            // 
            this.stackTimer2.Interval = 1000;
            this.stackTimer2.Tick += new System.EventHandler(this.stackTimer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(104)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1586, 905);
            this.Controls.Add(this.btn_Team2TimePlenty);
            this.Controls.Add(this.btn_Team1TimePlenty);
            this.Controls.Add(this.btn_IncSec);
            this.Controls.Add(this.btn_DecSec);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_IncMin);
            this.Controls.Add(this.btn_DecMin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Team2LeeresTOR);
            this.Controls.Add(this.btn_TopTeam2Timeout);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Team2Inc);
            this.Controls.Add(this.btn_Team2Dec);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Team1Inc);
            this.Controls.Add(this.btn_Team1Dec);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btn_Team1LeeresTOR);
            this.Controls.Add(this.btn_TopTeam1Timeout);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Team1LeeresTOR;
        private System.Windows.Forms.Button btn_TopTeam1Timeout;
        private System.Windows.Forms.Button btn_Team1Dec;
        private System.Windows.Forms.Button btn_Team1Inc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Team2Inc;
        private System.Windows.Forms.Button btn_Team2Dec;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btn_Team2LeeresTOR;
        private System.Windows.Forms.Button btn_TopTeam2Timeout;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_DecMin;
        private System.Windows.Forms.Button btn_IncMin;
        private System.Windows.Forms.Button btn_IncSec;
        private System.Windows.Forms.Button btn_DecSec;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btn_BottomTeam1Timeout;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lab_BottomClock;
        private System.Windows.Forms.Label lab_Goal;
        private System.Windows.Forms.Timer StopWatch;
        private System.Windows.Forms.Label lab_TopClock;
        private System.Windows.Forms.Button btn_Team1TimePlenty;
        private System.Windows.Forms.Button btn_Team2TimePlenty;
        private System.Windows.Forms.Button btn_HalfTime_Results;
        private System.Windows.Forms.Button btn_Results;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_ToSave;
        private System.Windows.Forms.Button btn_StartWatchFrom30;
        private System.Windows.Forms.Button btn_StartWatchFromZero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_START;
        private System.Windows.Forms.Panel pnl_Team1Color;
        private System.Windows.Forms.Panel pnl_Team2Color;
        private System.Windows.Forms.FlowLayoutPanel displayTeam1Stack;
        private System.Windows.Forms.Timer stackTimer1;
        private System.Windows.Forms.Button btn_BottomTeam2Timeout;
        private System.Windows.Forms.FlowLayoutPanel controlTeam1Stack;
        private System.Windows.Forms.FlowLayoutPanel displayTeam2Stack;
        private System.Windows.Forms.FlowLayoutPanel controlTeam2Stack;
        private System.Windows.Forms.Timer stackTimer2;
    }
}

