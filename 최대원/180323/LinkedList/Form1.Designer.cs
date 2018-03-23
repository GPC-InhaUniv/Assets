namespace LinkedList
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
            this.btStart = new System.Windows.Forms.Button();
            this.btNodeAdd = new System.Windows.Forms.Button();
            this.btNodeDel = new System.Windows.Forms.Button();
            this.btView = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.tBData = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(426, 10);
            this.btStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(83, 49);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "링크리스트 생성";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btNodeAdd
            // 
            this.btNodeAdd.Location = new System.Drawing.Point(426, 88);
            this.btNodeAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNodeAdd.Name = "btNodeAdd";
            this.btNodeAdd.Size = new System.Drawing.Size(83, 24);
            this.btNodeAdd.TabIndex = 2;
            this.btNodeAdd.Text = "노드 추가";
            this.btNodeAdd.UseVisualStyleBackColor = true;
            this.btNodeAdd.Click += new System.EventHandler(this.btNodeAdd_Click);
            // 
            // btNodeDel
            // 
            this.btNodeDel.Location = new System.Drawing.Point(426, 117);
            this.btNodeDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNodeDel.Name = "btNodeDel";
            this.btNodeDel.Size = new System.Drawing.Size(83, 24);
            this.btNodeDel.TabIndex = 3;
            this.btNodeDel.Text = "노드 삭제";
            this.btNodeDel.UseVisualStyleBackColor = true;
            this.btNodeDel.Click += new System.EventHandler(this.btNodeDel_Click);
            // 
            // btView
            // 
            this.btView.Location = new System.Drawing.Point(426, 146);
            this.btView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(83, 24);
            this.btView.TabIndex = 4;
            this.btView.Text = "상태 보기";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(426, 268);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(83, 24);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "종료 하기";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tBData
            // 
            this.tBData.Location = new System.Drawing.Point(426, 63);
            this.tBData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBData.Name = "tBData";
            this.tBData.Size = new System.Drawing.Size(84, 21);
            this.tBData.TabIndex = 6;
            this.tBData.Text = "data";
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(13, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(407, 278);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(426, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "크기 : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tBData);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.btNodeDel);
            this.Controls.Add(this.btNodeAdd);
            this.Controls.Add(this.btStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btNodeAdd;
        private System.Windows.Forms.Button btNodeDel;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tBData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

