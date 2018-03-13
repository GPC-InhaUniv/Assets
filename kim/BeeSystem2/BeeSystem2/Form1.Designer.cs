namespace BeeSystem2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Shift = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.AssignBtn = new System.Windows.Forms.Button();
            this.WorkList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NextBtn = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shift)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Shift);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AssignBtn);
            this.groupBox1.Controls.Add(this.WorkList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // Shift
            // 
            this.Shift.Location = new System.Drawing.Point(166, 35);
            this.Shift.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Shift.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Shift.Name = "Shift";
            this.Shift.Size = new System.Drawing.Size(63, 21);
            this.Shift.TabIndex = 4;
            this.Shift.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "shifts";
            // 
            // AssignBtn
            // 
            this.AssignBtn.Location = new System.Drawing.Point(9, 63);
            this.AssignBtn.Name = "AssignBtn";
            this.AssignBtn.Size = new System.Drawing.Size(150, 23);
            this.AssignBtn.TabIndex = 2;
            this.AssignBtn.Text = "Assign this job to a bee";
            this.AssignBtn.UseVisualStyleBackColor = true;
            this.AssignBtn.Click += new System.EventHandler(this.AssignBtn_Click);
            // 
            // WorkList
            // 
            this.WorkList.FormattingEnabled = true;
            this.WorkList.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.WorkList.Location = new System.Drawing.Point(7, 37);
            this.WorkList.Name = "WorkList";
            this.WorkList.Size = new System.Drawing.Size(152, 20);
            this.WorkList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worker Bee Job";
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(259, 25);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 87);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.Text = "Work the next shift";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(13, 119);
            this.Report.Multiline = true;
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(411, 153);
            this.Report.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 286);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Shift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AssignBtn;
        private System.Windows.Forms.ComboBox WorkList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.TextBox Report;
    }
}

