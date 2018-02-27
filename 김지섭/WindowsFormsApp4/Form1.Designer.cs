namespace WindowsFormsApp4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.Joe_Button = new System.Windows.Forms.RadioButton();
            this.AI_Button = new System.Windows.Forms.RadioButton();
            this.Bob_Button = new System.Windows.Forms.RadioButton();
            this.Betting_GroupBox = new System.Windows.Forms.GroupBox();
            this.Joe_BetState_Label = new System.Windows.Forms.Label();
            this.Bob_BetState_Label = new System.Windows.Forms.Label();
            this.AI_BetState_Label = new System.Windows.Forms.Label();
            this.Joe_BetState_Lavel = new System.Windows.Forms.Label();
            this.Bets_Lavel = new System.Windows.Forms.Label();
            this.Race_Button = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Bets_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MiniBet_Lavel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.Betting_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 201);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 20);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(46, 177);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 20);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(46, 121);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(75, 20);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(46, 68);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(75, 20);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // Joe_Button
            // 
            this.Joe_Button.AutoSize = true;
            this.Joe_Button.Location = new System.Drawing.Point(6, 51);
            this.Joe_Button.Name = "Joe_Button";
            this.Joe_Button.Size = new System.Drawing.Size(43, 16);
            this.Joe_Button.TabIndex = 8;
            this.Joe_Button.TabStop = true;
            this.Joe_Button.Text = "Joe";
            this.Joe_Button.UseVisualStyleBackColor = true;
            this.Joe_Button.CheckedChanged += new System.EventHandler(this.Joe_Button_CheckedChanged);
            // 
            // AI_Button
            // 
            this.AI_Button.AutoSize = true;
            this.AI_Button.Location = new System.Drawing.Point(6, 95);
            this.AI_Button.Name = "AI_Button";
            this.AI_Button.Size = new System.Drawing.Size(34, 16);
            this.AI_Button.TabIndex = 9;
            this.AI_Button.TabStop = true;
            this.AI_Button.Text = "AI";
            this.AI_Button.UseVisualStyleBackColor = true;
            // 
            // Bob_Button
            // 
            this.Bob_Button.AutoSize = true;
            this.Bob_Button.Location = new System.Drawing.Point(6, 73);
            this.Bob_Button.Name = "Bob_Button";
            this.Bob_Button.Size = new System.Drawing.Size(45, 16);
            this.Bob_Button.TabIndex = 10;
            this.Bob_Button.TabStop = true;
            this.Bob_Button.Text = "Bob";
            this.Bob_Button.UseVisualStyleBackColor = true;
            // 
            // Betting_GroupBox
            // 
            this.Betting_GroupBox.Controls.Add(this.Joe_BetState_Label);
            this.Betting_GroupBox.Controls.Add(this.Bob_BetState_Label);
            this.Betting_GroupBox.Controls.Add(this.AI_BetState_Label);
            this.Betting_GroupBox.Controls.Add(this.Joe_BetState_Lavel);
            this.Betting_GroupBox.Controls.Add(this.Bets_Lavel);
            this.Betting_GroupBox.Controls.Add(this.Race_Button);
            this.Betting_GroupBox.Controls.Add(this.numericUpDown2);
            this.Betting_GroupBox.Controls.Add(this.numericUpDown1);
            this.Betting_GroupBox.Controls.Add(this.label3);
            this.Betting_GroupBox.Controls.Add(this.Bets_Button);
            this.Betting_GroupBox.Controls.Add(this.label2);
            this.Betting_GroupBox.Controls.Add(this.MiniBet_Lavel);
            this.Betting_GroupBox.Controls.Add(this.Joe_Button);
            this.Betting_GroupBox.Controls.Add(this.AI_Button);
            this.Betting_GroupBox.Controls.Add(this.Bob_Button);
            this.Betting_GroupBox.Location = new System.Drawing.Point(33, 231);
            this.Betting_GroupBox.Name = "Betting_GroupBox";
            this.Betting_GroupBox.Size = new System.Drawing.Size(603, 187);
            this.Betting_GroupBox.TabIndex = 11;
            this.Betting_GroupBox.TabStop = false;
            this.Betting_GroupBox.Text = "Betting";
            this.Betting_GroupBox.Enter += new System.EventHandler(this.Betting_GroupBox_Enter);
            // 
            // Joe_BetState_Label
            // 
            this.Joe_BetState_Label.AutoSize = true;
            this.Joe_BetState_Label.Location = new System.Drawing.Point(232, 51);
            this.Joe_BetState_Label.Name = "Joe_BetState_Label";
            this.Joe_BetState_Label.Size = new System.Drawing.Size(38, 12);
            this.Joe_BetState_Label.TabIndex = 23;
            this.Joe_BetState_Label.Text = "label1";
            this.Joe_BetState_Label.Click += new System.EventHandler(this.Joe_BetState_Label_Click);
            // 
            // Bob_BetState_Label
            // 
            this.Bob_BetState_Label.AutoSize = true;
            this.Bob_BetState_Label.Location = new System.Drawing.Point(232, 73);
            this.Bob_BetState_Label.Name = "Bob_BetState_Label";
            this.Bob_BetState_Label.Size = new System.Drawing.Size(38, 12);
            this.Bob_BetState_Label.TabIndex = 22;
            this.Bob_BetState_Label.Text = "label5";
            // 
            // AI_BetState_Label
            // 
            this.AI_BetState_Label.AutoSize = true;
            this.AI_BetState_Label.Location = new System.Drawing.Point(232, 95);
            this.AI_BetState_Label.Name = "AI_BetState_Label";
            this.AI_BetState_Label.Size = new System.Drawing.Size(38, 12);
            this.AI_BetState_Label.TabIndex = 21;
            this.AI_BetState_Label.Text = "label4";
            // 
            // Joe_BetState_Lavel
            // 
            this.Joe_BetState_Lavel.AutoSize = true;
            this.Joe_BetState_Lavel.Location = new System.Drawing.Point(232, 51);
            this.Joe_BetState_Lavel.Name = "Joe_BetState_Lavel";
            this.Joe_BetState_Lavel.Size = new System.Drawing.Size(0, 12);
            this.Joe_BetState_Lavel.TabIndex = 20;
            // 
            // Bets_Lavel
            // 
            this.Bets_Lavel.AutoSize = true;
            this.Bets_Lavel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bets_Lavel.Location = new System.Drawing.Point(231, 21);
            this.Bets_Lavel.Name = "Bets_Lavel";
            this.Bets_Lavel.Size = new System.Drawing.Size(45, 16);
            this.Bets_Lavel.TabIndex = 19;
            this.Bets_Lavel.Text = "Bets";
            // 
            // Race_Button
            // 
            this.Race_Button.Location = new System.Drawing.Point(497, 131);
            this.Race_Button.Name = "Race_Button";
            this.Race_Button.Size = new System.Drawing.Size(100, 48);
            this.Race_Button.TabIndex = 18;
            this.Race_Button.Text = "Race";
            this.Race_Button.UseVisualStyleBackColor = true;
            this.Race_Button.Click += new System.EventHandler(this.Race_Button_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(132, 151);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(44, 21);
            this.numericUpDown2.TabIndex = 17;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(368, 151);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 21);
            this.numericUpDown1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bucks on dog number";
            // 
            // Bets_Button
            // 
            this.Bets_Button.Location = new System.Drawing.Point(62, 151);
            this.Bets_Button.Name = "Bets_Button";
            this.Bets_Button.Size = new System.Drawing.Size(55, 21);
            this.Bets_Button.TabIndex = 13;
            this.Bets_Button.Text = "Bets";
            this.Bets_Button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // MiniBet_Lavel
            // 
            this.MiniBet_Lavel.AutoSize = true;
            this.MiniBet_Lavel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MiniBet_Lavel.Location = new System.Drawing.Point(6, 21);
            this.MiniBet_Lavel.Name = "MiniBet_Lavel";
            this.MiniBet_Lavel.Size = new System.Drawing.Size(111, 16);
            this.MiniBet_Lavel.TabIndex = 11;
            this.MiniBet_Lavel.Text = "Minimum Bet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 430);
            this.Controls.Add(this.Betting_GroupBox);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.Betting_GroupBox.ResumeLayout(false);
            this.Betting_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.RadioButton Joe_Button;
        private System.Windows.Forms.RadioButton AI_Button;
        private System.Windows.Forms.RadioButton Bob_Button;
        private System.Windows.Forms.GroupBox Betting_GroupBox;
        private System.Windows.Forms.Label MiniBet_Lavel;
        private System.Windows.Forms.Button Bets_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Bets_Lavel;
        private System.Windows.Forms.Button Race_Button;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Bob_BetState_Label;
        private System.Windows.Forms.Label AI_BetState_Label;
        private System.Windows.Forms.Label Joe_BetState_Lavel;
        private System.Windows.Forms.Label Joe_BetState_Label;
    }
}

