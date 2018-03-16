namespace Quest2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player_Pic = new System.Windows.Forms.PictureBox();
            this.Up_move = new System.Windows.Forms.Button();
            this.left_move = new System.Windows.Forms.Button();
            this.Right_move = new System.Windows.Forms.Button();
            this.Down_move = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player_Pic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player_Pic
            // 
            this.Player_Pic.BackColor = System.Drawing.Color.Transparent;
            this.Player_Pic.Image = ((System.Drawing.Image)(resources.GetObject("Player_Pic.Image")));
            this.Player_Pic.Location = new System.Drawing.Point(74, 56);
            this.Player_Pic.Name = "Player_Pic";
            this.Player_Pic.Size = new System.Drawing.Size(30, 30);
            this.Player_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player_Pic.TabIndex = 0;
            this.Player_Pic.TabStop = false;
            // 
            // Up_move
            // 
            this.Up_move.Location = new System.Drawing.Point(58, 15);
            this.Up_move.Name = "Up_move";
            this.Up_move.Size = new System.Drawing.Size(75, 23);
            this.Up_move.TabIndex = 1;
            this.Up_move.Text = "UP";
            this.Up_move.UseVisualStyleBackColor = true;
            this.Up_move.Click += new System.EventHandler(this.Up_move_Click);
            // 
            // left_move
            // 
            this.left_move.Location = new System.Drawing.Point(19, 42);
            this.left_move.Name = "left_move";
            this.left_move.Size = new System.Drawing.Size(75, 23);
            this.left_move.TabIndex = 2;
            this.left_move.Text = "LEFT";
            this.left_move.UseVisualStyleBackColor = true;
            this.left_move.Click += new System.EventHandler(this.left_move_Click);
            // 
            // Right_move
            // 
            this.Right_move.Location = new System.Drawing.Point(100, 42);
            this.Right_move.Name = "Right_move";
            this.Right_move.Size = new System.Drawing.Size(75, 23);
            this.Right_move.TabIndex = 3;
            this.Right_move.Text = "RIGHT";
            this.Right_move.UseVisualStyleBackColor = true;
            this.Right_move.Click += new System.EventHandler(this.Right_move_Click);
            // 
            // Down_move
            // 
            this.Down_move.Location = new System.Drawing.Point(58, 71);
            this.Down_move.Name = "Down_move";
            this.Down_move.Size = new System.Drawing.Size(75, 23);
            this.Down_move.TabIndex = 4;
            this.Down_move.Text = "DOWN";
            this.Down_move.UseVisualStyleBackColor = true;
            this.Down_move.Click += new System.EventHandler(this.Down_move_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.left_move);
            this.groupBox1.Controls.Add(this.Up_move);
            this.groupBox1.Controls.Add(this.Right_move);
            this.groupBox1.Controls.Add(this.Down_move);
            this.groupBox1.Location = new System.Drawing.Point(608, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(990, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Player_Pic);
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player_Pic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player_Pic;
        private System.Windows.Forms.Button Up_move;
        private System.Windows.Forms.Button left_move;
        private System.Windows.Forms.Button Right_move;
        private System.Windows.Forms.Button Down_move;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

