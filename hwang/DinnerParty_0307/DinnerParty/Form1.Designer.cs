namespace DinnerParty
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
            this.NumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FancyCheck = new System.Windows.Forms.CheckBox();
            this.HealthyCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.TextBox();
            this.CouponCheck = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfPeople2 = new System.Windows.Forms.NumericUpDown();
            this.FancyOption2 = new System.Windows.Forms.CheckBox();
            this.WritingOption = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WritingBox = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.Label();
            this.TotalCost2 = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeople)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeople2)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberOfPeople
            // 
            this.NumberOfPeople.Location = new System.Drawing.Point(22, 29);
            this.NumberOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfPeople.Name = "NumberOfPeople";
            this.NumberOfPeople.Size = new System.Drawing.Size(105, 21);
            this.NumberOfPeople.TabIndex = 0;
            this.NumberOfPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfPeople.ValueChanged += new System.EventHandler(this.NumberOfPeople_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of People";
            // 
            // FancyCheck
            // 
            this.FancyCheck.AutoSize = true;
            this.FancyCheck.Location = new System.Drawing.Point(22, 82);
            this.FancyCheck.Name = "FancyCheck";
            this.FancyCheck.Size = new System.Drawing.Size(130, 16);
            this.FancyCheck.TabIndex = 2;
            this.FancyCheck.Text = "Fancy Decorations";
            this.FancyCheck.UseVisualStyleBackColor = true;
            this.FancyCheck.CheckedChanged += new System.EventHandler(this.FancyCheck_CheckedChanged);
            // 
            // HealthyCheck
            // 
            this.HealthyCheck.AutoSize = true;
            this.HealthyCheck.Location = new System.Drawing.Point(22, 60);
            this.HealthyCheck.Name = "HealthyCheck";
            this.HealthyCheck.Size = new System.Drawing.Size(106, 16);
            this.HealthyCheck.TabIndex = 3;
            this.HealthyCheck.Text = "Healthy Option";
            this.HealthyCheck.UseVisualStyleBackColor = true;
            this.HealthyCheck.CheckedChanged += new System.EventHandler(this.HealthyCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(4, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // TotalCost
            // 
            this.TotalCost.Location = new System.Drawing.Point(56, 128);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            this.TotalCost.Size = new System.Drawing.Size(80, 21);
            this.TotalCost.TabIndex = 5;
            // 
            // CouponCheck
            // 
            this.CouponCheck.AutoSize = true;
            this.CouponCheck.Enabled = false;
            this.CouponCheck.Location = new System.Drawing.Point(22, 104);
            this.CouponCheck.Name = "CouponCheck";
            this.CouponCheck.Size = new System.Drawing.Size(94, 16);
            this.CouponCheck.TabIndex = 6;
            this.CouponCheck.Text = "Coupon(5%)";
            this.CouponCheck.UseVisualStyleBackColor = true;
            this.CouponCheck.CheckedChanged += new System.EventHandler(this.CouponOption_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(186, 216);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NumberOfPeople);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TotalCost);
            this.tabPage1.Controls.Add(this.CouponCheck);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.FancyCheck);
            this.tabPage1.Controls.Add(this.HealthyCheck);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(178, 190);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Ok);
            this.tabPage2.Controls.Add(this.TotalCost2);
            this.tabPage2.Controls.Add(this.Cost);
            this.tabPage2.Controls.Add(this.WritingBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.WritingOption);
            this.tabPage2.Controls.Add(this.FancyOption2);
            this.tabPage2.Controls.Add(this.NumberOfPeople2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(178, 190);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BirthDay Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "NumberOfPeople";
            // 
            // NumberOfPeople2
            // 
            this.NumberOfPeople2.Location = new System.Drawing.Point(23, 28);
            this.NumberOfPeople2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfPeople2.Name = "NumberOfPeople2";
            this.NumberOfPeople2.Size = new System.Drawing.Size(99, 21);
            this.NumberOfPeople2.TabIndex = 1;
            this.NumberOfPeople2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfPeople2.ValueChanged += new System.EventHandler(this.NumberOfPeople2_ValueChanged);
            // 
            // FancyOption2
            // 
            this.FancyOption2.AutoSize = true;
            this.FancyOption2.Location = new System.Drawing.Point(23, 57);
            this.FancyOption2.Name = "FancyOption2";
            this.FancyOption2.Size = new System.Drawing.Size(123, 16);
            this.FancyOption2.TabIndex = 2;
            this.FancyOption2.Text = "Fancy Decoration";
            this.FancyOption2.UseVisualStyleBackColor = true;
            this.FancyOption2.CheckedChanged += new System.EventHandler(this.FancyOption2_CheckedChanged);
            // 
            // WritingOption
            // 
            this.WritingOption.AutoSize = true;
            this.WritingOption.Location = new System.Drawing.Point(23, 78);
            this.WritingOption.Name = "WritingOption";
            this.WritingOption.Size = new System.Drawing.Size(98, 16);
            this.WritingOption.TabIndex = 3;
            this.WritingOption.Text = "Writng Option";
            this.WritingOption.UseVisualStyleBackColor = true;
            this.WritingOption.CheckedChanged += new System.EventHandler(this.WritingOption_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cake Writing";
            // 
            // WritingBox
            // 
            this.WritingBox.BackColor = System.Drawing.SystemColors.Window;
            this.WritingBox.Enabled = false;
            this.WritingBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.WritingBox.Location = new System.Drawing.Point(21, 118);
            this.WritingBox.Name = "WritingBox";
            this.WritingBox.Size = new System.Drawing.Size(100, 21);
            this.WritingBox.TabIndex = 5;
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cost.Location = new System.Drawing.Point(5, 148);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(47, 16);
            this.Cost.TabIndex = 6;
            this.Cost.Text = "Cost";
            // 
            // TotalCost2
            // 
            this.TotalCost2.Enabled = false;
            this.TotalCost2.Location = new System.Drawing.Point(60, 145);
            this.TotalCost2.Name = "TotalCost2";
            this.TotalCost2.Size = new System.Drawing.Size(80, 21);
            this.TotalCost2.TabIndex = 7;
            // 
            // Ok
            // 
            this.Ok.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ok.Location = new System.Drawing.Point(123, 117);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(45, 23);
            this.Ok.TabIndex = 8;
            this.Ok.Text = "Write!";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 213);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CostCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeople)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeople2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumberOfPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FancyCheck;
        private System.Windows.Forms.CheckBox HealthyCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalCost;
        private System.Windows.Forms.CheckBox CouponCheck;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox WritingBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox WritingOption;
        private System.Windows.Forms.CheckBox FancyOption2;
        private System.Windows.Forms.NumericUpDown NumberOfPeople2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.TextBox TotalCost2;
        private System.Windows.Forms.Button Ok;
    }
}

