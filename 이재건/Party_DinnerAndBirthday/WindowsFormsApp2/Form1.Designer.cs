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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labeltext = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelcost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CakeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CakeFancyCheck = new System.Windows.Forms.CheckBox();
            this.PartyUpdown = new System.Windows.Forms.NumericUpDown();
            this.PartyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumofPeopleUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartyUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // NumofPeopleUpDown
            // 
            this.NumofPeopleUpDown.Location = new System.Drawing.Point(3, 43);
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
            this.NumOfPeopleLabel.Location = new System.Drawing.Point(6, 15);
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
            this.fancyBox.Location = new System.Drawing.Point(6, 85);
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
            this.healthyBox.Location = new System.Drawing.Point(3, 107);
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
            this.CostLabel.Location = new System.Drawing.Point(3, 143);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(39, 13);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Cost";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(268, 211);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labeltext);
            this.tabPage1.Controls.Add(this.NumOfPeopleLabel);
            this.tabPage1.Controls.Add(this.CostLabel);
            this.tabPage1.Controls.Add(this.NumofPeopleUpDown);
            this.tabPage1.Controls.Add(this.fancyBox);
            this.tabPage1.Controls.Add(this.healthyBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(260, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // labeltext
            // 
            this.labeltext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labeltext.Location = new System.Drawing.Point(60, 133);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(100, 23);
            this.labeltext.TabIndex = 11;
            this.labeltext.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelcost);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.CakeText);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.CakeFancyCheck);
            this.tabPage2.Controls.Add(this.PartyUpdown);
            this.tabPage2.Controls.Add(this.PartyLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(260, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelcost
            // 
            this.labelcost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelcost.Location = new System.Drawing.Point(71, 145);
            this.labelcost.Name = "labelcost";
            this.labelcost.Size = new System.Drawing.Size(100, 23);
            this.labelcost.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cake Writing";
            // 
            // CakeText
            // 
            this.CakeText.Location = new System.Drawing.Point(6, 106);
            this.CakeText.Name = "CakeText";
            this.CakeText.Size = new System.Drawing.Size(100, 21);
            this.CakeText.TabIndex = 8;
            this.CakeText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(13, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cost";
            // 
            // CakeFancyCheck
            // 
            this.CakeFancyCheck.AutoSize = true;
            this.CakeFancyCheck.Checked = true;
            this.CakeFancyCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CakeFancyCheck.Location = new System.Drawing.Point(6, 67);
            this.CakeFancyCheck.Name = "CakeFancyCheck";
            this.CakeFancyCheck.Size = new System.Drawing.Size(130, 16);
            this.CakeFancyCheck.TabIndex = 4;
            this.CakeFancyCheck.Text = "Fancy Decorations";
            this.CakeFancyCheck.UseVisualStyleBackColor = true;
            this.CakeFancyCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PartyUpdown
            // 
            this.PartyUpdown.Location = new System.Drawing.Point(8, 40);
            this.PartyUpdown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PartyUpdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PartyUpdown.Name = "PartyUpdown";
            this.PartyUpdown.Size = new System.Drawing.Size(120, 21);
            this.PartyUpdown.TabIndex = 3;
            this.PartyUpdown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PartyUpdown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // PartyLabel
            // 
            this.PartyLabel.AutoSize = true;
            this.PartyLabel.Location = new System.Drawing.Point(6, 14);
            this.PartyLabel.Name = "PartyLabel";
            this.PartyLabel.Size = new System.Drawing.Size(107, 12);
            this.PartyLabel.TabIndex = 2;
            this.PartyLabel.Text = "Number of People";
            // 
            // PartyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "PartyForm";
            this.Text = "Party Planner";
            this.Load += new System.EventHandler(this.PartyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumofPeopleUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartyUpdown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumofPeopleUpDown;
        private System.Windows.Forms.Label NumOfPeopleLabel;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CakeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CakeFancyCheck;
        private System.Windows.Forms.NumericUpDown PartyUpdown;
        private System.Windows.Forms.Label PartyLabel;
        private System.Windows.Forms.Label labelcost;
        private System.Windows.Forms.Label labeltext;
    }
}

