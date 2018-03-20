namespace QuestGameCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Up = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.UpAttack = new System.Windows.Forms.Button();
            this.DownAttack = new System.Windows.Forms.Button();
            this.LeftAttack = new System.Windows.Forms.Button();
            this.RightAttack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PlayerBox = new System.Windows.Forms.PictureBox();
            this.WeaponBox = new System.Windows.Forms.PictureBox();
            this.BatBox = new System.Windows.Forms.PictureBox();
            this.GhoulBox = new System.Windows.Forms.PictureBox();
            this.GhostBox = new System.Windows.Forms.PictureBox();
            this.BowBox = new System.Windows.Forms.PictureBox();
            this.BluePotionBox = new System.Windows.Forms.PictureBox();
            this.RedPotionBox = new System.Windows.Forms.PictureBox();
            this.MaseBox = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Move";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Attack";
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(680, 25);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(78, 23);
            this.Up.TabIndex = 2;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(635, 54);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(78, 23);
            this.Left.TabIndex = 2;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(730, 54);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(78, 23);
            this.Right.TabIndex = 2;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(680, 83);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(78, 23);
            this.Down.TabIndex = 2;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // UpAttack
            // 
            this.UpAttack.Location = new System.Drawing.Point(680, 144);
            this.UpAttack.Name = "UpAttack";
            this.UpAttack.Size = new System.Drawing.Size(78, 23);
            this.UpAttack.TabIndex = 2;
            this.UpAttack.Text = "Up";
            this.UpAttack.UseVisualStyleBackColor = true;
            this.UpAttack.Click += new System.EventHandler(this.UpAttack_Click);
            // 
            // DownAttack
            // 
            this.DownAttack.Location = new System.Drawing.Point(680, 202);
            this.DownAttack.Name = "DownAttack";
            this.DownAttack.Size = new System.Drawing.Size(78, 23);
            this.DownAttack.TabIndex = 2;
            this.DownAttack.Text = "Down";
            this.DownAttack.UseVisualStyleBackColor = true;
            this.DownAttack.Click += new System.EventHandler(this.DownAttack_Click);
            // 
            // LeftAttack
            // 
            this.LeftAttack.Location = new System.Drawing.Point(635, 173);
            this.LeftAttack.Name = "LeftAttack";
            this.LeftAttack.Size = new System.Drawing.Size(78, 23);
            this.LeftAttack.TabIndex = 2;
            this.LeftAttack.Text = "Left";
            this.LeftAttack.UseVisualStyleBackColor = true;
            this.LeftAttack.Click += new System.EventHandler(this.LeftAttack_Click);
            // 
            // RightAttack
            // 
            this.RightAttack.Location = new System.Drawing.Point(730, 173);
            this.RightAttack.Name = "RightAttack";
            this.RightAttack.Size = new System.Drawing.Size(78, 23);
            this.RightAttack.TabIndex = 2;
            this.RightAttack.Text = "Right";
            this.RightAttack.UseVisualStyleBackColor = true;
            this.RightAttack.Click += new System.EventHandler(this.RightAttack_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(617, 239);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.35065F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.64935F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(213, 153);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ghost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "PlayerHP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "BatHP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "GhostHP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "GhoulHP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ghoul";
            // 
            // PlayerBox
            // 
            this.PlayerBox.Image = ((System.Drawing.Image)(resources.GetObject("PlayerBox.Image")));
            this.PlayerBox.Location = new System.Drawing.Point(83, 62);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(34, 33);
            this.PlayerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerBox.TabIndex = 4;
            this.PlayerBox.TabStop = false;
            // 
            // WeaponBox
            // 
            this.WeaponBox.Image = ((System.Drawing.Image)(resources.GetObject("WeaponBox.Image")));
            this.WeaponBox.Location = new System.Drawing.Point(123, 62);
            this.WeaponBox.Name = "WeaponBox";
            this.WeaponBox.Size = new System.Drawing.Size(34, 33);
            this.WeaponBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WeaponBox.TabIndex = 4;
            this.WeaponBox.TabStop = false;
            // 
            // BatBox
            // 
            this.BatBox.Image = ((System.Drawing.Image)(resources.GetObject("BatBox.Image")));
            this.BatBox.Location = new System.Drawing.Point(163, 62);
            this.BatBox.Name = "BatBox";
            this.BatBox.Size = new System.Drawing.Size(34, 33);
            this.BatBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BatBox.TabIndex = 4;
            this.BatBox.TabStop = false;
            // 
            // GhoulBox
            // 
            this.GhoulBox.Image = ((System.Drawing.Image)(resources.GetObject("GhoulBox.Image")));
            this.GhoulBox.Location = new System.Drawing.Point(203, 62);
            this.GhoulBox.Name = "GhoulBox";
            this.GhoulBox.Size = new System.Drawing.Size(34, 33);
            this.GhoulBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GhoulBox.TabIndex = 4;
            this.GhoulBox.TabStop = false;
            // 
            // GhostBox
            // 
            this.GhostBox.Image = ((System.Drawing.Image)(resources.GetObject("GhostBox.Image")));
            this.GhostBox.Location = new System.Drawing.Point(243, 62);
            this.GhostBox.Name = "GhostBox";
            this.GhostBox.Size = new System.Drawing.Size(34, 33);
            this.GhostBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GhostBox.TabIndex = 4;
            this.GhostBox.TabStop = false;
            // 
            // BowBox
            // 
            this.BowBox.Image = ((System.Drawing.Image)(resources.GetObject("BowBox.Image")));
            this.BowBox.Location = new System.Drawing.Point(283, 62);
            this.BowBox.Name = "BowBox";
            this.BowBox.Size = new System.Drawing.Size(34, 33);
            this.BowBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BowBox.TabIndex = 4;
            this.BowBox.TabStop = false;
            // 
            // BluePotionBox
            // 
            this.BluePotionBox.Image = ((System.Drawing.Image)(resources.GetObject("BluePotionBox.Image")));
            this.BluePotionBox.Location = new System.Drawing.Point(323, 62);
            this.BluePotionBox.Name = "BluePotionBox";
            this.BluePotionBox.Size = new System.Drawing.Size(34, 33);
            this.BluePotionBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BluePotionBox.TabIndex = 4;
            this.BluePotionBox.TabStop = false;
            // 
            // RedPotionBox
            // 
            this.RedPotionBox.Image = ((System.Drawing.Image)(resources.GetObject("RedPotionBox.Image")));
            this.RedPotionBox.Location = new System.Drawing.Point(363, 62);
            this.RedPotionBox.Name = "RedPotionBox";
            this.RedPotionBox.Size = new System.Drawing.Size(34, 33);
            this.RedPotionBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedPotionBox.TabIndex = 4;
            this.RedPotionBox.TabStop = false;
            // 
            // MaseBox
            // 
            this.MaseBox.Image = ((System.Drawing.Image)(resources.GetObject("MaseBox.Image")));
            this.MaseBox.Location = new System.Drawing.Point(403, 62);
            this.MaseBox.Name = "MaseBox";
            this.MaseBox.Size = new System.Drawing.Size(34, 33);
            this.MaseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaseBox.TabIndex = 4;
            this.MaseBox.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(86, 316);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(53, 52);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 4;
            this.pictureBox10.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(845, 398);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.RedPotionBox);
            this.Controls.Add(this.BluePotionBox);
            this.Controls.Add(this.GhostBox);
            this.Controls.Add(this.GhoulBox);
            this.Controls.Add(this.BatBox);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.RightAttack);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.LeftAttack);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.DownAttack);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.UpAttack);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeaponBox);
            this.Controls.Add(this.MaseBox);
            this.Controls.Add(this.BowBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button UpAttack;
        private System.Windows.Forms.Button DownAttack;
        private System.Windows.Forms.Button LeftAttack;
        private System.Windows.Forms.Button RightAttack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox PlayerBox;
        private System.Windows.Forms.PictureBox WeaponBox;
        private System.Windows.Forms.PictureBox BatBox;
        private System.Windows.Forms.PictureBox GhoulBox;
        private System.Windows.Forms.PictureBox GhostBox;
        private System.Windows.Forms.PictureBox BowBox;
        private System.Windows.Forms.PictureBox BluePotionBox;
        private System.Windows.Forms.PictureBox RedPotionBox;
        private System.Windows.Forms.PictureBox MaseBox;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}

