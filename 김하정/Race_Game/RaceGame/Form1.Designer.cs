namespace RaceGame
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
            this.PBox0 = new System.Windows.Forms.PictureBox();
            this.PBox1 = new System.Windows.Forms.PictureBox();
            this.PBox2 = new System.Windows.Forms.PictureBox();
            this.PBox3 = new System.Windows.Forms.PictureBox();
            this.JoeButton = new System.Windows.Forms.RadioButton();
            this.BobButton = new System.Windows.Forms.RadioButton();
            this.AiButton = new System.Windows.Forms.RadioButton();
            this.tbox_minimum = new System.Windows.Forms.Label();
            this.tbox_bet = new System.Windows.Forms.Label();
            this.but_race = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AiLabel = new System.Windows.Forms.Label();
            this.BobLabel = new System.Windows.Forms.Label();
            this.JoeLabel = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(839, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PBox0
            // 
            this.PBox0.Image = ((System.Drawing.Image)(resources.GetObject("PBox0.Image")));
            this.PBox0.Location = new System.Drawing.Point(40, 38);
            this.PBox0.Name = "PBox0";
            this.PBox0.Size = new System.Drawing.Size(100, 50);
            this.PBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBox0.TabIndex = 1;
            this.PBox0.TabStop = false;
            // 
            // PBox1
            // 
            this.PBox1.Image = ((System.Drawing.Image)(resources.GetObject("PBox1.Image")));
            this.PBox1.Location = new System.Drawing.Point(40, 104);
            this.PBox1.Name = "PBox1";
            this.PBox1.Size = new System.Drawing.Size(100, 50);
            this.PBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBox1.TabIndex = 2;
            this.PBox1.TabStop = false;
            // 
            // PBox2
            // 
            this.PBox2.Image = ((System.Drawing.Image)(resources.GetObject("PBox2.Image")));
            this.PBox2.Location = new System.Drawing.Point(40, 185);
            this.PBox2.Name = "PBox2";
            this.PBox2.Size = new System.Drawing.Size(100, 50);
            this.PBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBox2.TabIndex = 3;
            this.PBox2.TabStop = false;
            // 
            // PBox3
            // 
            this.PBox3.Image = ((System.Drawing.Image)(resources.GetObject("PBox3.Image")));
            this.PBox3.Location = new System.Drawing.Point(40, 262);
            this.PBox3.Name = "PBox3";
            this.PBox3.Size = new System.Drawing.Size(100, 50);
            this.PBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBox3.TabIndex = 4;
            this.PBox3.TabStop = false;
            // 
            // JoeButton
            // 
            this.JoeButton.AutoSize = true;
            this.JoeButton.Location = new System.Drawing.Point(19, 71);
            this.JoeButton.Name = "JoeButton";
            this.JoeButton.Size = new System.Drawing.Size(43, 16);
            this.JoeButton.TabIndex = 5;
            this.JoeButton.TabStop = true;
            this.JoeButton.Text = "Joe";
            this.JoeButton.UseVisualStyleBackColor = true;
            // 
            // BobButton
            // 
            this.BobButton.AutoSize = true;
            this.BobButton.Location = new System.Drawing.Point(17, 98);
            this.BobButton.Name = "BobButton";
            this.BobButton.Size = new System.Drawing.Size(45, 16);
            this.BobButton.TabIndex = 6;
            this.BobButton.TabStop = true;
            this.BobButton.Text = "Bob";
            this.BobButton.UseVisualStyleBackColor = true;
            // 
            // AiButton
            // 
            this.AiButton.AutoSize = true;
            this.AiButton.Location = new System.Drawing.Point(19, 125);
            this.AiButton.Name = "AiButton";
            this.AiButton.Size = new System.Drawing.Size(34, 16);
            this.AiButton.TabIndex = 7;
            this.AiButton.TabStop = true;
            this.AiButton.Text = "AI";
            this.AiButton.UseVisualStyleBackColor = true;
            // 
            // tbox_minimum
            // 
            this.tbox_minimum.AutoSize = true;
            this.tbox_minimum.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbox_minimum.Location = new System.Drawing.Point(15, 36);
            this.tbox_minimum.Name = "tbox_minimum";
            this.tbox_minimum.Size = new System.Drawing.Size(126, 21);
            this.tbox_minimum.TabIndex = 8;
            this.tbox_minimum.Text = "Minimum bet";
            // 
            // tbox_bet
            // 
            this.tbox_bet.AutoSize = true;
            this.tbox_bet.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbox_bet.Location = new System.Drawing.Point(476, 36);
            this.tbox_bet.Name = "tbox_bet";
            this.tbox_bet.Size = new System.Drawing.Size(53, 21);
            this.tbox_bet.TabIndex = 9;
            this.tbox_bet.Text = "Bets";
            // 
            // but_race
            // 
            this.but_race.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but_race.Location = new System.Drawing.Point(754, 154);
            this.but_race.Name = "but_race";
            this.but_race.Size = new System.Drawing.Size(74, 35);
            this.but_race.TabIndex = 13;
            this.but_race.Text = "Race";
            this.but_race.UseVisualStyleBackColor = true;
            // 
            // NameBox
            // 
            this.NameBox.AutoSize = true;
            this.NameBox.Location = new System.Drawing.Point(17, 159);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(25, 12);
            this.NameBox.TabIndex = 14;
            this.NameBox.Text = "Joe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AiLabel);
            this.groupBox1.Controls.Add(this.BobLabel);
            this.groupBox1.Controls.Add(this.JoeLabel);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbox_minimum);
            this.groupBox1.Controls.Add(this.but_race);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.JoeButton);
            this.groupBox1.Controls.Add(this.BobButton);
            this.groupBox1.Controls.Add(this.tbox_bet);
            this.groupBox1.Controls.Add(this.AiButton);
            this.groupBox1.Location = new System.Drawing.Point(21, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 206);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // AiLabel
            // 
            this.AiLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AiLabel.Location = new System.Drawing.Point(480, 126);
            this.AiLabel.Name = "AiLabel";
            this.AiLabel.Size = new System.Drawing.Size(348, 20);
            this.AiLabel.TabIndex = 21;
            this.AiLabel.Text = "label4";
            // 
            // BobLabel
            // 
            this.BobLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BobLabel.Location = new System.Drawing.Point(480, 99);
            this.BobLabel.Name = "BobLabel";
            this.BobLabel.Size = new System.Drawing.Size(348, 20);
            this.BobLabel.TabIndex = 20;
            this.BobLabel.Text = "label3";
            // 
            // JoeLabel
            // 
            this.JoeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JoeLabel.Location = new System.Drawing.Point(480, 72);
            this.JoeLabel.Name = "JoeLabel";
            this.JoeLabel.Size = new System.Drawing.Size(348, 20);
            this.JoeLabel.TabIndex = 19;
            this.JoeLabel.Text = "label2";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(364, 154);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(66, 21);
            this.numericUpDown2.TabIndex = 18;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "bucks on dog number";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(157, 154);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 21);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PBox3);
            this.Controls.Add(this.PBox2);
            this.Controls.Add(this.PBox1);
            this.Controls.Add(this.PBox0);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PBox0;
        private System.Windows.Forms.PictureBox PBox1;
        private System.Windows.Forms.PictureBox PBox2;
        private System.Windows.Forms.PictureBox PBox3;
        private System.Windows.Forms.RadioButton JoeButton;
        private System.Windows.Forms.RadioButton BobButton;
        private System.Windows.Forms.RadioButton AiButton;
        private System.Windows.Forms.Label tbox_minimum;
        private System.Windows.Forms.Label tbox_bet;
        private System.Windows.Forms.Button but_race;
        private System.Windows.Forms.Label NameBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label AiLabel;
        private System.Windows.Forms.Label BobLabel;
        private System.Windows.Forms.Label JoeLabel;
    }
}

