namespace SlimeRace
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
            this.map = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.slime1 = new System.Windows.Forms.PictureBox();
            this.slime2 = new System.Windows.Forms.PictureBox();
            this.slime3 = new System.Windows.Forms.PictureBox();
            this.slime4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eventSlime2 = new System.Windows.Forms.PictureBox();
            this.eventSlime1 = new System.Windows.Forms.PictureBox();
            this.choiceUpDown = new System.Windows.Forms.NumericUpDown();
            this.bettingUpDown = new System.Windows.Forms.NumericUpDown();
            this.user3Lable = new System.Windows.Forms.Label();
            this.user2Lable = new System.Windows.Forms.Label();
            this.user1Lable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.betting = new System.Windows.Forms.Button();
            this.bettingName = new System.Windows.Forms.Label();
            this.user3 = new System.Windows.Forms.RadioButton();
            this.user2 = new System.Windows.Forms.RadioButton();
            this.user1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slime2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slime3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slime4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventSlime2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventSlime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bettingUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Image = ((System.Drawing.Image)(resources.GetObject("map.Image")));
            this.map.Location = new System.Drawing.Point(79, 50);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(935, 310);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(413, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "- 슬라임 레이스 -";
            // 
            // slime1
            // 
            this.slime1.Image = ((System.Drawing.Image)(resources.GetObject("slime1.Image")));
            this.slime1.Location = new System.Drawing.Point(122, 50);
            this.slime1.Name = "slime1";
            this.slime1.Size = new System.Drawing.Size(71, 57);
            this.slime1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slime1.TabIndex = 2;
            this.slime1.TabStop = false;
            this.slime1.Click += new System.EventHandler(this.slime1_Click);
            // 
            // slime2
            // 
            this.slime2.Image = ((System.Drawing.Image)(resources.GetObject("slime2.Image")));
            this.slime2.Location = new System.Drawing.Point(122, 122);
            this.slime2.Name = "slime2";
            this.slime2.Size = new System.Drawing.Size(71, 65);
            this.slime2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slime2.TabIndex = 3;
            this.slime2.TabStop = false;
            this.slime2.Click += new System.EventHandler(this.slime2_Click);
            // 
            // slime3
            // 
            this.slime3.Image = ((System.Drawing.Image)(resources.GetObject("slime3.Image")));
            this.slime3.Location = new System.Drawing.Point(122, 206);
            this.slime3.Name = "slime3";
            this.slime3.Size = new System.Drawing.Size(71, 66);
            this.slime3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slime3.TabIndex = 4;
            this.slime3.TabStop = false;
            this.slime3.Click += new System.EventHandler(this.slime3_Click);
            // 
            // slime4
            // 
            this.slime4.Image = ((System.Drawing.Image)(resources.GetObject("slime4.Image")));
            this.slime4.Location = new System.Drawing.Point(122, 293);
            this.slime4.Name = "slime4";
            this.slime4.Size = new System.Drawing.Size(71, 58);
            this.slime4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slime4.TabIndex = 5;
            this.slime4.TabStop = false;
            this.slime4.Click += new System.EventHandler(this.slime4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eventSlime2);
            this.groupBox1.Controls.Add(this.eventSlime1);
            this.groupBox1.Controls.Add(this.choiceUpDown);
            this.groupBox1.Controls.Add(this.bettingUpDown);
            this.groupBox1.Controls.Add(this.user3Lable);
            this.groupBox1.Controls.Add(this.user2Lable);
            this.groupBox1.Controls.Add(this.user1Lable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.betting);
            this.groupBox1.Controls.Add(this.bettingName);
            this.groupBox1.Controls.Add(this.user3);
            this.groupBox1.Controls.Add(this.user2);
            this.groupBox1.Controls.Add(this.user1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(79, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 293);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "베팅 창";
            // 
            // eventSlime2
            // 
            this.eventSlime2.Image = ((System.Drawing.Image)(resources.GetObject("eventSlime2.Image")));
            this.eventSlime2.Location = new System.Drawing.Point(810, 101);
            this.eventSlime2.Name = "eventSlime2";
            this.eventSlime2.Size = new System.Drawing.Size(100, 97);
            this.eventSlime2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eventSlime2.TabIndex = 21;
            this.eventSlime2.TabStop = false;
            // 
            // eventSlime1
            // 
            this.eventSlime1.Image = ((System.Drawing.Image)(resources.GetObject("eventSlime1.Image")));
            this.eventSlime1.Location = new System.Drawing.Point(810, 104);
            this.eventSlime1.Name = "eventSlime1";
            this.eventSlime1.Size = new System.Drawing.Size(100, 96);
            this.eventSlime1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eventSlime1.TabIndex = 20;
            this.eventSlime1.TabStop = false;
            // 
            // choiceUpDown
            // 
            this.choiceUpDown.Location = new System.Drawing.Point(522, 232);
            this.choiceUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.choiceUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.choiceUpDown.Name = "choiceUpDown";
            this.choiceUpDown.Size = new System.Drawing.Size(93, 29);
            this.choiceUpDown.TabIndex = 19;
            this.choiceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bettingUpDown
            // 
            this.bettingUpDown.Location = new System.Drawing.Point(170, 232);
            this.bettingUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.bettingUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.bettingUpDown.Name = "bettingUpDown";
            this.bettingUpDown.Size = new System.Drawing.Size(85, 29);
            this.bettingUpDown.TabIndex = 18;
            this.bettingUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // user3Lable
            // 
            this.user3Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user3Lable.Location = new System.Drawing.Point(318, 161);
            this.user3Lable.Name = "user3Lable";
            this.user3Lable.Size = new System.Drawing.Size(462, 21);
            this.user3Lable.TabIndex = 16;
            this.user3Lable.Text = "user3Lable";
            // 
            // user2Lable
            // 
            this.user2Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user2Lable.Location = new System.Drawing.Point(318, 132);
            this.user2Lable.Name = "user2Lable";
            this.user2Lable.Size = new System.Drawing.Size(462, 21);
            this.user2Lable.TabIndex = 15;
            this.user2Lable.Text = "user2Lable";
            // 
            // user1Lable
            // 
            this.user1Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user1Lable.Location = new System.Drawing.Point(318, 103);
            this.user1Lable.Name = "user1Lable";
            this.user1Lable.Size = new System.Drawing.Size(462, 21);
            this.user1Lable.TabIndex = 14;
            this.user1Lable.Text = "user1Lable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(315, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "베팅내역";
            // 
            // race
            // 
            this.race.Location = new System.Drawing.Point(650, 207);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(110, 54);
            this.race.TabIndex = 9;
            this.race.Text = "Race!!!";
            this.race.UseVisualStyleBackColor = true;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "베팅할 슬라임을 선택하세요.";
            // 
            // betting
            // 
            this.betting.Location = new System.Drawing.Point(85, 232);
            this.betting.Name = "betting";
            this.betting.Size = new System.Drawing.Size(75, 29);
            this.betting.TabIndex = 5;
            this.betting.Text = "베팅";
            this.betting.UseVisualStyleBackColor = true;
            this.betting.Click += new System.EventHandler(this.betting_Click);
            // 
            // bettingName
            // 
            this.bettingName.AutoSize = true;
            this.bettingName.Location = new System.Drawing.Point(15, 237);
            this.bettingName.Name = "bettingName";
            this.bettingName.Size = new System.Drawing.Size(71, 19);
            this.bettingName.TabIndex = 4;
            this.bettingName.Text = "btName";
            // 
            // user3
            // 
            this.user3.AutoSize = true;
            this.user3.Location = new System.Drawing.Point(31, 159);
            this.user3.Name = "user3";
            this.user3.Size = new System.Drawing.Size(73, 23);
            this.user3.TabIndex = 3;
            this.user3.TabStop = true;
            this.user3.Text = "user3";
            this.user3.UseVisualStyleBackColor = true;
            this.user3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // user2
            // 
            this.user2.AutoSize = true;
            this.user2.Location = new System.Drawing.Point(31, 130);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(73, 23);
            this.user2.TabIndex = 2;
            this.user2.TabStop = true;
            this.user2.Text = "user2";
            this.user2.UseVisualStyleBackColor = true;
            this.user2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // user1
            // 
            this.user1.AutoSize = true;
            this.user1.Location = new System.Drawing.Point(31, 101);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(73, 23);
            this.user1.TabIndex = 1;
            this.user1.TabStop = true;
            this.user1.Text = "user1";
            this.user1.UseVisualStyleBackColor = true;
            this.user1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "최소 베팅 : 5 Won";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1106, 690);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.slime4);
            this.Controls.Add(this.slime3);
            this.Controls.Add(this.slime2);
            this.Controls.Add(this.slime1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slime2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slime3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slime4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventSlime2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventSlime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bettingUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox slime1;
        private System.Windows.Forms.PictureBox slime2;
        private System.Windows.Forms.PictureBox slime3;
        private System.Windows.Forms.PictureBox slime4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button betting;
        private System.Windows.Forms.Label bettingName;
        private System.Windows.Forms.RadioButton user3;
        private System.Windows.Forms.RadioButton user2;
        private System.Windows.Forms.RadioButton user1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown choiceUpDown;
        private System.Windows.Forms.NumericUpDown bettingUpDown;
        private System.Windows.Forms.Label user3Lable;
        private System.Windows.Forms.Label user2Lable;
        private System.Windows.Forms.Label user1Lable;
        private System.Windows.Forms.PictureBox eventSlime2;
        private System.Windows.Forms.PictureBox eventSlime1;
    }
}

