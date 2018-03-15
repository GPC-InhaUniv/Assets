namespace CircleQueue
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
            this.EnqeueBtn = new System.Windows.Forms.Button();
            this.DequeueBtn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnqueueValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnqeueBtn
            // 
            this.EnqeueBtn.Location = new System.Drawing.Point(448, 71);
            this.EnqeueBtn.Name = "EnqeueBtn";
            this.EnqeueBtn.Size = new System.Drawing.Size(158, 74);
            this.EnqeueBtn.TabIndex = 0;
            this.EnqeueBtn.Text = "Enqueue";
            this.EnqeueBtn.UseVisualStyleBackColor = true;
            this.EnqeueBtn.Click += new System.EventHandler(this.EnqeueBtn_Click);
            // 
            // DequeueBtn
            // 
            this.DequeueBtn.Location = new System.Drawing.Point(448, 160);
            this.DequeueBtn.Name = "DequeueBtn";
            this.DequeueBtn.Size = new System.Drawing.Size(158, 79);
            this.DequeueBtn.TabIndex = 1;
            this.DequeueBtn.Text = "Dequeue";
            this.DequeueBtn.UseVisualStyleBackColor = true;
            this.DequeueBtn.Click += new System.EventHandler(this.DequeueBtn_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(448, 254);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(170, 69);
            this.ShowBtn.TabIndex = 2;
            this.ShowBtn.Text = "Show";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(24, 71);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(394, 252);
            this.TextBox.TabIndex = 3;
            this.TextBox.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(35, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "CircleQueue";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnqueueValue
            // 
            this.EnqueueValue.Location = new System.Drawing.Point(448, 30);
            this.EnqueueValue.Name = "EnqueueValue";
            this.EnqueueValue.Size = new System.Drawing.Size(80, 21);
            this.EnqueueValue.TabIndex = 5;
            this.EnqueueValue.TextChanged += new System.EventHandler(this.EnqueueValue_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 373);
            this.Controls.Add(this.EnqueueValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.DequeueBtn);
            this.Controls.Add(this.EnqeueBtn);
            this.Name = "Form1";
            this.Text = "CircleQueue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnqeueBtn;
        private System.Windows.Forms.Button DequeueBtn;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnqueueValue;
    }
}

