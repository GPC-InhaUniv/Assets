﻿namespace Beehive
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
            this.buttonAssignJob = new System.Windows.Forms.Button();
            this.numericUpDownShiifts = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxWokerBeeJob = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNextShift = new System.Windows.Forms.Button();
            this.textBoxReport = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShiifts)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAssignJob);
            this.groupBox1.Controls.Add(this.numericUpDownShiifts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxWokerBeeJob);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Job Assignments";
            // 
            // buttonAssignJob
            // 
            this.buttonAssignJob.Location = new System.Drawing.Point(22, 76);
            this.buttonAssignJob.Name = "buttonAssignJob";
            this.buttonAssignJob.Size = new System.Drawing.Size(195, 28);
            this.buttonAssignJob.TabIndex = 4;
            this.buttonAssignJob.Text = "Assign this job to bee";
            this.buttonAssignJob.UseVisualStyleBackColor = true;
            this.buttonAssignJob.Click += new System.EventHandler(this.buttonAssignJob_Click);
            // 
            // numericUpDownShiifts
            // 
            this.numericUpDownShiifts.Location = new System.Drawing.Point(249, 49);
            this.numericUpDownShiifts.Name = "numericUpDownShiifts";
            this.numericUpDownShiifts.Size = new System.Drawing.Size(99, 21);
            this.numericUpDownShiifts.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shifts";
            // 
            // comboBoxWokerBeeJob
            // 
            this.comboBoxWokerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWokerBeeJob.FormattingEnabled = true;
            this.comboBoxWokerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.comboBoxWokerBeeJob.Location = new System.Drawing.Point(22, 50);
            this.comboBoxWokerBeeJob.Name = "comboBoxWokerBeeJob";
            this.comboBoxWokerBeeJob.Size = new System.Drawing.Size(195, 20);
            this.comboBoxWokerBeeJob.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worker bee job";
            // 
            // buttonNextShift
            // 
            this.buttonNextShift.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNextShift.Location = new System.Drawing.Point(436, 56);
            this.buttonNextShift.Name = "buttonNextShift";
            this.buttonNextShift.Size = new System.Drawing.Size(76, 81);
            this.buttonNextShift.TabIndex = 1;
            this.buttonNextShift.Text = "Work the next shift";
            this.buttonNextShift.UseVisualStyleBackColor = true;
            this.buttonNextShift.Click += new System.EventHandler(this.buttonNextShift_Click);
            // 
            // textBoxReport
            // 
            this.textBoxReport.Location = new System.Drawing.Point(28, 179);
            this.textBoxReport.Multiline = true;
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.Size = new System.Drawing.Size(483, 224);
            this.textBoxReport.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(543, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 433);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxReport);
            this.Controls.Add(this.buttonNextShift);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShiifts)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAssignJob;
        private System.Windows.Forms.NumericUpDown numericUpDownShiifts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxWokerBeeJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNextShift;
        private System.Windows.Forms.TextBox textBoxReport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

