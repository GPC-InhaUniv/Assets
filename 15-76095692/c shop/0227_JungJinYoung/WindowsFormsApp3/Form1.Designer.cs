namespace WindowsFormsApp3
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
            this.backGround = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AlLabel = new System.Windows.Forms.Label();
            this.BobLabel = new System.Windows.Forms.Label();
            this.JoeLabel = new System.Windows.Forms.Label();
            this.DogUpDown = new System.Windows.Forms.NumericUpDown();
            this.BetUpDown = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GuyNameLabel = new System.Windows.Forms.Label();
            this.AlRadioButton = new System.Windows.Forms.RadioButton();
            this.BobRadioButton = new System.Windows.Forms.RadioButton();
            this.JoeRadioButton = new System.Windows.Forms.RadioButton();
            this.MinimumBetLabel = new System.Windows.Forms.Label();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            this.SuspendLayout();
            // 
            // backGround
            // 
            this.backGround.Image = global::WindowsFormsApp3.Properties.Resources.bg;
            this.backGround.Location = new System.Drawing.Point(13, 13);
            this.backGround.Name = "backGround";
            this.backGround.Size = new System.Drawing.Size(548, 256);
            this.backGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backGround.TabIndex = 0;
            this.backGround.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AlLabel);
            this.groupBox1.Controls.Add(this.BobLabel);
            this.groupBox1.Controls.Add(this.JoeLabel);
            this.groupBox1.Controls.Add(this.DogUpDown);
            this.groupBox1.Controls.Add(this.BetUpDown);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.GuyNameLabel);
            this.groupBox1.Controls.Add(this.AlRadioButton);
            this.groupBox1.Controls.Add(this.BobRadioButton);
            this.groupBox1.Controls.Add(this.JoeRadioButton);
            this.groupBox1.Controls.Add(this.MinimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // AlLabel
            // 
            this.AlLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.AlLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlLabel.Location = new System.Drawing.Point(313, 103);
            this.AlLabel.Name = "AlLabel";
            this.AlLabel.Size = new System.Drawing.Size(332, 22);
            this.AlLabel.TabIndex = 16;
            this.AlLabel.Text = "label5";
            // 
            // BobLabel
            // 
            this.BobLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.BobLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BobLabel.Location = new System.Drawing.Point(313, 80);
            this.BobLabel.Name = "BobLabel";
            this.BobLabel.Size = new System.Drawing.Size(332, 22);
            this.BobLabel.TabIndex = 15;
            this.BobLabel.Text = "label2";
            // 
            // JoeLabel
            // 
            this.JoeLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.JoeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JoeLabel.Location = new System.Drawing.Point(313, 57);
            this.JoeLabel.Name = "JoeLabel";
            this.JoeLabel.Size = new System.Drawing.Size(332, 22);
            this.JoeLabel.TabIndex = 14;
            this.JoeLabel.Text = "label1";
            // 
            // DogUpDown
            // 
            this.DogUpDown.Location = new System.Drawing.Point(407, 147);
            this.DogUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.DogUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DogUpDown.Name = "DogUpDown";
            this.DogUpDown.Size = new System.Drawing.Size(120, 21);
            this.DogUpDown.TabIndex = 13;
            this.DogUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BetUpDown
            // 
            this.BetUpDown.Location = new System.Drawing.Point(132, 145);
            this.BetUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.BetUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetUpDown.Name = "BetUpDown";
            this.BetUpDown.Size = new System.Drawing.Size(120, 21);
            this.BetUpDown.TabIndex = 12;
            this.BetUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "Race!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "bucks on dog number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuyNameLabel
            // 
            this.GuyNameLabel.AutoSize = true;
            this.GuyNameLabel.Location = new System.Drawing.Point(5, 144);
            this.GuyNameLabel.Name = "GuyNameLabel";
            this.GuyNameLabel.Size = new System.Drawing.Size(38, 12);
            this.GuyNameLabel.TabIndex = 4;
            this.GuyNameLabel.Text = "label2";
            // 
            // AlRadioButton
            // 
            this.AlRadioButton.AutoSize = true;
            this.AlRadioButton.Location = new System.Drawing.Point(7, 103);
            this.AlRadioButton.Name = "AlRadioButton";
            this.AlRadioButton.Size = new System.Drawing.Size(14, 13);
            this.AlRadioButton.TabIndex = 3;
            this.AlRadioButton.TabStop = true;
            this.AlRadioButton.UseVisualStyleBackColor = true;
            this.AlRadioButton.CheckedChanged += new System.EventHandler(this.AlRadioButton_CheckedChanged);
            // 
            // BobRadioButton
            // 
            this.BobRadioButton.AutoSize = true;
            this.BobRadioButton.Location = new System.Drawing.Point(7, 80);
            this.BobRadioButton.Name = "BobRadioButton";
            this.BobRadioButton.Size = new System.Drawing.Size(14, 13);
            this.BobRadioButton.TabIndex = 2;
            this.BobRadioButton.TabStop = true;
            this.BobRadioButton.UseVisualStyleBackColor = true;
            this.BobRadioButton.CheckedChanged += new System.EventHandler(this.BobRadioButton_CheckedChanged);
            // 
            // JoeRadioButton
            // 
            this.JoeRadioButton.AutoSize = true;
            this.JoeRadioButton.Location = new System.Drawing.Point(6, 58);
            this.JoeRadioButton.Name = "JoeRadioButton";
            this.JoeRadioButton.Size = new System.Drawing.Size(14, 13);
            this.JoeRadioButton.TabIndex = 1;
            this.JoeRadioButton.TabStop = true;
            this.JoeRadioButton.UseVisualStyleBackColor = true;
            this.JoeRadioButton.CheckedChanged += new System.EventHandler(this.JoeRadioButton_CheckedChanged);
            // 
            // MinimumBetLabel
            // 
            this.MinimumBetLabel.AutoSize = true;
            this.MinimumBetLabel.Location = new System.Drawing.Point(7, 31);
            this.MinimumBetLabel.Name = "MinimumBetLabel";
            this.MinimumBetLabel.Size = new System.Drawing.Size(38, 12);
            this.MinimumBetLabel.TabIndex = 0;
            this.MinimumBetLabel.Text = "label1";
            // 
            // dog1
            // 
            this.dog1.Image = global::WindowsFormsApp3.Properties.Resources.dog;
            this.dog1.Location = new System.Drawing.Point(22, 25);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(89, 31);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog1.TabIndex = 2;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = global::WindowsFormsApp3.Properties.Resources.dog;
            this.dog2.Location = new System.Drawing.Point(23, 92);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(89, 31);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog2.TabIndex = 3;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = global::WindowsFormsApp3.Properties.Resources.dog;
            this.dog3.Location = new System.Drawing.Point(23, 167);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(89, 31);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog3.TabIndex = 4;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = global::WindowsFormsApp3.Properties.Resources.dog;
            this.dog4.Location = new System.Drawing.Point(23, 222);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(89, 31);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog4.TabIndex = 5;
            this.dog4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 472);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backGround);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backGround;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown DogUpDown;
        private System.Windows.Forms.NumericUpDown BetUpDown;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label GuyNameLabel;
        private System.Windows.Forms.RadioButton AlRadioButton;
        private System.Windows.Forms.RadioButton BobRadioButton;
        private System.Windows.Forms.RadioButton JoeRadioButton;
        private System.Windows.Forms.Label MinimumBetLabel;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.Label AlLabel;
        private System.Windows.Forms.Label BobLabel;
        private System.Windows.Forms.Label JoeLabel;
    }
}

