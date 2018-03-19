namespace TheQuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MoveLabel = new System.Windows.Forms.Label();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.AttackLabel = new System.Windows.Forms.Label();
            this.AttackDown = new System.Windows.Forms.Button();
            this.AttackRight = new System.Windows.Forms.Button();
            this.AttackLeft = new System.Windows.Forms.Button();
            this.AttackUp = new System.Windows.Forms.Button();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.BatLabel = new System.Windows.Forms.Label();
            this.GhostLabel = new System.Windows.Forms.Label();
            this.GhoulLabel = new System.Windows.Forms.Label();
            this.WeaponImage1 = new System.Windows.Forms.PictureBox();
            this.WeaponImage2 = new System.Windows.Forms.PictureBox();
            this.WeaponImage3 = new System.Windows.Forms.PictureBox();
            this.playerImage = new System.Windows.Forms.PictureBox();
            this.PlayerHpLabel = new System.Windows.Forms.Label();
            this.BatHpLabel = new System.Windows.Forms.Label();
            this.GhostHpLabel = new System.Windows.Forms.Label();
            this.GhoulHpLabel = new System.Windows.Forms.Label();
            this.BatImage1 = new System.Windows.Forms.PictureBox();
            this.GhostImage1 = new System.Windows.Forms.PictureBox();
            this.GhoulImage1 = new System.Windows.Forms.PictureBox();
            this.PopImage = new System.Windows.Forms.PictureBox();
            this.PostionImage1 = new System.Windows.Forms.PictureBox();
            this.PostionImage2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostionImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostionImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveLabel
            // 
            this.MoveLabel.AutoSize = true;
            this.MoveLabel.Location = new System.Drawing.Point(629, 12);
            this.MoveLabel.Name = "MoveLabel";
            this.MoveLabel.Size = new System.Drawing.Size(36, 12);
            this.MoveLabel.TabIndex = 1;
            this.MoveLabel.Text = "Move";
            // 
            // MoveUp
            // 
            this.MoveUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveUp.Location = new System.Drawing.Point(724, 40);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(75, 23);
            this.MoveUp.TabIndex = 2;
            this.MoveUp.Text = "Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveLeft
            // 
            this.MoveLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveLeft.Location = new System.Drawing.Point(657, 78);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(75, 23);
            this.MoveLeft.TabIndex = 3;
            this.MoveLeft.Text = "Left";
            this.MoveLeft.UseVisualStyleBackColor = true;
            this.MoveLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // MoveRight
            // 
            this.MoveRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveRight.Location = new System.Drawing.Point(800, 78);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(75, 23);
            this.MoveRight.TabIndex = 4;
            this.MoveRight.Text = "Right";
            this.MoveRight.UseVisualStyleBackColor = true;
            this.MoveRight.Click += new System.EventHandler(this.MoveRight_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveDown.Location = new System.Drawing.Point(724, 119);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(75, 23);
            this.MoveDown.TabIndex = 5;
            this.MoveDown.Text = "Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.Location = new System.Drawing.Point(629, 177);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(39, 12);
            this.AttackLabel.TabIndex = 6;
            this.AttackLabel.Text = "Attack";
            // 
            // AttackDown
            // 
            this.AttackDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttackDown.Location = new System.Drawing.Point(724, 281);
            this.AttackDown.Name = "AttackDown";
            this.AttackDown.Size = new System.Drawing.Size(75, 23);
            this.AttackDown.TabIndex = 10;
            this.AttackDown.Text = "Down";
            this.AttackDown.UseVisualStyleBackColor = true;
            this.AttackDown.Click += new System.EventHandler(this.AttackDown_Click);
            // 
            // AttackRight
            // 
            this.AttackRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttackRight.Location = new System.Drawing.Point(800, 240);
            this.AttackRight.Name = "AttackRight";
            this.AttackRight.Size = new System.Drawing.Size(75, 23);
            this.AttackRight.TabIndex = 9;
            this.AttackRight.Text = "Right";
            this.AttackRight.UseVisualStyleBackColor = true;
            this.AttackRight.Click += new System.EventHandler(this.AttackRight_Click);
            // 
            // AttackLeft
            // 
            this.AttackLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttackLeft.Location = new System.Drawing.Point(657, 240);
            this.AttackLeft.Name = "AttackLeft";
            this.AttackLeft.Size = new System.Drawing.Size(75, 23);
            this.AttackLeft.TabIndex = 8;
            this.AttackLeft.Text = "Left";
            this.AttackLeft.UseVisualStyleBackColor = true;
            this.AttackLeft.Click += new System.EventHandler(this.AttackLeft_Click);
            // 
            // AttackUp
            // 
            this.AttackUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttackUp.Location = new System.Drawing.Point(724, 202);
            this.AttackUp.Name = "AttackUp";
            this.AttackUp.Size = new System.Drawing.Size(75, 23);
            this.AttackUp.TabIndex = 7;
            this.AttackUp.Text = "Up";
            this.AttackUp.UseVisualStyleBackColor = true;
            this.AttackUp.Click += new System.EventHandler(this.AttackUp_Click);
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(629, 318);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(41, 12);
            this.PlayerLabel.TabIndex = 11;
            this.PlayerLabel.Text = "Player";
            // 
            // BatLabel
            // 
            this.BatLabel.AutoSize = true;
            this.BatLabel.Location = new System.Drawing.Point(629, 342);
            this.BatLabel.Name = "BatLabel";
            this.BatLabel.Size = new System.Drawing.Size(23, 12);
            this.BatLabel.TabIndex = 12;
            this.BatLabel.Text = "Bat";
            // 
            // GhostLabel
            // 
            this.GhostLabel.AutoSize = true;
            this.GhostLabel.Location = new System.Drawing.Point(629, 372);
            this.GhostLabel.Name = "GhostLabel";
            this.GhostLabel.Size = new System.Drawing.Size(38, 12);
            this.GhostLabel.TabIndex = 13;
            this.GhostLabel.Text = "Ghost";
            // 
            // GhoulLabel
            // 
            this.GhoulLabel.AutoSize = true;
            this.GhoulLabel.Location = new System.Drawing.Point(629, 400);
            this.GhoulLabel.Name = "GhoulLabel";
            this.GhoulLabel.Size = new System.Drawing.Size(38, 12);
            this.GhoulLabel.TabIndex = 14;
            this.GhoulLabel.Text = "Ghoul";
            // 
            // WeaponImage1
            // 
            this.WeaponImage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WeaponImage1.BackColor = System.Drawing.Color.Transparent;
            this.WeaponImage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WeaponImage1.ImageLocation = "";
            this.WeaponImage1.Location = new System.Drawing.Point(89, 51);
            this.WeaponImage1.Name = "WeaponImage1";
            this.WeaponImage1.Size = new System.Drawing.Size(50, 50);
            this.WeaponImage1.TabIndex = 19;
            this.WeaponImage1.TabStop = false;
            this.WeaponImage1.Visible = false;
            this.WeaponImage1.Click += new System.EventHandler(this.WeaponImage1_Click);
            // 
            // WeaponImage2
            // 
            this.WeaponImage2.BackColor = System.Drawing.Color.Transparent;
            this.WeaponImage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WeaponImage2.Location = new System.Drawing.Point(145, 51);
            this.WeaponImage2.Name = "WeaponImage2";
            this.WeaponImage2.Size = new System.Drawing.Size(50, 50);
            this.WeaponImage2.TabIndex = 20;
            this.WeaponImage2.TabStop = false;
            this.WeaponImage2.Visible = false;
            this.WeaponImage2.Click += new System.EventHandler(this.WeaponImage2_Click);
            // 
            // WeaponImage3
            // 
            this.WeaponImage3.BackColor = System.Drawing.Color.Transparent;
            this.WeaponImage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WeaponImage3.Location = new System.Drawing.Point(206, 51);
            this.WeaponImage3.Name = "WeaponImage3";
            this.WeaponImage3.Size = new System.Drawing.Size(50, 50);
            this.WeaponImage3.TabIndex = 21;
            this.WeaponImage3.TabStop = false;
            this.WeaponImage3.Visible = false;
            this.WeaponImage3.Click += new System.EventHandler(this.WeaponImage3_Click);
            // 
            // playerImage
            // 
            this.playerImage.BackColor = System.Drawing.Color.Transparent;
            this.playerImage.ImageLocation = "";
            this.playerImage.Location = new System.Drawing.Point(89, 139);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(50, 50);
            this.playerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playerImage.TabIndex = 25;
            this.playerImage.TabStop = false;
            // 
            // PlayerHpLabel
            // 
            this.PlayerHpLabel.AutoSize = true;
            this.PlayerHpLabel.Location = new System.Drawing.Point(691, 318);
            this.PlayerHpLabel.Name = "PlayerHpLabel";
            this.PlayerHpLabel.Size = new System.Drawing.Size(0, 12);
            this.PlayerHpLabel.TabIndex = 15;
            // 
            // BatHpLabel
            // 
            this.BatHpLabel.AutoSize = true;
            this.BatHpLabel.Location = new System.Drawing.Point(691, 342);
            this.BatHpLabel.Name = "BatHpLabel";
            this.BatHpLabel.Size = new System.Drawing.Size(0, 12);
            this.BatHpLabel.TabIndex = 16;
            // 
            // GhostHpLabel
            // 
            this.GhostHpLabel.AutoSize = true;
            this.GhostHpLabel.Location = new System.Drawing.Point(691, 372);
            this.GhostHpLabel.Name = "GhostHpLabel";
            this.GhostHpLabel.Size = new System.Drawing.Size(0, 12);
            this.GhostHpLabel.TabIndex = 17;
            // 
            // GhoulHpLabel
            // 
            this.GhoulHpLabel.AutoSize = true;
            this.GhoulHpLabel.Location = new System.Drawing.Point(691, 400);
            this.GhoulHpLabel.Name = "GhoulHpLabel";
            this.GhoulHpLabel.Size = new System.Drawing.Size(0, 12);
            this.GhoulHpLabel.TabIndex = 18;
            // 
            // BatImage1
            // 
            this.BatImage1.BackColor = System.Drawing.Color.Transparent;
            this.BatImage1.Enabled = false;
            this.BatImage1.ImageLocation = "";
            this.BatImage1.Location = new System.Drawing.Point(284, 51);
            this.BatImage1.Name = "BatImage1";
            this.BatImage1.Size = new System.Drawing.Size(50, 50);
            this.BatImage1.TabIndex = 26;
            this.BatImage1.TabStop = false;
            this.BatImage1.Visible = false;
            this.BatImage1.Click += new System.EventHandler(this.BatImage1_Click);
            // 
            // GhostImage1
            // 
            this.GhostImage1.BackColor = System.Drawing.Color.Transparent;
            this.GhostImage1.Enabled = false;
            this.GhostImage1.ImageLocation = "";
            this.GhostImage1.Location = new System.Drawing.Point(340, 51);
            this.GhostImage1.Name = "GhostImage1";
            this.GhostImage1.Size = new System.Drawing.Size(50, 50);
            this.GhostImage1.TabIndex = 27;
            this.GhostImage1.TabStop = false;
            this.GhostImage1.Visible = false;
            // 
            // GhoulImage1
            // 
            this.GhoulImage1.BackColor = System.Drawing.Color.Transparent;
            this.GhoulImage1.Enabled = false;
            this.GhoulImage1.ImageLocation = "";
            this.GhoulImage1.Location = new System.Drawing.Point(396, 51);
            this.GhoulImage1.Name = "GhoulImage1";
            this.GhoulImage1.Size = new System.Drawing.Size(50, 50);
            this.GhoulImage1.TabIndex = 28;
            this.GhoulImage1.TabStop = false;
            this.GhoulImage1.Visible = false;
            // 
            // PopImage
            // 
            this.PopImage.BackColor = System.Drawing.Color.Transparent;
            this.PopImage.ImageLocation = "";
            this.PopImage.Location = new System.Drawing.Point(452, 60);
            this.PopImage.Name = "PopImage";
            this.PopImage.Size = new System.Drawing.Size(24, 23);
            this.PopImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PopImage.TabIndex = 29;
            this.PopImage.TabStop = false;
            this.PopImage.Visible = false;
            // 
            // PostionImage1
            // 
            this.PostionImage1.BackColor = System.Drawing.Color.Transparent;
            this.PostionImage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PostionImage1.Location = new System.Drawing.Point(206, 107);
            this.PostionImage1.Name = "PostionImage1";
            this.PostionImage1.Size = new System.Drawing.Size(50, 50);
            this.PostionImage1.TabIndex = 30;
            this.PostionImage1.TabStop = false;
            this.PostionImage1.Visible = false;
            this.PostionImage1.Click += new System.EventHandler(this.PostionImage1_Click);
            // 
            // PostionImage2
            // 
            this.PostionImage2.BackColor = System.Drawing.Color.Transparent;
            this.PostionImage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PostionImage2.Location = new System.Drawing.Point(206, 175);
            this.PostionImage2.Name = "PostionImage2";
            this.PostionImage2.Size = new System.Drawing.Size(50, 50);
            this.PostionImage2.TabIndex = 31;
            this.PostionImage2.TabStop = false;
            this.PostionImage2.Visible = false;
            this.PostionImage2.Click += new System.EventHandler(this.PostionImage2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.PostionImage2);
            this.Controls.Add(this.PostionImage1);
            this.Controls.Add(this.PopImage);
            this.Controls.Add(this.GhoulImage1);
            this.Controls.Add(this.GhostImage1);
            this.Controls.Add(this.BatImage1);
            this.Controls.Add(this.playerImage);
            this.Controls.Add(this.WeaponImage3);
            this.Controls.Add(this.WeaponImage2);
            this.Controls.Add(this.WeaponImage1);
            this.Controls.Add(this.GhoulHpLabel);
            this.Controls.Add(this.GhostHpLabel);
            this.Controls.Add(this.BatHpLabel);
            this.Controls.Add(this.PlayerHpLabel);
            this.Controls.Add(this.GhoulLabel);
            this.Controls.Add(this.GhostLabel);
            this.Controls.Add(this.BatLabel);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.AttackDown);
            this.Controls.Add(this.AttackRight);
            this.Controls.Add(this.AttackLeft);
            this.Controls.Add(this.AttackUp);
            this.Controls.Add(this.AttackLabel);
            this.Controls.Add(this.MoveDown);
            this.Controls.Add(this.MoveRight);
            this.Controls.Add(this.MoveLeft);
            this.Controls.Add(this.MoveUp);
            this.Controls.Add(this.MoveLabel);
            this.Name = "MainForm";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeaponImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostionImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostionImage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MoveLabel;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MoveLeft;
        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Label AttackLabel;
        private System.Windows.Forms.Button AttackDown;
        private System.Windows.Forms.Button AttackRight;
        private System.Windows.Forms.Button AttackLeft;
        private System.Windows.Forms.Button AttackUp;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label BatLabel;
        private System.Windows.Forms.Label GhostLabel;
        private System.Windows.Forms.Label GhoulLabel;
        private System.Windows.Forms.PictureBox WeaponImage1;
        private System.Windows.Forms.PictureBox WeaponImage2;
        private System.Windows.Forms.PictureBox WeaponImage3;
        private System.Windows.Forms.PictureBox playerImage;
        private System.Windows.Forms.Label PlayerHpLabel;
        private System.Windows.Forms.Label BatHpLabel;
        private System.Windows.Forms.Label GhostHpLabel;
        private System.Windows.Forms.Label GhoulHpLabel;
        private System.Windows.Forms.PictureBox BatImage1;
        private System.Windows.Forms.PictureBox GhostImage1;
        private System.Windows.Forms.PictureBox GhoulImage1;
        private System.Windows.Forms.PictureBox PopImage;
        private System.Windows.Forms.PictureBox PostionImage1;
        private System.Windows.Forms.PictureBox PostionImage2;
    }
}