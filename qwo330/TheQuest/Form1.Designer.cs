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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.playerHitPoint = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Mace = new System.Windows.Forms.PictureBox();
            this.Potion_Blue = new System.Windows.Forms.PictureBox();
            this.Potion_Red = new System.Windows.Forms.PictureBox();
            this.Bow = new System.Windows.Forms.PictureBox();
            this.Ghost = new System.Windows.Forms.PictureBox();
            this.Ghoul = new System.Windows.Forms.PictureBox();
            this.Bat = new System.Windows.Forms.PictureBox();
            this.Sword = new System.Windows.Forms.PictureBox();
            this.Inven7 = new System.Windows.Forms.PictureBox();
            this.Inven6 = new System.Windows.Forms.PictureBox();
            this.InvenMace = new System.Windows.Forms.PictureBox();
            this.InvenRedPotion = new System.Windows.Forms.PictureBox();
            this.InvenBow = new System.Windows.Forms.PictureBox();
            this.InvenBluePotion = new System.Windows.Forms.PictureBox();
            this.InvenSword = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.StageLevel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Potion_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Potion_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inven7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inven6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvenMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvenRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvenBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvenBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvenSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ghoul";
            // 
            // playerHitPoint
            // 
            this.playerHitPoint.AutoSize = true;
            this.playerHitPoint.Location = new System.Drawing.Point(50, 0);
            this.playerHitPoint.Name = "playerHitPoint";
            this.playerHitPoint.Size = new System.Drawing.Size(82, 12);
            this.playerHitPoint.TabIndex = 3;
            this.playerHitPoint.Text = "playerHitPoint";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(50, 22);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(71, 12);
            this.batHitPoints.TabIndex = 3;
            this.batHitPoints.Text = "batHitPoints";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(50, 44);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(85, 12);
            this.ghostHitPoints.TabIndex = 3;
            this.ghostHitPoints.Text = "ghostHitPoints";
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(50, 66);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(85, 12);
            this.ghoulHitPoints.TabIndex = 3;
            this.ghoulHitPoints.Text = "ghoulHitPoints";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoint, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(607, 310);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(158, 91);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.ErrorImage = global::TheQuest.Properties.Resources.player;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(84, 64);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(30, 30);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 7;
            this.Player.TabStop = false;
            // 
            // Mace
            // 
            this.Mace.BackColor = System.Drawing.Color.Transparent;
            this.Mace.Image = ((System.Drawing.Image)(resources.GetObject("Mace.Image")));
            this.Mace.Location = new System.Drawing.Point(370, 63);
            this.Mace.Name = "Mace";
            this.Mace.Size = new System.Drawing.Size(30, 30);
            this.Mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mace.TabIndex = 15;
            this.Mace.TabStop = false;
            // 
            // Potion_Blue
            // 
            this.Potion_Blue.BackColor = System.Drawing.Color.Transparent;
            this.Potion_Blue.Image = ((System.Drawing.Image)(resources.GetObject("Potion_Blue.Image")));
            this.Potion_Blue.Location = new System.Drawing.Point(334, 63);
            this.Potion_Blue.Name = "Potion_Blue";
            this.Potion_Blue.Size = new System.Drawing.Size(30, 30);
            this.Potion_Blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Potion_Blue.TabIndex = 14;
            this.Potion_Blue.TabStop = false;
            // 
            // Potion_Red
            // 
            this.Potion_Red.BackColor = System.Drawing.Color.Transparent;
            this.Potion_Red.Image = ((System.Drawing.Image)(resources.GetObject("Potion_Red.Image")));
            this.Potion_Red.Location = new System.Drawing.Point(298, 64);
            this.Potion_Red.Name = "Potion_Red";
            this.Potion_Red.Size = new System.Drawing.Size(30, 30);
            this.Potion_Red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Potion_Red.TabIndex = 13;
            this.Potion_Red.TabStop = false;
            // 
            // Bow
            // 
            this.Bow.BackColor = System.Drawing.Color.Transparent;
            this.Bow.Image = ((System.Drawing.Image)(resources.GetObject("Bow.Image")));
            this.Bow.Location = new System.Drawing.Point(264, 64);
            this.Bow.Name = "Bow";
            this.Bow.Size = new System.Drawing.Size(30, 30);
            this.Bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bow.TabIndex = 12;
            this.Bow.TabStop = false;
            // 
            // Ghost
            // 
            this.Ghost.BackColor = System.Drawing.Color.Transparent;
            this.Ghost.Image = ((System.Drawing.Image)(resources.GetObject("Ghost.Image")));
            this.Ghost.Location = new System.Drawing.Point(228, 63);
            this.Ghost.Name = "Ghost";
            this.Ghost.Size = new System.Drawing.Size(30, 30);
            this.Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ghost.TabIndex = 11;
            this.Ghost.TabStop = false;
            // 
            // Ghoul
            // 
            this.Ghoul.BackColor = System.Drawing.Color.Transparent;
            this.Ghoul.Image = ((System.Drawing.Image)(resources.GetObject("Ghoul.Image")));
            this.Ghoul.Location = new System.Drawing.Point(192, 64);
            this.Ghoul.Name = "Ghoul";
            this.Ghoul.Size = new System.Drawing.Size(30, 30);
            this.Ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ghoul.TabIndex = 10;
            this.Ghoul.TabStop = false;
            // 
            // Bat
            // 
            this.Bat.BackColor = System.Drawing.Color.Transparent;
            this.Bat.Image = ((System.Drawing.Image)(resources.GetObject("Bat.Image")));
            this.Bat.Location = new System.Drawing.Point(156, 63);
            this.Bat.Name = "Bat";
            this.Bat.Size = new System.Drawing.Size(30, 30);
            this.Bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bat.TabIndex = 9;
            this.Bat.TabStop = false;
            // 
            // Sword
            // 
            this.Sword.BackColor = System.Drawing.Color.Transparent;
            this.Sword.Image = ((System.Drawing.Image)(resources.GetObject("Sword.Image")));
            this.Sword.Location = new System.Drawing.Point(120, 64);
            this.Sword.Name = "Sword";
            this.Sword.Size = new System.Drawing.Size(30, 30);
            this.Sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sword.TabIndex = 8;
            this.Sword.TabStop = false;
            // 
            // Inven7
            // 
            this.Inven7.BackColor = System.Drawing.Color.Transparent;
            this.Inven7.Location = new System.Drawing.Point(473, 317);
            this.Inven7.Name = "Inven7";
            this.Inven7.Size = new System.Drawing.Size(50, 50);
            this.Inven7.TabIndex = 7;
            this.Inven7.TabStop = false;
            // 
            // Inven6
            // 
            this.Inven6.BackColor = System.Drawing.Color.Transparent;
            this.Inven6.Location = new System.Drawing.Point(407, 317);
            this.Inven6.Name = "Inven6";
            this.Inven6.Size = new System.Drawing.Size(50, 50);
            this.Inven6.TabIndex = 7;
            this.Inven6.TabStop = false;
            // 
            // InvenMace
            // 
            this.InvenMace.BackColor = System.Drawing.Color.Transparent;
            this.InvenMace.Image = global::TheQuest.Properties.Resources.mace;
            this.InvenMace.Location = new System.Drawing.Point(341, 317);
            this.InvenMace.Name = "InvenMace";
            this.InvenMace.Size = new System.Drawing.Size(50, 50);
            this.InvenMace.TabIndex = 7;
            this.InvenMace.TabStop = false;
            // 
            // InvenRedPotion
            // 
            this.InvenRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.InvenRedPotion.Image = global::TheQuest.Properties.Resources.potion_red;
            this.InvenRedPotion.Location = new System.Drawing.Point(275, 317);
            this.InvenRedPotion.Name = "InvenRedPotion";
            this.InvenRedPotion.Size = new System.Drawing.Size(50, 50);
            this.InvenRedPotion.TabIndex = 7;
            this.InvenRedPotion.TabStop = false;
            // 
            // InvenBow
            // 
            this.InvenBow.BackColor = System.Drawing.Color.Transparent;
            this.InvenBow.Image = global::TheQuest.Properties.Resources.bow;
            this.InvenBow.Location = new System.Drawing.Point(209, 317);
            this.InvenBow.Name = "InvenBow";
            this.InvenBow.Size = new System.Drawing.Size(50, 50);
            this.InvenBow.TabIndex = 7;
            this.InvenBow.TabStop = false;
            // 
            // InvenBluePotion
            // 
            this.InvenBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.InvenBluePotion.Image = global::TheQuest.Properties.Resources.potion_blue;
            this.InvenBluePotion.Location = new System.Drawing.Point(143, 317);
            this.InvenBluePotion.Name = "InvenBluePotion";
            this.InvenBluePotion.Size = new System.Drawing.Size(50, 50);
            this.InvenBluePotion.TabIndex = 7;
            this.InvenBluePotion.TabStop = false;
            // 
            // InvenSword
            // 
            this.InvenSword.BackColor = System.Drawing.Color.Transparent;
            this.InvenSword.Image = global::TheQuest.Properties.Resources.sword;
            this.InvenSword.Location = new System.Drawing.Point(78, 317);
            this.InvenSword.Name = "InvenSword";
            this.InvenSword.Size = new System.Drawing.Size(50, 50);
            this.InvenSword.TabIndex = 7;
            this.InvenSword.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(607, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(608, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(625, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "Move";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "Attack";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(640, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "+";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(605, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "SelectItem";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(606, 222);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(153, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // StageLevel
            // 
            this.StageLevel.AutoSize = true;
            this.StageLevel.BackColor = System.Drawing.Color.Transparent;
            this.StageLevel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StageLevel.Location = new System.Drawing.Point(272, 9);
            this.StageLevel.Name = "StageLevel";
            this.StageLevel.Size = new System.Drawing.Size(96, 15);
            this.StageLevel.TabIndex = 21;
            this.StageLevel.Text = "Stage Level";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheQuest.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(766, 402);
            this.Controls.Add(this.StageLevel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Mace);
            this.Controls.Add(this.Potion_Blue);
            this.Controls.Add(this.Potion_Red);
            this.Controls.Add(this.Bow);
            this.Controls.Add(this.Ghost);
            this.Controls.Add(this.Ghoul);
            this.Controls.Add(this.Bat);
            this.Controls.Add(this.Sword);
            this.Controls.Add(this.Inven7);
            this.Controls.Add(this.Inven6);
            this.Controls.Add(this.InvenMace);
            this.Controls.Add(this.InvenRedPotion);
            this.Controls.Add(this.InvenBow);
            this.Controls.Add(this.InvenBluePotion);
            this.Controls.Add(this.InvenSword);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputKeyboard);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Potion_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Potion_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inven7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inven6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvenMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvenRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvenBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvenBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvenSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label playerHitPoint;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox InvenSword;
        private System.Windows.Forms.PictureBox InvenBluePotion;
        private System.Windows.Forms.PictureBox InvenBow;
        private System.Windows.Forms.PictureBox InvenRedPotion;
        private System.Windows.Forms.PictureBox InvenMace;
        private System.Windows.Forms.PictureBox Inven6;
        private System.Windows.Forms.PictureBox Inven7;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Sword;
        private System.Windows.Forms.PictureBox Bat;
        private System.Windows.Forms.PictureBox Ghoul;
        private System.Windows.Forms.PictureBox Ghost;
        private System.Windows.Forms.PictureBox Bow;
        private System.Windows.Forms.PictureBox Potion_Red;
        private System.Windows.Forms.PictureBox Potion_Blue;
        private System.Windows.Forms.PictureBox Mace;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label StageLevel;
    }
}

