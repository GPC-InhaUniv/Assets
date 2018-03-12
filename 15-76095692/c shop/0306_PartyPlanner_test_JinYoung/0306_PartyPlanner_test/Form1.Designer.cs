namespace _0306_PartyPlanner_test
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfPeopleUpDown = new System.Windows.Forms.NumericUpDown();
            this.FancyCheckBox = new System.Windows.Forms.CheckBox();
            this.HealthyCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DinnerPartyTabPage = new System.Windows.Forms.TabPage();
            this.BirthdayPartyTabPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeopleUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.DinnerPartyTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // NumberOfPeopleUpDown
            // 
            this.NumberOfPeopleUpDown.Location = new System.Drawing.Point(8, 29);
            this.NumberOfPeopleUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumberOfPeopleUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfPeopleUpDown.Name = "NumberOfPeopleUpDown";
            this.NumberOfPeopleUpDown.Size = new System.Drawing.Size(120, 21);
            this.NumberOfPeopleUpDown.TabIndex = 1;
            this.NumberOfPeopleUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumberOfPeopleUpDown.ValueChanged += new System.EventHandler(this.NumberOfPeopleUpDown_ValueChanged);
            // 
            // FancyCheckBox
            // 
            this.FancyCheckBox.AutoSize = true;
            this.FancyCheckBox.Location = new System.Drawing.Point(8, 61);
            this.FancyCheckBox.Name = "FancyCheckBox";
            this.FancyCheckBox.Size = new System.Drawing.Size(130, 16);
            this.FancyCheckBox.TabIndex = 2;
            this.FancyCheckBox.Text = "Fancy Decorations";
            this.FancyCheckBox.UseVisualStyleBackColor = true;
            this.FancyCheckBox.CheckedChanged += new System.EventHandler(this.FancyCheckBox_CheckedChanged);
            // 
            // HealthyCheckBox
            // 
            this.HealthyCheckBox.AutoSize = true;
            this.HealthyCheckBox.Location = new System.Drawing.Point(8, 83);
            this.HealthyCheckBox.Name = "HealthyCheckBox";
            this.HealthyCheckBox.Size = new System.Drawing.Size(106, 16);
            this.HealthyCheckBox.TabIndex = 3;
            this.HealthyCheckBox.Text = "Healthy Option";
            this.HealthyCheckBox.UseVisualStyleBackColor = true;
            this.HealthyCheckBox.CheckedChanged += new System.EventHandler(this.HealthyCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(46, 109);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(100, 22);
            this.costLabel.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DinnerPartyTabPage);
            this.tabControl1.Controls.Add(this.BirthdayPartyTabPage);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(178, 180);
            this.tabControl1.TabIndex = 6;
            // 
            // DinnerPartyTabPage
            // 
            this.DinnerPartyTabPage.Controls.Add(this.label1);
            this.DinnerPartyTabPage.Controls.Add(this.FancyCheckBox);
            this.DinnerPartyTabPage.Controls.Add(this.costLabel);
            this.DinnerPartyTabPage.Controls.Add(this.label2);
            this.DinnerPartyTabPage.Controls.Add(this.NumberOfPeopleUpDown);
            this.DinnerPartyTabPage.Controls.Add(this.HealthyCheckBox);
            this.DinnerPartyTabPage.Location = new System.Drawing.Point(4, 22);
            this.DinnerPartyTabPage.Name = "DinnerPartyTabPage";
            this.DinnerPartyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DinnerPartyTabPage.Size = new System.Drawing.Size(170, 154);
            this.DinnerPartyTabPage.TabIndex = 0;
            this.DinnerPartyTabPage.Text = "Dinner Party";
            this.DinnerPartyTabPage.UseVisualStyleBackColor = true;
            // 
            // BirthdayPartyTabPage
            // 
            this.BirthdayPartyTabPage.Font = new System.Drawing.Font("굴림", 9F);
            this.BirthdayPartyTabPage.Location = new System.Drawing.Point(4, 22);
            this.BirthdayPartyTabPage.Name = "BirthdayPartyTabPage";
            this.BirthdayPartyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BirthdayPartyTabPage.Size = new System.Drawing.Size(170, 154);
            this.BirthdayPartyTabPage.TabIndex = 1;
            this.BirthdayPartyTabPage.Text = "Birthday Party";
            this.BirthdayPartyTabPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 186);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeopleUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.DinnerPartyTabPage.ResumeLayout(false);
            this.DinnerPartyTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumberOfPeopleUpDown;
        private System.Windows.Forms.CheckBox FancyCheckBox;
        private System.Windows.Forms.CheckBox HealthyCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DinnerPartyTabPage;
        private System.Windows.Forms.TabPage BirthdayPartyTabPage;
    }
}

