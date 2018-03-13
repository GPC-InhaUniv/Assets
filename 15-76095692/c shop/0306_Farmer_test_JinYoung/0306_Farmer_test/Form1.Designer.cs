namespace _0306_Farmer_test
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
            this.cowLabel = new System.Windows.Forms.Label();
            this.CowUpDown = new System.Windows.Forms.NumericUpDown();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CowUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cowLabel
            // 
            this.cowLabel.AutoSize = true;
            this.cowLabel.Location = new System.Drawing.Point(13, 26);
            this.cowLabel.Name = "cowLabel";
            this.cowLabel.Size = new System.Drawing.Size(38, 12);
            this.cowLabel.TabIndex = 0;
            this.cowLabel.Text = "Cows";
            // 
            // CowUpDown
            // 
            this.CowUpDown.Location = new System.Drawing.Point(73, 16);
            this.CowUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.CowUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CowUpDown.Name = "CowUpDown";
            this.CowUpDown.Size = new System.Drawing.Size(120, 21);
            this.CowUpDown.TabIndex = 1;
            this.CowUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.CowUpDown.ValueChanged += new System.EventHandler(this.CowUpDown_ValueChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(15, 58);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 93);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.CowUpDown);
            this.Controls.Add(this.cowLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cow calculator";
            ((System.ComponentModel.ISupportInitialize)(this.CowUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cowLabel;
        private System.Windows.Forms.NumericUpDown CowUpDown;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button button1;
    }
}

