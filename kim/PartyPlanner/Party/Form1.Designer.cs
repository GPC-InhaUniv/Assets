namespace Party
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
            this.BirthdayCost = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Numbtn1 = new System.Windows.Forms.NumericUpDown();
            this.HealtyCheck = new System.Windows.Forms.CheckBox();
            this.FancyCheck1 = new System.Windows.Forms.CheckBox();
            this.DinnerCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CakeWritingBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Numbtn2 = new System.Windows.Forms.NumericUpDown();
            this.FancyCheck2 = new System.Windows.Forms.CheckBox();
            this.CostTextBox2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            this.BirthdayCost.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numbtn1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numbtn2)).BeginInit();
            this.SuspendLayout();
            // 
            // BirthdayCost
            // 
            this.BirthdayCost.Controls.Add(this.tabPage1);
            this.BirthdayCost.Controls.Add(this.tabPage2);
            this.BirthdayCost.Location = new System.Drawing.Point(13, 4);
            this.BirthdayCost.Name = "BirthdayCost";
            this.BirthdayCost.SelectedIndex = 0;
            this.BirthdayCost.Size = new System.Drawing.Size(259, 245);
            this.BirthdayCost.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Numbtn1);
            this.tabPage1.Controls.Add(this.HealtyCheck);
            this.tabPage1.Controls.Add(this.FancyCheck1);
            this.tabPage1.Controls.Add(this.DinnerCost);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(251, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Numbtn1
            // 
            this.Numbtn1.Location = new System.Drawing.Point(11, 41);
            this.Numbtn1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Numbtn1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numbtn1.Name = "Numbtn1";
            this.Numbtn1.Size = new System.Drawing.Size(120, 21);
            this.Numbtn1.TabIndex = 5;
            this.Numbtn1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Numbtn1.ValueChanged += new System.EventHandler(this.Numbtn1_ValueChanged);
            // 
            // HealtyCheck
            // 
            this.HealtyCheck.AutoSize = true;
            this.HealtyCheck.Location = new System.Drawing.Point(11, 114);
            this.HealtyCheck.Name = "HealtyCheck";
            this.HealtyCheck.Size = new System.Drawing.Size(106, 16);
            this.HealtyCheck.TabIndex = 4;
            this.HealtyCheck.Text = "Healthy Option";
            this.HealtyCheck.UseVisualStyleBackColor = true;
            this.HealtyCheck.CheckedChanged += new System.EventHandler(this.HealtyCheck_CheckedChanged);
            // 
            // FancyCheck1
            // 
            this.FancyCheck1.AutoSize = true;
            this.FancyCheck1.Checked = true;
            this.FancyCheck1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FancyCheck1.Location = new System.Drawing.Point(11, 91);
            this.FancyCheck1.Name = "FancyCheck1";
            this.FancyCheck1.Size = new System.Drawing.Size(130, 16);
            this.FancyCheck1.TabIndex = 3;
            this.FancyCheck1.Text = "Fancy Decorations";
            this.FancyCheck1.UseVisualStyleBackColor = true;
            this.FancyCheck1.CheckedChanged += new System.EventHandler(this.FancyCheckBox_Checked);
            // 
            // DinnerCost
            // 
            this.DinnerCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DinnerCost.Location = new System.Drawing.Point(46, 173);
            this.DinnerCost.Name = "DinnerCost";
            this.DinnerCost.Size = new System.Drawing.Size(100, 23);
            this.DinnerCost.TabIndex = 2;
            this.DinnerCost.Text = "\"\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CakeWritingBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Numbtn2);
            this.tabPage2.Controls.Add(this.FancyCheck2);
            this.tabPage2.Controls.Add(this.CostTextBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.labell);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(251, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CakeWritingBox
            // 
            this.CakeWritingBox.Location = new System.Drawing.Point(9, 113);
            this.CakeWritingBox.Name = "CakeWritingBox";
            this.CakeWritingBox.Size = new System.Drawing.Size(100, 21);
            this.CakeWritingBox.TabIndex = 6;
            this.CakeWritingBox.TextChanged += new System.EventHandler(this.CakeWritingBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cake Writing";
            // 
            // Numbtn2
            // 
            this.Numbtn2.Location = new System.Drawing.Point(9, 32);
            this.Numbtn2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Numbtn2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numbtn2.Name = "Numbtn2";
            this.Numbtn2.Size = new System.Drawing.Size(120, 21);
            this.Numbtn2.TabIndex = 4;
            this.Numbtn2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Numbtn2.ValueChanged += new System.EventHandler(this.Numbtn1_ValueChanged);
            // 
            // FancyCheck2
            // 
            this.FancyCheck2.AutoSize = true;
            this.FancyCheck2.Checked = true;
            this.FancyCheck2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FancyCheck2.Location = new System.Drawing.Point(9, 74);
            this.FancyCheck2.Name = "FancyCheck2";
            this.FancyCheck2.Size = new System.Drawing.Size(130, 16);
            this.FancyCheck2.TabIndex = 3;
            this.FancyCheck2.Text = "Fancy Decorations";
            this.FancyCheck2.UseVisualStyleBackColor = true;
            this.FancyCheck2.CheckedChanged += new System.EventHandler(this.FancyCheckBox_Checked);
            // 
            // CostTextBox2
            // 
            this.CostTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CostTextBox2.Location = new System.Drawing.Point(66, 179);
            this.CostTextBox2.Name = "CostTextBox2";
            this.CostTextBox2.Size = new System.Drawing.Size(100, 23);
            this.CostTextBox2.TabIndex = 2;
            this.CostTextBox2.Text = "\"\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cost";
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Location = new System.Drawing.Point(7, 7);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(101, 12);
            this.labell.TabIndex = 0;
            this.labell.Text = "NumberOfPeople";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BirthdayCost);
            this.Name = "Form1";
            this.Text = "PartyPlanner";
            this.BirthdayCost.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numbtn1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numbtn2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl BirthdayCost;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown Numbtn1;
        private System.Windows.Forms.CheckBox HealtyCheck;
        private System.Windows.Forms.CheckBox FancyCheck1;
        private System.Windows.Forms.Label DinnerCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Numbtn2;
        private System.Windows.Forms.CheckBox FancyCheck2;
        private System.Windows.Forms.Label CostTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.TextBox CakeWritingBox;
        private System.Windows.Forms.Label label3;
    }
}

