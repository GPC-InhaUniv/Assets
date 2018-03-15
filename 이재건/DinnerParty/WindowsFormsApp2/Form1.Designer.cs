namespace WindowsFormsApp2
{
    partial class PartyForm
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
            this.NumofPeopleUpDown = new System.Windows.Forms.NumericUpDown();
            this.NumOfPeopleLabel = new System.Windows.Forms.Label();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.costTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumofPeopleUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NumofPeopleUpDown
            // 
            this.NumofPeopleUpDown.Location = new System.Drawing.Point(13, 40);
            this.NumofPeopleUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumofPeopleUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumofPeopleUpDown.Name = "NumofPeopleUpDown";
            this.NumofPeopleUpDown.Size = new System.Drawing.Size(120, 21);
            this.NumofPeopleUpDown.TabIndex = 0;
            this.NumofPeopleUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumofPeopleUpDown.ValueChanged += new System.EventHandler(this.NumofPeopleUpDown_ValueChanged);
            // 
            // NumOfPeopleLabel
            // 
            this.NumOfPeopleLabel.AutoSize = true;
            this.NumOfPeopleLabel.Location = new System.Drawing.Point(13, 13);
            this.NumOfPeopleLabel.Name = "NumOfPeopleLabel";
            this.NumOfPeopleLabel.Size = new System.Drawing.Size(107, 12);
            this.NumOfPeopleLabel.TabIndex = 1;
            this.NumOfPeopleLabel.Text = "Number of People";
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Checked = true;
            this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox.Location = new System.Drawing.Point(15, 80);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(130, 16);
            this.fancyBox.TabIndex = 2;
            this.fancyBox.Text = "Fancy Decorations";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.DecorationCheckBox_CheckedChanged);
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(13, 112);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(106, 16);
            this.healthyBox.TabIndex = 3;
            this.healthyBox.Text = "Healthy Option";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.HealthyCheckBox_CheckedChanged);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CostLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CostLabel.Location = new System.Drawing.Point(15, 201);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(39, 13);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Cost";
            // 
            // costTextbox
            // 
            this.costTextbox.Location = new System.Drawing.Point(75, 199);
            this.costTextbox.Name = "costTextbox";
            this.costTextbox.Size = new System.Drawing.Size(100, 21);
            this.costTextbox.TabIndex = 5;
            // 
            // PartyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.costTextbox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.healthyBox);
            this.Controls.Add(this.fancyBox);
            this.Controls.Add(this.NumOfPeopleLabel);
            this.Controls.Add(this.NumofPeopleUpDown);
            this.Name = "PartyForm";
            this.Text = "Party Planner";
            this.Load += new System.EventHandler(this.PartyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumofPeopleUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumofPeopleUpDown;
        private System.Windows.Forms.Label NumOfPeopleLabel;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox costTextbox;
    }
}

