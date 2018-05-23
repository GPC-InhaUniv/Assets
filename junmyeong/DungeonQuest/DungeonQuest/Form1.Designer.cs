namespace DungeonQuest
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.swordPictureBox = new System.Windows.Forms.PictureBox();
            this.meleeMinionPictureBox = new System.Windows.Forms.PictureBox();
            this.casterMinionPictureBox = new System.Windows.Forms.PictureBox();
            this.siegeMinionPictureBox = new System.Windows.Forms.PictureBox();
            this.boxPictureBox = new System.Windows.Forms.PictureBox();
            this.redPotionPictureBox = new System.Windows.Forms.PictureBox();
            this.bluePotionPictureBox = new System.Windows.Forms.PictureBox();
            this.macePictureBox = new System.Windows.Forms.PictureBox();
            this.moveLabel = new System.Windows.Forms.Label();
            this.attackLabel = new System.Windows.Forms.Label();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.attackUpButton = new System.Windows.Forms.Button();
            this.attackLeftButton = new System.Windows.Forms.Button();
            this.attackRightButton = new System.Windows.Forms.Button();
            this.attackDownButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.siegeMinionHpLabel = new System.Windows.Forms.Label();
            this.casterMinionHpLabel = new System.Windows.Forms.Label();
            this.meleeMinionHpLabel = new System.Windows.Forms.Label();
            this.playerHpLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.meleeMinionLabel = new System.Windows.Forms.Label();
            this.casterMinionLabel = new System.Windows.Forms.Label();
            this.siegeMinionLabel = new System.Windows.Forms.Label();
            this.inSwordPictureBox = new System.Windows.Forms.PictureBox();
            this.inBowPictureBox = new System.Windows.Forms.PictureBox();
            this.inMacePictureBox = new System.Windows.Forms.PictureBox();
            this.inRedPotionPictureBox = new System.Windows.Forms.PictureBox();
            this.inBluePotionPictureBox = new System.Windows.Forms.PictureBox();
            this.progressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meleeMinionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casterMinionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siegeMinionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macePictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inSwordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inMacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inRedPotionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBluePotionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.playerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("playerPictureBox.Image")));
            this.playerPictureBox.Location = new System.Drawing.Point(730, 210);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(50, 50);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureBox.TabIndex = 1;
            this.playerPictureBox.TabStop = false;
            // 
            // swordPictureBox
            // 
            this.swordPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.swordPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("swordPictureBox.Image")));
            this.swordPictureBox.Location = new System.Drawing.Point(116, 101);
            this.swordPictureBox.Name = "swordPictureBox";
            this.swordPictureBox.Size = new System.Drawing.Size(35, 35);
            this.swordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swordPictureBox.TabIndex = 2;
            this.swordPictureBox.TabStop = false;
            this.swordPictureBox.Visible = false;
            // 
            // meleeMinionPictureBox
            // 
            this.meleeMinionPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.meleeMinionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("meleeMinionPictureBox.Image")));
            this.meleeMinionPictureBox.Location = new System.Drawing.Point(157, 101);
            this.meleeMinionPictureBox.Name = "meleeMinionPictureBox";
            this.meleeMinionPictureBox.Size = new System.Drawing.Size(35, 35);
            this.meleeMinionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.meleeMinionPictureBox.TabIndex = 3;
            this.meleeMinionPictureBox.TabStop = false;
            this.meleeMinionPictureBox.Visible = false;
            // 
            // casterMinionPictureBox
            // 
            this.casterMinionPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.casterMinionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("casterMinionPictureBox.Image")));
            this.casterMinionPictureBox.Location = new System.Drawing.Point(198, 101);
            this.casterMinionPictureBox.Name = "casterMinionPictureBox";
            this.casterMinionPictureBox.Size = new System.Drawing.Size(35, 35);
            this.casterMinionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.casterMinionPictureBox.TabIndex = 4;
            this.casterMinionPictureBox.TabStop = false;
            this.casterMinionPictureBox.Visible = false;
            // 
            // siegeMinionPictureBox
            // 
            this.siegeMinionPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.siegeMinionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("siegeMinionPictureBox.Image")));
            this.siegeMinionPictureBox.Location = new System.Drawing.Point(239, 101);
            this.siegeMinionPictureBox.Name = "siegeMinionPictureBox";
            this.siegeMinionPictureBox.Size = new System.Drawing.Size(35, 35);
            this.siegeMinionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siegeMinionPictureBox.TabIndex = 5;
            this.siegeMinionPictureBox.TabStop = false;
            this.siegeMinionPictureBox.Visible = false;
            // 
            // boxPictureBox
            // 
            this.boxPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.boxPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("boxPictureBox.Image")));
            this.boxPictureBox.Location = new System.Drawing.Point(280, 101);
            this.boxPictureBox.Name = "boxPictureBox";
            this.boxPictureBox.Size = new System.Drawing.Size(35, 35);
            this.boxPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxPictureBox.TabIndex = 6;
            this.boxPictureBox.TabStop = false;
            this.boxPictureBox.Visible = false;
            // 
            // redPotionPictureBox
            // 
            this.redPotionPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.redPotionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("redPotionPictureBox.Image")));
            this.redPotionPictureBox.Location = new System.Drawing.Point(321, 101);
            this.redPotionPictureBox.Name = "redPotionPictureBox";
            this.redPotionPictureBox.Size = new System.Drawing.Size(35, 35);
            this.redPotionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redPotionPictureBox.TabIndex = 7;
            this.redPotionPictureBox.TabStop = false;
            this.redPotionPictureBox.Visible = false;
            // 
            // bluePotionPictureBox
            // 
            this.bluePotionPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.bluePotionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("bluePotionPictureBox.Image")));
            this.bluePotionPictureBox.Location = new System.Drawing.Point(362, 101);
            this.bluePotionPictureBox.Name = "bluePotionPictureBox";
            this.bluePotionPictureBox.Size = new System.Drawing.Size(35, 35);
            this.bluePotionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePotionPictureBox.TabIndex = 8;
            this.bluePotionPictureBox.TabStop = false;
            this.bluePotionPictureBox.Visible = false;
            // 
            // macePictureBox
            // 
            this.macePictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.macePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("macePictureBox.Image")));
            this.macePictureBox.Location = new System.Drawing.Point(403, 101);
            this.macePictureBox.Name = "macePictureBox";
            this.macePictureBox.Size = new System.Drawing.Size(35, 35);
            this.macePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.macePictureBox.TabIndex = 9;
            this.macePictureBox.TabStop = false;
            this.macePictureBox.Visible = false;
            // 
            // moveLabel
            // 
            this.moveLabel.AutoSize = true;
            this.moveLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.moveLabel.Location = new System.Drawing.Point(959, 274);
            this.moveLabel.Name = "moveLabel";
            this.moveLabel.Size = new System.Drawing.Size(65, 16);
            this.moveLabel.TabIndex = 10;
            this.moveLabel.Text = "이동 키";
            // 
            // attackLabel
            // 
            this.attackLabel.AutoSize = true;
            this.attackLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.attackLabel.Location = new System.Drawing.Point(1161, 274);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(65, 16);
            this.attackLabel.TabIndex = 11;
            this.attackLabel.Text = "공격 키";
            // 
            // moveUpButton
            // 
            this.moveUpButton.Location = new System.Drawing.Point(962, 304);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(54, 29);
            this.moveUpButton.TabIndex = 12;
            this.moveUpButton.Text = "Up";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(907, 360);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(54, 29);
            this.moveLeftButton.TabIndex = 13;
            this.moveLeftButton.Text = "Left";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(962, 414);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(54, 29);
            this.moveDownButton.TabIndex = 14;
            this.moveDownButton.TabStop = false;
            this.moveDownButton.Text = "Down";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(1016, 360);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(54, 29);
            this.moveRightButton.TabIndex = 15;
            this.moveRightButton.Text = "Right";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // attackUpButton
            // 
            this.attackUpButton.Location = new System.Drawing.Point(1164, 304);
            this.attackUpButton.Name = "attackUpButton";
            this.attackUpButton.Size = new System.Drawing.Size(54, 29);
            this.attackUpButton.TabIndex = 16;
            this.attackUpButton.Text = "Up";
            this.attackUpButton.UseVisualStyleBackColor = true;
            this.attackUpButton.Click += new System.EventHandler(this.attackUpButton_Click);
            // 
            // attackLeftButton
            // 
            this.attackLeftButton.Location = new System.Drawing.Point(1109, 360);
            this.attackLeftButton.Name = "attackLeftButton";
            this.attackLeftButton.Size = new System.Drawing.Size(54, 29);
            this.attackLeftButton.TabIndex = 17;
            this.attackLeftButton.Text = "Left";
            this.attackLeftButton.UseVisualStyleBackColor = true;
            this.attackLeftButton.Click += new System.EventHandler(this.attackLeftButton_Click);
            // 
            // attackRightButton
            // 
            this.attackRightButton.Location = new System.Drawing.Point(1216, 360);
            this.attackRightButton.Name = "attackRightButton";
            this.attackRightButton.Size = new System.Drawing.Size(54, 29);
            this.attackRightButton.TabIndex = 18;
            this.attackRightButton.Text = "Right";
            this.attackRightButton.UseVisualStyleBackColor = true;
            this.attackRightButton.Click += new System.EventHandler(this.attackRightButton_Click);
            // 
            // attackDownButton
            // 
            this.attackDownButton.Location = new System.Drawing.Point(1164, 414);
            this.attackDownButton.Name = "attackDownButton";
            this.attackDownButton.Size = new System.Drawing.Size(54, 29);
            this.attackDownButton.TabIndex = 19;
            this.attackDownButton.Text = "Down";
            this.attackDownButton.UseVisualStyleBackColor = true;
            this.attackDownButton.Click += new System.EventHandler(this.attackDownButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.21622F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.78378F));
            this.tableLayoutPanel1.Controls.Add(this.siegeMinionHpLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.casterMinionHpLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.meleeMinionHpLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerHpLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.meleeMinionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.casterMinionLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.siegeMinionLabel, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(942, 459);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 215);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // siegeMinionHpLabel
            // 
            this.siegeMinionHpLabel.AutoSize = true;
            this.siegeMinionHpLabel.Font = new System.Drawing.Font("굴림", 13F);
            this.siegeMinionHpLabel.Location = new System.Drawing.Point(125, 129);
            this.siegeMinionHpLabel.Name = "siegeMinionHpLabel";
            this.siegeMinionHpLabel.Size = new System.Drawing.Size(125, 18);
            this.siegeMinionHpLabel.TabIndex = 7;
            this.siegeMinionHpLabel.Text = "SiegeMinionHp";
            // 
            // casterMinionHpLabel
            // 
            this.casterMinionHpLabel.AutoSize = true;
            this.casterMinionHpLabel.Font = new System.Drawing.Font("굴림", 13F);
            this.casterMinionHpLabel.Location = new System.Drawing.Point(125, 86);
            this.casterMinionHpLabel.Name = "casterMinionHpLabel";
            this.casterMinionHpLabel.Size = new System.Drawing.Size(134, 18);
            this.casterMinionHpLabel.TabIndex = 6;
            this.casterMinionHpLabel.Text = "CasterMinionHp";
            // 
            // meleeMinionHpLabel
            // 
            this.meleeMinionHpLabel.AutoSize = true;
            this.meleeMinionHpLabel.Font = new System.Drawing.Font("굴림", 13F);
            this.meleeMinionHpLabel.Location = new System.Drawing.Point(125, 43);
            this.meleeMinionHpLabel.Name = "meleeMinionHpLabel";
            this.meleeMinionHpLabel.Size = new System.Drawing.Size(129, 18);
            this.meleeMinionHpLabel.TabIndex = 5;
            this.meleeMinionHpLabel.Text = "MeleeMinionHp";
            this.meleeMinionHpLabel.Visible = false;
            // 
            // playerHpLabel
            // 
            this.playerHpLabel.AutoSize = true;
            this.playerHpLabel.Font = new System.Drawing.Font("굴림", 13F);
            this.playerHpLabel.Location = new System.Drawing.Point(125, 0);
            this.playerHpLabel.Name = "playerHpLabel";
            this.playerHpLabel.Size = new System.Drawing.Size(78, 18);
            this.playerHpLabel.TabIndex = 4;
            this.playerHpLabel.Text = "playerHp";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("굴림", 13F);
            this.playerLabel.Location = new System.Drawing.Point(3, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(64, 18);
            this.playerLabel.TabIndex = 0;
            this.playerLabel.Text = " Player";
            // 
            // meleeMinionLabel
            // 
            this.meleeMinionLabel.AutoSize = true;
            this.meleeMinionLabel.Font = new System.Drawing.Font("굴림", 13F);
            this.meleeMinionLabel.Location = new System.Drawing.Point(3, 43);
            this.meleeMinionLabel.Name = "meleeMinionLabel";
            this.meleeMinionLabel.Size = new System.Drawing.Size(108, 18);
            this.meleeMinionLabel.TabIndex = 1;
            this.meleeMinionLabel.Text = "MeleeMinion";
            this.meleeMinionLabel.Visible = false;
            // 
            // casterMinionLabel
            // 
            this.casterMinionLabel.AutoSize = true;
            this.casterMinionLabel.Font = new System.Drawing.Font("굴림", 13F);
            this.casterMinionLabel.Location = new System.Drawing.Point(3, 86);
            this.casterMinionLabel.Name = "casterMinionLabel";
            this.casterMinionLabel.Size = new System.Drawing.Size(113, 18);
            this.casterMinionLabel.TabIndex = 2;
            this.casterMinionLabel.Text = "CasterMinion";
            // 
            // siegeMinionLabel
            // 
            this.siegeMinionLabel.AutoSize = true;
            this.siegeMinionLabel.Font = new System.Drawing.Font("굴림", 13F);
            this.siegeMinionLabel.Location = new System.Drawing.Point(3, 129);
            this.siegeMinionLabel.Name = "siegeMinionLabel";
            this.siegeMinionLabel.Size = new System.Drawing.Size(104, 18);
            this.siegeMinionLabel.TabIndex = 3;
            this.siegeMinionLabel.Text = "SiegeMinion";
            // 
            // inSwordPictureBox
            // 
            this.inSwordPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("inSwordPictureBox.Image")));
            this.inSwordPictureBox.Location = new System.Drawing.Point(116, 482);
            this.inSwordPictureBox.Name = "inSwordPictureBox";
            this.inSwordPictureBox.Size = new System.Drawing.Size(60, 60);
            this.inSwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inSwordPictureBox.TabIndex = 21;
            this.inSwordPictureBox.TabStop = false;
            this.inSwordPictureBox.Visible = false;
            this.inSwordPictureBox.Click += new System.EventHandler(this.inSwordPictureBox_Click);
            // 
            // inBowPictureBox
            // 
            this.inBowPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("inBowPictureBox.Image")));
            this.inBowPictureBox.Location = new System.Drawing.Point(198, 482);
            this.inBowPictureBox.Name = "inBowPictureBox";
            this.inBowPictureBox.Size = new System.Drawing.Size(60, 60);
            this.inBowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inBowPictureBox.TabIndex = 22;
            this.inBowPictureBox.TabStop = false;
            this.inBowPictureBox.Visible = false;
            this.inBowPictureBox.Click += new System.EventHandler(this.inBowPictureBox_Click);
            // 
            // inMacePictureBox
            // 
            this.inMacePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("inMacePictureBox.Image")));
            this.inMacePictureBox.Location = new System.Drawing.Point(280, 482);
            this.inMacePictureBox.Name = "inMacePictureBox";
            this.inMacePictureBox.Size = new System.Drawing.Size(60, 60);
            this.inMacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inMacePictureBox.TabIndex = 23;
            this.inMacePictureBox.TabStop = false;
            this.inMacePictureBox.Visible = false;
            this.inMacePictureBox.Click += new System.EventHandler(this.inMacePictureBox_Click);
            // 
            // inRedPotionPictureBox
            // 
            this.inRedPotionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("inRedPotionPictureBox.Image")));
            this.inRedPotionPictureBox.Location = new System.Drawing.Point(362, 482);
            this.inRedPotionPictureBox.Name = "inRedPotionPictureBox";
            this.inRedPotionPictureBox.Size = new System.Drawing.Size(60, 60);
            this.inRedPotionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inRedPotionPictureBox.TabIndex = 24;
            this.inRedPotionPictureBox.TabStop = false;
            this.inRedPotionPictureBox.Visible = false;
            this.inRedPotionPictureBox.Click += new System.EventHandler(this.inRedPotionPictureBox_Click);
            // 
            // inBluePotionPictureBox
            // 
            this.inBluePotionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("inBluePotionPictureBox.Image")));
            this.inBluePotionPictureBox.Location = new System.Drawing.Point(444, 482);
            this.inBluePotionPictureBox.Name = "inBluePotionPictureBox";
            this.inBluePotionPictureBox.Size = new System.Drawing.Size(60, 60);
            this.inBluePotionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inBluePotionPictureBox.TabIndex = 25;
            this.inBluePotionPictureBox.TabStop = false;
            this.inBluePotionPictureBox.Visible = false;
            this.inBluePotionPictureBox.Click += new System.EventHandler(this.inBluePotionPictureBox_Click);
            // 
            // progressTextBox
            // 
            this.progressTextBox.Location = new System.Drawing.Point(907, 33);
            this.progressTextBox.Multiline = true;
            this.progressTextBox.Name = "progressTextBox";
            this.progressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.progressTextBox.Size = new System.Drawing.Size(392, 238);
            this.progressTextBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(904, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "진행 창";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1311, 686);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressTextBox);
            this.Controls.Add(this.inBluePotionPictureBox);
            this.Controls.Add(this.inRedPotionPictureBox);
            this.Controls.Add(this.inMacePictureBox);
            this.Controls.Add(this.inBowPictureBox);
            this.Controls.Add(this.inSwordPictureBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.attackDownButton);
            this.Controls.Add(this.attackRightButton);
            this.Controls.Add(this.attackLeftButton);
            this.Controls.Add(this.attackUpButton);
            this.Controls.Add(this.moveRightButton);
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveLeftButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.attackLabel);
            this.Controls.Add(this.moveLabel);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.macePictureBox);
            this.Controls.Add(this.bluePotionPictureBox);
            this.Controls.Add(this.redPotionPictureBox);
            this.Controls.Add(this.boxPictureBox);
            this.Controls.Add(this.siegeMinionPictureBox);
            this.Controls.Add(this.casterMinionPictureBox);
            this.Controls.Add(this.meleeMinionPictureBox);
            this.Controls.Add(this.swordPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meleeMinionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casterMinionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siegeMinionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macePictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inSwordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inMacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inRedPotionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBluePotionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.PictureBox swordPictureBox;
        private System.Windows.Forms.PictureBox meleeMinionPictureBox;
        private System.Windows.Forms.PictureBox casterMinionPictureBox;
        private System.Windows.Forms.PictureBox siegeMinionPictureBox;
        private System.Windows.Forms.PictureBox boxPictureBox;
        private System.Windows.Forms.PictureBox redPotionPictureBox;
        private System.Windows.Forms.PictureBox bluePotionPictureBox;
        private System.Windows.Forms.PictureBox macePictureBox;
        private System.Windows.Forms.Label moveLabel;
        private System.Windows.Forms.Label attackLabel;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button attackUpButton;
        private System.Windows.Forms.Button attackLeftButton;
        private System.Windows.Forms.Button attackRightButton;
        private System.Windows.Forms.Button attackDownButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label meleeMinionLabel;
        private System.Windows.Forms.Label casterMinionLabel;
        private System.Windows.Forms.Label siegeMinionLabel;
        private System.Windows.Forms.Label siegeMinionHpLabel;
        private System.Windows.Forms.Label casterMinionHpLabel;
        private System.Windows.Forms.Label meleeMinionHpLabel;
        private System.Windows.Forms.Label playerHpLabel;
        private System.Windows.Forms.PictureBox inSwordPictureBox;
        private System.Windows.Forms.PictureBox inBowPictureBox;
        private System.Windows.Forms.PictureBox inMacePictureBox;
        private System.Windows.Forms.PictureBox inRedPotionPictureBox;
        private System.Windows.Forms.PictureBox inBluePotionPictureBox;
        private System.Windows.Forms.TextBox progressTextBox;
        private System.Windows.Forms.Label label1;
    }
}

