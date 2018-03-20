namespace AdventureGame
{
    partial class Dungeon
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
            this.gbMove = new System.Windows.Forms.GroupBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.gbAttack = new System.Windows.Forms.GroupBox();
            this.btnAttackRight = new System.Windows.Forms.Button();
            this.btnAttackUp = new System.Windows.Forms.Button();
            this.btnAttackLeft = new System.Windows.Forms.Button();
            this.btnAttackDown = new System.Windows.Forms.Button();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbSword = new System.Windows.Forms.PictureBox();
            this.pbBat = new System.Windows.Forms.PictureBox();
            this.pbGhoul = new System.Windows.Forms.PictureBox();
            this.pbGhost = new System.Windows.Forms.PictureBox();
            this.pbBow = new System.Windows.Forms.PictureBox();
            this.pbRedPotion = new System.Windows.Forms.PictureBox();
            this.pbBluePotion = new System.Windows.Forms.PictureBox();
            this.pbMace = new System.Windows.Forms.PictureBox();
            this.pbInventoryBluePotion = new System.Windows.Forms.PictureBox();
            this.pbInventorySword = new System.Windows.Forms.PictureBox();
            this.pbInventoryBow = new System.Windows.Forms.PictureBox();
            this.pbInventoryMace = new System.Windows.Forms.PictureBox();
            this.pbInventoryRedPotion = new System.Windows.Forms.PictureBox();
            this.tableStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblGhoulHitPoints = new System.Windows.Forms.Label();
            this.lblGhoul = new System.Windows.Forms.Label();
            this.lblGhostHitPoints = new System.Windows.Forms.Label();
            this.lblGhost = new System.Windows.Forms.Label();
            this.lblBatHitPoints = new System.Windows.Forms.Label();
            this.lblBat = new System.Windows.Forms.Label();
            this.lblPlayerHitPoints = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.gbMove.SuspendLayout();
            this.gbAttack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventoryBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventorySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventoryBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventoryMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventoryRedPotion)).BeginInit();
            this.tableStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMove
            // 
            this.gbMove.Controls.Add(this.btnMoveRight);
            this.gbMove.Controls.Add(this.btnMoveLeft);
            this.gbMove.Controls.Add(this.btnMoveDown);
            this.gbMove.Controls.Add(this.btnMoveUp);
            this.gbMove.Location = new System.Drawing.Point(617, 13);
            this.gbMove.Name = "gbMove";
            this.gbMove.Size = new System.Drawing.Size(172, 112);
            this.gbMove.TabIndex = 1;
            this.gbMove.TabStop = false;
            this.gbMove.Text = "Move";
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMoveRight.Location = new System.Drawing.Point(88, 45);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 28);
            this.btnMoveRight.TabIndex = 3;
            this.btnMoveRight.Text = "Right";
            this.btnMoveRight.UseVisualStyleBackColor = false;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMoveLeft.Location = new System.Drawing.Point(9, 45);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 28);
            this.btnMoveLeft.TabIndex = 2;
            this.btnMoveLeft.Text = "Left";
            this.btnMoveLeft.UseVisualStyleBackColor = false;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMoveDown.Location = new System.Drawing.Point(49, 73);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 28);
            this.btnMoveDown.TabIndex = 1;
            this.btnMoveDown.Text = "Down";
            this.btnMoveDown.UseVisualStyleBackColor = false;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMoveUp.Location = new System.Drawing.Point(49, 15);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 28);
            this.btnMoveUp.TabIndex = 0;
            this.btnMoveUp.Text = "Up";
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // gbAttack
            // 
            this.gbAttack.Controls.Add(this.btnAttackRight);
            this.gbAttack.Controls.Add(this.btnAttackUp);
            this.gbAttack.Controls.Add(this.btnAttackLeft);
            this.gbAttack.Controls.Add(this.btnAttackDown);
            this.gbAttack.Location = new System.Drawing.Point(617, 131);
            this.gbAttack.Name = "gbAttack";
            this.gbAttack.Size = new System.Drawing.Size(172, 112);
            this.gbAttack.TabIndex = 2;
            this.gbAttack.TabStop = false;
            this.gbAttack.Text = "Attack";
            // 
            // btnAttackRight
            // 
            this.btnAttackRight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAttackRight.Location = new System.Drawing.Point(88, 45);
            this.btnAttackRight.Name = "btnAttackRight";
            this.btnAttackRight.Size = new System.Drawing.Size(75, 28);
            this.btnAttackRight.TabIndex = 7;
            this.btnAttackRight.Text = "Right";
            this.btnAttackRight.UseVisualStyleBackColor = false;
            this.btnAttackRight.Click += new System.EventHandler(this.btnAttackRight_Click);
            // 
            // btnAttackUp
            // 
            this.btnAttackUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAttackUp.Location = new System.Drawing.Point(49, 15);
            this.btnAttackUp.Name = "btnAttackUp";
            this.btnAttackUp.Size = new System.Drawing.Size(75, 28);
            this.btnAttackUp.TabIndex = 4;
            this.btnAttackUp.Text = "Up";
            this.btnAttackUp.UseVisualStyleBackColor = false;
            this.btnAttackUp.Click += new System.EventHandler(this.btnAttackUp_Click);
            // 
            // btnAttackLeft
            // 
            this.btnAttackLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAttackLeft.Location = new System.Drawing.Point(9, 45);
            this.btnAttackLeft.Name = "btnAttackLeft";
            this.btnAttackLeft.Size = new System.Drawing.Size(75, 28);
            this.btnAttackLeft.TabIndex = 6;
            this.btnAttackLeft.Text = "Left";
            this.btnAttackLeft.UseVisualStyleBackColor = false;
            this.btnAttackLeft.Click += new System.EventHandler(this.btnAttackLeft_Click);
            // 
            // btnAttackDown
            // 
            this.btnAttackDown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAttackDown.Location = new System.Drawing.Point(49, 73);
            this.btnAttackDown.Name = "btnAttackDown";
            this.btnAttackDown.Size = new System.Drawing.Size(75, 28);
            this.btnAttackDown.TabIndex = 5;
            this.btnAttackDown.Text = "Down";
            this.btnAttackDown.UseVisualStyleBackColor = false;
            this.btnAttackDown.Click += new System.EventHandler(this.btnAttackDown_Click);
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = global::AdventureGame.Properties.Resources.player;
            this.pbPlayer.Location = new System.Drawing.Point(81, 63);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(32, 29);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 3;
            this.pbPlayer.TabStop = false;
            // 
            // pbSword
            // 
            this.pbSword.BackColor = System.Drawing.Color.Transparent;
            this.pbSword.Image = global::AdventureGame.Properties.Resources.sword;
            this.pbSword.Location = new System.Drawing.Point(119, 63);
            this.pbSword.Name = "pbSword";
            this.pbSword.Size = new System.Drawing.Size(32, 29);
            this.pbSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSword.TabIndex = 4;
            this.pbSword.TabStop = false;
            // 
            // pbBat
            // 
            this.pbBat.BackColor = System.Drawing.Color.Transparent;
            this.pbBat.Image = global::AdventureGame.Properties.Resources.bat;
            this.pbBat.Location = new System.Drawing.Point(157, 63);
            this.pbBat.Name = "pbBat";
            this.pbBat.Size = new System.Drawing.Size(32, 29);
            this.pbBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBat.TabIndex = 5;
            this.pbBat.TabStop = false;
            // 
            // pbGhoul
            // 
            this.pbGhoul.BackColor = System.Drawing.Color.Transparent;
            this.pbGhoul.Image = global::AdventureGame.Properties.Resources.ghoul;
            this.pbGhoul.Location = new System.Drawing.Point(195, 63);
            this.pbGhoul.Name = "pbGhoul";
            this.pbGhoul.Size = new System.Drawing.Size(32, 29);
            this.pbGhoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGhoul.TabIndex = 6;
            this.pbGhoul.TabStop = false;
            // 
            // pbGhost
            // 
            this.pbGhost.BackColor = System.Drawing.Color.Transparent;
            this.pbGhost.Image = global::AdventureGame.Properties.Resources.ghost;
            this.pbGhost.Location = new System.Drawing.Point(233, 63);
            this.pbGhost.Name = "pbGhost";
            this.pbGhost.Size = new System.Drawing.Size(32, 29);
            this.pbGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGhost.TabIndex = 7;
            this.pbGhost.TabStop = false;
            // 
            // pbBow
            // 
            this.pbBow.BackColor = System.Drawing.Color.Transparent;
            this.pbBow.Image = global::AdventureGame.Properties.Resources.bow;
            this.pbBow.Location = new System.Drawing.Point(271, 63);
            this.pbBow.Name = "pbBow";
            this.pbBow.Size = new System.Drawing.Size(32, 29);
            this.pbBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBow.TabIndex = 8;
            this.pbBow.TabStop = false;
            // 
            // pbRedPotion
            // 
            this.pbRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.pbRedPotion.Image = global::AdventureGame.Properties.Resources.potion_red;
            this.pbRedPotion.Location = new System.Drawing.Point(309, 63);
            this.pbRedPotion.Name = "pbRedPotion";
            this.pbRedPotion.Size = new System.Drawing.Size(32, 29);
            this.pbRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRedPotion.TabIndex = 9;
            this.pbRedPotion.TabStop = false;
            // 
            // pbBluePotion
            // 
            this.pbBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.pbBluePotion.Image = global::AdventureGame.Properties.Resources.potion_blue;
            this.pbBluePotion.Location = new System.Drawing.Point(347, 63);
            this.pbBluePotion.Name = "pbBluePotion";
            this.pbBluePotion.Size = new System.Drawing.Size(32, 29);
            this.pbBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBluePotion.TabIndex = 10;
            this.pbBluePotion.TabStop = false;
            // 
            // pbMace
            // 
            this.pbMace.BackColor = System.Drawing.Color.Transparent;
            this.pbMace.Image = global::AdventureGame.Properties.Resources.mace;
            this.pbMace.Location = new System.Drawing.Point(385, 63);
            this.pbMace.Name = "pbMace";
            this.pbMace.Size = new System.Drawing.Size(32, 29);
            this.pbMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMace.TabIndex = 11;
            this.pbMace.TabStop = false;
            // 
            // pbInventoryBluePotion
            // 
            this.pbInventoryBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.pbInventoryBluePotion.Image = global::AdventureGame.Properties.Resources.potion_blue;
            this.pbInventoryBluePotion.Location = new System.Drawing.Point(399, 318);
            this.pbInventoryBluePotion.Name = "pbInventoryBluePotion";
            this.pbInventoryBluePotion.Size = new System.Drawing.Size(50, 50);
            this.pbInventoryBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInventoryBluePotion.TabIndex = 16;
            this.pbInventoryBluePotion.TabStop = false;
            this.pbInventoryBluePotion.Click += new System.EventHandler(this.pbInventoryBluePotion_Click);
            // 
            // pbInventorySword
            // 
            this.pbInventorySword.BackColor = System.Drawing.Color.Transparent;
            this.pbInventorySword.Image = global::AdventureGame.Properties.Resources.sword;
            this.pbInventorySword.Location = new System.Drawing.Point(95, 318);
            this.pbInventorySword.Name = "pbInventorySword";
            this.pbInventorySword.Size = new System.Drawing.Size(50, 50);
            this.pbInventorySword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInventorySword.TabIndex = 17;
            this.pbInventorySword.TabStop = false;
            this.pbInventorySword.Click += new System.EventHandler(this.pbInventorySword_Click);
            // 
            // pbInventoryBow
            // 
            this.pbInventoryBow.BackColor = System.Drawing.Color.Transparent;
            this.pbInventoryBow.Image = global::AdventureGame.Properties.Resources.bow;
            this.pbInventoryBow.Location = new System.Drawing.Point(171, 318);
            this.pbInventoryBow.Name = "pbInventoryBow";
            this.pbInventoryBow.Size = new System.Drawing.Size(50, 50);
            this.pbInventoryBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInventoryBow.TabIndex = 18;
            this.pbInventoryBow.TabStop = false;
            this.pbInventoryBow.Click += new System.EventHandler(this.pbInventoryBow_Click);
            // 
            // pbInventoryMace
            // 
            this.pbInventoryMace.BackColor = System.Drawing.Color.Transparent;
            this.pbInventoryMace.Image = global::AdventureGame.Properties.Resources.mace;
            this.pbInventoryMace.Location = new System.Drawing.Point(247, 318);
            this.pbInventoryMace.Name = "pbInventoryMace";
            this.pbInventoryMace.Size = new System.Drawing.Size(50, 50);
            this.pbInventoryMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInventoryMace.TabIndex = 19;
            this.pbInventoryMace.TabStop = false;
            this.pbInventoryMace.Click += new System.EventHandler(this.pbInventoryMace_Click);
            // 
            // pbInventoryRedPotion
            // 
            this.pbInventoryRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.pbInventoryRedPotion.Image = global::AdventureGame.Properties.Resources.potion_red;
            this.pbInventoryRedPotion.Location = new System.Drawing.Point(323, 318);
            this.pbInventoryRedPotion.Name = "pbInventoryRedPotion";
            this.pbInventoryRedPotion.Size = new System.Drawing.Size(50, 50);
            this.pbInventoryRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInventoryRedPotion.TabIndex = 20;
            this.pbInventoryRedPotion.TabStop = false;
            this.pbInventoryRedPotion.Click += new System.EventHandler(this.pbInventoryRedPotion_Click);
            // 
            // tableStatus
            // 
            this.tableStatus.ColumnCount = 2;
            this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.30233F));
            this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.69768F));
            this.tableStatus.Controls.Add(this.lblGhoulHitPoints, 1, 3);
            this.tableStatus.Controls.Add(this.lblGhoul, 0, 3);
            this.tableStatus.Controls.Add(this.lblGhostHitPoints, 1, 2);
            this.tableStatus.Controls.Add(this.lblGhost, 0, 2);
            this.tableStatus.Controls.Add(this.lblBatHitPoints, 1, 1);
            this.tableStatus.Controls.Add(this.lblBat, 0, 1);
            this.tableStatus.Controls.Add(this.lblPlayerHitPoints, 1, 0);
            this.tableStatus.Controls.Add(this.lblPlayer, 0, 0);
            this.tableStatus.Location = new System.Drawing.Point(617, 259);
            this.tableStatus.Name = "tableStatus";
            this.tableStatus.RowCount = 4;
            this.tableStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableStatus.Size = new System.Drawing.Size(172, 126);
            this.tableStatus.TabIndex = 22;
            // 
            // lblGhoulHitPoints
            // 
            this.lblGhoulHitPoints.AutoSize = true;
            this.lblGhoulHitPoints.Location = new System.Drawing.Point(62, 95);
            this.lblGhoulHitPoints.Name = "lblGhoulHitPoints";
            this.lblGhoulHitPoints.Size = new System.Drawing.Size(85, 12);
            this.lblGhoulHitPoints.TabIndex = 7;
            this.lblGhoulHitPoints.Text = "ghoulHitPoints";
            // 
            // lblGhoul
            // 
            this.lblGhoul.AutoSize = true;
            this.lblGhoul.Location = new System.Drawing.Point(3, 95);
            this.lblGhoul.Name = "lblGhoul";
            this.lblGhoul.Size = new System.Drawing.Size(38, 12);
            this.lblGhoul.TabIndex = 6;
            this.lblGhoul.Text = "Ghoul";
            // 
            // lblGhostHitPoints
            // 
            this.lblGhostHitPoints.AutoSize = true;
            this.lblGhostHitPoints.Location = new System.Drawing.Point(62, 64);
            this.lblGhostHitPoints.Name = "lblGhostHitPoints";
            this.lblGhostHitPoints.Size = new System.Drawing.Size(85, 12);
            this.lblGhostHitPoints.TabIndex = 5;
            this.lblGhostHitPoints.Text = "ghostHitPoints";
            // 
            // lblGhost
            // 
            this.lblGhost.AutoSize = true;
            this.lblGhost.Location = new System.Drawing.Point(3, 64);
            this.lblGhost.Name = "lblGhost";
            this.lblGhost.Size = new System.Drawing.Size(38, 12);
            this.lblGhost.TabIndex = 4;
            this.lblGhost.Text = "Ghost";
            // 
            // lblBatHitPoints
            // 
            this.lblBatHitPoints.AutoSize = true;
            this.lblBatHitPoints.Location = new System.Drawing.Point(62, 32);
            this.lblBatHitPoints.Name = "lblBatHitPoints";
            this.lblBatHitPoints.Size = new System.Drawing.Size(71, 12);
            this.lblBatHitPoints.TabIndex = 3;
            this.lblBatHitPoints.Text = "batHitPoints";
            // 
            // lblBat
            // 
            this.lblBat.AutoSize = true;
            this.lblBat.Location = new System.Drawing.Point(3, 32);
            this.lblBat.Name = "lblBat";
            this.lblBat.Size = new System.Drawing.Size(23, 12);
            this.lblBat.TabIndex = 2;
            this.lblBat.Text = "Bat";
            // 
            // lblPlayerHitPoints
            // 
            this.lblPlayerHitPoints.AutoSize = true;
            this.lblPlayerHitPoints.Location = new System.Drawing.Point(62, 0);
            this.lblPlayerHitPoints.Name = "lblPlayerHitPoints";
            this.lblPlayerHitPoints.Size = new System.Drawing.Size(89, 12);
            this.lblPlayerHitPoints.TabIndex = 1;
            this.lblPlayerHitPoints.Text = "playerHitPoints";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(3, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(41, 12);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Player";
            // 
            // Dungeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::AdventureGame.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(799, 401);
            this.Controls.Add(this.tableStatus);
            this.Controls.Add(this.pbInventoryRedPotion);
            this.Controls.Add(this.pbInventoryMace);
            this.Controls.Add(this.pbInventoryBow);
            this.Controls.Add(this.pbInventorySword);
            this.Controls.Add(this.pbInventoryBluePotion);
            this.Controls.Add(this.pbMace);
            this.Controls.Add(this.pbBluePotion);
            this.Controls.Add(this.pbRedPotion);
            this.Controls.Add(this.pbBow);
            this.Controls.Add(this.pbGhost);
            this.Controls.Add(this.pbGhoul);
            this.Controls.Add(this.pbBat);
            this.Controls.Add(this.pbSword);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.gbAttack);
            this.Controls.Add(this.gbMove);
            this.Name = "Dungeon";
            this.Text = "AdventureGame";
            this.Load += new System.EventHandler(this.Dungeon_Load);
            this.gbMove.ResumeLayout(false);
            this.gbAttack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventoryBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventorySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventoryBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventoryMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventoryRedPotion)).EndInit();
            this.tableStatus.ResumeLayout(false);
            this.tableStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbMove;
        private System.Windows.Forms.GroupBox gbAttack;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbSword;
        private System.Windows.Forms.PictureBox pbBat;
        private System.Windows.Forms.PictureBox pbGhoul;
        private System.Windows.Forms.PictureBox pbGhost;
        private System.Windows.Forms.PictureBox pbBow;
        private System.Windows.Forms.PictureBox pbRedPotion;
        private System.Windows.Forms.PictureBox pbBluePotion;
        private System.Windows.Forms.PictureBox pbMace;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnAttackRight;
        private System.Windows.Forms.Button btnAttackUp;
        private System.Windows.Forms.Button btnAttackLeft;
        private System.Windows.Forms.Button btnAttackDown;
        private System.Windows.Forms.PictureBox pbInventoryBluePotion;
        private System.Windows.Forms.PictureBox pbInventorySword;
        private System.Windows.Forms.PictureBox pbInventoryBow;
        private System.Windows.Forms.PictureBox pbInventoryMace;
        private System.Windows.Forms.PictureBox pbInventoryRedPotion;
        private System.Windows.Forms.TableLayoutPanel tableStatus;
        private System.Windows.Forms.Label lblGhoulHitPoints;
        private System.Windows.Forms.Label lblGhoul;
        private System.Windows.Forms.Label lblGhostHitPoints;
        private System.Windows.Forms.Label lblGhost;
        private System.Windows.Forms.Label lblBatHitPoints;
        private System.Windows.Forms.Label lblBat;
        private System.Windows.Forms.Label lblPlayerHitPoints;
        private System.Windows.Forms.Label lblPlayer;
    }
}

