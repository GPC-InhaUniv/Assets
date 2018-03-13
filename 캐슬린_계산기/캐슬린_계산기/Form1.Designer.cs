namespace 캐슬린_계산기
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
            this.lbPeople = new System.Windows.Forms.Label();
            this.chbFancy = new System.Windows.Forms.CheckBox();
            this.chbHealth = new System.Windows.Forms.CheckBox();
            this.numericUDPeople = new System.Windows.Forms.NumericUpDown();
            this.lbCost1 = new System.Windows.Forms.Label();
            this.lbCost2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPeople
            // 
            this.lbPeople.AutoSize = true;
            this.lbPeople.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPeople.Location = new System.Drawing.Point(54, 9);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(133, 25);
            this.lbPeople.TabIndex = 0;
            this.lbPeople.Text = "파티참여 인원";
            // 
            // chbFancy
            // 
            this.chbFancy.AutoSize = true;
            this.chbFancy.Checked = true;
            this.chbFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFancy.Location = new System.Drawing.Point(59, 64);
            this.chbFancy.Name = "chbFancy";
            this.chbFancy.Size = new System.Drawing.Size(88, 16);
            this.chbFancy.TabIndex = 1;
            this.chbFancy.Text = "화려한 장식";
            this.chbFancy.UseVisualStyleBackColor = true;
            this.chbFancy.CheckedChanged += new System.EventHandler(this.chbFancy_CheckedChanged);
            // 
            // chbHealth
            // 
            this.chbHealth.AutoSize = true;
            this.chbHealth.Location = new System.Drawing.Point(59, 86);
            this.chbHealth.Name = "chbHealth";
            this.chbHealth.Size = new System.Drawing.Size(88, 16);
            this.chbHealth.TabIndex = 2;
            this.chbHealth.Text = "유기농 음식";
            this.chbHealth.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.chbHealth.UseVisualStyleBackColor = true;
            this.chbHealth.CheckedChanged += new System.EventHandler(this.chbHealth_CheckedChanged);
            // 
            // numericUDPeople
            // 
            this.numericUDPeople.Location = new System.Drawing.Point(59, 37);
            this.numericUDPeople.Name = "numericUDPeople";
            this.numericUDPeople.Size = new System.Drawing.Size(120, 21);
            this.numericUDPeople.TabIndex = 3;
            this.numericUDPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUDPeople.ValueChanged += new System.EventHandler(this.numericUDPeople_ValueChanged);
            // 
            // lbCost1
            // 
            this.lbCost1.AutoSize = true;
            this.lbCost1.Location = new System.Drawing.Point(57, 119);
            this.lbCost1.Name = "lbCost1";
            this.lbCost1.Size = new System.Drawing.Size(29, 12);
            this.lbCost1.TabIndex = 4;
            this.lbCost1.Text = "비용";
            // 
            // lbCost2
            // 
            this.lbCost2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCost2.Location = new System.Drawing.Point(92, 119);
            this.lbCost2.Name = "lbCost2";
            this.lbCost2.Size = new System.Drawing.Size(87, 21);
            this.lbCost2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 159);
            this.Controls.Add(this.lbCost2);
            this.Controls.Add(this.lbCost1);
            this.Controls.Add(this.numericUDPeople);
            this.Controls.Add(this.chbHealth);
            this.Controls.Add(this.chbFancy);
            this.Controls.Add(this.lbPeople);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "캐슬린 파티 계산기";
            ((System.ComponentModel.ISupportInitialize)(this.numericUDPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPeople;
        private System.Windows.Forms.CheckBox chbFancy;
        private System.Windows.Forms.CheckBox chbHealth;
        private System.Windows.Forms.NumericUpDown numericUDPeople;
        private System.Windows.Forms.Label lbCost1;
        private System.Windows.Forms.Label lbCost2;
    }
}

