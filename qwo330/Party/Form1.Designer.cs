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
            this.label1 = new System.Windows.Forms.Label();
            this.numUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkDeco = new System.Windows.Forms.CheckBox();
            this.checkHealth = new System.Windows.Forms.CheckBox();
            this.labelCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // numUD
            // 
            this.numUD.Location = new System.Drawing.Point(15, 29);
            this.numUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD.Name = "numUD";
            this.numUD.Size = new System.Drawing.Size(120, 21);
            this.numUD.TabIndex = 1;
            this.numUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUD.ValueChanged += new System.EventHandler(this.numUD_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cost";
            // 
            // checkDeco
            // 
            this.checkDeco.AutoSize = true;
            this.checkDeco.Checked = true;
            this.checkDeco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDeco.Location = new System.Drawing.Point(15, 60);
            this.checkDeco.Name = "checkDeco";
            this.checkDeco.Size = new System.Drawing.Size(130, 16);
            this.checkDeco.TabIndex = 3;
            this.checkDeco.Text = "Fancy Decorations";
            this.checkDeco.UseVisualStyleBackColor = true;
            this.checkDeco.CheckedChanged += new System.EventHandler(this.checkDeco_CheckedChanged);
            // 
            // checkHealth
            // 
            this.checkHealth.AutoSize = true;
            this.checkHealth.Location = new System.Drawing.Point(15, 82);
            this.checkHealth.Name = "checkHealth";
            this.checkHealth.Size = new System.Drawing.Size(106, 16);
            this.checkHealth.TabIndex = 4;
            this.checkHealth.Text = "Healthy Option";
            this.checkHealth.UseVisualStyleBackColor = true;
            this.checkHealth.CheckedChanged += new System.EventHandler(this.checkHealth_CheckedChanged);
            // 
            // labelCost
            // 
            this.labelCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCost.Location = new System.Drawing.Point(54, 117);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(107, 22);
            this.labelCost.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 171);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.checkHealth);
            this.Controls.Add(this.checkDeco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numUD);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkDeco;
        private System.Windows.Forms.CheckBox checkHealth;
        private System.Windows.Forms.Label labelCost;
    }
}

