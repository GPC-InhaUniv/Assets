namespace WindowsFormsApp1
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
            this.g_betInfo = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_bet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.l_bettor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.ud_betHow = new System.Windows.Forms.NumericUpDown();
            this.ud_dogNum = new System.Windows.Forms.NumericUpDown();
            this.g_betInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_betHow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_dogNum)).BeginInit();
            this.SuspendLayout();
            // 
            // g_betInfo
            // 
            this.g_betInfo.Controls.Add(this.ud_dogNum);
            this.g_betInfo.Controls.Add(this.ud_betHow);
            this.g_betInfo.Controls.Add(this.textBox2);
            this.g_betInfo.Controls.Add(this.textBox3);
            this.g_betInfo.Controls.Add(this.textBox1);
            this.g_betInfo.Controls.Add(this.radioButton3);
            this.g_betInfo.Controls.Add(this.radioButton2);
            this.g_betInfo.Controls.Add(this.radioButton1);
            this.g_betInfo.Controls.Add(this.btn_bet);
            this.g_betInfo.Controls.Add(this.button1);
            this.g_betInfo.Controls.Add(this.label7);
            this.g_betInfo.Controls.Add(this.l_bettor);
            this.g_betInfo.Controls.Add(this.label5);
            this.g_betInfo.Controls.Add(this.label1);
            this.g_betInfo.Location = new System.Drawing.Point(13, 209);
            this.g_betInfo.Name = "g_betInfo";
            this.g_betInfo.Size = new System.Drawing.Size(548, 220);
            this.g_betInfo.TabIndex = 1;
            this.g_betInfo.TabStop = false;
            this.g_betInfo.Text = "Betting Parlor";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(303, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 21);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(303, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 21);
            this.textBox3.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(303, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 21);
            this.textBox1.TabIndex = 5;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 119);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(113, 16);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Al has 45 bucks";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 87);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 16);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bob has 75 bucks";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 16);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Joe has 50 bucks";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_bet
            // 
            this.btn_bet.Location = new System.Drawing.Point(32, 194);
            this.btn_bet.Name = "btn_bet";
            this.btn_bet.Size = new System.Drawing.Size(55, 23);
            this.btn_bet.TabIndex = 1;
            this.btn_bet.Text = "Bets";
            this.btn_bet.UseVisualStyleBackColor = true;
            this.btn_bet.Click += new System.EventHandler(this.btn_bet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Race!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "bucks on dog number";
            // 
            // l_bettor
            // 
            this.l_bettor.AutoSize = true;
            this.l_bettor.Location = new System.Drawing.Point(7, 199);
            this.l_bettor.Name = "l_bettor";
            this.l_bettor.Size = new System.Drawing.Size(25, 12);
            this.l_bettor.TabIndex = 0;
            this.l_bettor.Text = "Joe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(301, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum bet: 5 bucks ";
            // 
            // dog1
            // 
            this.dog1.Image = global::WindowsFormsApp1.Properties.Resources.dog;
            this.dog1.Location = new System.Drawing.Point(22, 15);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(68, 31);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog1.TabIndex = 2;
            this.dog1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.racetrack;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = global::WindowsFormsApp1.Properties.Resources.dog;
            this.dog2.Location = new System.Drawing.Point(22, 64);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(68, 31);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog2.TabIndex = 3;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = global::WindowsFormsApp1.Properties.Resources.dog;
            this.dog3.Location = new System.Drawing.Point(22, 116);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(68, 31);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog3.TabIndex = 4;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = global::WindowsFormsApp1.Properties.Resources.dog;
            this.dog4.Location = new System.Drawing.Point(22, 164);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(68, 31);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog4.TabIndex = 5;
            this.dog4.TabStop = false;
            // 
            // ud_betHow
            // 
            this.ud_betHow.Location = new System.Drawing.Point(93, 196);
            this.ud_betHow.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ud_betHow.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ud_betHow.Name = "ud_betHow";
            this.ud_betHow.Size = new System.Drawing.Size(52, 21);
            this.ud_betHow.TabIndex = 8;
            this.ud_betHow.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ud_dogNum
            // 
            this.ud_dogNum.Location = new System.Drawing.Point(286, 196);
            this.ud_dogNum.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ud_dogNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud_dogNum.Name = "ud_dogNum";
            this.ud_dogNum.Size = new System.Drawing.Size(63, 21);
            this.ud_dogNum.TabIndex = 9;
            this.ud_dogNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 441);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.g_betInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.g_betInfo.ResumeLayout(false);
            this.g_betInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_betHow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_dogNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox g_betInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_bet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_bettor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.NumericUpDown ud_dogNum;
        private System.Windows.Forms.NumericUpDown ud_betHow;
    }
}

