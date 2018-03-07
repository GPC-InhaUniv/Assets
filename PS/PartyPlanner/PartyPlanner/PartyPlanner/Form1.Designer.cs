namespace PartyPlanner
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
            this.lblNumOfPeople = new System.Windows.Forms.Label();
            this.numericNumOfPeople = new System.Windows.Forms.NumericUpDown();
            this.cbFancyDeco = new System.Windows.Forms.CheckBox();
            this.cbHealthyOpt = new System.Windows.Forms.CheckBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblDisplayCalculatedCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumOfPeople
            // 
            this.lblNumOfPeople.AutoSize = true;
            this.lblNumOfPeople.Location = new System.Drawing.Point(21, 21);
            this.lblNumOfPeople.Name = "lblNumOfPeople";
            this.lblNumOfPeople.Size = new System.Drawing.Size(107, 12);
            this.lblNumOfPeople.TabIndex = 0;
            this.lblNumOfPeople.Text = "Number of People";
            // 
            // numericNumOfPeople
            // 
            this.numericNumOfPeople.Location = new System.Drawing.Point(23, 49);
            this.numericNumOfPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericNumOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumOfPeople.Name = "numericNumOfPeople";
            this.numericNumOfPeople.Size = new System.Drawing.Size(120, 21);
            this.numericNumOfPeople.TabIndex = 1;
            this.numericNumOfPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericNumOfPeople.ValueChanged += new System.EventHandler(this.numericNumOfPeople_ValueChanged);
            // 
            // cbFancyDeco
            // 
            this.cbFancyDeco.AutoSize = true;
            this.cbFancyDeco.Checked = true;
            this.cbFancyDeco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFancyDeco.Location = new System.Drawing.Point(23, 90);
            this.cbFancyDeco.Name = "cbFancyDeco";
            this.cbFancyDeco.Size = new System.Drawing.Size(130, 16);
            this.cbFancyDeco.TabIndex = 2;
            this.cbFancyDeco.Text = "Fancy Decorations";
            this.cbFancyDeco.UseVisualStyleBackColor = true;
            this.cbFancyDeco.CheckedChanged += new System.EventHandler(this.cbFancyDeco_CheckedChanged);
            // 
            // cbHealthyOpt
            // 
            this.cbHealthyOpt.AutoSize = true;
            this.cbHealthyOpt.Location = new System.Drawing.Point(23, 121);
            this.cbHealthyOpt.Name = "cbHealthyOpt";
            this.cbHealthyOpt.Size = new System.Drawing.Size(106, 16);
            this.cbHealthyOpt.TabIndex = 3;
            this.cbHealthyOpt.Text = "Healthy Option";
            this.cbHealthyOpt.UseVisualStyleBackColor = true;
            this.cbHealthyOpt.CheckedChanged += new System.EventHandler(this.cbHealthyOpt_CheckedChanged);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCost.Location = new System.Drawing.Point(21, 159);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(35, 12);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost";
            // 
            // lblDisplayCalculatedCost
            // 
            this.lblDisplayCalculatedCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayCalculatedCost.Location = new System.Drawing.Point(63, 154);
            this.lblDisplayCalculatedCost.Name = "lblDisplayCalculatedCost";
            this.lblDisplayCalculatedCost.Size = new System.Drawing.Size(118, 23);
            this.lblDisplayCalculatedCost.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 198);
            this.Controls.Add(this.lblDisplayCalculatedCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.cbHealthyOpt);
            this.Controls.Add(this.cbFancyDeco);
            this.Controls.Add(this.numericNumOfPeople);
            this.Controls.Add(this.lblNumOfPeople);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumOfPeople;
        private System.Windows.Forms.NumericUpDown numericNumOfPeople;
        private System.Windows.Forms.CheckBox cbFancyDeco;
        private System.Windows.Forms.CheckBox cbHealthyOpt;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDisplayCalculatedCost;
    }
}

