namespace 실습2_The_Quest
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
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbGhoul = new System.Windows.Forms.PictureBox();
            this.pbGhost = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbBat = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btMoveLeft = new System.Windows.Forms.Button();
            this.btMoveRight = new System.Windows.Forms.Button();
            this.btMoveDown = new System.Windows.Forms.Button();
            this.btMoveUp = new System.Windows.Forms.Button();
            this.btAttackRight = new System.Windows.Forms.Button();
            this.btAttackUp = new System.Windows.Forms.Button();
            this.btAttackLeft = new System.Windows.Forms.Button();
            this.btAttackDown = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(151, 160);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(34, 38);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Click += new System.EventHandler(this.pbPlayer_Click);
            // 
            // pbGhoul
            // 
            this.pbGhoul.BackColor = System.Drawing.Color.Transparent;
            this.pbGhoul.Image = ((System.Drawing.Image)(resources.GetObject("pbGhoul.Image")));
            this.pbGhoul.Location = new System.Drawing.Point(174, 72);
            this.pbGhoul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbGhoul.Name = "pbGhoul";
            this.pbGhoul.Size = new System.Drawing.Size(34, 38);
            this.pbGhoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGhoul.TabIndex = 1;
            this.pbGhoul.TabStop = false;
            // 
            // pbGhost
            // 
            this.pbGhost.BackColor = System.Drawing.Color.Transparent;
            this.pbGhost.Image = ((System.Drawing.Image)(resources.GetObject("pbGhost.Image")));
            this.pbGhost.Location = new System.Drawing.Point(110, 72);
            this.pbGhost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbGhost.Name = "pbGhost";
            this.pbGhost.Size = new System.Drawing.Size(34, 38);
            this.pbGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGhost.TabIndex = 2;
            this.pbGhost.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(343, 133);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pbBat
            // 
            this.pbBat.BackColor = System.Drawing.Color.Transparent;
            this.pbBat.Image = ((System.Drawing.Image)(resources.GetObject("pbBat.Image")));
            this.pbBat.Location = new System.Drawing.Point(376, 188);
            this.pbBat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbBat.Name = "pbBat";
            this.pbBat.Size = new System.Drawing.Size(34, 38);
            this.pbBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBat.TabIndex = 4;
            this.pbBat.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(279, 72);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(238, 72);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 38);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // btMoveLeft
            // 
            this.btMoveLeft.Location = new System.Drawing.Point(736, 81);
            this.btMoveLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btMoveLeft.Name = "btMoveLeft";
            this.btMoveLeft.Size = new System.Drawing.Size(86, 29);
            this.btMoveLeft.TabIndex = 7;
            this.btMoveLeft.Text = "Left";
            this.btMoveLeft.UseVisualStyleBackColor = true;
            this.btMoveLeft.Click += new System.EventHandler(this.btMoveLeft_Click);
            // 
            // btMoveRight
            // 
            this.btMoveRight.Location = new System.Drawing.Point(850, 81);
            this.btMoveRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btMoveRight.Name = "btMoveRight";
            this.btMoveRight.Size = new System.Drawing.Size(86, 29);
            this.btMoveRight.TabIndex = 8;
            this.btMoveRight.Text = "Right";
            this.btMoveRight.UseVisualStyleBackColor = true;
            this.btMoveRight.Click += new System.EventHandler(this.btMoveRight_Click);
            // 
            // btMoveDown
            // 
            this.btMoveDown.Location = new System.Drawing.Point(790, 118);
            this.btMoveDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btMoveDown.Name = "btMoveDown";
            this.btMoveDown.Size = new System.Drawing.Size(86, 29);
            this.btMoveDown.TabIndex = 9;
            this.btMoveDown.Text = "Down";
            this.btMoveDown.UseVisualStyleBackColor = true;
            this.btMoveDown.Click += new System.EventHandler(this.btMoveDown_Click);
            // 
            // btMoveUp
            // 
            this.btMoveUp.Location = new System.Drawing.Point(790, 45);
            this.btMoveUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btMoveUp.Name = "btMoveUp";
            this.btMoveUp.Size = new System.Drawing.Size(86, 29);
            this.btMoveUp.TabIndex = 10;
            this.btMoveUp.Text = "Up";
            this.btMoveUp.UseVisualStyleBackColor = true;
            this.btMoveUp.Click += new System.EventHandler(this.btMoveUp_Click);
            // 
            // btAttackRight
            // 
            this.btAttackRight.Location = new System.Drawing.Point(850, 232);
            this.btAttackRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAttackRight.Name = "btAttackRight";
            this.btAttackRight.Size = new System.Drawing.Size(86, 29);
            this.btAttackRight.TabIndex = 11;
            this.btAttackRight.Text = "Right";
            this.btAttackRight.UseVisualStyleBackColor = true;
            // 
            // btAttackUp
            // 
            this.btAttackUp.Location = new System.Drawing.Point(790, 196);
            this.btAttackUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAttackUp.Name = "btAttackUp";
            this.btAttackUp.Size = new System.Drawing.Size(86, 29);
            this.btAttackUp.TabIndex = 12;
            this.btAttackUp.Text = "Up";
            this.btAttackUp.UseVisualStyleBackColor = true;
            // 
            // btAttackLeft
            // 
            this.btAttackLeft.Location = new System.Drawing.Point(736, 232);
            this.btAttackLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAttackLeft.Name = "btAttackLeft";
            this.btAttackLeft.Size = new System.Drawing.Size(86, 29);
            this.btAttackLeft.TabIndex = 13;
            this.btAttackLeft.Text = "Left";
            this.btAttackLeft.UseVisualStyleBackColor = true;
            // 
            // btAttackDown
            // 
            this.btAttackDown.Location = new System.Drawing.Point(790, 269);
            this.btAttackDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAttackDown.Name = "btAttackDown";
            this.btAttackDown.Size = new System.Drawing.Size(86, 29);
            this.btAttackDown.TabIndex = 14;
            this.btAttackDown.Text = "Down";
            this.btAttackDown.UseVisualStyleBackColor = true;
            this.btAttackDown.Click += new System.EventHandler(this.btAttackDown_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.26316F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.73684F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(697, 305);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 131);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(81, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "playerHitPoint";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(81, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "batHitPoints";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ghost";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(81, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "ghostHitPoints";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ghoul";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(81, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 29);
            this.label10.TabIndex = 7;
            this.label10.Text = "ghoulHitPoints";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bat";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(695, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Attack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(695, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Move";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(402, 72);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(34, 38);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 18;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(361, 72);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(34, 38);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(343, 404);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(57, 62);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 20;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(279, 404);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(57, 62);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 21;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(215, 404);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(57, 62);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 22;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(151, 404);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(57, 62);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 23;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(87, 404);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(57, 62);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 24;
            this.pictureBox14.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(971, 501);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btAttackDown);
            this.Controls.Add(this.btAttackLeft);
            this.Controls.Add(this.btAttackUp);
            this.Controls.Add(this.btAttackRight);
            this.Controls.Add(this.btMoveUp);
            this.Controls.Add(this.btMoveDown);
            this.Controls.Add(this.btMoveRight);
            this.Controls.Add(this.btMoveLeft);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pbBat);
            this.Controls.Add(this.pbGhost);
            this.Controls.Add(this.pbGhoul);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbGhoul;
        private System.Windows.Forms.PictureBox pbGhost;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pbBat;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btMoveLeft;
        private System.Windows.Forms.Button btMoveRight;
        private System.Windows.Forms.Button btMoveDown;
        private System.Windows.Forms.Button btMoveUp;
        private System.Windows.Forms.Button btAttackRight;
        private System.Windows.Forms.Button btAttackUp;
        private System.Windows.Forms.Button btAttackLeft;
        private System.Windows.Forms.Button btAttackDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

