namespace CowCalculator
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
            this.lblCowNum = new System.Windows.Forms.Label();
            this.numericCowNum = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCowNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCowNum
            // 
            this.lblCowNum.AutoSize = true;
            this.lblCowNum.Location = new System.Drawing.Point(27, 31);
            this.lblCowNum.Name = "lblCowNum";
            this.lblCowNum.Size = new System.Drawing.Size(55, 18);
            this.lblCowNum.TabIndex = 0;
            this.lblCowNum.Text = "Cows";
            // 
            // numericCowNum
            // 
            this.numericCowNum.Location = new System.Drawing.Point(101, 29);
            this.numericCowNum.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericCowNum.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericCowNum.Name = "numericCowNum";
            this.numericCowNum.Size = new System.Drawing.Size(120, 28);
            this.numericCowNum.TabIndex = 1;
            this.numericCowNum.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericCowNum.ValueChanged += new System.EventHandler(this.numericCowNum_ValueChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(108, 90);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 32);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 149);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.numericCowNum);
            this.Controls.Add(this.lblCowNum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cow calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericCowNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCowNum;
        private System.Windows.Forms.NumericUpDown numericCowNum;
        private System.Windows.Forms.Button btnCalculate;
    }
}

