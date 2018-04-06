namespace WindowsFormsApp7
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
            this.Greyhound1 = new System.Windows.Forms.PictureBox();
            this.Greyhound2 = new System.Windows.Forms.PictureBox();
            this.Greyhound3 = new System.Windows.Forms.PictureBox();
            this.Greyhound4 = new System.Windows.Forms.PictureBox();
            this.JoeRadio = new System.Windows.Forms.RadioButton();
            this.BobRadio = new System.Windows.Forms.RadioButton();
            this.AlRadio = new System.Windows.Forms.RadioButton();
            this.BetNumeric = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.HoundNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RaceButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AlLabel = new System.Windows.Forms.Label();
            this.BobLabel = new System.Windows.Forms.Label();
            this.JoeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoundNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackGround
            // 
            this.BackGround.Image = ((System.Drawing.Image)(resources.GetObject("BackGround.Image")));
            this.BackGround.Location = new System.Drawing.Point(12, 12);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(610, 205);
            this.BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackGround.TabIndex = 0;
            this.BackGround.TabStop = false;
            // 
            // Greyhound1
            // 
            this.Greyhound1.Image = ((System.Drawing.Image)(resources.GetObject("Greyhound1.Image")));
            this.Greyhound1.Location = new System.Drawing.Point(22, 21);
            this.Greyhound1.Name = "Greyhound1";
            this.Greyhound1.Size = new System.Drawing.Size(78, 22);
            this.Greyhound1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Greyhound1.TabIndex = 4;
            this.Greyhound1.TabStop = false;
            // 
            // Greyhound2
            // 
            this.Greyhound2.Image = ((System.Drawing.Image)(resources.GetObject("Greyhound2.Image")));
            this.Greyhound2.Location = new System.Drawing.Point(22, 72);
            this.Greyhound2.Name = "Greyhound2";
            this.Greyhound2.Size = new System.Drawing.Size(78, 22);
            this.Greyhound2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Greyhound2.TabIndex = 5;
            this.Greyhound2.TabStop = false;
            // 
            // Greyhound3
            // 
            this.Greyhound3.Image = ((System.Drawing.Image)(resources.GetObject("Greyhound3.Image")));
            this.Greyhound3.Location = new System.Drawing.Point(22, 125);
            this.Greyhound3.Name = "Greyhound3";
            this.Greyhound3.Size = new System.Drawing.Size(78, 22);
            this.Greyhound3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Greyhound3.TabIndex = 6;
            this.Greyhound3.TabStop = false;
            // 
            // Greyhound4
            // 
            this.Greyhound4.Image = ((System.Drawing.Image)(resources.GetObject("Greyhound4.Image")));
            this.Greyhound4.Location = new System.Drawing.Point(22, 179);
            this.Greyhound4.Name = "Greyhound4";
            this.Greyhound4.Size = new System.Drawing.Size(78, 22);
            this.Greyhound4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Greyhound4.TabIndex = 7;
            this.Greyhound4.TabStop = false;
            // 
            // JoeRadio
            // 
            this.JoeRadio.AutoSize = true;
            this.JoeRadio.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JoeRadio.Location = new System.Drawing.Point(10, 50);
            this.JoeRadio.Name = "JoeRadio";
            this.JoeRadio.Size = new System.Drawing.Size(47, 17);
            this.JoeRadio.TabIndex = 8;
            this.JoeRadio.Text = "Joe";
            this.JoeRadio.UseVisualStyleBackColor = true;
            this.JoeRadio.CheckedChanged += new System.EventHandler(this.JoeRadio_CheckedChanged);
            // 
            // BobRadio
            // 
            this.BobRadio.AutoSize = true;
            this.BobRadio.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BobRadio.Location = new System.Drawing.Point(10, 75);
            this.BobRadio.Name = "BobRadio";
            this.BobRadio.Size = new System.Drawing.Size(50, 17);
            this.BobRadio.TabIndex = 9;
            this.BobRadio.TabStop = true;
            this.BobRadio.Text = "Bob";
            this.BobRadio.UseVisualStyleBackColor = true;
            this.BobRadio.CheckedChanged += new System.EventHandler(this.BobRadio_CheckedChanged);
            // 
            // AlRadio
            // 
            this.AlRadio.AutoSize = true;
            this.AlRadio.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AlRadio.Location = new System.Drawing.Point(10, 100);
            this.AlRadio.Name = "AlRadio";
            this.AlRadio.Size = new System.Drawing.Size(36, 17);
            this.AlRadio.TabIndex = 10;
            this.AlRadio.TabStop = true;
            this.AlRadio.Text = "Al";
            this.AlRadio.UseVisualStyleBackColor = true;
            this.AlRadio.CheckedChanged += new System.EventHandler(this.AlRadio_CheckedChanged);
            // 
            // BetNumeric
            // 
            this.BetNumeric.Location = new System.Drawing.Point(160, 158);
            this.BetNumeric.Name = "BetNumeric";
            this.BetNumeric.Size = new System.Drawing.Size(71, 22);
            this.BetNumeric.TabIndex = 11;
            this.BetNumeric.ValueChanged += new System.EventHandler(this.BetNumeric_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Bets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HoundNumeric
            // 
            this.HoundNumeric.Location = new System.Drawing.Point(388, 159);
            this.HoundNumeric.Name = "HoundNumeric";
            this.HoundNumeric.Size = new System.Drawing.Size(71, 22);
            this.HoundNumeric.TabIndex = 16;
            this.HoundNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HoundNumeric.ValueChanged += new System.EventHandler(this.HoundNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Minimum bet";
            // 
            // RaceButton
            // 
            this.RaceButton.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RaceButton.Location = new System.Drawing.Point(496, 146);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(102, 35);
            this.RaceButton.TabIndex = 18;
            this.RaceButton.Text = "Race!";
            this.RaceButton.UseVisualStyleBackColor = true;
            this.RaceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(308, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "bucks on dog number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.AlLabel);
            this.groupBox1.Controls.Add(this.BobLabel);
            this.groupBox1.Controls.Add(this.JoeLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.HoundNumeric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RaceButton);
            this.groupBox1.Controls.Add(this.BetNumeric);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.JoeRadio);
            this.groupBox1.Controls.Add(this.BobRadio);
            this.groupBox1.Controls.Add(this.AlRadio);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 187);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(16, 163);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 13);
            this.NameLabel.TabIndex = 23;
            this.NameLabel.Text = "label4";
            // 
            // AlLabel
            // 
            this.AlLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AlLabel.Location = new System.Drawing.Point(312, 97);
            this.AlLabel.Name = "AlLabel";
            this.AlLabel.Size = new System.Drawing.Size(275, 20);
            this.AlLabel.TabIndex = 23;
            this.AlLabel.Text = "label6";
            // 
            // BobLabel
            // 
            this.BobLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BobLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BobLabel.Location = new System.Drawing.Point(312, 72);
            this.BobLabel.Name = "BobLabel";
            this.BobLabel.Size = new System.Drawing.Size(275, 20);
            this.BobLabel.TabIndex = 22;
            this.BobLabel.Text = "label5";
            // 
            // JoeLabel
            // 
            this.JoeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JoeLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JoeLabel.Location = new System.Drawing.Point(312, 47);
            this.JoeLabel.Name = "JoeLabel";
            this.JoeLabel.Size = new System.Drawing.Size(275, 20);
            this.JoeLabel.TabIndex = 21;
            this.JoeLabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Greyhound4);
            this.Controls.Add(this.Greyhound3);
            this.Controls.Add(this.Greyhound2);
            this.Controls.Add(this.Greyhound1);
            this.Controls.Add(this.BackGround);
            this.Name = "Form1";
            this.Text = "GeyHound Race!!!";
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoundNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackGround;
        private System.Windows.Forms.PictureBox Greyhound1;
        private System.Windows.Forms.PictureBox Greyhound2;
        private System.Windows.Forms.PictureBox Greyhound3;
        private System.Windows.Forms.PictureBox Greyhound4;
        private System.Windows.Forms.RadioButton JoeRadio;
        private System.Windows.Forms.RadioButton BobRadio;
        private System.Windows.Forms.RadioButton AlRadio;
        private System.Windows.Forms.NumericUpDown BetNumeric;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown HoundNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RaceButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label AlLabel;
        private System.Windows.Forms.Label BobLabel;
        private System.Windows.Forms.Label JoeLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}

