namespace RaceSimulation
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button BetButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundpicture = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.RaceButton = new System.Windows.Forms.Button();
            this.JoeButton = new System.Windows.Forms.RadioButton();
            this.BobButton = new System.Windows.Forms.RadioButton();
            this.JackButton = new System.Windows.Forms.RadioButton();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CashUpDown = new System.Windows.Forms.NumericUpDown();
            this.DogUpDown = new System.Windows.Forms.NumericUpDown();
            this.BetInfo = new System.Windows.Forms.Label();
            this.JoeTextBox = new System.Windows.Forms.TextBox();
            this.BobTextBox = new System.Windows.Forms.TextBox();
            this.JackTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Timer = new System.Windows.Forms.Label();
            this.JackPotBar = new System.Windows.Forms.TrackBar();
            this.JackPotOnOff = new System.Windows.Forms.RadioButton();
            this.CurrentCash = new System.Windows.Forms.Label();
            BetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JackPotBar)).BeginInit();
            this.SuspendLayout();
            // 
            // BetButton
            // 
            BetButton.BackColor = System.Drawing.SystemColors.ControlDark;
            BetButton.ForeColor = System.Drawing.Color.Cornsilk;
            BetButton.Location = new System.Drawing.Point(100, 412);
            BetButton.Name = "BetButton";
            BetButton.Size = new System.Drawing.Size(75, 23);
            BetButton.TabIndex = 11;
            BetButton.Text = "Bet!";
            BetButton.UseVisualStyleBackColor = false;
            BetButton.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // backgroundpicture
            // 
            this.backgroundpicture.Image = ((System.Drawing.Image)(resources.GetObject("backgroundpicture.Image")));
            this.backgroundpicture.ImageLocation = "";
            this.backgroundpicture.Location = new System.Drawing.Point(12, 12);
            this.backgroundpicture.Name = "backgroundpicture";
            this.backgroundpicture.Size = new System.Drawing.Size(790, 218);
            this.backgroundpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundpicture.TabIndex = 0;
            this.backgroundpicture.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(31, 12);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(100, 39);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog1.TabIndex = 1;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(31, 67);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(100, 39);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog2.TabIndex = 2;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(31, 126);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(100, 39);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog3.TabIndex = 3;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = ((System.Drawing.Image)(resources.GetObject("dog4.Image")));
            this.dog4.Location = new System.Drawing.Point(31, 182);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(100, 39);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog4.TabIndex = 4;
            this.dog4.TabStop = false;
            // 
            // RaceButton
            // 
            this.RaceButton.Location = new System.Drawing.Point(674, 374);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(128, 62);
            this.RaceButton.TabIndex = 5;
            this.RaceButton.Text = "Race";
            this.RaceButton.UseVisualStyleBackColor = true;
            this.RaceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // JoeButton
            // 
            this.JoeButton.AutoSize = true;
            this.JoeButton.Location = new System.Drawing.Point(31, 309);
            this.JoeButton.Name = "JoeButton";
            this.JoeButton.Size = new System.Drawing.Size(43, 16);
            this.JoeButton.TabIndex = 7;
            this.JoeButton.TabStop = true;
            this.JoeButton.Text = "Joe";
            this.JoeButton.UseVisualStyleBackColor = true;
            this.JoeButton.CheckedChanged += new System.EventHandler(this.JoeButton_CheckedChanged);
            // 
            // BobButton
            // 
            this.BobButton.AutoSize = true;
            this.BobButton.Location = new System.Drawing.Point(31, 349);
            this.BobButton.Name = "BobButton";
            this.BobButton.Size = new System.Drawing.Size(45, 16);
            this.BobButton.TabIndex = 8;
            this.BobButton.TabStop = true;
            this.BobButton.Text = "Bob";
            this.BobButton.UseVisualStyleBackColor = true;
            this.BobButton.CheckedChanged += new System.EventHandler(this.BobButton_CheckedChanged);
            // 
            // JackButton
            // 
            this.JackButton.AutoSize = true;
            this.JackButton.Location = new System.Drawing.Point(31, 381);
            this.JackButton.Name = "JackButton";
            this.JackButton.Size = new System.Drawing.Size(49, 16);
            this.JackButton.TabIndex = 9;
            this.JackButton.TabStop = true;
            this.JackButton.Text = "Jack";
            this.JackButton.UseVisualStyleBackColor = true;
            this.JackButton.CheckedChanged += new System.EventHandler(this.JackButton_CheckedChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(29, 423);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 12);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Check";
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Location = new System.Drawing.Point(205, 399);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(66, 12);
            this.Text1.TabIndex = 14;
            this.Text1.Text = "Input Cash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select DogNum";
            // 
            // CashUpDown
            // 
            this.CashUpDown.Location = new System.Drawing.Point(207, 415);
            this.CashUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.CashUpDown.Name = "CashUpDown";
            this.CashUpDown.Size = new System.Drawing.Size(73, 21);
            this.CashUpDown.TabIndex = 14;
            this.CashUpDown.ValueChanged += new System.EventHandler(this.CashUpDown_ValueChanged);
            // 
            // DogUpDown
            // 
            this.DogUpDown.Location = new System.Drawing.Point(326, 415);
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
            this.DogUpDown.Size = new System.Drawing.Size(91, 21);
            this.DogUpDown.TabIndex = 4;
            this.DogUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BetInfo
            // 
            this.BetInfo.AutoSize = true;
            this.BetInfo.Location = new System.Drawing.Point(369, 245);
            this.BetInfo.Name = "BetInfo";
            this.BetInfo.Size = new System.Drawing.Size(105, 12);
            this.BetInfo.TabIndex = 16;
            this.BetInfo.Text = "Betting Infomation";
            // 
            // JoeTextBox
            // 
            this.JoeTextBox.Location = new System.Drawing.Point(371, 267);
            this.JoeTextBox.Name = "JoeTextBox";
            this.JoeTextBox.Size = new System.Drawing.Size(312, 21);
            this.JoeTextBox.TabIndex = 17;
            // 
            // BobTextBox
            // 
            this.BobTextBox.Location = new System.Drawing.Point(371, 304);
            this.BobTextBox.Name = "BobTextBox";
            this.BobTextBox.Size = new System.Drawing.Size(312, 21);
            this.BobTextBox.TabIndex = 18;
            // 
            // JackTextBox
            // 
            this.JackTextBox.Location = new System.Drawing.Point(371, 344);
            this.JackTextBox.Name = "JackTextBox";
            this.JackTextBox.Size = new System.Drawing.Size(312, 21);
            this.JackTextBox.TabIndex = 19;
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Timer.Location = new System.Drawing.Point(618, 245);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(0, 12);
            this.Timer.TabIndex = 20;
            // 
            // JackPotBar
            // 
            this.JackPotBar.BackColor = System.Drawing.SystemColors.Menu;
            this.JackPotBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JackPotBar.Enabled = false;
            this.JackPotBar.Location = new System.Drawing.Point(31, 267);
            this.JackPotBar.Maximum = 50;
            this.JackPotBar.Name = "JackPotBar";
            this.JackPotBar.Size = new System.Drawing.Size(104, 45);
            this.JackPotBar.TabIndex = 21;
            this.JackPotBar.TickFrequency = 0;
            // 
            // JackPotOnOff
            // 
            this.JackPotOnOff.AutoSize = true;
            this.JackPotOnOff.Enabled = false;
            this.JackPotOnOff.Location = new System.Drawing.Point(128, 243);
            this.JackPotOnOff.Name = "JackPotOnOff";
            this.JackPotOnOff.Size = new System.Drawing.Size(86, 16);
            this.JackPotOnOff.TabIndex = 22;
            this.JackPotOnOff.TabStop = true;
            this.JackPotOnOff.Text = "JackPot Off";
            this.JackPotOnOff.UseVisualStyleBackColor = true;
            // 
            // CurrentCash
            // 
            this.CurrentCash.AutoSize = true;
            this.CurrentCash.Location = new System.Drawing.Point(29, 245);
            this.CurrentCash.Name = "CurrentCash";
            this.CurrentCash.Size = new System.Drawing.Size(69, 12);
            this.CurrentCash.TabIndex = 23;
            this.CurrentCash.Text = "JackPot: $0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 444);
            this.Controls.Add(this.CurrentCash);
            this.Controls.Add(this.JackPotOnOff);
            this.Controls.Add(this.JackPotBar);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.JackTextBox);
            this.Controls.Add(this.BobTextBox);
            this.Controls.Add(this.JoeTextBox);
            this.Controls.Add(this.BetInfo);
            this.Controls.Add(this.DogUpDown);
            this.Controls.Add(this.CashUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(BetButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.JackButton);
            this.Controls.Add(this.BobButton);
            this.Controls.Add(this.JoeButton);
            this.Controls.Add(this.RaceButton);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.backgroundpicture);
            this.Name = "Form1";
            this.Text = "A Day at Race";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JackPotBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundpicture;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.Button RaceButton;
        private System.Windows.Forms.RadioButton JoeButton;
        private System.Windows.Forms.RadioButton BobButton;
        private System.Windows.Forms.RadioButton JackButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CashUpDown;
        private System.Windows.Forms.NumericUpDown DogUpDown;
        private System.Windows.Forms.Label BetInfo;
        private System.Windows.Forms.TextBox JoeTextBox;
        private System.Windows.Forms.TextBox BobTextBox;
        private System.Windows.Forms.TextBox JackTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.TrackBar JackPotBar;
        private System.Windows.Forms.RadioButton JackPotOnOff;
        private System.Windows.Forms.Label CurrentCash;
    }
}

