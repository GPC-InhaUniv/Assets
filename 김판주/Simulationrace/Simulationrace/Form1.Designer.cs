namespace Simulationrace
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dognum1 = new System.Windows.Forms.PictureBox();
            this.Racetrack = new System.Windows.Forms.PictureBox();
            this.Dognum2 = new System.Windows.Forms.PictureBox();
            this.Dognum3 = new System.Windows.Forms.PictureBox();
            this.Dognum4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAll = new System.Windows.Forms.Button();
            this.labAI = new System.Windows.Forms.Label();
            this.labBob = new System.Windows.Forms.Label();
            this.labJoe = new System.Windows.Forms.Label();
            this.btnRace = new System.Windows.Forms.Button();
            this.labBetslist = new System.Windows.Forms.Label();
            this.viewname = new System.Windows.Forms.Label();
            this.labdognum = new System.Windows.Forms.Label();
            this.dogupdown = new System.Windows.Forms.NumericUpDown();
            this.Betupdown = new System.Windows.Forms.NumericUpDown();
            this.btnbet = new System.Windows.Forms.Button();
            this.rbAI = new System.Windows.Forms.RadioButton();
            this.rbbob = new System.Windows.Forms.RadioButton();
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.labMbet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dognum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dognum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dognum3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dognum4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Betupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // Dognum1
            // 
            this.Dognum1.Image = global::Simulationrace.Properties.Resources.hound;
            this.Dognum1.Location = new System.Drawing.Point(96, 22);
            this.Dognum1.Name = "Dognum1";
            this.Dognum1.Size = new System.Drawing.Size(92, 36);
            this.Dognum1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dognum1.TabIndex = 1;
            this.Dognum1.TabStop = false;
            this.Dognum1.DoubleClick += new System.EventHandler(this.Dognum1_DoubleClick);
            // 
            // Racetrack
            // 
            this.Racetrack.Image = global::Simulationrace.Properties.Resources.ground;
            this.Racetrack.Location = new System.Drawing.Point(82, 12);
            this.Racetrack.Name = "Racetrack";
            this.Racetrack.Size = new System.Drawing.Size(498, 234);
            this.Racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Racetrack.TabIndex = 0;
            this.Racetrack.TabStop = false;
            // 
            // Dognum2
            // 
            this.Dognum2.Image = global::Simulationrace.Properties.Resources.hound;
            this.Dognum2.Location = new System.Drawing.Point(96, 76);
            this.Dognum2.Name = "Dognum2";
            this.Dognum2.Size = new System.Drawing.Size(92, 36);
            this.Dognum2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dognum2.TabIndex = 1;
            this.Dognum2.TabStop = false;
            this.Dognum2.Click += new System.EventHandler(this.Dognum2_Click);
            // 
            // Dognum3
            // 
            this.Dognum3.Image = global::Simulationrace.Properties.Resources.hound;
            this.Dognum3.Location = new System.Drawing.Point(96, 136);
            this.Dognum3.Name = "Dognum3";
            this.Dognum3.Size = new System.Drawing.Size(92, 36);
            this.Dognum3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dognum3.TabIndex = 1;
            this.Dognum3.TabStop = false;
            this.Dognum3.Click += new System.EventHandler(this.Dognum3_Click);
            // 
            // Dognum4
            // 
            this.Dognum4.Image = global::Simulationrace.Properties.Resources.hound;
            this.Dognum4.Location = new System.Drawing.Point(96, 198);
            this.Dognum4.Name = "Dognum4";
            this.Dognum4.Size = new System.Drawing.Size(92, 36);
            this.Dognum4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dognum4.TabIndex = 1;
            this.Dognum4.TabStop = false;
            this.Dognum4.Click += new System.EventHandler(this.Dognum4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAll);
            this.groupBox1.Controls.Add(this.labAI);
            this.groupBox1.Controls.Add(this.labBob);
            this.groupBox1.Controls.Add(this.labJoe);
            this.groupBox1.Controls.Add(this.btnRace);
            this.groupBox1.Controls.Add(this.labBetslist);
            this.groupBox1.Controls.Add(this.viewname);
            this.groupBox1.Controls.Add(this.labdognum);
            this.groupBox1.Controls.Add(this.dogupdown);
            this.groupBox1.Controls.Add(this.Betupdown);
            this.groupBox1.Controls.Add(this.btnbet);
            this.groupBox1.Controls.Add(this.rbAI);
            this.groupBox1.Controls.Add(this.rbbob);
            this.groupBox1.Controls.Add(this.rbJoe);
            this.groupBox1.Controls.Add(this.labMbet);
            this.groupBox1.Location = new System.Drawing.Point(19, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // BtnAll
            // 
            this.BtnAll.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.BtnAll.Location = new System.Drawing.Point(189, 55);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(75, 63);
            this.BtnAll.TabIndex = 9;
            this.BtnAll.Text = "ALL - IN";
            this.BtnAll.UseVisualStyleBackColor = true;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // labAI
            // 
            this.labAI.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labAI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labAI.Location = new System.Drawing.Point(302, 115);
            this.labAI.Name = "labAI";
            this.labAI.Size = new System.Drawing.Size(273, 21);
            this.labAI.TabIndex = 8;
            this.labAI.Text = "AI는 배팅하지 않았습니다.";
            // 
            // labBob
            // 
            this.labBob.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labBob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labBob.Location = new System.Drawing.Point(302, 79);
            this.labBob.Name = "labBob";
            this.labBob.Size = new System.Drawing.Size(273, 21);
            this.labBob.TabIndex = 8;
            this.labBob.Text = "Bob은 배팅하지 않았습니다.";
            // 
            // labJoe
            // 
            this.labJoe.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labJoe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labJoe.Location = new System.Drawing.Point(302, 46);
            this.labJoe.Name = "labJoe";
            this.labJoe.Size = new System.Drawing.Size(273, 21);
            this.labJoe.TabIndex = 8;
            this.labJoe.Text = "Joe는 배팅하지 않았습니다.";
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(456, 143);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(119, 37);
            this.btnRace.TabIndex = 7;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // labBetslist
            // 
            this.labBetslist.AutoSize = true;
            this.labBetslist.Location = new System.Drawing.Point(302, 26);
            this.labBetslist.Name = "labBetslist";
            this.labBetslist.Size = new System.Drawing.Size(30, 12);
            this.labBetslist.TabIndex = 6;
            this.labBetslist.Text = "Bets";
            // 
            // viewname
            // 
            this.viewname.AutoSize = true;
            this.viewname.Location = new System.Drawing.Point(19, 159);
            this.viewname.Name = "viewname";
            this.viewname.Size = new System.Drawing.Size(25, 12);
            this.viewname.TabIndex = 6;
            this.viewname.Text = "Joe";
            // 
            // labdognum
            // 
            this.labdognum.AutoSize = true;
            this.labdognum.Location = new System.Drawing.Point(249, 162);
            this.labdognum.Name = "labdognum";
            this.labdognum.Size = new System.Drawing.Size(129, 12);
            this.labdognum.TabIndex = 5;
            this.labdognum.Text = "bucks on dog number";
            // 
            // dogupdown
            // 
            this.dogupdown.Location = new System.Drawing.Point(384, 153);
            this.dogupdown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogupdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogupdown.Name = "dogupdown";
            this.dogupdown.Size = new System.Drawing.Size(46, 21);
            this.dogupdown.TabIndex = 4;
            this.dogupdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Betupdown
            // 
            this.Betupdown.Location = new System.Drawing.Point(189, 153);
            this.Betupdown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Betupdown.Name = "Betupdown";
            this.Betupdown.Size = new System.Drawing.Size(44, 21);
            this.Betupdown.TabIndex = 3;
            this.Betupdown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnbet
            // 
            this.btnbet.Location = new System.Drawing.Point(77, 153);
            this.btnbet.Name = "btnbet";
            this.btnbet.Size = new System.Drawing.Size(87, 25);
            this.btnbet.TabIndex = 2;
            this.btnbet.Text = "Bets";
            this.btnbet.UseVisualStyleBackColor = true;
            this.btnbet.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbAI
            // 
            this.rbAI.AutoSize = true;
            this.rbAI.Location = new System.Drawing.Point(16, 120);
            this.rbAI.Name = "rbAI";
            this.rbAI.Size = new System.Drawing.Size(34, 16);
            this.rbAI.TabIndex = 1;
            this.rbAI.Text = "AI";
            this.rbAI.UseVisualStyleBackColor = true;
            this.rbAI.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // rbbob
            // 
            this.rbbob.AutoSize = true;
            this.rbbob.Location = new System.Drawing.Point(16, 84);
            this.rbbob.Name = "rbbob";
            this.rbbob.Size = new System.Drawing.Size(45, 16);
            this.rbbob.TabIndex = 1;
            this.rbbob.Text = "Bob";
            this.rbbob.UseVisualStyleBackColor = true;
            this.rbbob.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.Checked = true;
            this.rbJoe.Location = new System.Drawing.Point(16, 51);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(43, 16);
            this.rbJoe.TabIndex = 1;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Joe";
            this.rbJoe.UseVisualStyleBackColor = true;
            this.rbJoe.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // labMbet
            // 
            this.labMbet.AutoSize = true;
            this.labMbet.Location = new System.Drawing.Point(19, 26);
            this.labMbet.Name = "labMbet";
            this.labMbet.Size = new System.Drawing.Size(87, 12);
            this.labMbet.TabIndex = 0;
            this.labMbet.Text = "Minimum bet :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dognum4);
            this.Controls.Add(this.Dognum3);
            this.Controls.Add(this.Dognum2);
            this.Controls.Add(this.Dognum1);
            this.Controls.Add(this.Racetrack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "race";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dognum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dognum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dognum3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dognum4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Betupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Racetrack;
        private System.Windows.Forms.PictureBox Dognum1;
        private System.Windows.Forms.PictureBox Dognum2;
        private System.Windows.Forms.PictureBox Dognum3;
        private System.Windows.Forms.PictureBox Dognum4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label labBetslist;
        private System.Windows.Forms.Label viewname;
        private System.Windows.Forms.Label labdognum;
        private System.Windows.Forms.NumericUpDown dogupdown;
        private System.Windows.Forms.NumericUpDown Betupdown;
        private System.Windows.Forms.Button btnbet;
        private System.Windows.Forms.RadioButton rbAI;
        private System.Windows.Forms.RadioButton rbbob;
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.Label labMbet;
        private System.Windows.Forms.Label labJoe;
        private System.Windows.Forms.Label labAI;
        private System.Windows.Forms.Label labBob;
        private System.Windows.Forms.Button BtnAll;
    }
}

