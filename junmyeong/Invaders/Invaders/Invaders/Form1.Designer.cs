namespace Invaders
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
            this.components = new System.ComponentModel.Container();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.invaderLogo = new System.Windows.Forms.PictureBox();
            this.gameOverLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.invaderLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // invaderLogo
            // 
            this.invaderLogo.Image = global::Invaders.Properties.Resources.invaderLogo;
            this.invaderLogo.Location = new System.Drawing.Point(21, 122);
            this.invaderLogo.Name = "invaderLogo";
            this.invaderLogo.Size = new System.Drawing.Size(700, 318);
            this.invaderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.invaderLogo.TabIndex = 0;
            this.invaderLogo.TabStop = false;
            // 
            // gameOverLogo
            // 
            this.gameOverLogo.Image = global::Invaders.Properties.Resources.gameOver;
            this.gameOverLogo.Location = new System.Drawing.Point(74, 151);
            this.gameOverLogo.Name = "gameOverLogo";
            this.gameOverLogo.Size = new System.Drawing.Size(585, 217);
            this.gameOverLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gameOverLogo.TabIndex = 2;
            this.gameOverLogo.TabStop = false;
            this.gameOverLogo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(746, 861);
            this.Controls.Add(this.gameOverLogo);
            this.Controls.Add(this.invaderLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.invaderLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox invaderLogo;
        private System.Windows.Forms.PictureBox gameOverLogo;
    }
}

