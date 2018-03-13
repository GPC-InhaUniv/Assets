namespace partyplanner
{
    partial class dinnerparty
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
            this.txtNumPeople = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkfancy = new System.Windows.Forms.CheckBox();
            this.checkhelthy = new System.Windows.Forms.CheckBox();
            this.lblcost = new System.Windows.Forms.Label();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.tebpartyplanner = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labeltotalcost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textcakedeco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkbfancy = new System.Windows.Forms.CheckBox();
            this.numericPeople = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tebpartyplanner.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumPeople
            // 
            this.txtNumPeople.AutoSize = true;
            this.txtNumPeople.Location = new System.Drawing.Point(12, 9);
            this.txtNumPeople.Name = "txtNumPeople";
            this.txtNumPeople.Size = new System.Drawing.Size(101, 12);
            this.txtNumPeople.TabIndex = 0;
            this.txtNumPeople.Text = "NumberOfPeople";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(14, 25);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkfancy
            // 
            this.checkfancy.Location = new System.Drawing.Point(14, 70);
            this.checkfancy.Name = "checkfancy";
            this.checkfancy.Size = new System.Drawing.Size(104, 24);
            this.checkfancy.TabIndex = 2;
            this.checkfancy.Text = "Fancy Decorations";
            this.checkfancy.UseVisualStyleBackColor = true;
            this.checkfancy.CheckedChanged += new System.EventHandler(this.checkfancy_CheckedChanged);
            // 
            // checkhelthy
            // 
            this.checkhelthy.AutoSize = true;
            this.checkhelthy.Location = new System.Drawing.Point(14, 104);
            this.checkhelthy.Name = "checkhelthy";
            this.checkhelthy.Size = new System.Drawing.Size(99, 16);
            this.checkhelthy.TabIndex = 3;
            this.checkhelthy.Text = "Healty Option";
            this.checkhelthy.UseVisualStyleBackColor = true;
            this.checkhelthy.CheckedChanged += new System.EventHandler(this.checkhelthy_CheckedChanged);
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.Location = new System.Drawing.Point(12, 147);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(31, 12);
            this.lblcost.TabIndex = 4;
            this.lblcost.Text = "Cost";
            this.lblcost.Click += new System.EventHandler(this.lblcost_Click);
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(49, 144);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(100, 21);
            this.txtcost.TabIndex = 5;
            this.txtcost.TextChanged += new System.EventHandler(this.txtcost_TextChanged);
            // 
            // tebpartyplanner
            // 
            this.tebpartyplanner.Controls.Add(this.tabPage1);
            this.tebpartyplanner.Controls.Add(this.tabPage2);
            this.tebpartyplanner.Location = new System.Drawing.Point(-1, -1);
            this.tebpartyplanner.Name = "tebpartyplanner";
            this.tebpartyplanner.SelectedIndex = 0;
            this.tebpartyplanner.Size = new System.Drawing.Size(218, 179);
            this.tebpartyplanner.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.numericUpDown2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(210, 153);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "normalparty";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cost";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(39, 93);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 16);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Healty Option";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(39, 59);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(139, 24);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Fancy Decorations";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(39, 32);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "NumberOfPeople";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labeltotalcost);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textcakedeco);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.checkbfancy);
            this.tabPage2.Controls.Add(this.numericPeople);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(210, 153);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "birthdayparty";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labeltotalcost
            // 
            this.labeltotalcost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labeltotalcost.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labeltotalcost.Location = new System.Drawing.Point(89, 116);
            this.labeltotalcost.Name = "labeltotalcost";
            this.labeltotalcost.Size = new System.Drawing.Size(112, 28);
            this.labeltotalcost.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "TotalCost";
            // 
            // textcakedeco
            // 
            this.textcakedeco.Location = new System.Drawing.Point(89, 72);
            this.textcakedeco.Name = "textcakedeco";
            this.textcakedeco.Size = new System.Drawing.Size(112, 21);
            this.textcakedeco.TabIndex = 11;
            this.textcakedeco.Text = "Input your Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cake Writing";
            // 
            // checkbfancy
            // 
            this.checkbfancy.AutoSize = true;
            this.checkbfancy.Location = new System.Drawing.Point(11, 52);
            this.checkbfancy.Name = "checkbfancy";
            this.checkbfancy.Size = new System.Drawing.Size(99, 16);
            this.checkbfancy.TabIndex = 9;
            this.checkbfancy.Text = "Fancy Option";
            this.checkbfancy.UseVisualStyleBackColor = true;
            // 
            // numericPeople
            // 
            this.numericPeople.Location = new System.Drawing.Point(11, 25);
            this.numericPeople.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPeople.Name = "numericPeople";
            this.numericPeople.Size = new System.Drawing.Size(120, 21);
            this.numericPeople.TabIndex = 8;
            this.numericPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number Of People";
            // 
            // dinnerparty
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 176);
            this.Controls.Add(this.tebpartyplanner);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.checkhelthy);
            this.Controls.Add(this.checkfancy);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtNumPeople);
            this.Name = "dinnerparty";
            this.Text = "Dinner party";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tebpartyplanner.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNumPeople;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkfancy;
        private System.Windows.Forms.CheckBox checkhelthy;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TabControl tebpartyplanner;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labeltotalcost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textcakedeco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkbfancy;
        private System.Windows.Forms.NumericUpDown numericPeople;
        private System.Windows.Forms.Label label5;
    }
}

