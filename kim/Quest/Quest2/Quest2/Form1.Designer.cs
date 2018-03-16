namespace Quest2
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
            this.Player_Pic = new System.Windows.Forms.PictureBox();
            this.Up_move = new System.Windows.Forms.Button();
            this.left_move = new System.Windows.Forms.Button();
            this.Right_move = new System.Windows.Forms.Button();
            this.Down_move = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bat_Pic = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Up_attack = new System.Windows.Forms.Button();
            this.Left_Attack = new System.Windows.Forms.Button();
            this.Right_Attack = new System.Windows.Forms.Button();
            this.Down_Attack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerHP = new System.Windows.Forms.Label();
            this.BatHP = new System.Windows.Forms.Label();
            this.Sword_Drop_Pic = new System.Windows.Forms.PictureBox();
            this.Sword_Inven_Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player_Pic)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bat_Pic)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sword_Drop_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sword_Inven_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Player_Pic
            // 
            this.Player_Pic.BackColor = System.Drawing.Color.Transparent;
            this.Player_Pic.Image = ((System.Drawing.Image)(resources.GetObject("Player_Pic.Image")));
            this.Player_Pic.Location = new System.Drawing.Point(73, 54);
            this.Player_Pic.Name = "Player_Pic";
            this.Player_Pic.Size = new System.Drawing.Size(30, 30);
            this.Player_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player_Pic.TabIndex = 0;
            this.Player_Pic.TabStop = false;
            // 
            // Up_move
            // 
            this.Up_move.Location = new System.Drawing.Point(58, 15);
            this.Up_move.Name = "Up_move";
            this.Up_move.Size = new System.Drawing.Size(75, 23);
            this.Up_move.TabIndex = 1;
            this.Up_move.Text = "UP";
            this.Up_move.UseVisualStyleBackColor = true;
            this.Up_move.Click += new System.EventHandler(this.Up_move_Click);
            // 
            // left_move
            // 
            this.left_move.Location = new System.Drawing.Point(19, 42);
            this.left_move.Name = "left_move";
            this.left_move.Size = new System.Drawing.Size(75, 23);
            this.left_move.TabIndex = 2;
            this.left_move.Text = "LEFT";
            this.left_move.UseVisualStyleBackColor = true;
            this.left_move.Click += new System.EventHandler(this.left_move_Click);
            // 
            // Right_move
            // 
            this.Right_move.Location = new System.Drawing.Point(100, 42);
            this.Right_move.Name = "Right_move";
            this.Right_move.Size = new System.Drawing.Size(75, 23);
            this.Right_move.TabIndex = 3;
            this.Right_move.Text = "RIGHT";
            this.Right_move.UseVisualStyleBackColor = true;
            this.Right_move.Click += new System.EventHandler(this.Right_move_Click);
            // 
            // Down_move
            // 
            this.Down_move.Location = new System.Drawing.Point(58, 71);
            this.Down_move.Name = "Down_move";
            this.Down_move.Size = new System.Drawing.Size(75, 23);
            this.Down_move.TabIndex = 4;
            this.Down_move.Text = "DOWN";
            this.Down_move.UseVisualStyleBackColor = true;
            this.Down_move.Click += new System.EventHandler(this.Down_move_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.left_move);
            this.groupBox1.Controls.Add(this.Up_move);
            this.groupBox1.Controls.Add(this.Right_move);
            this.groupBox1.Controls.Add(this.Down_move);
            this.groupBox1.Location = new System.Drawing.Point(608, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // Bat_Pic
            // 
            this.Bat_Pic.BackColor = System.Drawing.Color.Transparent;
            this.Bat_Pic.Image = ((System.Drawing.Image)(resources.GetObject("Bat_Pic.Image")));
            this.Bat_Pic.Location = new System.Drawing.Point(373, 92);
            this.Bat_Pic.Name = "Bat_Pic";
            this.Bat_Pic.Size = new System.Drawing.Size(30, 30);
            this.Bat_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bat_Pic.TabIndex = 6;
            this.Bat_Pic.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Down_Attack);
            this.groupBox2.Controls.Add(this.Right_Attack);
            this.groupBox2.Controls.Add(this.Left_Attack);
            this.groupBox2.Controls.Add(this.Up_attack);
            this.groupBox2.Location = new System.Drawing.Point(608, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 113);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attack";
            // 
            // Up_attack
            // 
            this.Up_attack.Location = new System.Drawing.Point(58, 21);
            this.Up_attack.Name = "Up_attack";
            this.Up_attack.Size = new System.Drawing.Size(75, 23);
            this.Up_attack.TabIndex = 0;
            this.Up_attack.Text = "UP";
            this.Up_attack.UseVisualStyleBackColor = true;
            this.Up_attack.Click += new System.EventHandler(this.button1_Click);
            // 
            // Left_Attack
            // 
            this.Left_Attack.Location = new System.Drawing.Point(19, 50);
            this.Left_Attack.Name = "Left_Attack";
            this.Left_Attack.Size = new System.Drawing.Size(75, 23);
            this.Left_Attack.TabIndex = 1;
            this.Left_Attack.Text = "LEFT";
            this.Left_Attack.UseVisualStyleBackColor = true;
            this.Left_Attack.Click += new System.EventHandler(this.button2_Click);
            // 
            // Right_Attack
            // 
            this.Right_Attack.Location = new System.Drawing.Point(100, 49);
            this.Right_Attack.Name = "Right_Attack";
            this.Right_Attack.Size = new System.Drawing.Size(75, 23);
            this.Right_Attack.TabIndex = 2;
            this.Right_Attack.Text = "RIGHT";
            this.Right_Attack.UseVisualStyleBackColor = true;
            this.Right_Attack.Click += new System.EventHandler(this.button3_Click);
            // 
            // Down_Attack
            // 
            this.Down_Attack.Location = new System.Drawing.Point(58, 79);
            this.Down_Attack.Name = "Down_Attack";
            this.Down_Attack.Size = new System.Drawing.Size(75, 23);
            this.Down_Attack.TabIndex = 3;
            this.Down_Attack.Text = "DOWN";
            this.Down_Attack.UseVisualStyleBackColor = true;
            this.Down_Attack.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(608, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Player HP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(625, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bat HP :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ghost HP :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ghoul HP :";
            // 
            // PlayerHP
            // 
            this.PlayerHP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlayerHP.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlayerHP.Location = new System.Drawing.Point(683, 246);
            this.PlayerHP.Name = "PlayerHP";
            this.PlayerHP.Size = new System.Drawing.Size(37, 15);
            this.PlayerHP.TabIndex = 12;
            this.PlayerHP.Text = "0";
            // 
            // BatHP
            // 
            this.BatHP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BatHP.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BatHP.Location = new System.Drawing.Point(683, 272);
            this.BatHP.Name = "BatHP";
            this.BatHP.Size = new System.Drawing.Size(37, 15);
            this.BatHP.TabIndex = 13;
            this.BatHP.Text = "0";
            // 
            // Sword_Drop_Pic
            // 
            this.Sword_Drop_Pic.BackColor = System.Drawing.Color.Transparent;
            this.Sword_Drop_Pic.Image = ((System.Drawing.Image)(resources.GetObject("Sword_Drop_Pic.Image")));
            this.Sword_Drop_Pic.Location = new System.Drawing.Point(136, 105);
            this.Sword_Drop_Pic.Name = "Sword_Drop_Pic";
            this.Sword_Drop_Pic.Size = new System.Drawing.Size(30, 30);
            this.Sword_Drop_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sword_Drop_Pic.TabIndex = 14;
            this.Sword_Drop_Pic.TabStop = false;
            // 
            // Sword_Inven_Pic
            // 
            this.Sword_Inven_Pic.BackColor = System.Drawing.Color.Transparent;
            this.Sword_Inven_Pic.Image = ((System.Drawing.Image)(resources.GetObject("Sword_Inven_Pic.Image")));
            this.Sword_Inven_Pic.Location = new System.Drawing.Point(73, 315);
            this.Sword_Inven_Pic.Name = "Sword_Inven_Pic";
            this.Sword_Inven_Pic.Size = new System.Drawing.Size(50, 50);
            this.Sword_Inven_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sword_Inven_Pic.TabIndex = 15;
            this.Sword_Inven_Pic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(990, 399);
            this.Controls.Add(this.Sword_Inven_Pic);
            this.Controls.Add(this.Sword_Drop_Pic);
            this.Controls.Add(this.BatHP);
            this.Controls.Add(this.PlayerHP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Player_Pic);
            this.Controls.Add(this.Bat_Pic);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player_Pic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bat_Pic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sword_Drop_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sword_Inven_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player_Pic;
        private System.Windows.Forms.Button Up_move;
        private System.Windows.Forms.Button left_move;
        private System.Windows.Forms.Button Right_move;
        private System.Windows.Forms.Button Down_move;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Bat_Pic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Down_Attack;
        private System.Windows.Forms.Button Right_Attack;
        private System.Windows.Forms.Button Left_Attack;
        private System.Windows.Forms.Button Up_attack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PlayerHP;
        private System.Windows.Forms.Label BatHP;
        private System.Windows.Forms.PictureBox Sword_Drop_Pic;
        private System.Windows.Forms.PictureBox Sword_Inven_Pic;
    }
}

