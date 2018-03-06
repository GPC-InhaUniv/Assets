namespace ReDogsRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BackGround = new System.Windows.Forms.PictureBox();
            this.PicDog1 = new System.Windows.Forms.PictureBox();
            this.PicDog4 = new System.Windows.Forms.PictureBox();
            this.PicDog3 = new System.Windows.Forms.PictureBox();
            this.PicDog2 = new System.Windows.Forms.PictureBox();
            this.Betting_Parlor = new System.Windows.Forms.GroupBox();
            this.CashCharge = new System.Windows.Forms.Button();
            this.BetInfo3 = new System.Windows.Forms.TextBox();
            this.BetInfo2 = new System.Windows.Forms.TextBox();
            this.BetInfo1 = new System.Windows.Forms.TextBox();
            this.Bet_info_Label = new System.Windows.Forms.Label();
            this.Bettor3 = new System.Windows.Forms.RadioButton();
            this.Bettor2 = new System.Windows.Forms.RadioButton();
            this.Bettor1 = new System.Windows.Forms.RadioButton();
            this.Min_Bet_Cost = new System.Windows.Forms.Label();
            this.Min_bet_Label = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.BetDogNum = new System.Windows.Forms.NumericUpDown();
            this.BetCost = new System.Windows.Forms.NumericUpDown();
            this.CurrBettor = new System.Windows.Forms.Label();
            this.Start_Btn = new System.Windows.Forms.Button();
            this.Bet_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDog2)).BeginInit();
            this.Betting_Parlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BetDogNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetCost)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGround
            // 
            this.BackGround.Image = ((System.Drawing.Image)(resources.GetObject("BackGround.Image")));
            this.BackGround.Location = new System.Drawing.Point(13, 13);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(743, 248);
            this.BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackGround.TabIndex = 0;
            this.BackGround.TabStop = false;
            // 
            // PicDog1
            // 
            this.PicDog1.Image = ((System.Drawing.Image)(resources.GetObject("PicDog1.Image")));
            this.PicDog1.Location = new System.Drawing.Point(26, 23);
            this.PicDog1.Name = "PicDog1";
            this.PicDog1.Size = new System.Drawing.Size(100, 30);
            this.PicDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDog1.TabIndex = 1;
            this.PicDog1.TabStop = false;
            // 
            // PicDog4
            // 
            this.PicDog4.Image = ((System.Drawing.Image)(resources.GetObject("PicDog4.Image")));
            this.PicDog4.Location = new System.Drawing.Point(26, 216);
            this.PicDog4.Name = "PicDog4";
            this.PicDog4.Size = new System.Drawing.Size(100, 30);
            this.PicDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDog4.TabIndex = 2;
            this.PicDog4.TabStop = false;
            // 
            // PicDog3
            // 
            this.PicDog3.Image = ((System.Drawing.Image)(resources.GetObject("PicDog3.Image")));
            this.PicDog3.Location = new System.Drawing.Point(26, 146);
            this.PicDog3.Name = "PicDog3";
            this.PicDog3.Size = new System.Drawing.Size(100, 30);
            this.PicDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDog3.TabIndex = 3;
            this.PicDog3.TabStop = false;
            // 
            // PicDog2
            // 
            this.PicDog2.Image = ((System.Drawing.Image)(resources.GetObject("PicDog2.Image")));
            this.PicDog2.Location = new System.Drawing.Point(26, 81);
            this.PicDog2.Name = "PicDog2";
            this.PicDog2.Size = new System.Drawing.Size(100, 30);
            this.PicDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDog2.TabIndex = 4;
            this.PicDog2.TabStop = false;
            // 
            // Betting_Parlor
            // 
            this.Betting_Parlor.Controls.Add(this.CashCharge);
            this.Betting_Parlor.Controls.Add(this.BetInfo3);
            this.Betting_Parlor.Controls.Add(this.BetInfo2);
            this.Betting_Parlor.Controls.Add(this.BetInfo1);
            this.Betting_Parlor.Controls.Add(this.Bet_info_Label);
            this.Betting_Parlor.Controls.Add(this.Bettor3);
            this.Betting_Parlor.Controls.Add(this.Bettor2);
            this.Betting_Parlor.Controls.Add(this.Bettor1);
            this.Betting_Parlor.Controls.Add(this.Min_Bet_Cost);
            this.Betting_Parlor.Controls.Add(this.Min_bet_Label);
            this.Betting_Parlor.Controls.Add(this.label);
            this.Betting_Parlor.Controls.Add(this.BetDogNum);
            this.Betting_Parlor.Controls.Add(this.BetCost);
            this.Betting_Parlor.Controls.Add(this.CurrBettor);
            this.Betting_Parlor.Controls.Add(this.Start_Btn);
            this.Betting_Parlor.Controls.Add(this.Bet_Btn);
            this.Betting_Parlor.Location = new System.Drawing.Point(13, 268);
            this.Betting_Parlor.Name = "Betting_Parlor";
            this.Betting_Parlor.Size = new System.Drawing.Size(743, 262);
            this.Betting_Parlor.TabIndex = 5;
            this.Betting_Parlor.TabStop = false;
            this.Betting_Parlor.Text = "Betting Parlor";
            // 
            // CashCharge
            // 
            this.CashCharge.Location = new System.Drawing.Point(249, 71);
            this.CashCharge.Name = "CashCharge";
            this.CashCharge.Size = new System.Drawing.Size(160, 59);
            this.CashCharge.TabIndex = 15;
            this.CashCharge.Text = "CashShop";
            this.CashCharge.UseVisualStyleBackColor = true;
            this.CashCharge.Click += new System.EventHandler(this.CashCharge_Click);
            // 
            // BetInfo3
            // 
            this.BetInfo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BetInfo3.Enabled = false;
            this.BetInfo3.Location = new System.Drawing.Point(436, 152);
            this.BetInfo3.Name = "BetInfo3";
            this.BetInfo3.Size = new System.Drawing.Size(301, 21);
            this.BetInfo3.TabIndex = 14;
            // 
            // BetInfo2
            // 
            this.BetInfo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BetInfo2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BetInfo2.Enabled = false;
            this.BetInfo2.Location = new System.Drawing.Point(436, 113);
            this.BetInfo2.Name = "BetInfo2";
            this.BetInfo2.Size = new System.Drawing.Size(301, 21);
            this.BetInfo2.TabIndex = 13;
            // 
            // BetInfo1
            // 
            this.BetInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BetInfo1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BetInfo1.Enabled = false;
            this.BetInfo1.Location = new System.Drawing.Point(436, 74);
            this.BetInfo1.Name = "BetInfo1";
            this.BetInfo1.Size = new System.Drawing.Size(301, 21);
            this.BetInfo1.TabIndex = 12;
            // 
            // Bet_info_Label
            // 
            this.Bet_info_Label.AutoSize = true;
            this.Bet_info_Label.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bet_info_Label.Location = new System.Drawing.Point(432, 32);
            this.Bet_info_Label.Name = "Bet_info_Label";
            this.Bet_info_Label.Size = new System.Drawing.Size(60, 24);
            this.Bet_info_Label.TabIndex = 11;
            this.Bet_info_Label.Text = "Bets";
            // 
            // Bettor3
            // 
            this.Bettor3.AutoSize = true;
            this.Bettor3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bettor3.Location = new System.Drawing.Point(13, 149);
            this.Bettor3.Name = "Bettor3";
            this.Bettor3.Size = new System.Drawing.Size(41, 20);
            this.Bettor3.TabIndex = 10;
            this.Bettor3.TabStop = true;
            this.Bettor3.Text = "Al";
            this.Bettor3.UseVisualStyleBackColor = true;
            this.Bettor3.CheckedChanged += new System.EventHandler(this.Bettor3_CheckedChanged);
            // 
            // Bettor2
            // 
            this.Bettor2.AutoSize = true;
            this.Bettor2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bettor2.Location = new System.Drawing.Point(13, 110);
            this.Bettor2.Name = "Bettor2";
            this.Bettor2.Size = new System.Drawing.Size(58, 20);
            this.Bettor2.TabIndex = 9;
            this.Bettor2.TabStop = true;
            this.Bettor2.Text = "Bob";
            this.Bettor2.UseVisualStyleBackColor = true;
            this.Bettor2.CheckedChanged += new System.EventHandler(this.Bettor2_CheckedChanged);
            // 
            // Bettor1
            // 
            this.Bettor1.AutoSize = true;
            this.Bettor1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bettor1.Location = new System.Drawing.Point(13, 71);
            this.Bettor1.Name = "Bettor1";
            this.Bettor1.Size = new System.Drawing.Size(54, 20);
            this.Bettor1.TabIndex = 8;
            this.Bettor1.TabStop = true;
            this.Bettor1.Text = "Joe";
            this.Bettor1.UseVisualStyleBackColor = true;
            this.Bettor1.CheckedChanged += new System.EventHandler(this.Bettor1_CheckedChanged);
            // 
            // Min_Bet_Cost
            // 
            this.Min_Bet_Cost.AutoSize = true;
            this.Min_Bet_Cost.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Min_Bet_Cost.Location = new System.Drawing.Point(185, 32);
            this.Min_Bet_Cost.Name = "Min_Bet_Cost";
            this.Min_Bet_Cost.Size = new System.Drawing.Size(0, 21);
            this.Min_Bet_Cost.TabIndex = 7;
            // 
            // Min_bet_Label
            // 
            this.Min_bet_Label.AutoSize = true;
            this.Min_bet_Label.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Min_bet_Label.Location = new System.Drawing.Point(9, 32);
            this.Min_bet_Label.Name = "Min_bet_Label";
            this.Min_bet_Label.Size = new System.Drawing.Size(176, 24);
            this.Min_bet_Label.TabIndex = 6;
            this.Min_bet_Label.Text = "Minimum bet : ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.Location = new System.Drawing.Point(164, 222);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(187, 16);
            this.label.TabIndex = 5;
            this.label.Text = "bucks on dog number";
            // 
            // BetDogNum
            // 
            this.BetDogNum.Location = new System.Drawing.Point(357, 220);
            this.BetDogNum.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.BetDogNum.Name = "BetDogNum";
            this.BetDogNum.Size = new System.Drawing.Size(62, 21);
            this.BetDogNum.TabIndex = 4;
            // 
            // BetCost
            // 
            this.BetCost.Location = new System.Drawing.Point(70, 220);
            this.BetCost.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.BetCost.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetCost.Name = "BetCost";
            this.BetCost.Size = new System.Drawing.Size(76, 21);
            this.BetCost.TabIndex = 3;
            this.BetCost.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // CurrBettor
            // 
            this.CurrBettor.AutoSize = true;
            this.CurrBettor.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CurrBettor.Location = new System.Drawing.Point(6, 222);
            this.CurrBettor.Name = "CurrBettor";
            this.CurrBettor.Size = new System.Drawing.Size(58, 16);
            this.CurrBettor.TabIndex = 2;
            this.CurrBettor.Text = "Bettor";
            // 
            // Start_Btn
            // 
            this.Start_Btn.Location = new System.Drawing.Point(585, 185);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(152, 71);
            this.Start_Btn.TabIndex = 1;
            this.Start_Btn.Text = "Race!";
            this.Start_Btn.UseVisualStyleBackColor = true;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Btn_Click);
            // 
            // Bet_Btn
            // 
            this.Bet_Btn.Location = new System.Drawing.Point(436, 185);
            this.Bet_Btn.Name = "Bet_Btn";
            this.Bet_Btn.Size = new System.Drawing.Size(143, 71);
            this.Bet_Btn.TabIndex = 0;
            this.Bet_Btn.Text = "Bets";
            this.Bet_Btn.UseVisualStyleBackColor = true;
            this.Bet_Btn.Click += new System.EventHandler(this.Bet_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 542);
            this.Controls.Add(this.Betting_Parlor);
            this.Controls.Add(this.PicDog2);
            this.Controls.Add(this.PicDog3);
            this.Controls.Add(this.PicDog4);
            this.Controls.Add(this.PicDog1);
            this.Controls.Add(this.BackGround);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDog2)).EndInit();
            this.Betting_Parlor.ResumeLayout(false);
            this.Betting_Parlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BetDogNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackGround;
        private System.Windows.Forms.PictureBox PicDog1;
        private System.Windows.Forms.PictureBox PicDog4;
        private System.Windows.Forms.PictureBox PicDog3;
        private System.Windows.Forms.PictureBox PicDog2;
        private System.Windows.Forms.GroupBox Betting_Parlor;
        private System.Windows.Forms.Label CurrBettor;
        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.Button Bet_Btn;
        private System.Windows.Forms.TextBox BetInfo3;
        private System.Windows.Forms.TextBox BetInfo2;
        private System.Windows.Forms.TextBox BetInfo1;
        private System.Windows.Forms.Label Bet_info_Label;
        private System.Windows.Forms.RadioButton Bettor3;
        private System.Windows.Forms.RadioButton Bettor2;
        private System.Windows.Forms.RadioButton Bettor1;
        private System.Windows.Forms.Label Min_Bet_Cost;
        private System.Windows.Forms.Label Min_bet_Label;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown BetDogNum;
        private System.Windows.Forms.NumericUpDown BetCost;
        private System.Windows.Forms.Button CashCharge;
    }
}

