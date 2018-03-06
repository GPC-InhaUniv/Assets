namespace Party_Planner
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
            this.NumberOfPeopleLable = new System.Windows.Forms.Label();
            this.numericNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxFancy = new System.Windows.Forms.CheckBox();
            this.CheckBoxHealthyOption = new System.Windows.Forms.CheckBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostShowLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberOfPeopleLable
            // 
            this.NumberOfPeopleLable.AutoSize = true;
            this.NumberOfPeopleLable.Location = new System.Drawing.Point(36, 30);
            this.NumberOfPeopleLable.Name = "NumberOfPeopleLable";
            this.NumberOfPeopleLable.Size = new System.Drawing.Size(107, 12);
            this.NumberOfPeopleLable.TabIndex = 0;
            this.NumberOfPeopleLable.Text = "Number of People";
            // 
            // numericNumberOfPeople
            // 
            this.numericNumberOfPeople.Location = new System.Drawing.Point(38, 58);
            this.numericNumberOfPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericNumberOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumberOfPeople.Name = "numericNumberOfPeople";
            this.numericNumberOfPeople.Size = new System.Drawing.Size(114, 21);
            this.numericNumberOfPeople.TabIndex = 1;
            this.numericNumberOfPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericNumberOfPeople.ValueChanged += new System.EventHandler(this.NumericNumberOfPeople_ValueChanged);
            // 
            // CheckBoxFancy
            // 
            this.CheckBoxFancy.AutoSize = true;
            this.CheckBoxFancy.Checked = true;
            this.CheckBoxFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxFancy.Location = new System.Drawing.Point(42, 100);
            this.CheckBoxFancy.Name = "CheckBoxFancy";
            this.CheckBoxFancy.Size = new System.Drawing.Size(129, 16);
            this.CheckBoxFancy.TabIndex = 2;
            this.CheckBoxFancy.Text = "Fancy decorations";
            this.CheckBoxFancy.UseVisualStyleBackColor = true;
            this.CheckBoxFancy.CheckedChanged += new System.EventHandler(this.CheckBoxFancy_CheckedChanged);
            // 
            // CheckBoxHealthyOption
            // 
            this.CheckBoxHealthyOption.AutoSize = true;
            this.CheckBoxHealthyOption.Location = new System.Drawing.Point(42, 131);
            this.CheckBoxHealthyOption.Name = "CheckBoxHealthyOption";
            this.CheckBoxHealthyOption.Size = new System.Drawing.Size(103, 16);
            this.CheckBoxHealthyOption.TabIndex = 3;
            this.CheckBoxHealthyOption.Text = "Heathy Option";
            this.CheckBoxHealthyOption.UseVisualStyleBackColor = true;
            this.CheckBoxHealthyOption.CheckedChanged += new System.EventHandler(this.CheckBoxHealthyOption_CheckedChanged);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(36, 205);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(31, 12);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Cost";
            // 
            // CostShowLabel
            // 
            this.CostShowLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CostShowLabel.Location = new System.Drawing.Point(87, 204);
            this.CostShowLabel.Name = "CostShowLabel";
            this.CostShowLabel.Size = new System.Drawing.Size(84, 17);
            this.CostShowLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CostShowLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.CheckBoxHealthyOption);
            this.Controls.Add(this.CheckBoxFancy);
            this.Controls.Add(this.numericNumberOfPeople);
            this.Controls.Add(this.NumberOfPeopleLable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberOfPeopleLable;
        private System.Windows.Forms.NumericUpDown numericNumberOfPeople;
        private System.Windows.Forms.CheckBox CheckBoxFancy;
        private System.Windows.Forms.CheckBox CheckBoxHealthyOption;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CostShowLabel;
    }
}

