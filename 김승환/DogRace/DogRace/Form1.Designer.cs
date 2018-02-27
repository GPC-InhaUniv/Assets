namespace DogRace
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
            this.racePictureBox = new System.Windows.Forms.PictureBox();
            this.dogPictureBox1 = new System.Windows.Forms.PictureBox();
            this.dogPictureBox2 = new System.Windows.Forms.PictureBox();
            this.dogPictureBox3 = new System.Windows.Forms.PictureBox();
            this.dogPictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raceButton = new System.Windows.Forms.Button();
            this.bettorNameLabel = new System.Windows.Forms.Label();
            this.dogNumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.bettorLabel3 = new System.Windows.Forms.Label();
            this.bettorLabel2 = new System.Windows.Forms.Label();
            this.bettorLabel1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rechargeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.racePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // racePictureBox
            // 
            this.racePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("racePictureBox.Image")));
            this.racePictureBox.InitialImage = null;
            this.racePictureBox.Location = new System.Drawing.Point(12, 12);
            this.racePictureBox.Name = "racePictureBox";
            this.racePictureBox.Size = new System.Drawing.Size(977, 310);
            this.racePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racePictureBox.TabIndex = 0;
            this.racePictureBox.TabStop = false;
            // 
            // dogPictureBox1
            // 
            this.dogPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("dogPictureBox1.Image")));
            this.dogPictureBox1.Location = new System.Drawing.Point(38, 29);
            this.dogPictureBox1.Name = "dogPictureBox1";
            this.dogPictureBox1.Size = new System.Drawing.Size(105, 32);
            this.dogPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPictureBox1.TabIndex = 1;
            this.dogPictureBox1.TabStop = false;
            // 
            // dogPictureBox2
            // 
            this.dogPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("dogPictureBox2.Image")));
            this.dogPictureBox2.Location = new System.Drawing.Point(38, 98);
            this.dogPictureBox2.Name = "dogPictureBox2";
            this.dogPictureBox2.Size = new System.Drawing.Size(105, 32);
            this.dogPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPictureBox2.TabIndex = 1;
            this.dogPictureBox2.TabStop = false;
            // 
            // dogPictureBox3
            // 
            this.dogPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("dogPictureBox3.Image")));
            this.dogPictureBox3.Location = new System.Drawing.Point(38, 186);
            this.dogPictureBox3.Name = "dogPictureBox3";
            this.dogPictureBox3.Size = new System.Drawing.Size(105, 32);
            this.dogPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPictureBox3.TabIndex = 1;
            this.dogPictureBox3.TabStop = false;
            // 
            // dogPictureBox4
            // 
            this.dogPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("dogPictureBox4.Image")));
            this.dogPictureBox4.Location = new System.Drawing.Point(38, 268);
            this.dogPictureBox4.Name = "dogPictureBox4";
            this.dogPictureBox4.Size = new System.Drawing.Size(105, 32);
            this.dogPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPictureBox4.TabIndex = 1;
            this.dogPictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rechargeButton);
            this.groupBox1.Controls.Add(this.raceButton);
            this.groupBox1.Controls.Add(this.bettorNameLabel);
            this.groupBox1.Controls.Add(this.dogNumNumericUpDown);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.amountNumericUpDown);
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.bettorLabel3);
            this.groupBox1.Controls.Add(this.bettorLabel2);
            this.groupBox1.Controls.Add(this.bettorLabel1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(977, 201);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(694, 152);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(127, 31);
            this.raceButton.TabIndex = 12;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // bettorNameLabel
            // 
            this.bettorNameLabel.AutoSize = true;
            this.bettorNameLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bettorNameLabel.Location = new System.Drawing.Point(41, 159);
            this.bettorNameLabel.Name = "bettorNameLabel";
            this.bettorNameLabel.Size = new System.Drawing.Size(57, 19);
            this.bettorNameLabel.TabIndex = 11;
            this.bettorNameLabel.Text = "Bettor";
            // 
            // dogNumNumericUpDown
            // 
            this.dogNumNumericUpDown.Location = new System.Drawing.Point(606, 159);
            this.dogNumNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.dogNumNumericUpDown.Name = "dogNumNumericUpDown";
            this.dogNumNumericUpDown.Size = new System.Drawing.Size(65, 21);
            this.dogNumNumericUpDown.TabIndex = 10;
            this.dogNumNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(411, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "bucks on dog number";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(271, 159);
            this.amountNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(134, 21);
            this.amountNumericUpDown.TabIndex = 8;
            this.amountNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(116, 152);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(132, 31);
            this.betButton.TabIndex = 7;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // bettorLabel3
            // 
            this.bettorLabel3.Location = new System.Drawing.Point(658, 112);
            this.bettorLabel3.Name = "bettorLabel3";
            this.bettorLabel3.Size = new System.Drawing.Size(196, 12);
            this.bettorLabel3.TabIndex = 5;
            this.bettorLabel3.Text = "AI\'s bet";
            // 
            // bettorLabel2
            // 
            this.bettorLabel2.Location = new System.Drawing.Point(658, 85);
            this.bettorLabel2.Name = "bettorLabel2";
            this.bettorLabel2.Size = new System.Drawing.Size(196, 12);
            this.bettorLabel2.TabIndex = 5;
            this.bettorLabel2.Text = "Bob\'s bet";
            // 
            // bettorLabel1
            // 
            this.bettorLabel1.Location = new System.Drawing.Point(658, 58);
            this.bettorLabel1.Name = "bettorLabel1";
            this.bettorLabel1.Size = new System.Drawing.Size(196, 17);
            this.bettorLabel1.TabIndex = 5;
            this.bettorLabel1.Text = "Joe\'s bet";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(26, 112);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 85);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum bet";
            // 
            // rechargeButton
            // 
            this.rechargeButton.Location = new System.Drawing.Point(827, 152);
            this.rechargeButton.Name = "rechargeButton";
            this.rechargeButton.Size = new System.Drawing.Size(130, 31);
            this.rechargeButton.TabIndex = 13;
            this.rechargeButton.Text = "Recharge";
            this.rechargeButton.UseVisualStyleBackColor = true;
            this.rechargeButton.Click += new System.EventHandler(this.rechargeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1013, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dogPictureBox4);
            this.Controls.Add(this.dogPictureBox3);
            this.Controls.Add(this.dogPictureBox2);
            this.Controls.Add(this.dogPictureBox1);
            this.Controls.Add(this.racePictureBox);
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racePictureBox;
        private System.Windows.Forms.PictureBox dogPictureBox1;
        private System.Windows.Forms.PictureBox dogPictureBox2;
        private System.Windows.Forms.PictureBox dogPictureBox3;
        private System.Windows.Forms.PictureBox dogPictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label bettorLabel3;
        private System.Windows.Forms.Label bettorLabel2;
        private System.Windows.Forms.Label bettorLabel1;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Label bettorNameLabel;
        private System.Windows.Forms.NumericUpDown dogNumNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Button rechargeButton;
    }
}

