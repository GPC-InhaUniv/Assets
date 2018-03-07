namespace WindowsFormsApp6
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
            this.UDNumber = new System.Windows.Forms.NumericUpDown();
            this.NumberOfPeople = new System.Windows.Forms.Label();
            this.Fancy = new System.Windows.Forms.CheckBox();
            this.Nonalcoholic = new System.Windows.Forms.CheckBox();
            this.Cost = new System.Windows.Forms.Label();
            this.LbText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UDNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // UDNumber
            // 
            this.UDNumber.Location = new System.Drawing.Point(12, 31);
            this.UDNumber.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UDNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDNumber.Name = "UDNumber";
            this.UDNumber.Size = new System.Drawing.Size(120, 25);
            this.UDNumber.TabIndex = 0;
            this.UDNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UDNumber.ValueChanged += new System.EventHandler(this.UDNumber_ValueChanged);
            // 
            // NumberOfPeople
            // 
            this.NumberOfPeople.AutoSize = true;
            this.NumberOfPeople.Location = new System.Drawing.Point(13, 13);
            this.NumberOfPeople.Name = "NumberOfPeople";
            this.NumberOfPeople.Size = new System.Drawing.Size(92, 15);
            this.NumberOfPeople.TabIndex = 1;
            this.NumberOfPeople.Text = "파티 인원 수";
            // 
            // Fancy
            // 
            this.Fancy.AutoSize = true;
            this.Fancy.Location = new System.Drawing.Point(12, 87);
            this.Fancy.Name = "Fancy";
            this.Fancy.Size = new System.Drawing.Size(129, 19);
            this.Fancy.TabIndex = 2;
            this.Fancy.Text = "고급 장식 추가";
            this.Fancy.UseVisualStyleBackColor = true;
            this.Fancy.CheckedChanged += new System.EventHandler(this.Fancy_CheckedChanged);
            // 
            // Nonalcoholic
            // 
            this.Nonalcoholic.AutoSize = true;
            this.Nonalcoholic.Checked = true;
            this.Nonalcoholic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Nonalcoholic.Location = new System.Drawing.Point(12, 62);
            this.Nonalcoholic.Name = "Nonalcoholic";
            this.Nonalcoholic.Size = new System.Drawing.Size(109, 19);
            this.Nonalcoholic.TabIndex = 3;
            this.Nonalcoholic.Text = "무알콜 파티";
            this.Nonalcoholic.UseVisualStyleBackColor = true;
            this.Nonalcoholic.CheckedChanged += new System.EventHandler(this.Nonalcoholic_CheckedChanged);
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(13, 116);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(57, 15);
            this.Cost.TabIndex = 4;
            this.Cost.Text = "총 비용";
            // 
            // LbText
            // 
            this.LbText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbText.Location = new System.Drawing.Point(12, 135);
            this.LbText.Name = "LbText";
            this.LbText.Size = new System.Drawing.Size(100, 23);
            this.LbText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 192);
            this.Controls.Add(this.LbText);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Nonalcoholic);
            this.Controls.Add(this.Fancy);
            this.Controls.Add(this.NumberOfPeople);
            this.Controls.Add(this.UDNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UDNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown UDNumber;
        private System.Windows.Forms.Label NumberOfPeople;
        private System.Windows.Forms.CheckBox Fancy;
        private System.Windows.Forms.CheckBox Nonalcoholic;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label LbText;
    }
}

