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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelGameInfo = new System.Windows.Forms.TableLayoutPanel();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelBat = new System.Windows.Forms.Label();
            this.labelPlayerHP = new System.Windows.Forms.Label();
            this.labelBatHP = new System.Windows.Forms.Label();
            this.labelGhost = new System.Windows.Forms.Label();
            this.labelGhostHP = new System.Windows.Forms.Label();
            this.labelGhoul = new System.Windows.Forms.Label();
            this.labelGhoulHP = new System.Windows.Forms.Label();
            this.labelMove = new System.Windows.Forms.Label();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.labelAttack = new System.Windows.Forms.Label();
            this.buttonAttackUp = new System.Windows.Forms.Button();
            this.buttonAttackLeft = new System.Windows.Forms.Button();
            this.buttonAttackRight = new System.Windows.Forms.Button();
            this.buttonAttackDown = new System.Windows.Forms.Button();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxSword = new System.Windows.Forms.PictureBox();
            this.pictureBoxBat = new System.Windows.Forms.PictureBox();
            this.pictureBoxBow = new System.Windows.Forms.PictureBox();
            this.pictureBoxRedPotion = new System.Windows.Forms.PictureBox();
            this.pictureBoxBluePotion = new System.Windows.Forms.PictureBox();
            this.pictureBoxMace = new System.Windows.Forms.PictureBox();
            this.pictureItemSword = new System.Windows.Forms.PictureBox();
            this.pictureItemBow = new System.Windows.Forms.PictureBox();
            this.pictureItemMace = new System.Windows.Forms.PictureBox();
            this.pictureItemBP = new System.Windows.Forms.PictureBox();
            this.pictureItemRP = new System.Windows.Forms.PictureBox();
            this.pictureBoxGhost = new System.Windows.Forms.PictureBox();
            this.pictureBoxGhoul = new System.Windows.Forms.PictureBox();
            this.panelGameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItemSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItemBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItemMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItemBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItemRP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGhoul)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGameInfo
            // 
            this.panelGameInfo.BackColor = System.Drawing.SystemColors.Control;
            this.panelGameInfo.ColumnCount = 2;
            this.panelGameInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.41237F));
            this.panelGameInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.58763F));
            this.panelGameInfo.Controls.Add(this.labelPlayer, 0, 0);
            this.panelGameInfo.Controls.Add(this.labelBat, 0, 1);
            this.panelGameInfo.Controls.Add(this.labelPlayerHP, 1, 0);
            this.panelGameInfo.Controls.Add(this.labelBatHP, 1, 1);
            this.panelGameInfo.Controls.Add(this.labelGhost, 0, 2);
            this.panelGameInfo.Controls.Add(this.labelGhostHP, 1, 2);
            this.panelGameInfo.Controls.Add(this.labelGhoul, 0, 3);
            this.panelGameInfo.Controls.Add(this.labelGhoulHP, 1, 3);
            this.panelGameInfo.Location = new System.Drawing.Point(601, 267);
            this.panelGameInfo.Name = "panelGameInfo";
            this.panelGameInfo.RowCount = 4;
            this.panelGameInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelGameInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelGameInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelGameInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelGameInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelGameInfo.Size = new System.Drawing.Size(194, 132);
            this.panelGameInfo.TabIndex = 0;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(3, 0);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(41, 12);
            this.labelPlayer.TabIndex = 0;
            this.labelPlayer.Text = "Player";
            // 
            // labelBat
            // 
            this.labelBat.AutoSize = true;
            this.labelBat.Location = new System.Drawing.Point(3, 33);
            this.labelBat.Name = "labelBat";
            this.labelBat.Size = new System.Drawing.Size(23, 12);
            this.labelBat.TabIndex = 0;
            this.labelBat.Text = "Bat";
            // 
            // labelPlayerHP
            // 
            this.labelPlayerHP.AutoSize = true;
            this.labelPlayerHP.Location = new System.Drawing.Point(61, 0);
            this.labelPlayerHP.Name = "labelPlayerHP";
            this.labelPlayerHP.Size = new System.Drawing.Size(57, 12);
            this.labelPlayerHP.TabIndex = 0;
            this.labelPlayerHP.Text = "PlayerHP";
            // 
            // labelBatHP
            // 
            this.labelBatHP.AutoSize = true;
            this.labelBatHP.Location = new System.Drawing.Point(61, 33);
            this.labelBatHP.Name = "labelBatHP";
            this.labelBatHP.Size = new System.Drawing.Size(39, 12);
            this.labelBatHP.TabIndex = 0;
            this.labelBatHP.Text = "BatHP";
            // 
            // labelGhost
            // 
            this.labelGhost.AutoSize = true;
            this.labelGhost.Location = new System.Drawing.Point(3, 66);
            this.labelGhost.Name = "labelGhost";
            this.labelGhost.Size = new System.Drawing.Size(38, 12);
            this.labelGhost.TabIndex = 0;
            this.labelGhost.Text = "Ghost";
            // 
            // labelGhostHP
            // 
            this.labelGhostHP.AutoSize = true;
            this.labelGhostHP.Location = new System.Drawing.Point(61, 66);
            this.labelGhostHP.Name = "labelGhostHP";
            this.labelGhostHP.Size = new System.Drawing.Size(54, 12);
            this.labelGhostHP.TabIndex = 0;
            this.labelGhostHP.Text = "GhostHP";
            // 
            // labelGhoul
            // 
            this.labelGhoul.AutoSize = true;
            this.labelGhoul.Location = new System.Drawing.Point(3, 99);
            this.labelGhoul.Name = "labelGhoul";
            this.labelGhoul.Size = new System.Drawing.Size(38, 12);
            this.labelGhoul.TabIndex = 0;
            this.labelGhoul.Text = "Ghoul";
            // 
            // labelGhoulHP
            // 
            this.labelGhoulHP.AutoSize = true;
            this.labelGhoulHP.Location = new System.Drawing.Point(61, 99);
            this.labelGhoulHP.Name = "labelGhoulHP";
            this.labelGhoulHP.Size = new System.Drawing.Size(54, 12);
            this.labelGhoulHP.TabIndex = 0;
            this.labelGhoulHP.Text = "GhoulHP";
            // 
            // labelMove
            // 
            this.labelMove.AutoSize = true;
            this.labelMove.Location = new System.Drawing.Point(609, 9);
            this.labelMove.Name = "labelMove";
            this.labelMove.Size = new System.Drawing.Size(36, 12);
            this.labelMove.TabIndex = 1;
            this.labelMove.Text = "Move";
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Location = new System.Drawing.Point(657, 26);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(53, 28);
            this.buttonMoveUp.TabIndex = 2;
            this.buttonMoveUp.Text = "Up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.Location = new System.Drawing.Point(626, 60);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(53, 28);
            this.buttonMoveLeft.TabIndex = 3;
            this.buttonMoveLeft.Text = "Left";
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.Location = new System.Drawing.Point(685, 60);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(53, 28);
            this.buttonMoveRight.TabIndex = 4;
            this.buttonMoveRight.Text = "Right";
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Location = new System.Drawing.Point(657, 94);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(53, 28);
            this.buttonMoveDown.TabIndex = 5;
            this.buttonMoveDown.Text = "Down";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // labelAttack
            // 
            this.labelAttack.AutoSize = true;
            this.labelAttack.Location = new System.Drawing.Point(609, 134);
            this.labelAttack.Name = "labelAttack";
            this.labelAttack.Size = new System.Drawing.Size(39, 12);
            this.labelAttack.TabIndex = 6;
            this.labelAttack.Text = "Attack";
            // 
            // buttonAttackUp
            // 
            this.buttonAttackUp.Location = new System.Drawing.Point(657, 146);
            this.buttonAttackUp.Name = "buttonAttackUp";
            this.buttonAttackUp.Size = new System.Drawing.Size(53, 28);
            this.buttonAttackUp.TabIndex = 7;
            this.buttonAttackUp.Text = "Up";
            this.buttonAttackUp.UseVisualStyleBackColor = true;
            this.buttonAttackUp.Click += new System.EventHandler(this.buttonAttackUp_Click);
            // 
            // buttonAttackLeft
            // 
            this.buttonAttackLeft.Location = new System.Drawing.Point(626, 180);
            this.buttonAttackLeft.Name = "buttonAttackLeft";
            this.buttonAttackLeft.Size = new System.Drawing.Size(53, 28);
            this.buttonAttackLeft.TabIndex = 8;
            this.buttonAttackLeft.Text = "Left";
            this.buttonAttackLeft.UseVisualStyleBackColor = true;
            this.buttonAttackLeft.Click += new System.EventHandler(this.buttonAttackLeft_Click);
            // 
            // buttonAttackRight
            // 
            this.buttonAttackRight.Location = new System.Drawing.Point(685, 180);
            this.buttonAttackRight.Name = "buttonAttackRight";
            this.buttonAttackRight.Size = new System.Drawing.Size(53, 28);
            this.buttonAttackRight.TabIndex = 9;
            this.buttonAttackRight.Text = "Right";
            this.buttonAttackRight.UseVisualStyleBackColor = true;
            this.buttonAttackRight.Click += new System.EventHandler(this.buttonAttackRight_Click);
            // 
            // buttonAttackDown
            // 
            this.buttonAttackDown.Location = new System.Drawing.Point(657, 214);
            this.buttonAttackDown.Name = "buttonAttackDown";
            this.buttonAttackDown.Size = new System.Drawing.Size(53, 28);
            this.buttonAttackDown.TabIndex = 10;
            this.buttonAttackDown.Text = "Down";
            this.buttonAttackDown.UseVisualStyleBackColor = true;
            this.buttonAttackDown.Click += new System.EventHandler(this.buttonAttackDown_Click);
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayer.Image")));
            this.pictureBoxPlayer.Location = new System.Drawing.Point(78, 60);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer.TabIndex = 11;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxSword
            // 
            this.pictureBoxSword.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSword.Image")));
            this.pictureBoxSword.InitialImage = null;
            this.pictureBoxSword.Location = new System.Drawing.Point(114, 60);
            this.pictureBoxSword.Name = "pictureBoxSword";
            this.pictureBoxSword.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSword.TabIndex = 12;
            this.pictureBoxSword.TabStop = false;
            // 
            // pictureBoxBat
            // 
            this.pictureBoxBat.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBat.Image")));
            this.pictureBoxBat.InitialImage = null;
            this.pictureBoxBat.Location = new System.Drawing.Point(150, 60);
            this.pictureBoxBat.Name = "pictureBoxBat";
            this.pictureBoxBat.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBat.TabIndex = 12;
            this.pictureBoxBat.TabStop = false;
            // 
            // pictureBoxBow
            // 
            this.pictureBoxBow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBow.Image")));
            this.pictureBoxBow.InitialImage = null;
            this.pictureBoxBow.Location = new System.Drawing.Point(258, 60);
            this.pictureBoxBow.Name = "pictureBoxBow";
            this.pictureBoxBow.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBow.TabIndex = 12;
            this.pictureBoxBow.TabStop = false;
            // 
            // pictureBoxRedPotion
            // 
            this.pictureBoxRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRedPotion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRedPotion.Image")));
            this.pictureBoxRedPotion.InitialImage = null;
            this.pictureBoxRedPotion.Location = new System.Drawing.Point(294, 60);
            this.pictureBoxRedPotion.Name = "pictureBoxRedPotion";
            this.pictureBoxRedPotion.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRedPotion.TabIndex = 12;
            this.pictureBoxRedPotion.TabStop = false;
            // 
            // pictureBoxBluePotion
            // 
            this.pictureBoxBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBluePotion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBluePotion.Image")));
            this.pictureBoxBluePotion.InitialImage = null;
            this.pictureBoxBluePotion.Location = new System.Drawing.Point(330, 60);
            this.pictureBoxBluePotion.Name = "pictureBoxBluePotion";
            this.pictureBoxBluePotion.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBluePotion.TabIndex = 12;
            this.pictureBoxBluePotion.TabStop = false;
            // 
            // pictureBoxMace
            // 
            this.pictureBoxMace.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMace.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMace.Image")));
            this.pictureBoxMace.InitialImage = null;
            this.pictureBoxMace.Location = new System.Drawing.Point(366, 60);
            this.pictureBoxMace.Name = "pictureBoxMace";
            this.pictureBoxMace.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMace.TabIndex = 12;
            this.pictureBoxMace.TabStop = false;
            // 
            // pictureItemSword
            // 
            this.pictureItemSword.BackColor = System.Drawing.Color.Transparent;
            this.pictureItemSword.Image = ((System.Drawing.Image)(resources.GetObject("pictureItemSword.Image")));
            this.pictureItemSword.Location = new System.Drawing.Point(82, 321);
            this.pictureItemSword.Name = "pictureItemSword";
            this.pictureItemSword.Size = new System.Drawing.Size(50, 50);
            this.pictureItemSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureItemSword.TabIndex = 13;
            this.pictureItemSword.TabStop = false;
            this.pictureItemSword.Click += new System.EventHandler(this.pictureItemSword_Click);
            // 
            // pictureItemBow
            // 
            this.pictureItemBow.BackColor = System.Drawing.Color.Transparent;
            this.pictureItemBow.Image = ((System.Drawing.Image)(resources.GetObject("pictureItemBow.Image")));
            this.pictureItemBow.Location = new System.Drawing.Point(138, 321);
            this.pictureItemBow.Name = "pictureItemBow";
            this.pictureItemBow.Size = new System.Drawing.Size(50, 50);
            this.pictureItemBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureItemBow.TabIndex = 13;
            this.pictureItemBow.TabStop = false;
            this.pictureItemBow.Click += new System.EventHandler(this.pictureItemBow_Click);
            // 
            // pictureItemMace
            // 
            this.pictureItemMace.BackColor = System.Drawing.Color.Transparent;
            this.pictureItemMace.Image = ((System.Drawing.Image)(resources.GetObject("pictureItemMace.Image")));
            this.pictureItemMace.Location = new System.Drawing.Point(194, 321);
            this.pictureItemMace.Name = "pictureItemMace";
            this.pictureItemMace.Size = new System.Drawing.Size(50, 50);
            this.pictureItemMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureItemMace.TabIndex = 13;
            this.pictureItemMace.TabStop = false;
            this.pictureItemMace.Click += new System.EventHandler(this.pictureItemMace_Click);
            // 
            // pictureItemBP
            // 
            this.pictureItemBP.BackColor = System.Drawing.Color.Transparent;
            this.pictureItemBP.Image = ((System.Drawing.Image)(resources.GetObject("pictureItemBP.Image")));
            this.pictureItemBP.Location = new System.Drawing.Point(250, 321);
            this.pictureItemBP.Name = "pictureItemBP";
            this.pictureItemBP.Size = new System.Drawing.Size(50, 50);
            this.pictureItemBP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureItemBP.TabIndex = 13;
            this.pictureItemBP.TabStop = false;
            this.pictureItemBP.Click += new System.EventHandler(this.pictureItemBP_Click);
            // 
            // pictureItemRP
            // 
            this.pictureItemRP.BackColor = System.Drawing.Color.Transparent;
            this.pictureItemRP.Image = ((System.Drawing.Image)(resources.GetObject("pictureItemRP.Image")));
            this.pictureItemRP.Location = new System.Drawing.Point(310, 321);
            this.pictureItemRP.Name = "pictureItemRP";
            this.pictureItemRP.Size = new System.Drawing.Size(50, 50);
            this.pictureItemRP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureItemRP.TabIndex = 13;
            this.pictureItemRP.TabStop = false;
            this.pictureItemRP.Click += new System.EventHandler(this.pictureItemRP_Click);
            // 
            // pictureBoxGhost
            // 
            this.pictureBoxGhost.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGhost.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGhost.Image")));
            this.pictureBoxGhost.InitialImage = null;
            this.pictureBoxGhost.Location = new System.Drawing.Point(222, 60);
            this.pictureBoxGhost.Name = "pictureBoxGhost";
            this.pictureBoxGhost.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGhost.TabIndex = 14;
            this.pictureBoxGhost.TabStop = false;
            // 
            // pictureBoxGhoul
            // 
            this.pictureBoxGhoul.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGhoul.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGhoul.Image")));
            this.pictureBoxGhoul.Location = new System.Drawing.Point(186, 60);
            this.pictureBoxGhoul.Name = "pictureBoxGhoul";
            this.pictureBoxGhoul.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxGhoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGhoul.TabIndex = 15;
            this.pictureBoxGhoul.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(790, 401);
            this.Controls.Add(this.pictureBoxGhoul);
            this.Controls.Add(this.pictureBoxGhost);
            this.Controls.Add(this.pictureBoxMace);
            this.Controls.Add(this.pictureBoxBluePotion);
            this.Controls.Add(this.pictureBoxRedPotion);
            this.Controls.Add(this.pictureBoxBow);
            this.Controls.Add(this.pictureBoxBat);
            this.Controls.Add(this.pictureBoxSword);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.pictureItemRP);
            this.Controls.Add(this.pictureItemBP);
            this.Controls.Add(this.pictureItemMace);
            this.Controls.Add(this.pictureItemBow);
            this.Controls.Add(this.pictureItemSword);
            this.Controls.Add(this.buttonAttackDown);
            this.Controls.Add(this.buttonAttackRight);
            this.Controls.Add(this.buttonAttackLeft);
            this.Controls.Add(this.buttonAttackUp);
            this.Controls.Add(this.labelAttack);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.buttonMoveRight);
            this.Controls.Add(this.buttonMoveLeft);
            this.Controls.Add(this.buttonMoveUp);
            this.Controls.Add(this.labelMove);
            this.Controls.Add(this.panelGameInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelGameInfo.ResumeLayout(false);
            this.panelGameInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItemSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItemBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItemMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItemBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItemRP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGhoul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelGameInfo;
        private System.Windows.Forms.Label labelMove;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Label labelAttack;
        private System.Windows.Forms.Button buttonAttackUp;
        private System.Windows.Forms.Button buttonAttackLeft;
        private System.Windows.Forms.Button buttonAttackRight;
        private System.Windows.Forms.Button buttonAttackDown;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxSword;
        private System.Windows.Forms.PictureBox pictureBoxBat;
        private System.Windows.Forms.PictureBox pictureBoxBow;
        private System.Windows.Forms.PictureBox pictureBoxRedPotion;
        private System.Windows.Forms.PictureBox pictureBoxBluePotion;
        private System.Windows.Forms.PictureBox pictureBoxMace;
        private System.Windows.Forms.PictureBox pictureItemSword;
        private System.Windows.Forms.PictureBox pictureItemBow;
        private System.Windows.Forms.PictureBox pictureItemMace;
        private System.Windows.Forms.PictureBox pictureItemBP;
        private System.Windows.Forms.PictureBox pictureItemRP;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelBat;
        private System.Windows.Forms.Label labelPlayerHP;
        private System.Windows.Forms.Label labelBatHP;
        private System.Windows.Forms.Label labelGhost;
        private System.Windows.Forms.Label labelGhostHP;
        private System.Windows.Forms.Label labelGhoul;
        private System.Windows.Forms.Label labelGhoulHP;
        private System.Windows.Forms.PictureBox pictureBoxGhost;
        private System.Windows.Forms.PictureBox pictureBoxGhoul;
    }
}

