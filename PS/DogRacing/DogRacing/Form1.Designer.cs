namespace DogRacing
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
            this.pbDog4 = new System.Windows.Forms.PictureBox();
            this.pbDog3 = new System.Windows.Forms.PictureBox();
            this.pbDog2 = new System.Windows.Forms.PictureBox();
            this.pbDog1 = new System.Windows.Forms.PictureBox();
            this.pbRacetrack = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAlBet = new System.Windows.Forms.Label();
            this.lbBobBet = new System.Windows.Forms.Label();
            this.lbJoeBet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRace = new System.Windows.Forms.Button();
            this.numericDog = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            this.btnBets = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbMinimumBet = new System.Windows.Forms.Label();
            this.rbAl = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.rbJoe = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacetrack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDog4
            // 
            this.pbDog4.Image = global::DogRacing.Properties.Resources.dog;
            this.pbDog4.Location = new System.Drawing.Point(21, 192);
            this.pbDog4.Name = "pbDog4";
            this.pbDog4.Size = new System.Drawing.Size(88, 26);
            this.pbDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog4.TabIndex = 1;
            this.pbDog4.TabStop = false;
            // 
            // pbDog3
            // 
            this.pbDog3.Image = global::DogRacing.Properties.Resources.dog;
            this.pbDog3.Location = new System.Drawing.Point(21, 134);
            this.pbDog3.Name = "pbDog3";
            this.pbDog3.Size = new System.Drawing.Size(88, 26);
            this.pbDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog3.TabIndex = 1;
            this.pbDog3.TabStop = false;
            // 
            // pbDog2
            // 
            this.pbDog2.Image = global::DogRacing.Properties.Resources.dog;
            this.pbDog2.Location = new System.Drawing.Point(21, 71);
            this.pbDog2.Name = "pbDog2";
            this.pbDog2.Size = new System.Drawing.Size(88, 26);
            this.pbDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog2.TabIndex = 1;
            this.pbDog2.TabStop = false;
            // 
            // pbDog1
            // 
            this.pbDog1.Image = global::DogRacing.Properties.Resources.dog;
            this.pbDog1.Location = new System.Drawing.Point(21, 21);
            this.pbDog1.Name = "pbDog1";
            this.pbDog1.Size = new System.Drawing.Size(88, 26);
            this.pbDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog1.TabIndex = 1;
            this.pbDog1.TabStop = false;
            // 
            // pbRacetrack
            // 
            this.pbRacetrack.Image = global::DogRacing.Properties.Resources.racetrack;
            this.pbRacetrack.Location = new System.Drawing.Point(12, 12);
            this.pbRacetrack.Name = "pbRacetrack";
            this.pbRacetrack.Size = new System.Drawing.Size(659, 220);
            this.pbRacetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRacetrack.TabIndex = 0;
            this.pbRacetrack.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbAlBet);
            this.groupBox1.Controls.Add(this.lbBobBet);
            this.groupBox1.Controls.Add(this.lbJoeBet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnRace);
            this.groupBox1.Controls.Add(this.numericDog);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericAmount);
            this.groupBox1.Controls.Add(this.btnBets);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbMinimumBet);
            this.groupBox1.Controls.Add(this.rbAl);
            this.groupBox1.Controls.Add(this.rbBob);
            this.groupBox1.Controls.Add(this.rbJoe);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 176);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // lbAlBet
            // 
            this.lbAlBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAlBet.Location = new System.Drawing.Point(349, 99);
            this.lbAlBet.Name = "lbAlBet";
            this.lbAlBet.Size = new System.Drawing.Size(284, 20);
            this.lbAlBet.TabIndex = 14;
            this.lbAlBet.Text = "Al\'s bet";
            // 
            // lbBobBet
            // 
            this.lbBobBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBobBet.Location = new System.Drawing.Point(349, 72);
            this.lbBobBet.Name = "lbBobBet";
            this.lbBobBet.Size = new System.Drawing.Size(284, 20);
            this.lbBobBet.TabIndex = 14;
            this.lbBobBet.Text = "Bob\'s bet";
            // 
            // lbJoeBet
            // 
            this.lbJoeBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbJoeBet.Location = new System.Drawing.Point(349, 45);
            this.lbJoeBet.Name = "lbJoeBet";
            this.lbJoeBet.Size = new System.Drawing.Size(284, 20);
            this.lbJoeBet.TabIndex = 14;
            this.lbJoeBet.Text = "Joe\'s bet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(346, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bets";
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(541, 133);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(92, 30);
            this.btnRace.TabIndex = 12;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // numericDog
            // 
            this.numericDog.Location = new System.Drawing.Point(412, 135);
            this.numericDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericDog.Name = "numericDog";
            this.numericDog.Size = new System.Drawing.Size(73, 23);
            this.numericDog.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "bucks on dog number";
            // 
            // numericAmount
            // 
            this.numericAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericAmount.Location = new System.Drawing.Point(174, 138);
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(63, 23);
            this.numericAmount.TabIndex = 9;
            // 
            // btnBets
            // 
            this.btnBets.Location = new System.Drawing.Point(83, 137);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(75, 23);
            this.btnBets.TabIndex = 8;
            this.btnBets.Text = "Bets";
            this.btnBets.UseVisualStyleBackColor = true;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(20, 142);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 14);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Name";
            // 
            // lbMinimumBet
            // 
            this.lbMinimumBet.AutoSize = true;
            this.lbMinimumBet.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.lbMinimumBet.Location = new System.Drawing.Point(17, 25);
            this.lbMinimumBet.Name = "lbMinimumBet";
            this.lbMinimumBet.Size = new System.Drawing.Size(110, 16);
            this.lbMinimumBet.TabIndex = 6;
            this.lbMinimumBet.Text = "Minimum bet";
            // 
            // rbAl
            // 
            this.rbAl.AutoSize = true;
            this.rbAl.Location = new System.Drawing.Point(20, 105);
            this.rbAl.Name = "rbAl";
            this.rbAl.Size = new System.Drawing.Size(37, 18);
            this.rbAl.TabIndex = 3;
            this.rbAl.TabStop = true;
            this.rbAl.Text = "Al";
            this.rbAl.UseVisualStyleBackColor = true;
            this.rbAl.CheckedChanged += new System.EventHandler(this.rbName_Click);
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.Location = new System.Drawing.Point(20, 77);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(52, 18);
            this.rbBob.TabIndex = 4;
            this.rbBob.TabStop = true;
            this.rbBob.Text = "Bob";
            this.rbBob.UseVisualStyleBackColor = true;
            this.rbBob.CheckedChanged += new System.EventHandler(this.rbName_Click);
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.Location = new System.Drawing.Point(20, 49);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(48, 18);
            this.rbJoe.TabIndex = 5;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Joe";
            this.rbJoe.UseVisualStyleBackColor = true;
            this.rbJoe.CheckedChanged += new System.EventHandler(this.rbName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbDog4);
            this.Controls.Add(this.pbDog3);
            this.Controls.Add(this.pbDog2);
            this.Controls.Add(this.pbDog1);
            this.Controls.Add(this.pbRacetrack);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacetrack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRacetrack;
        private System.Windows.Forms.PictureBox pbDog1;
        private System.Windows.Forms.PictureBox pbDog2;
        private System.Windows.Forms.PictureBox pbDog3;
        private System.Windows.Forms.PictureBox pbDog4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAl;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.Label lbAlBet;
        private System.Windows.Forms.Label lbBobBet;
        private System.Windows.Forms.Label lbJoeBet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.NumericUpDown numericDog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMinimumBet;
    }
}

