namespace PracticeQuest
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
            this.AtkUp = new System.Windows.Forms.Button();
            this.AtkLeft = new System.Windows.Forms.Button();
            this.AtkRight = new System.Windows.Forms.Button();
            this.AtkDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labPlayerHp = new System.Windows.Forms.Label();
            this.labBatHp = new System.Windows.Forms.Label();
            this.labGhostHp = new System.Windows.Forms.Label();
            this.labGhoulHp = new System.Windows.Forms.Label();
            this.labPlayer = new System.Windows.Forms.Label();
            this.labBat = new System.Windows.Forms.Label();
            this.labGhost = new System.Windows.Forms.Label();
            this.labGhoul = new System.Windows.Forms.Label();
            this.InventorySword = new System.Windows.Forms.PictureBox();
            this.InventoryBluePotion = new System.Windows.Forms.PictureBox();
            this.InventoryBow = new System.Windows.Forms.PictureBox();
            this.InventoryRedPotion = new System.Windows.Forms.PictureBox();
            this.InventoryMace = new System.Windows.Forms.PictureBox();
            this.RoomPlayer = new System.Windows.Forms.PictureBox();
            this.RoomSword = new System.Windows.Forms.PictureBox();
            this.RoomBat = new System.Windows.Forms.PictureBox();
            this.RoomGhoul = new System.Windows.Forms.PictureBox();
            this.RoomGhost = new System.Windows.Forms.PictureBox();
            this.RoomBow = new System.Windows.Forms.PictureBox();
            this.RoomRedPotion = new System.Windows.Forms.PictureBox();
            this.RoomBluePotion = new System.Windows.Forms.PictureBox();
            this.RoomMace = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.HitBg = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventorySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGhoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomMace)).BeginInit();
            this.SuspendLayout();
            // 
            // AtkUp
            // 
            this.AtkUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AtkUp.Location = new System.Drawing.Point(660, 159);
            this.AtkUp.Name = "AtkUp";
            this.AtkUp.Size = new System.Drawing.Size(72, 27);
            this.AtkUp.TabIndex = 0;
            this.AtkUp.Text = "Up";
            this.AtkUp.UseVisualStyleBackColor = true;
            this.AtkUp.Click += new System.EventHandler(this.AtkUp_Click);
            // 
            // AtkLeft
            // 
            this.AtkLeft.Location = new System.Drawing.Point(613, 192);
            this.AtkLeft.Name = "AtkLeft";
            this.AtkLeft.Size = new System.Drawing.Size(72, 27);
            this.AtkLeft.TabIndex = 0;
            this.AtkLeft.Text = "Left";
            this.AtkLeft.UseVisualStyleBackColor = true;
            this.AtkLeft.Click += new System.EventHandler(this.AtkLeft_Click);
            // 
            // AtkRight
            // 
            this.AtkRight.Location = new System.Drawing.Point(710, 192);
            this.AtkRight.Name = "AtkRight";
            this.AtkRight.Size = new System.Drawing.Size(72, 27);
            this.AtkRight.TabIndex = 0;
            this.AtkRight.Text = "Right";
            this.AtkRight.UseVisualStyleBackColor = true;
            this.AtkRight.Click += new System.EventHandler(this.AtkRight_Click);
            // 
            // AtkDown
            // 
            this.AtkDown.Location = new System.Drawing.Point(660, 225);
            this.AtkDown.Name = "AtkDown";
            this.AtkDown.Size = new System.Drawing.Size(72, 27);
            this.AtkDown.TabIndex = 0;
            this.AtkDown.Text = "Down";
            this.AtkDown.UseVisualStyleBackColor = true;
            this.AtkDown.Click += new System.EventHandler(this.AtkDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attack";
            // 
            // MoveUp
            // 
            this.MoveUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MoveUp.Location = new System.Drawing.Point(660, 33);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(72, 27);
            this.MoveUp.TabIndex = 0;
            this.MoveUp.Text = "Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveLeft
            // 
            this.MoveLeft.Location = new System.Drawing.Point(613, 66);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(72, 27);
            this.MoveLeft.TabIndex = 0;
            this.MoveLeft.Text = "Left";
            this.MoveLeft.UseVisualStyleBackColor = true;
            this.MoveLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // MoveRight
            // 
            this.MoveRight.Location = new System.Drawing.Point(710, 66);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(72, 27);
            this.MoveRight.TabIndex = 0;
            this.MoveRight.Text = "Right";
            this.MoveRight.UseVisualStyleBackColor = true;
            this.MoveRight.Click += new System.EventHandler(this.MoveRight_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(660, 99);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(72, 27);
            this.MoveDown.TabIndex = 0;
            this.MoveDown.Text = "Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Move";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.08989F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.91011F));
            this.tableLayoutPanel1.Controls.Add(this.labPlayerHp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labBatHp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labGhostHp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labGhoulHp, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labPlayer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labBat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labGhost, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labGhoul, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(613, 271);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(179, 114);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // labPlayerHp
            // 
            this.labPlayerHp.AutoSize = true;
            this.labPlayerHp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labPlayerHp.Location = new System.Drawing.Point(53, 0);
            this.labPlayerHp.Name = "labPlayerHp";
            this.labPlayerHp.Size = new System.Drawing.Size(84, 14);
            this.labPlayerHp.TabIndex = 1;
            this.labPlayerHp.Text = "playerHitPoint";
            // 
            // labBatHp
            // 
            this.labBatHp.AutoSize = true;
            this.labBatHp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labBatHp.Location = new System.Drawing.Point(53, 28);
            this.labBatHp.Name = "labBatHp";
            this.labBatHp.Size = new System.Drawing.Size(66, 14);
            this.labBatHp.TabIndex = 2;
            this.labBatHp.Text = "batHitPoint";
            // 
            // labGhostHp
            // 
            this.labGhostHp.AutoSize = true;
            this.labGhostHp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labGhostHp.Location = new System.Drawing.Point(53, 56);
            this.labGhostHp.Name = "labGhostHp";
            this.labGhostHp.Size = new System.Drawing.Size(13, 14);
            this.labGhostHp.TabIndex = 3;
            this.labGhostHp.Text = "0";
            // 
            // labGhoulHp
            // 
            this.labGhoulHp.AutoSize = true;
            this.labGhoulHp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labGhoulHp.Location = new System.Drawing.Point(53, 84);
            this.labGhoulHp.Name = "labGhoulHp";
            this.labGhoulHp.Size = new System.Drawing.Size(13, 14);
            this.labGhoulHp.TabIndex = 4;
            this.labGhoulHp.Text = "0";
            // 
            // labPlayer
            // 
            this.labPlayer.AutoSize = true;
            this.labPlayer.Location = new System.Drawing.Point(3, 0);
            this.labPlayer.Name = "labPlayer";
            this.labPlayer.Size = new System.Drawing.Size(41, 12);
            this.labPlayer.TabIndex = 0;
            this.labPlayer.Text = "Player";
            // 
            // labBat
            // 
            this.labBat.AutoSize = true;
            this.labBat.Location = new System.Drawing.Point(3, 28);
            this.labBat.Name = "labBat";
            this.labBat.Size = new System.Drawing.Size(23, 12);
            this.labBat.TabIndex = 0;
            this.labBat.Text = "Bat";
            // 
            // labGhost
            // 
            this.labGhost.AutoSize = true;
            this.labGhost.Location = new System.Drawing.Point(3, 56);
            this.labGhost.Name = "labGhost";
            this.labGhost.Size = new System.Drawing.Size(38, 12);
            this.labGhost.TabIndex = 0;
            this.labGhost.Text = "Ghost";
            // 
            // labGhoul
            // 
            this.labGhoul.AutoSize = true;
            this.labGhoul.Location = new System.Drawing.Point(3, 84);
            this.labGhoul.Name = "labGhoul";
            this.labGhoul.Size = new System.Drawing.Size(38, 12);
            this.labGhoul.TabIndex = 0;
            this.labGhoul.Text = "Ghoul";
            // 
            // InventorySword
            // 
            this.InventorySword.BackColor = System.Drawing.Color.Transparent;
            this.InventorySword.Image = global::PracticeQuest.Properties.Resources.sword;
            this.InventorySword.Location = new System.Drawing.Point(79, 320);
            this.InventorySword.Name = "InventorySword";
            this.InventorySword.Size = new System.Drawing.Size(50, 50);
            this.InventorySword.TabIndex = 3;
            this.InventorySword.TabStop = false;
            this.InventorySword.Click += new System.EventHandler(this.InventorySword_Click);
            // 
            // InventoryBluePotion
            // 
            this.InventoryBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.InventoryBluePotion.Image = global::PracticeQuest.Properties.Resources.potion_blue;
            this.InventoryBluePotion.Location = new System.Drawing.Point(135, 320);
            this.InventoryBluePotion.Name = "InventoryBluePotion";
            this.InventoryBluePotion.Size = new System.Drawing.Size(50, 50);
            this.InventoryBluePotion.TabIndex = 3;
            this.InventoryBluePotion.TabStop = false;
            this.InventoryBluePotion.Click += new System.EventHandler(this.InventoryBluePotion_Click);
            // 
            // InventoryBow
            // 
            this.InventoryBow.BackColor = System.Drawing.Color.Transparent;
            this.InventoryBow.Image = global::PracticeQuest.Properties.Resources.bow;
            this.InventoryBow.Location = new System.Drawing.Point(191, 320);
            this.InventoryBow.Name = "InventoryBow";
            this.InventoryBow.Size = new System.Drawing.Size(50, 50);
            this.InventoryBow.TabIndex = 3;
            this.InventoryBow.TabStop = false;
            this.InventoryBow.Click += new System.EventHandler(this.InventoryBow_Click);
            // 
            // InventoryRedPotion
            // 
            this.InventoryRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.InventoryRedPotion.Image = global::PracticeQuest.Properties.Resources.potion_red;
            this.InventoryRedPotion.Location = new System.Drawing.Point(247, 320);
            this.InventoryRedPotion.Name = "InventoryRedPotion";
            this.InventoryRedPotion.Size = new System.Drawing.Size(50, 50);
            this.InventoryRedPotion.TabIndex = 3;
            this.InventoryRedPotion.TabStop = false;
            this.InventoryRedPotion.Click += new System.EventHandler(this.InventoryRedPotion_Click);
            // 
            // InventoryMace
            // 
            this.InventoryMace.BackColor = System.Drawing.Color.Transparent;
            this.InventoryMace.Image = global::PracticeQuest.Properties.Resources.mace;
            this.InventoryMace.Location = new System.Drawing.Point(303, 320);
            this.InventoryMace.Name = "InventoryMace";
            this.InventoryMace.Size = new System.Drawing.Size(50, 50);
            this.InventoryMace.TabIndex = 3;
            this.InventoryMace.TabStop = false;
            this.InventoryMace.Click += new System.EventHandler(this.InventoryMace_Click);
            // 
            // RoomPlayer
            // 
            this.RoomPlayer.BackColor = System.Drawing.Color.Transparent;
            this.RoomPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RoomPlayer.Image = global::PracticeQuest.Properties.Resources.player;
            this.RoomPlayer.Location = new System.Drawing.Point(79, 63);
            this.RoomPlayer.Name = "RoomPlayer";
            this.RoomPlayer.Size = new System.Drawing.Size(30, 30);
            this.RoomPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomPlayer.TabIndex = 3;
            this.RoomPlayer.TabStop = false;
            // 
            // RoomSword
            // 
            this.RoomSword.BackColor = System.Drawing.Color.Transparent;
            this.RoomSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RoomSword.Image = global::PracticeQuest.Properties.Resources.sword;
            this.RoomSword.Location = new System.Drawing.Point(115, 63);
            this.RoomSword.Name = "RoomSword";
            this.RoomSword.Size = new System.Drawing.Size(30, 30);
            this.RoomSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomSword.TabIndex = 3;
            this.RoomSword.TabStop = false;
            // 
            // RoomBat
            // 
            this.RoomBat.BackColor = System.Drawing.Color.Transparent;
            this.RoomBat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RoomBat.Image = global::PracticeQuest.Properties.Resources.bat;
            this.RoomBat.Location = new System.Drawing.Point(151, 63);
            this.RoomBat.Name = "RoomBat";
            this.RoomBat.Size = new System.Drawing.Size(30, 30);
            this.RoomBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomBat.TabIndex = 3;
            this.RoomBat.TabStop = false;
            // 
            // RoomGhoul
            // 
            this.RoomGhoul.BackColor = System.Drawing.Color.Transparent;
            this.RoomGhoul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RoomGhoul.Image = global::PracticeQuest.Properties.Resources.ghoul;
            this.RoomGhoul.Location = new System.Drawing.Point(187, 63);
            this.RoomGhoul.Name = "RoomGhoul";
            this.RoomGhoul.Size = new System.Drawing.Size(30, 30);
            this.RoomGhoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomGhoul.TabIndex = 3;
            this.RoomGhoul.TabStop = false;
            // 
            // RoomGhost
            // 
            this.RoomGhost.BackColor = System.Drawing.Color.Transparent;
            this.RoomGhost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RoomGhost.Image = global::PracticeQuest.Properties.Resources.ghost;
            this.RoomGhost.Location = new System.Drawing.Point(223, 63);
            this.RoomGhost.Name = "RoomGhost";
            this.RoomGhost.Size = new System.Drawing.Size(30, 30);
            this.RoomGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomGhost.TabIndex = 3;
            this.RoomGhost.TabStop = false;
            // 
            // RoomBow
            // 
            this.RoomBow.BackColor = System.Drawing.Color.Transparent;
            this.RoomBow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RoomBow.Image = global::PracticeQuest.Properties.Resources.bow;
            this.RoomBow.Location = new System.Drawing.Point(259, 63);
            this.RoomBow.Name = "RoomBow";
            this.RoomBow.Size = new System.Drawing.Size(30, 30);
            this.RoomBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomBow.TabIndex = 3;
            this.RoomBow.TabStop = false;
            // 
            // RoomRedPotion
            // 
            this.RoomRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.RoomRedPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RoomRedPotion.Image = global::PracticeQuest.Properties.Resources.potion_red;
            this.RoomRedPotion.Location = new System.Drawing.Point(295, 63);
            this.RoomRedPotion.Name = "RoomRedPotion";
            this.RoomRedPotion.Size = new System.Drawing.Size(30, 30);
            this.RoomRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomRedPotion.TabIndex = 3;
            this.RoomRedPotion.TabStop = false;
            // 
            // RoomBluePotion
            // 
            this.RoomBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.RoomBluePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RoomBluePotion.Image = global::PracticeQuest.Properties.Resources.potion_blue;
            this.RoomBluePotion.Location = new System.Drawing.Point(331, 63);
            this.RoomBluePotion.Name = "RoomBluePotion";
            this.RoomBluePotion.Size = new System.Drawing.Size(30, 30);
            this.RoomBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomBluePotion.TabIndex = 3;
            this.RoomBluePotion.TabStop = false;
            // 
            // RoomMace
            // 
            this.RoomMace.BackColor = System.Drawing.Color.Transparent;
            this.RoomMace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RoomMace.Image = global::PracticeQuest.Properties.Resources.mace;
            this.RoomMace.Location = new System.Drawing.Point(367, 63);
            this.RoomMace.Name = "RoomMace";
            this.RoomMace.Size = new System.Drawing.Size(30, 30);
            this.RoomMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomMace.TabIndex = 3;
            this.RoomMace.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(611, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "HP";
            // 
            // HitBg
            // 
            this.HitBg.BackColor = System.Drawing.Color.Red;
            this.HitBg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HitBg.Location = new System.Drawing.Point(151, 91);
            this.HitBg.Name = "HitBg";
            this.HitBg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HitBg.Size = new System.Drawing.Size(295, 128);
            this.HitBg.TabIndex = 5;
            this.HitBg.Text = "\"Hit:\"";
            this.HitBg.UseVisualStyleBackColor = false;
            this.HitBg.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::PracticeQuest.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(794, 397);
            this.Controls.Add(this.HitBg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RoomPlayer);
            this.Controls.Add(this.RoomMace);
            this.Controls.Add(this.RoomBluePotion);
            this.Controls.Add(this.RoomRedPotion);
            this.Controls.Add(this.RoomBow);
            this.Controls.Add(this.RoomGhost);
            this.Controls.Add(this.RoomGhoul);
            this.Controls.Add(this.RoomBat);
            this.Controls.Add(this.RoomSword);
            this.Controls.Add(this.InventoryMace);
            this.Controls.Add(this.InventoryRedPotion);
            this.Controls.Add(this.InventoryBow);
            this.Controls.Add(this.InventoryBluePotion);
            this.Controls.Add(this.InventorySword);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoveDown);
            this.Controls.Add(this.AtkDown);
            this.Controls.Add(this.MoveRight);
            this.Controls.Add(this.MoveLeft);
            this.Controls.Add(this.AtkRight);
            this.Controls.Add(this.MoveUp);
            this.Controls.Add(this.AtkLeft);
            this.Controls.Add(this.AtkUp);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventorySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGhoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomMace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AtkUp;
        private System.Windows.Forms.Button AtkLeft;
        private System.Windows.Forms.Button AtkRight;
        private System.Windows.Forms.Button AtkDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MoveLeft;
        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox InventoryBluePotion;
        private System.Windows.Forms.PictureBox InventoryBow;
        private System.Windows.Forms.PictureBox InventoryRedPotion;
        private System.Windows.Forms.PictureBox InventoryMace;
        private System.Windows.Forms.PictureBox RoomPlayer;
        private System.Windows.Forms.PictureBox RoomSword;
        private System.Windows.Forms.PictureBox RoomBat;
        private System.Windows.Forms.PictureBox RoomGhoul;
        private System.Windows.Forms.PictureBox RoomGhost;
        private System.Windows.Forms.PictureBox RoomBow;
        private System.Windows.Forms.PictureBox RoomRedPotion;
        private System.Windows.Forms.PictureBox RoomBluePotion;
        private System.Windows.Forms.PictureBox RoomMace;
        private System.Windows.Forms.Label labPlayerHp;
        private System.Windows.Forms.Label labBatHp;
        private System.Windows.Forms.Label labGhostHp;
        private System.Windows.Forms.Label labGhoulHp;
        private System.Windows.Forms.Label labPlayer;
        private System.Windows.Forms.Label labBat;
        private System.Windows.Forms.Label labGhost;
        private System.Windows.Forms.Label labGhoul;
        private System.Windows.Forms.PictureBox InventorySword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button HitBg;
    }
}

