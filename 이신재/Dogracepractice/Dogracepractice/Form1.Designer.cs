namespace Dogracepractice
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
            this.dogpicture1 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.dogpicture2 = new System.Windows.Forms.PictureBox();
            this.dogpicture3 = new System.Windows.Forms.PictureBox();
            this.dogpicture4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericdognumber = new System.Windows.Forms.NumericUpDown();
            this.numericbetamount = new System.Windows.Forms.NumericUpDown();
            this.btnrace = new System.Windows.Forms.Button();
            this.btnbet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.changelabel = new System.Windows.Forms.Label();
            this.btnai = new System.Windows.Forms.RadioButton();
            this.btnbob = new System.Windows.Forms.RadioButton();
            this.btnjoe = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtai = new System.Windows.Forms.Label();
            this.txtbob = new System.Windows.Forms.Label();
            this.txtjoe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dogpicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogpicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogpicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogpicture4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericdognumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericbetamount)).BeginInit();
            this.SuspendLayout();
            // 
            // dogpicture1
            // 
            this.dogpicture1.Image = global::Dogracepractice.Properties.Resources.dog;
            this.dogpicture1.Location = new System.Drawing.Point(54, 20);
            this.dogpicture1.Name = "dogpicture1";
            this.dogpicture1.Size = new System.Drawing.Size(76, 19);
            this.dogpicture1.TabIndex = 1;
            this.dogpicture1.TabStop = false;
            // 
            // background
            // 
            this.background.Image = global::Dogracepractice.Properties.Resources.racetrack;
            this.background.Location = new System.Drawing.Point(40, 12);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(604, 205);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // dogpicture2
            // 
            this.dogpicture2.Image = global::Dogracepractice.Properties.Resources.dog;
            this.dogpicture2.Location = new System.Drawing.Point(54, 69);
            this.dogpicture2.Name = "dogpicture2";
            this.dogpicture2.Size = new System.Drawing.Size(76, 19);
            this.dogpicture2.TabIndex = 2;
            this.dogpicture2.TabStop = false;
            // 
            // dogpicture3
            // 
            this.dogpicture3.Image = global::Dogracepractice.Properties.Resources.dog;
            this.dogpicture3.Location = new System.Drawing.Point(54, 123);
            this.dogpicture3.Name = "dogpicture3";
            this.dogpicture3.Size = new System.Drawing.Size(76, 19);
            this.dogpicture3.TabIndex = 3;
            this.dogpicture3.TabStop = false;
            // 
            // dogpicture4
            // 
            this.dogpicture4.Image = global::Dogracepractice.Properties.Resources.dog;
            this.dogpicture4.Location = new System.Drawing.Point(54, 173);
            this.dogpicture4.Name = "dogpicture4";
            this.dogpicture4.Size = new System.Drawing.Size(76, 19);
            this.dogpicture4.TabIndex = 4;
            this.dogpicture4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericdognumber);
            this.groupBox1.Controls.Add(this.numericbetamount);
            this.groupBox1.Controls.Add(this.btnrace);
            this.groupBox1.Controls.Add(this.btnbet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.changelabel);
            this.groupBox1.Controls.Add(this.btnai);
            this.groupBox1.Controls.Add(this.btnbob);
            this.groupBox1.Controls.Add(this.btnjoe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtai);
            this.groupBox1.Controls.Add(this.txtbob);
            this.groupBox1.Controls.Add(this.txtjoe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 268);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // numericdognumber
            // 
            this.numericdognumber.Location = new System.Drawing.Point(404, 228);
            this.numericdognumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericdognumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericdognumber.Name = "numericdognumber";
            this.numericdognumber.Size = new System.Drawing.Size(41, 21);
            this.numericdognumber.TabIndex = 13;
            this.numericdognumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericdognumber.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericbetamount
            // 
            this.numericbetamount.Location = new System.Drawing.Point(172, 228);
            this.numericbetamount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericbetamount.Name = "numericbetamount";
            this.numericbetamount.Size = new System.Drawing.Size(45, 21);
            this.numericbetamount.TabIndex = 12;
            this.numericbetamount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericbetamount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnrace
            // 
            this.btnrace.Location = new System.Drawing.Point(506, 216);
            this.btnrace.Name = "btnrace";
            this.btnrace.Size = new System.Drawing.Size(94, 46);
            this.btnrace.TabIndex = 11;
            this.btnrace.Text = "Race!!";
            this.btnrace.UseVisualStyleBackColor = true;
            this.btnrace.Click += new System.EventHandler(this.btnrace_Click);
            // 
            // btnbet
            // 
            this.btnbet.Location = new System.Drawing.Point(80, 228);
            this.btnbet.Name = "btnbet";
            this.btnbet.Size = new System.Drawing.Size(75, 23);
            this.btnbet.TabIndex = 10;
            this.btnbet.Text = "Bets";
            this.btnbet.UseVisualStyleBackColor = true;
            this.btnbet.Click += new System.EventHandler(this.btnbet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "bucks on dog number";
            // 
            // changelabel
            // 
            this.changelabel.AutoSize = true;
            this.changelabel.Location = new System.Drawing.Point(26, 233);
            this.changelabel.Name = "changelabel";
            this.changelabel.Size = new System.Drawing.Size(25, 12);
            this.changelabel.TabIndex = 8;
            this.changelabel.Text = "Joe";
            // 
            // btnai
            // 
            this.btnai.AutoSize = true;
            this.btnai.Location = new System.Drawing.Point(28, 137);
            this.btnai.Name = "btnai";
            this.btnai.Size = new System.Drawing.Size(34, 16);
            this.btnai.TabIndex = 7;
            this.btnai.TabStop = true;
            this.btnai.Text = "AI";
            this.btnai.UseVisualStyleBackColor = true;
            this.btnai.CheckedChanged += new System.EventHandler(this.btnai_CheckedChanged);
            // 
            // btnbob
            // 
            this.btnbob.AutoSize = true;
            this.btnbob.Location = new System.Drawing.Point(29, 106);
            this.btnbob.Name = "btnbob";
            this.btnbob.Size = new System.Drawing.Size(45, 16);
            this.btnbob.TabIndex = 6;
            this.btnbob.TabStop = true;
            this.btnbob.Text = "Bob";
            this.btnbob.UseVisualStyleBackColor = true;
            this.btnbob.CheckedChanged += new System.EventHandler(this.btnbob_CheckedChanged);
            // 
            // btnjoe
            // 
            this.btnjoe.AutoSize = true;
            this.btnjoe.Location = new System.Drawing.Point(28, 78);
            this.btnjoe.Name = "btnjoe";
            this.btnjoe.Size = new System.Drawing.Size(43, 16);
            this.btnjoe.TabIndex = 5;
            this.btnjoe.TabStop = true;
            this.btnjoe.Text = "Joe";
            this.btnjoe.UseVisualStyleBackColor = true;
            this.btnjoe.CheckedChanged += new System.EventHandler(this.btnjoe_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bets";
            // 
            // txtai
            // 
            this.txtai.AutoSize = true;
            this.txtai.Location = new System.Drawing.Point(348, 137);
            this.txtai.Name = "txtai";
            this.txtai.Size = new System.Drawing.Size(48, 12);
            this.txtai.TabIndex = 3;
            this.txtai.Text = "AI\'s bet";
            this.txtai.Click += new System.EventHandler(this.txtai_Click);
            // 
            // txtbob
            // 
            this.txtbob.AutoSize = true;
            this.txtbob.Location = new System.Drawing.Point(346, 106);
            this.txtbob.Name = "txtbob";
            this.txtbob.Size = new System.Drawing.Size(59, 12);
            this.txtbob.TabIndex = 2;
            this.txtbob.Text = "Bob\'s bet";
            this.txtbob.Click += new System.EventHandler(this.txtbob_Click);
            // 
            // txtjoe
            // 
            this.txtjoe.AutoSize = true;
            this.txtjoe.Location = new System.Drawing.Point(348, 78);
            this.txtjoe.Name = "txtjoe";
            this.txtjoe.Size = new System.Drawing.Size(57, 12);
            this.txtjoe.TabIndex = 1;
            this.txtjoe.Text = "Joe\'s bet";
            this.txtjoe.Click += new System.EventHandler(this.txtjoe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum bet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dogpicture4);
            this.Controls.Add(this.dogpicture3);
            this.Controls.Add(this.dogpicture2);
            this.Controls.Add(this.dogpicture1);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dogpicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogpicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogpicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogpicture4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericdognumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericbetamount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox dogpicture1;
        private System.Windows.Forms.PictureBox dogpicture2;
        private System.Windows.Forms.PictureBox dogpicture3;
        private System.Windows.Forms.PictureBox dogpicture4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericdognumber;
        private System.Windows.Forms.NumericUpDown numericbetamount;
        private System.Windows.Forms.Button btnrace;
        private System.Windows.Forms.Button btnbet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label changelabel;
        private System.Windows.Forms.RadioButton btnai;
        private System.Windows.Forms.RadioButton btnbob;
        private System.Windows.Forms.RadioButton btnjoe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtai;
        private System.Windows.Forms.Label txtbob;
        private System.Windows.Forms.Label txtjoe;
        private System.Windows.Forms.Label label1;
    }
}

