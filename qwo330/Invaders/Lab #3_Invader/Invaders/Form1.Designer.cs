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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.lifeImg = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.gameOverr = new System.Windows.Forms.Label();
            this.Life = new System.Windows.Forms.Label();
            this.Stage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lifeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick_1);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 33;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick_1);
            // 
            // lifeImg
            // 
            this.lifeImg.Image = global::Invaders.Properties.Resources.player;
            this.lifeImg.Location = new System.Drawing.Point(719, 6);
            this.lifeImg.Name = "lifeImg";
            this.lifeImg.Size = new System.Drawing.Size(40, 30);
            this.lifeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lifeImg.TabIndex = 5;
            this.lifeImg.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Score.Location = new System.Drawing.Point(12, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(77, 24);
            this.Score.TabIndex = 6;
            this.Score.Text = "Score";
            // 
            // gameOverr
            // 
            this.gameOverr.AutoSize = true;
            this.gameOverr.BackColor = System.Drawing.Color.Transparent;
            this.gameOverr.Font = new System.Drawing.Font("굴림", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gameOverr.ForeColor = System.Drawing.Color.Yellow;
            this.gameOverr.Location = new System.Drawing.Point(23, 97);
            this.gameOverr.Name = "gameOverr";
            this.gameOverr.Size = new System.Drawing.Size(550, 96);
            this.gameOverr.TabIndex = 7;
            this.gameOverr.Text = "Game Over";
            // 
            // Life
            // 
            this.Life.AutoSize = true;
            this.Life.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Life.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Life.Location = new System.Drawing.Point(759, 10);
            this.Life.Name = "Life";
            this.Life.Size = new System.Drawing.Size(61, 24);
            this.Life.TabIndex = 8;
            this.Life.Text = ": life";
            // 
            // Stage
            // 
            this.Stage.AutoSize = true;
            this.Stage.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Stage.Location = new System.Drawing.Point(315, 9);
            this.Stage.Name = "Stage";
            this.Stage.Size = new System.Drawing.Size(98, 24);
            this.Stage.TabIndex = 9;
            this.Stage.Text = "Wave : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(881, 961);
            this.Controls.Add(this.Stage);
            this.Controls.Add(this.Life);
            this.Controls.Add(this.gameOverr);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.lifeImg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Invaders";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.lifeImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.PictureBox lifeImg;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label gameOverr;
        private System.Windows.Forms.Label Life;
        private System.Windows.Forms.Label Stage;
    }
}

