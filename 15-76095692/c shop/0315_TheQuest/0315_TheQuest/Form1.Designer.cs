namespace _0315_TheQuest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MoveLeftButton = new System.Windows.Forms.Button();
            this.MoveRightButton = new System.Windows.Forms.Button();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AttackLeftButton = new System.Windows.Forms.Button();
            this.AttackRightButton = new System.Windows.Forms.Button();
            this.AttackDownButton = new System.Windows.Forms.Button();
            this.AttackUpButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerHitPointLabel = new System.Windows.Forms.Label();
            this.BetHitPointLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GhoulHitPointLabel = new System.Windows.Forms.Label();
            this.GhostHitPointLabel = new System.Windows.Forms.Label();
            this.In_P_RedPictureBox = new System.Windows.Forms.PictureBox();
            this.In_P_BluePictureBox = new System.Windows.Forms.PictureBox();
            this.In_MacePictureBox = new System.Windows.Forms.PictureBox();
            this.In_BowPictureBox = new System.Windows.Forms.PictureBox();
            this.In_SowrdPictureBox = new System.Windows.Forms.PictureBox();
            this.BetPictureBox = new System.Windows.Forms.PictureBox();
            this.GhostPictureBox = new System.Windows.Forms.PictureBox();
            this.GhoulPictureBox = new System.Windows.Forms.PictureBox();
            this.P_RedPictureBox = new System.Windows.Forms.PictureBox();
            this.P_BluePictureBox = new System.Windows.Forms.PictureBox();
            this.MacePictureBox = new System.Windows.Forms.PictureBox();
            this.BowPictureBox = new System.Windows.Forms.PictureBox();
            this.SowrdPictureBox = new System.Windows.Forms.PictureBox();
            this.PlayerPictureBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.In_P_RedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.In_P_BluePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.In_MacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.In_BowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.In_SowrdPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_RedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_BluePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SowrdPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MoveLeftButton);
            this.groupBox1.Controls.Add(this.MoveRightButton);
            this.groupBox1.Controls.Add(this.MoveDownButton);
            this.groupBox1.Controls.Add(this.MoveUpButton);
            this.groupBox1.Location = new System.Drawing.Point(607, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // MoveLeftButton
            // 
            this.MoveLeftButton.Location = new System.Drawing.Point(20, 49);
            this.MoveLeftButton.Name = "MoveLeftButton";
            this.MoveLeftButton.Size = new System.Drawing.Size(75, 23);
            this.MoveLeftButton.TabIndex = 3;
            this.MoveLeftButton.Text = "Left";
            this.MoveLeftButton.UseVisualStyleBackColor = true;
            this.MoveLeftButton.Click += new System.EventHandler(this.MoveLeftButton_Click);
            // 
            // MoveRightButton
            // 
            this.MoveRightButton.Location = new System.Drawing.Point(140, 49);
            this.MoveRightButton.Name = "MoveRightButton";
            this.MoveRightButton.Size = new System.Drawing.Size(75, 23);
            this.MoveRightButton.TabIndex = 2;
            this.MoveRightButton.Text = "Right";
            this.MoveRightButton.UseVisualStyleBackColor = true;
            this.MoveRightButton.Click += new System.EventHandler(this.MoveRightButton_Click);
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Location = new System.Drawing.Point(80, 78);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(75, 23);
            this.MoveDownButton.TabIndex = 1;
            this.MoveDownButton.Text = "Down";
            this.MoveDownButton.UseVisualStyleBackColor = true;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Location = new System.Drawing.Point(80, 20);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(75, 23);
            this.MoveUpButton.TabIndex = 0;
            this.MoveUpButton.Text = "Up";
            this.MoveUpButton.UseVisualStyleBackColor = true;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AttackLeftButton);
            this.groupBox2.Controls.Add(this.AttackRightButton);
            this.groupBox2.Controls.Add(this.AttackDownButton);
            this.groupBox2.Controls.Add(this.AttackUpButton);
            this.groupBox2.Location = new System.Drawing.Point(607, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 114);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attack";
            // 
            // AttackLeftButton
            // 
            this.AttackLeftButton.Location = new System.Drawing.Point(20, 49);
            this.AttackLeftButton.Name = "AttackLeftButton";
            this.AttackLeftButton.Size = new System.Drawing.Size(75, 23);
            this.AttackLeftButton.TabIndex = 3;
            this.AttackLeftButton.Text = "Left";
            this.AttackLeftButton.UseVisualStyleBackColor = true;
            this.AttackLeftButton.Click += new System.EventHandler(this.AttackLeftButton_Click);
            // 
            // AttackRightButton
            // 
            this.AttackRightButton.Location = new System.Drawing.Point(140, 49);
            this.AttackRightButton.Name = "AttackRightButton";
            this.AttackRightButton.Size = new System.Drawing.Size(75, 23);
            this.AttackRightButton.TabIndex = 2;
            this.AttackRightButton.Text = "Right";
            this.AttackRightButton.UseVisualStyleBackColor = true;
            this.AttackRightButton.Click += new System.EventHandler(this.AttackRightButton_Click);
            // 
            // AttackDownButton
            // 
            this.AttackDownButton.Location = new System.Drawing.Point(80, 78);
            this.AttackDownButton.Name = "AttackDownButton";
            this.AttackDownButton.Size = new System.Drawing.Size(75, 23);
            this.AttackDownButton.TabIndex = 1;
            this.AttackDownButton.Text = "Down";
            this.AttackDownButton.UseVisualStyleBackColor = true;
            this.AttackDownButton.Click += new System.EventHandler(this.AttackDownButton_Click);
            // 
            // AttackUpButton
            // 
            this.AttackUpButton.Location = new System.Drawing.Point(80, 20);
            this.AttackUpButton.Name = "AttackUpButton";
            this.AttackUpButton.Size = new System.Drawing.Size(75, 23);
            this.AttackUpButton.TabIndex = 0;
            this.AttackUpButton.Text = "Up";
            this.AttackUpButton.UseVisualStyleBackColor = true;
            this.AttackUpButton.Click += new System.EventHandler(this.AttackUpButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.49505F));
            this.tableLayoutPanel1.Controls.Add(this.PlayerHitPointLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BetHitPointLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.GhoulHitPointLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.GhostHitPointLabel, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(607, 254);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(126, 134);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // PlayerHitPointLabel
            // 
            this.PlayerHitPointLabel.AutoSize = true;
            this.PlayerHitPointLabel.Location = new System.Drawing.Point(65, 0);
            this.PlayerHitPointLabel.Name = "PlayerHitPointLabel";
            this.PlayerHitPointLabel.Size = new System.Drawing.Size(55, 24);
            this.PlayerHitPointLabel.TabIndex = 4;
            this.PlayerHitPointLabel.Text = "PlayerHitPoint";
            // 
            // BetHitPointLabel
            // 
            this.BetHitPointLabel.AutoSize = true;
            this.BetHitPointLabel.Location = new System.Drawing.Point(65, 33);
            this.BetHitPointLabel.Name = "BetHitPointLabel";
            this.BetHitPointLabel.Size = new System.Drawing.Size(55, 24);
            this.BetHitPointLabel.TabIndex = 5;
            this.BetHitPointLabel.Text = "BetHitPoint";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghoul";
            // 
            // GhoulHitPointLabel
            // 
            this.GhoulHitPointLabel.AutoSize = true;
            this.GhoulHitPointLabel.Location = new System.Drawing.Point(65, 99);
            this.GhoulHitPointLabel.Name = "GhoulHitPointLabel";
            this.GhoulHitPointLabel.Size = new System.Drawing.Size(52, 24);
            this.GhoulHitPointLabel.TabIndex = 7;
            this.GhoulHitPointLabel.Text = "GhoulHitPoint";
            // 
            // GhostHitPointLabel
            // 
            this.GhostHitPointLabel.AutoSize = true;
            this.GhostHitPointLabel.Location = new System.Drawing.Point(65, 66);
            this.GhostHitPointLabel.Name = "GhostHitPointLabel";
            this.GhostHitPointLabel.Size = new System.Drawing.Size(52, 24);
            this.GhostHitPointLabel.TabIndex = 6;
            this.GhostHitPointLabel.Text = "GhostHitPoint";
            // 
            // In_P_RedPictureBox
            // 
            this.In_P_RedPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.In_P_RedPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("In_P_RedPictureBox.Image")));
            this.In_P_RedPictureBox.Location = new System.Drawing.Point(314, 317);
            this.In_P_RedPictureBox.Name = "In_P_RedPictureBox";
            this.In_P_RedPictureBox.Size = new System.Drawing.Size(50, 50);
            this.In_P_RedPictureBox.TabIndex = 19;
            this.In_P_RedPictureBox.TabStop = false;
            this.In_P_RedPictureBox.Visible = false;
            // 
            // In_P_BluePictureBox
            // 
            this.In_P_BluePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.In_P_BluePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("In_P_BluePictureBox.Image")));
            this.In_P_BluePictureBox.Location = new System.Drawing.Point(258, 317);
            this.In_P_BluePictureBox.Name = "In_P_BluePictureBox";
            this.In_P_BluePictureBox.Size = new System.Drawing.Size(50, 50);
            this.In_P_BluePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.In_P_BluePictureBox.TabIndex = 18;
            this.In_P_BluePictureBox.TabStop = false;
            this.In_P_BluePictureBox.Visible = false;
            // 
            // In_MacePictureBox
            // 
            this.In_MacePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.In_MacePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("In_MacePictureBox.Image")));
            this.In_MacePictureBox.Location = new System.Drawing.Point(202, 317);
            this.In_MacePictureBox.Name = "In_MacePictureBox";
            this.In_MacePictureBox.Size = new System.Drawing.Size(50, 50);
            this.In_MacePictureBox.TabIndex = 17;
            this.In_MacePictureBox.TabStop = false;
            this.In_MacePictureBox.Visible = false;
            // 
            // In_BowPictureBox
            // 
            this.In_BowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.In_BowPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("In_BowPictureBox.Image")));
            this.In_BowPictureBox.Location = new System.Drawing.Point(146, 317);
            this.In_BowPictureBox.Name = "In_BowPictureBox";
            this.In_BowPictureBox.Size = new System.Drawing.Size(50, 50);
            this.In_BowPictureBox.TabIndex = 16;
            this.In_BowPictureBox.TabStop = false;
            this.In_BowPictureBox.Visible = false;
            // 
            // In_SowrdPictureBox
            // 
            this.In_SowrdPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.In_SowrdPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("In_SowrdPictureBox.Image")));
            this.In_SowrdPictureBox.Location = new System.Drawing.Point(90, 317);
            this.In_SowrdPictureBox.Name = "In_SowrdPictureBox";
            this.In_SowrdPictureBox.Size = new System.Drawing.Size(50, 50);
            this.In_SowrdPictureBox.TabIndex = 15;
            this.In_SowrdPictureBox.TabStop = false;
            this.In_SowrdPictureBox.Visible = false;
            // 
            // BetPictureBox
            // 
            this.BetPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.BetPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BetPictureBox.Image")));
            this.BetPictureBox.Location = new System.Drawing.Point(290, 55);
            this.BetPictureBox.Name = "BetPictureBox";
            this.BetPictureBox.Size = new System.Drawing.Size(30, 30);
            this.BetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BetPictureBox.TabIndex = 13;
            this.BetPictureBox.TabStop = false;
            this.BetPictureBox.Visible = false;
            // 
            // GhostPictureBox
            // 
            this.GhostPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.GhostPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("GhostPictureBox.Image")));
            this.GhostPictureBox.Location = new System.Drawing.Point(326, 55);
            this.GhostPictureBox.Name = "GhostPictureBox";
            this.GhostPictureBox.Size = new System.Drawing.Size(30, 30);
            this.GhostPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GhostPictureBox.TabIndex = 12;
            this.GhostPictureBox.TabStop = false;
            this.GhostPictureBox.Visible = false;
            // 
            // GhoulPictureBox
            // 
            this.GhoulPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.GhoulPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("GhoulPictureBox.Image")));
            this.GhoulPictureBox.Location = new System.Drawing.Point(362, 55);
            this.GhoulPictureBox.Name = "GhoulPictureBox";
            this.GhoulPictureBox.Size = new System.Drawing.Size(30, 30);
            this.GhoulPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GhoulPictureBox.TabIndex = 11;
            this.GhoulPictureBox.TabStop = false;
            this.GhoulPictureBox.Visible = false;
            // 
            // P_RedPictureBox
            // 
            this.P_RedPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.P_RedPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("P_RedPictureBox.Image")));
            this.P_RedPictureBox.Location = new System.Drawing.Point(254, 55);
            this.P_RedPictureBox.Name = "P_RedPictureBox";
            this.P_RedPictureBox.Size = new System.Drawing.Size(30, 30);
            this.P_RedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P_RedPictureBox.TabIndex = 14;
            this.P_RedPictureBox.TabStop = false;
            this.P_RedPictureBox.Visible = false;
            // 
            // P_BluePictureBox
            // 
            this.P_BluePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.P_BluePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("P_BluePictureBox.Image")));
            this.P_BluePictureBox.Location = new System.Drawing.Point(218, 55);
            this.P_BluePictureBox.Name = "P_BluePictureBox";
            this.P_BluePictureBox.Size = new System.Drawing.Size(30, 30);
            this.P_BluePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P_BluePictureBox.TabIndex = 7;
            this.P_BluePictureBox.TabStop = false;
            this.P_BluePictureBox.Visible = false;
            // 
            // MacePictureBox
            // 
            this.MacePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.MacePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MacePictureBox.Image")));
            this.MacePictureBox.Location = new System.Drawing.Point(182, 55);
            this.MacePictureBox.Name = "MacePictureBox";
            this.MacePictureBox.Size = new System.Drawing.Size(30, 30);
            this.MacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MacePictureBox.TabIndex = 8;
            this.MacePictureBox.TabStop = false;
            this.MacePictureBox.Visible = false;
            // 
            // BowPictureBox
            // 
            this.BowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.BowPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BowPictureBox.Image")));
            this.BowPictureBox.Location = new System.Drawing.Point(146, 55);
            this.BowPictureBox.Name = "BowPictureBox";
            this.BowPictureBox.Size = new System.Drawing.Size(30, 30);
            this.BowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BowPictureBox.TabIndex = 9;
            this.BowPictureBox.TabStop = false;
            this.BowPictureBox.Visible = false;
            // 
            // SowrdPictureBox
            // 
            this.SowrdPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SowrdPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SowrdPictureBox.Image")));
            this.SowrdPictureBox.Location = new System.Drawing.Point(110, 55);
            this.SowrdPictureBox.Name = "SowrdPictureBox";
            this.SowrdPictureBox.Size = new System.Drawing.Size(30, 30);
            this.SowrdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SowrdPictureBox.TabIndex = 10;
            this.SowrdPictureBox.TabStop = false;
            this.SowrdPictureBox.Visible = false;
            // 
            // PlayerPictureBox
            // 
            this.PlayerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PlayerPictureBox.Image")));
            this.PlayerPictureBox.Location = new System.Drawing.Point(74, 55);
            this.PlayerPictureBox.Name = "PlayerPictureBox";
            this.PlayerPictureBox.Size = new System.Drawing.Size(30, 30);
            this.PlayerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerPictureBox.TabIndex = 6;
            this.PlayerPictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(772, 365);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 20;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(863, 400);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PlayerPictureBox);
            this.Controls.Add(this.In_P_RedPictureBox);
            this.Controls.Add(this.In_P_BluePictureBox);
            this.Controls.Add(this.In_MacePictureBox);
            this.Controls.Add(this.In_BowPictureBox);
            this.Controls.Add(this.In_SowrdPictureBox);
            this.Controls.Add(this.P_RedPictureBox);
            this.Controls.Add(this.BetPictureBox);
            this.Controls.Add(this.GhostPictureBox);
            this.Controls.Add(this.GhoulPictureBox);
            this.Controls.Add(this.SowrdPictureBox);
            this.Controls.Add(this.BowPictureBox);
            this.Controls.Add(this.MacePictureBox);
            this.Controls.Add(this.P_BluePictureBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.In_P_RedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.In_P_BluePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.In_MacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.In_BowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.In_SowrdPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_RedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_BluePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SowrdPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MoveLeftButton;
        private System.Windows.Forms.Button MoveRightButton;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Button MoveUpButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AttackLeftButton;
        private System.Windows.Forms.Button AttackRightButton;
        private System.Windows.Forms.Button AttackDownButton;
        private System.Windows.Forms.Button AttackUpButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox In_SowrdPictureBox;
        private System.Windows.Forms.PictureBox In_BowPictureBox;
        private System.Windows.Forms.PictureBox In_P_BluePictureBox;
        private System.Windows.Forms.PictureBox In_MacePictureBox;
        private System.Windows.Forms.PictureBox In_P_RedPictureBox;
        private System.Windows.Forms.PictureBox BetPictureBox;
        private System.Windows.Forms.PictureBox GhostPictureBox;
        private System.Windows.Forms.PictureBox GhoulPictureBox;
        private System.Windows.Forms.PictureBox P_RedPictureBox;
        private System.Windows.Forms.PictureBox P_BluePictureBox;
        private System.Windows.Forms.PictureBox MacePictureBox;
        private System.Windows.Forms.PictureBox BowPictureBox;
        private System.Windows.Forms.PictureBox SowrdPictureBox;
        private System.Windows.Forms.PictureBox PlayerPictureBox;
        private System.Windows.Forms.Label PlayerHitPointLabel;
        private System.Windows.Forms.Label BetHitPointLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GhoulHitPointLabel;
        private System.Windows.Forms.Label GhostHitPointLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

