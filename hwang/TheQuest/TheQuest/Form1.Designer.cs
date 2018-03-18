namespace TheQuest
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
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Sword1 = new System.Windows.Forms.PictureBox();
            this.Bat1 = new System.Windows.Forms.PictureBox();
            this.Ghoul1 = new System.Windows.Forms.PictureBox();
            this.Ghost1 = new System.Windows.Forms.PictureBox();
            this.Bow1 = new System.Windows.Forms.PictureBox();
            this.BluePotion1 = new System.Windows.Forms.PictureBox();
            this.RedPotion1 = new System.Windows.Forms.PictureBox();
            this.Mace1 = new System.Windows.Forms.PictureBox();
            this.Inventory1 = new System.Windows.Forms.PictureBox();
            this.Inventory2 = new System.Windows.Forms.PictureBox();
            this.Inventory3 = new System.Windows.Forms.PictureBox();
            this.Inventory4 = new System.Windows.Forms.PictureBox();
            this.Inventory5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AttackUP = new System.Windows.Forms.Button();
            this.AttackLeft = new System.Windows.Forms.Button();
            this.AttackRight = new System.Windows.Forms.Button();
            this.AttackDown = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PlayerHitPoint = new System.Windows.Forms.Label();
            this.BatHitPoint = new System.Windows.Forms.Label();
            this.GhostHitPoint = new System.Windows.Forms.Label();
            this.GhoulHitPoint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sword1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghoul1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory5)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Transparent;
            this.Player1.Image = global::TheQuest.Properties.Resources.player;
            this.Player1.Location = new System.Drawing.Point(141, 87);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(30, 30);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player1.TabIndex = 1;
            this.Player1.TabStop = false;
            // 
            // Sword1
            // 
            this.Sword1.BackColor = System.Drawing.Color.Transparent;
            this.Sword1.Image = global::TheQuest.Properties.Resources.sword;
            this.Sword1.Location = new System.Drawing.Point(177, 87);
            this.Sword1.Name = "Sword1";
            this.Sword1.Size = new System.Drawing.Size(30, 30);
            this.Sword1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sword1.TabIndex = 2;
            this.Sword1.TabStop = false;
            // 
            // Bat1
            // 
            this.Bat1.BackColor = System.Drawing.Color.Transparent;
            this.Bat1.Image = global::TheQuest.Properties.Resources.bat;
            this.Bat1.Location = new System.Drawing.Point(213, 87);
            this.Bat1.Name = "Bat1";
            this.Bat1.Size = new System.Drawing.Size(30, 30);
            this.Bat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bat1.TabIndex = 3;
            this.Bat1.TabStop = false;
            // 
            // Ghoul1
            // 
            this.Ghoul1.BackColor = System.Drawing.Color.Transparent;
            this.Ghoul1.Image = global::TheQuest.Properties.Resources.ghoul;
            this.Ghoul1.Location = new System.Drawing.Point(249, 87);
            this.Ghoul1.Name = "Ghoul1";
            this.Ghoul1.Size = new System.Drawing.Size(30, 30);
            this.Ghoul1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ghoul1.TabIndex = 4;
            this.Ghoul1.TabStop = false;
            // 
            // Ghost1
            // 
            this.Ghost1.BackColor = System.Drawing.Color.Transparent;
            this.Ghost1.Image = global::TheQuest.Properties.Resources.ghost;
            this.Ghost1.Location = new System.Drawing.Point(285, 87);
            this.Ghost1.Name = "Ghost1";
            this.Ghost1.Size = new System.Drawing.Size(30, 30);
            this.Ghost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ghost1.TabIndex = 5;
            this.Ghost1.TabStop = false;
            // 
            // Bow1
            // 
            this.Bow1.BackColor = System.Drawing.Color.Transparent;
            this.Bow1.Image = global::TheQuest.Properties.Resources.bow;
            this.Bow1.Location = new System.Drawing.Point(321, 87);
            this.Bow1.Name = "Bow1";
            this.Bow1.Size = new System.Drawing.Size(30, 30);
            this.Bow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bow1.TabIndex = 6;
            this.Bow1.TabStop = false;
            // 
            // BluePotion1
            // 
            this.BluePotion1.BackColor = System.Drawing.Color.Transparent;
            this.BluePotion1.Image = global::TheQuest.Properties.Resources.potion_blue;
            this.BluePotion1.Location = new System.Drawing.Point(357, 87);
            this.BluePotion1.Name = "BluePotion1";
            this.BluePotion1.Size = new System.Drawing.Size(30, 30);
            this.BluePotion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BluePotion1.TabIndex = 7;
            this.BluePotion1.TabStop = false;
            // 
            // RedPotion1
            // 
            this.RedPotion1.BackColor = System.Drawing.Color.Transparent;
            this.RedPotion1.Image = global::TheQuest.Properties.Resources.potion_red;
            this.RedPotion1.Location = new System.Drawing.Point(393, 87);
            this.RedPotion1.Name = "RedPotion1";
            this.RedPotion1.Size = new System.Drawing.Size(30, 30);
            this.RedPotion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedPotion1.TabIndex = 8;
            this.RedPotion1.TabStop = false;
            // 
            // Mace1
            // 
            this.Mace1.BackColor = System.Drawing.Color.Transparent;
            this.Mace1.Image = global::TheQuest.Properties.Resources.mace;
            this.Mace1.Location = new System.Drawing.Point(429, 87);
            this.Mace1.Name = "Mace1";
            this.Mace1.Size = new System.Drawing.Size(30, 30);
            this.Mace1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mace1.TabIndex = 9;
            this.Mace1.TabStop = false;
            // 
            // Inventory1
            // 
            this.Inventory1.BackColor = System.Drawing.Color.Transparent;
            this.Inventory1.Image = global::TheQuest.Properties.Resources.sword;
            this.Inventory1.Location = new System.Drawing.Point(85, 326);
            this.Inventory1.Name = "Inventory1";
            this.Inventory1.Size = new System.Drawing.Size(50, 50);
            this.Inventory1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Inventory1.TabIndex = 10;
            this.Inventory1.TabStop = false;
            this.Inventory1.Click += new System.EventHandler(this.Inventory1_Click);
            // 
            // Inventory2
            // 
            this.Inventory2.BackColor = System.Drawing.Color.Transparent;
            this.Inventory2.Image = global::TheQuest.Properties.Resources.potion_blue;
            this.Inventory2.Location = new System.Drawing.Point(177, 326);
            this.Inventory2.Name = "Inventory2";
            this.Inventory2.Size = new System.Drawing.Size(50, 50);
            this.Inventory2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Inventory2.TabIndex = 11;
            this.Inventory2.TabStop = false;
            this.Inventory2.Click += new System.EventHandler(this.Inventory2_Click);
            // 
            // Inventory3
            // 
            this.Inventory3.BackColor = System.Drawing.Color.Transparent;
            this.Inventory3.Image = global::TheQuest.Properties.Resources.bow;
            this.Inventory3.Location = new System.Drawing.Point(265, 326);
            this.Inventory3.Name = "Inventory3";
            this.Inventory3.Size = new System.Drawing.Size(50, 50);
            this.Inventory3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Inventory3.TabIndex = 12;
            this.Inventory3.TabStop = false;
            this.Inventory3.Click += new System.EventHandler(this.Inventory3_Click);
            // 
            // Inventory4
            // 
            this.Inventory4.BackColor = System.Drawing.Color.Transparent;
            this.Inventory4.Image = global::TheQuest.Properties.Resources.potion_red;
            this.Inventory4.Location = new System.Drawing.Point(357, 326);
            this.Inventory4.Name = "Inventory4";
            this.Inventory4.Size = new System.Drawing.Size(50, 50);
            this.Inventory4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Inventory4.TabIndex = 13;
            this.Inventory4.TabStop = false;
            this.Inventory4.Click += new System.EventHandler(this.Inventory4_Click);
            // 
            // Inventory5
            // 
            this.Inventory5.BackColor = System.Drawing.Color.Transparent;
            this.Inventory5.Image = global::TheQuest.Properties.Resources.mace;
            this.Inventory5.Location = new System.Drawing.Point(450, 326);
            this.Inventory5.Name = "Inventory5";
            this.Inventory5.Size = new System.Drawing.Size(50, 50);
            this.Inventory5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Inventory5.TabIndex = 14;
            this.Inventory5.TabStop = false;
            this.Inventory5.Click += new System.EventHandler(this.Inventory5_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Move";
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(676, 48);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(75, 23);
            this.MoveUp.TabIndex = 16;
            this.MoveUp.Text = "Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveLeft
            // 
            this.MoveLeft.Location = new System.Drawing.Point(632, 77);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(75, 23);
            this.MoveLeft.TabIndex = 17;
            this.MoveLeft.Text = "Left";
            this.MoveLeft.UseVisualStyleBackColor = true;
            this.MoveLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // MoveRight
            // 
            this.MoveRight.Location = new System.Drawing.Point(713, 77);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(75, 23);
            this.MoveRight.TabIndex = 18;
            this.MoveRight.Text = "Right";
            this.MoveRight.UseVisualStyleBackColor = true;
            this.MoveRight.Click += new System.EventHandler(this.MoveRight_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(676, 106);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(75, 23);
            this.MoveDown.TabIndex = 19;
            this.MoveDown.Text = "Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "Attack";
            // 
            // AttackUP
            // 
            this.AttackUP.Location = new System.Drawing.Point(676, 175);
            this.AttackUP.Name = "AttackUP";
            this.AttackUP.Size = new System.Drawing.Size(75, 23);
            this.AttackUP.TabIndex = 21;
            this.AttackUP.Text = "Up";
            this.AttackUP.UseVisualStyleBackColor = true;
            this.AttackUP.Click += new System.EventHandler(this.AttackUP_Click);
            // 
            // AttackLeft
            // 
            this.AttackLeft.Location = new System.Drawing.Point(632, 204);
            this.AttackLeft.Name = "AttackLeft";
            this.AttackLeft.Size = new System.Drawing.Size(75, 23);
            this.AttackLeft.TabIndex = 22;
            this.AttackLeft.Text = "Left";
            this.AttackLeft.UseVisualStyleBackColor = true;
            this.AttackLeft.Click += new System.EventHandler(this.AttackLeft_Click);
            // 
            // AttackRight
            // 
            this.AttackRight.Location = new System.Drawing.Point(713, 204);
            this.AttackRight.Name = "AttackRight";
            this.AttackRight.Size = new System.Drawing.Size(75, 23);
            this.AttackRight.TabIndex = 23;
            this.AttackRight.Text = "Right";
            this.AttackRight.UseVisualStyleBackColor = true;
            this.AttackRight.Click += new System.EventHandler(this.AttackRight_Click);
            // 
            // AttackDown
            // 
            this.AttackDown.Location = new System.Drawing.Point(676, 233);
            this.AttackDown.Name = "AttackDown";
            this.AttackDown.Size = new System.Drawing.Size(75, 23);
            this.AttackDown.TabIndex = 24;
            this.AttackDown.Text = "Down";
            this.AttackDown.UseVisualStyleBackColor = true;
            this.AttackDown.Click += new System.EventHandler(this.AttackDown_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PlayerHitPoint, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BatHitPoint, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.GhostHitPoint, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.GhoulHitPoint, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(611, 286);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(188, 123);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bat";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ghost";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ghoul";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerHitPoint
            // 
            this.PlayerHitPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerHitPoint.AutoSize = true;
            this.PlayerHitPoint.Location = new System.Drawing.Point(97, 0);
            this.PlayerHitPoint.Name = "PlayerHitPoint";
            this.PlayerHitPoint.Size = new System.Drawing.Size(88, 30);
            this.PlayerHitPoint.TabIndex = 4;
            this.PlayerHitPoint.Text = "PlayerHitPoint";
            this.PlayerHitPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BatHitPoint
            // 
            this.BatHitPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BatHitPoint.AutoSize = true;
            this.BatHitPoint.Location = new System.Drawing.Point(97, 30);
            this.BatHitPoint.Name = "BatHitPoint";
            this.BatHitPoint.Size = new System.Drawing.Size(88, 30);
            this.BatHitPoint.TabIndex = 5;
            this.BatHitPoint.Text = "BatHitPoint";
            this.BatHitPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GhostHitPoint
            // 
            this.GhostHitPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GhostHitPoint.AutoSize = true;
            this.GhostHitPoint.Location = new System.Drawing.Point(97, 60);
            this.GhostHitPoint.Name = "GhostHitPoint";
            this.GhostHitPoint.Size = new System.Drawing.Size(88, 30);
            this.GhostHitPoint.TabIndex = 6;
            this.GhostHitPoint.Text = "GhostHitPoint";
            this.GhostHitPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GhoulHitPoint
            // 
            this.GhoulHitPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GhoulHitPoint.AutoSize = true;
            this.GhoulHitPoint.Location = new System.Drawing.Point(97, 90);
            this.GhoulHitPoint.Name = "GhoulHitPoint";
            this.GhoulHitPoint.Size = new System.Drawing.Size(88, 33);
            this.GhoulHitPoint.TabIndex = 7;
            this.GhoulHitPoint.Text = "GhoulHitPoint";
            this.GhoulHitPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheQuest.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(826, 465);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AttackDown);
            this.Controls.Add(this.AttackRight);
            this.Controls.Add(this.AttackLeft);
            this.Controls.Add(this.AttackUP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MoveDown);
            this.Controls.Add(this.MoveRight);
            this.Controls.Add(this.MoveLeft);
            this.Controls.Add(this.MoveUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Inventory5);
            this.Controls.Add(this.Inventory4);
            this.Controls.Add(this.Inventory3);
            this.Controls.Add(this.Inventory2);
            this.Controls.Add(this.Inventory1);
            this.Controls.Add(this.Mace1);
            this.Controls.Add(this.RedPotion1);
            this.Controls.Add(this.BluePotion1);
            this.Controls.Add(this.Bow1);
            this.Controls.Add(this.Ghost1);
            this.Controls.Add(this.Ghoul1);
            this.Controls.Add(this.Bat1);
            this.Controls.Add(this.Sword1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sword1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghoul1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory5)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox Sword1;
        private System.Windows.Forms.PictureBox Bat1;
        private System.Windows.Forms.PictureBox Ghoul1;
        private System.Windows.Forms.PictureBox Ghost1;
        private System.Windows.Forms.PictureBox Bow1;
        private System.Windows.Forms.PictureBox BluePotion1;
        private System.Windows.Forms.PictureBox RedPotion1;
        private System.Windows.Forms.PictureBox Mace1;
        private System.Windows.Forms.PictureBox Inventory1;
        private System.Windows.Forms.PictureBox Inventory2;
        private System.Windows.Forms.PictureBox Inventory3;
        private System.Windows.Forms.PictureBox Inventory4;
        private System.Windows.Forms.PictureBox Inventory5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MoveLeft;
        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AttackUP;
        private System.Windows.Forms.Button AttackLeft;
        private System.Windows.Forms.Button AttackRight;
        private System.Windows.Forms.Button AttackDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PlayerHitPoint;
        private System.Windows.Forms.Label BatHitPoint;
        private System.Windows.Forms.Label GhostHitPoint;
        private System.Windows.Forms.Label GhoulHitPoint;
    }
}

