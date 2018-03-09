namespace PartyPlanner2._0
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.UDPeople = new System.Windows.Forms.NumericUpDown();
            this.cbNonAlcohol = new System.Windows.Forms.CheckBox();
            this.cbDecoUpgrade = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UDPeopleBirth = new System.Windows.Forms.NumericUpDown();
            this.cbDecoUpgradeBirth = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBirthdayText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCostBirth = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDPeopleBirth)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(312, 321);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbDecoUpgrade);
            this.tabPage1.Controls.Add(this.cbNonAlcohol);
            this.tabPage1.Controls.Add(this.UDPeople);
            this.tabPage1.Controls.Add(this.lbCost);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(304, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbCostBirth);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbBirthdayText);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbDecoUpgradeBirth);
            this.tabPage2.Controls.Add(this.UDPeopleBirth);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(304, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "파티 참가 인원 수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "총 견적 비용";
            // 
            // lbCost
            // 
            this.lbCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCost.Location = new System.Drawing.Point(105, 139);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(102, 23);
            this.lbCost.TabIndex = 2;
            // 
            // UDPeople
            // 
            this.UDPeople.Location = new System.Drawing.Point(10, 25);
            this.UDPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDPeople.Name = "UDPeople";
            this.UDPeople.Size = new System.Drawing.Size(120, 25);
            this.UDPeople.TabIndex = 3;
            this.UDPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UDPeople.ValueChanged += new System.EventHandler(this.UDPeople_ValueChanged);
            // 
            // cbNonAlcohol
            // 
            this.cbNonAlcohol.AutoSize = true;
            this.cbNonAlcohol.BackColor = System.Drawing.Color.Transparent;
            this.cbNonAlcohol.Location = new System.Drawing.Point(10, 71);
            this.cbNonAlcohol.Name = "cbNonAlcohol";
            this.cbNonAlcohol.Size = new System.Drawing.Size(129, 19);
            this.cbNonAlcohol.TabIndex = 4;
            this.cbNonAlcohol.Text = "술 대신 음료수";
            this.cbNonAlcohol.UseVisualStyleBackColor = false;
            this.cbNonAlcohol.CheckedChanged += new System.EventHandler(this.cbNonAlcohol_CheckedChanged);
            // 
            // cbDecoUpgrade
            // 
            this.cbDecoUpgrade.AutoSize = true;
            this.cbDecoUpgrade.Checked = true;
            this.cbDecoUpgrade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDecoUpgrade.Location = new System.Drawing.Point(10, 97);
            this.cbDecoUpgrade.Name = "cbDecoUpgrade";
            this.cbDecoUpgrade.Size = new System.Drawing.Size(129, 19);
            this.cbDecoUpgrade.TabIndex = 5;
            this.cbDecoUpgrade.Text = "고급 장식 사용";
            this.cbDecoUpgrade.UseVisualStyleBackColor = true;
            this.cbDecoUpgrade.CheckedChanged += new System.EventHandler(this.cbDecoUpgrade_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "파티 참가 인원 수";
            // 
            // UDPeopleBirth
            // 
            this.UDPeopleBirth.Location = new System.Drawing.Point(10, 25);
            this.UDPeopleBirth.Name = "UDPeopleBirth";
            this.UDPeopleBirth.Size = new System.Drawing.Size(120, 25);
            this.UDPeopleBirth.TabIndex = 1;
            this.UDPeopleBirth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UDPeopleBirth.ValueChanged += new System.EventHandler(this.UDPeopleBirth_ValueChanged);
            // 
            // cbDecoUpgradeBirth
            // 
            this.cbDecoUpgradeBirth.AutoSize = true;
            this.cbDecoUpgradeBirth.Location = new System.Drawing.Point(10, 71);
            this.cbDecoUpgradeBirth.Name = "cbDecoUpgradeBirth";
            this.cbDecoUpgradeBirth.Size = new System.Drawing.Size(129, 19);
            this.cbDecoUpgradeBirth.TabIndex = 2;
            this.cbDecoUpgradeBirth.Text = "고급 장식 사용";
            this.cbDecoUpgradeBirth.UseVisualStyleBackColor = true;
            this.cbDecoUpgradeBirth.CheckedChanged += new System.EventHandler(this.cbDecoUpgradeBirth_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "축하 메세지 (0 / 40)";
            // 
            // tbBirthdayText
            // 
            this.tbBirthdayText.Location = new System.Drawing.Point(10, 124);
            this.tbBirthdayText.Multiline = true;
            this.tbBirthdayText.Name = "tbBirthdayText";
            this.tbBirthdayText.Size = new System.Drawing.Size(195, 73);
            this.tbBirthdayText.TabIndex = 4;
            this.tbBirthdayText.TextChanged += new System.EventHandler(this.tbBirthdayText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "총 견적 비용";
            // 
            // lbCostBirth
            // 
            this.lbCostBirth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCostBirth.Location = new System.Drawing.Point(105, 215);
            this.lbCostBirth.Name = "lbCostBirth";
            this.lbCostBirth.Size = new System.Drawing.Size(100, 23);
            this.lbCostBirth.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 346);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Party Planner 2.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDPeopleBirth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbDecoUpgrade;
        private System.Windows.Forms.CheckBox cbNonAlcohol;
        private System.Windows.Forms.NumericUpDown UDPeople;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCostBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBirthdayText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbDecoUpgradeBirth;
        private System.Windows.Forms.NumericUpDown UDPeopleBirth;
        private System.Windows.Forms.Label label3;
    }
}

