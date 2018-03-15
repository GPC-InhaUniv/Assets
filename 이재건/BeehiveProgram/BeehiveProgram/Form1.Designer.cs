namespace BeehiveProgram
{
    partial class MainForm
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
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.nextshiftbutton = new System.Windows.Forms.Button();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.assignbutton = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenacne",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(12, 72);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(208, 20);
            this.workerBeeJob.TabIndex = 1;
            // 
            // nextshiftbutton
            // 
            this.nextshiftbutton.Location = new System.Drawing.Point(373, 53);
            this.nextshiftbutton.Name = "nextshiftbutton";
            this.nextshiftbutton.Size = new System.Drawing.Size(75, 94);
            this.nextshiftbutton.TabIndex = 2;
            this.nextshiftbutton.Text = "Work the next shift";
            this.nextshiftbutton.UseVisualStyleBackColor = true;
            this.nextshiftbutton.Click += new System.EventHandler(this.nextshiftbutton_Click);
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(246, 71);
            this.shifts.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.shifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(120, 21);
            this.shifts.TabIndex = 3;
            this.shifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Worker Bee Assignments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Worker bee job";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shifts";
            // 
            // assignbutton
            // 
            this.assignbutton.Location = new System.Drawing.Point(25, 109);
            this.assignbutton.Name = "assignbutton";
            this.assignbutton.Size = new System.Drawing.Size(239, 53);
            this.assignbutton.TabIndex = 7;
            this.assignbutton.Text = "Assign this job to a bee";
            this.assignbutton.UseVisualStyleBackColor = true;
            this.assignbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(34, 195);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(480, 200);
            this.report.TabIndex = 8;
            this.report.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 438);
            this.Controls.Add(this.report);
            this.Controls.Add(this.assignbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shifts);
            this.Controls.Add(this.nextshiftbutton);
            this.Controls.Add(this.workerBeeJob);
            this.Name = "MainForm";
            this.Text = "Beehive Management System";
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Button nextshiftbutton;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button assignbutton;
        private System.Windows.Forms.RichTextBox report;
    }
}

