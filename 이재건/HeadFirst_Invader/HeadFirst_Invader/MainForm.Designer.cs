namespace HeadFirst_Invader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.twinkleTimer = new System.Windows.Forms.Timer(this.components);
            this.currentStageLabel = new System.Windows.Forms.Label();
            this.invaderShotTimer = new System.Windows.Forms.Timer(this.components);
            this.gameStartLabel = new System.Windows.Forms.Label();
            this.HallOfFameLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.leftrightlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Interval = 50;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.scoreLabel.Size = new System.Drawing.Size(23, 23);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "0";
            this.scoreLabel.Visible = false;
            // 
            // twinkleTimer
            // 
            this.twinkleTimer.Enabled = true;
            this.twinkleTimer.Tick += new System.EventHandler(this.twinkleTimer_Tick);
            // 
            // currentStageLabel
            // 
            this.currentStageLabel.AutoSize = true;
            this.currentStageLabel.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStageLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.currentStageLabel.Location = new System.Drawing.Point(779, 9);
            this.currentStageLabel.Name = "currentStageLabel";
            this.currentStageLabel.Size = new System.Drawing.Size(77, 23);
            this.currentStageLabel.TabIndex = 1;
            this.currentStageLabel.Text = "Stage: ";
            this.currentStageLabel.Visible = false;
            // 
            // invaderShotTimer
            // 
            this.invaderShotTimer.Enabled = true;
            this.invaderShotTimer.Interval = 500;
            this.invaderShotTimer.Tick += new System.EventHandler(this.invaderShotTimer_Tick);
            // 
            // gameStartLabel
            // 
            this.gameStartLabel.AutoSize = true;
            this.gameStartLabel.Font = new System.Drawing.Font("궁서체", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gameStartLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.gameStartLabel.Location = new System.Drawing.Point(309, 307);
            this.gameStartLabel.Name = "gameStartLabel";
            this.gameStartLabel.Size = new System.Drawing.Size(205, 35);
            this.gameStartLabel.TabIndex = 2;
            this.gameStartLabel.Text = "Game Start";
            // 
            // HallOfFameLabel
            // 
            this.HallOfFameLabel.AutoSize = true;
            this.HallOfFameLabel.Font = new System.Drawing.Font("궁서체", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HallOfFameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.HallOfFameLabel.Location = new System.Drawing.Point(309, 358);
            this.HallOfFameLabel.Name = "HallOfFameLabel";
            this.HallOfFameLabel.Size = new System.Drawing.Size(243, 35);
            this.HallOfFameLabel.TabIndex = 3;
            this.HallOfFameLabel.Text = "Hall Of Fame";
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("궁서체", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExitLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitLabel.Location = new System.Drawing.Point(309, 411);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(91, 35);
            this.ExitLabel.TabIndex = 4;
            this.ExitLabel.Text = "Exit";
            // 
            // MainImage
            // 
            this.MainImage.BackColor = System.Drawing.Color.Transparent;
            this.MainImage.ImageLocation = "C:\\Users\\hrd32105\\Desktop\\IntroMainImage.jpg";
            this.MainImage.InitialImage = null;
            this.MainImage.Location = new System.Drawing.Point(171, -16);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(512, 320);
            this.MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainImage.TabIndex = 5;
            this.MainImage.TabStop = false;
            // 
            // leftrightlabel
            // 
            this.leftrightlabel.AutoSize = true;
            this.leftrightlabel.Font = new System.Drawing.Font("궁서체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftrightlabel.ForeColor = System.Drawing.SystemColors.Window;
            this.leftrightlabel.Location = new System.Drawing.Point(269, 316);
            this.leftrightlabel.Name = "leftrightlabel";
            this.leftrightlabel.Size = new System.Drawing.Size(34, 24);
            this.leftrightlabel.TabIndex = 6;
            this.leftrightlabel.Text = "▶";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.leftrightlabel);
            this.Controls.Add(this.MainImage);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.HallOfFameLabel);
            this.Controls.Add(this.gameStartLabel);
            this.Controls.Add(this.currentStageLabel);
            this.Controls.Add(this.scoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(399, 399);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Invaders";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer twinkleTimer;
        private System.Windows.Forms.Label currentStageLabel;
        private System.Windows.Forms.Timer invaderShotTimer;
        private System.Windows.Forms.Label gameStartLabel;
        private System.Windows.Forms.Label HallOfFameLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.PictureBox MainImage;
        private System.Windows.Forms.Label leftrightlabel;
    }
}