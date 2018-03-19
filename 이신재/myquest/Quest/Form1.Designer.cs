namespace Quest
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
            this.btnmovedown = new System.Windows.Forms.Button();
            this.btnmoveright = new System.Windows.Forms.Button();
            this.btnmoveleft = new System.Windows.Forms.Button();
            this.btnmoveup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnattackdown = new System.Windows.Forms.Button();
            this.btnattackright = new System.Windows.Forms.Button();
            this.btnattackup = new System.Windows.Forms.Button();
            this.btnattackleft = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtmastereihp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtyasuohp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtteemohp = new System.Windows.Forms.Label();
            this.txtplayerhp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pctinvenredpotion = new System.Windows.Forms.PictureBox();
            this.pctinvenbluepotion = new System.Windows.Forms.PictureBox();
            this.pctinvenbow = new System.Windows.Forms.PictureBox();
            this.pctinvensword = new System.Windows.Forms.PictureBox();
            this.pctinvenaxe = new System.Windows.Forms.PictureBox();
            this.pctplayer = new System.Windows.Forms.PictureBox();
            this.pctredpotion = new System.Windows.Forms.PictureBox();
            this.pctbluepotion = new System.Windows.Forms.PictureBox();
            this.pctbow = new System.Windows.Forms.PictureBox();
            this.pctsword = new System.Windows.Forms.PictureBox();
            this.pctteemo = new System.Windows.Forms.PictureBox();
            this.pctmasterei = new System.Windows.Forms.PictureBox();
            this.pctaxe = new System.Windows.Forms.PictureBox();
            this.pctyasuo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctinvenredpotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctinvenbluepotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctinvenbow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctinvensword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctinvenaxe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctredpotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbluepotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctsword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctteemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctmasterei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctaxe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctyasuo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnmovedown);
            this.groupBox1.Controls.Add(this.btnmoveright);
            this.groupBox1.Controls.Add(this.btnmoveleft);
            this.groupBox1.Controls.Add(this.btnmoveup);
            this.groupBox1.Location = new System.Drawing.Point(902, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // btnmovedown
            // 
            this.btnmovedown.Location = new System.Drawing.Point(72, 78);
            this.btnmovedown.Name = "btnmovedown";
            this.btnmovedown.Size = new System.Drawing.Size(75, 23);
            this.btnmovedown.TabIndex = 3;
            this.btnmovedown.Text = "Down";
            this.btnmovedown.UseVisualStyleBackColor = true;
            this.btnmovedown.Click += new System.EventHandler(this.btnmovedown_Click);
            // 
            // btnmoveright
            // 
            this.btnmoveright.Location = new System.Drawing.Point(129, 48);
            this.btnmoveright.Name = "btnmoveright";
            this.btnmoveright.Size = new System.Drawing.Size(75, 23);
            this.btnmoveright.TabIndex = 2;
            this.btnmoveright.Text = "Right";
            this.btnmoveright.UseVisualStyleBackColor = true;
            this.btnmoveright.Click += new System.EventHandler(this.btnmoveright_Click);
            // 
            // btnmoveleft
            // 
            this.btnmoveleft.Location = new System.Drawing.Point(18, 48);
            this.btnmoveleft.Name = "btnmoveleft";
            this.btnmoveleft.Size = new System.Drawing.Size(75, 23);
            this.btnmoveleft.TabIndex = 1;
            this.btnmoveleft.Text = "Left";
            this.btnmoveleft.UseVisualStyleBackColor = true;
            this.btnmoveleft.Click += new System.EventHandler(this.btnmoveleft_Click);
            // 
            // btnmoveup
            // 
            this.btnmoveup.Location = new System.Drawing.Point(72, 19);
            this.btnmoveup.Name = "btnmoveup";
            this.btnmoveup.Size = new System.Drawing.Size(75, 23);
            this.btnmoveup.TabIndex = 0;
            this.btnmoveup.Text = "Up";
            this.btnmoveup.UseVisualStyleBackColor = true;
            this.btnmoveup.Click += new System.EventHandler(this.btnmoveup_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnattackdown);
            this.groupBox2.Controls.Add(this.btnattackright);
            this.groupBox2.Controls.Add(this.btnattackup);
            this.groupBox2.Controls.Add(this.btnattackleft);
            this.groupBox2.Location = new System.Drawing.Point(902, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 108);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attack and UsingPotion";
            // 
            // btnattackdown
            // 
            this.btnattackdown.Location = new System.Drawing.Point(72, 79);
            this.btnattackdown.Name = "btnattackdown";
            this.btnattackdown.Size = new System.Drawing.Size(75, 23);
            this.btnattackdown.TabIndex = 7;
            this.btnattackdown.Text = "Down";
            this.btnattackdown.UseVisualStyleBackColor = true;
            this.btnattackdown.Click += new System.EventHandler(this.btnattackdown_Click);
            // 
            // btnattackright
            // 
            this.btnattackright.Location = new System.Drawing.Point(129, 49);
            this.btnattackright.Name = "btnattackright";
            this.btnattackright.Size = new System.Drawing.Size(75, 23);
            this.btnattackright.TabIndex = 6;
            this.btnattackright.Text = "Right";
            this.btnattackright.UseVisualStyleBackColor = true;
            this.btnattackright.Click += new System.EventHandler(this.btnattackright_Click);
            // 
            // btnattackup
            // 
            this.btnattackup.Location = new System.Drawing.Point(72, 20);
            this.btnattackup.Name = "btnattackup";
            this.btnattackup.Size = new System.Drawing.Size(75, 23);
            this.btnattackup.TabIndex = 4;
            this.btnattackup.Text = "Up";
            this.btnattackup.UseVisualStyleBackColor = true;
            this.btnattackup.Click += new System.EventHandler(this.btnattackup_Click);
            // 
            // btnattackleft
            // 
            this.btnattackleft.Location = new System.Drawing.Point(18, 49);
            this.btnattackleft.Name = "btnattackleft";
            this.btnattackleft.Size = new System.Drawing.Size(75, 23);
            this.btnattackleft.TabIndex = 5;
            this.btnattackleft.Text = "Left";
            this.btnattackleft.UseVisualStyleBackColor = true;
            this.btnattackleft.Click += new System.EventHandler(this.btnattackleft_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtmastereihp);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtyasuohp);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtteemohp);
            this.groupBox3.Controls.Add(this.txtplayerhp);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(902, 449);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 151);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HP";
            // 
            // txtmastereihp
            // 
            this.txtmastereihp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtmastereihp.Location = new System.Drawing.Point(72, 121);
            this.txtmastereihp.Name = "txtmastereihp";
            this.txtmastereihp.Size = new System.Drawing.Size(76, 13);
            this.txtmastereihp.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Master ei";
            // 
            // txtyasuohp
            // 
            this.txtyasuohp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtyasuohp.Location = new System.Drawing.Point(72, 88);
            this.txtyasuohp.Name = "txtyasuohp";
            this.txtyasuohp.Size = new System.Drawing.Size(76, 13);
            this.txtyasuohp.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Yasuo";
            // 
            // txtteemohp
            // 
            this.txtteemohp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtteemohp.Location = new System.Drawing.Point(72, 57);
            this.txtteemohp.Name = "txtteemohp";
            this.txtteemohp.Size = new System.Drawing.Size(76, 13);
            this.txtteemohp.TabIndex = 16;
            // 
            // txtplayerhp
            // 
            this.txtplayerhp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtplayerhp.Location = new System.Drawing.Point(72, 27);
            this.txtplayerhp.Name = "txtplayerhp";
            this.txtplayerhp.Size = new System.Drawing.Size(76, 13);
            this.txtplayerhp.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Teemo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Player";
            // 
            // pctinvenredpotion
            // 
            this.pctinvenredpotion.Image = global::Quest.Properties.Resources.빨간포션;
            this.pctinvenredpotion.Location = new System.Drawing.Point(508, 490);
            this.pctinvenredpotion.Name = "pctinvenredpotion";
            this.pctinvenredpotion.Size = new System.Drawing.Size(60, 60);
            this.pctinvenredpotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctinvenredpotion.TabIndex = 17;
            this.pctinvenredpotion.TabStop = false;
            // 
            // pctinvenbluepotion
            // 
            this.pctinvenbluepotion.Image = global::Quest.Properties.Resources.파란포션;
            this.pctinvenbluepotion.Location = new System.Drawing.Point(412, 490);
            this.pctinvenbluepotion.Name = "pctinvenbluepotion";
            this.pctinvenbluepotion.Size = new System.Drawing.Size(60, 60);
            this.pctinvenbluepotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctinvenbluepotion.TabIndex = 16;
            this.pctinvenbluepotion.TabStop = false;
            // 
            // pctinvenbow
            // 
            this.pctinvenbow.Image = global::Quest.Properties.Resources.활;
            this.pctinvenbow.Location = new System.Drawing.Point(317, 490);
            this.pctinvenbow.Name = "pctinvenbow";
            this.pctinvenbow.Size = new System.Drawing.Size(60, 60);
            this.pctinvenbow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctinvenbow.TabIndex = 15;
            this.pctinvenbow.TabStop = false;
            // 
            // pctinvensword
            // 
            this.pctinvensword.Image = global::Quest.Properties.Resources.무한의대검;
            this.pctinvensword.Location = new System.Drawing.Point(220, 490);
            this.pctinvensword.Name = "pctinvensword";
            this.pctinvensword.Size = new System.Drawing.Size(60, 60);
            this.pctinvensword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctinvensword.TabIndex = 14;
            this.pctinvensword.TabStop = false;
            // 
            // pctinvenaxe
            // 
            this.pctinvenaxe.Image = global::Quest.Properties.Resources.도끼;
            this.pctinvenaxe.Location = new System.Drawing.Point(127, 490);
            this.pctinvenaxe.Name = "pctinvenaxe";
            this.pctinvenaxe.Size = new System.Drawing.Size(60, 60);
            this.pctinvenaxe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctinvenaxe.TabIndex = 13;
            this.pctinvenaxe.TabStop = false;
            // 
            // pctplayer
            // 
            this.pctplayer.BackColor = System.Drawing.Color.Transparent;
            this.pctplayer.Image = ((System.Drawing.Image)(resources.GetObject("pctplayer.Image")));
            this.pctplayer.Location = new System.Drawing.Point(127, 98);
            this.pctplayer.Name = "pctplayer";
            this.pctplayer.Size = new System.Drawing.Size(30, 30);
            this.pctplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctplayer.TabIndex = 12;
            this.pctplayer.TabStop = false;
            // 
            // pctredpotion
            // 
            this.pctredpotion.BackColor = System.Drawing.Color.Transparent;
            this.pctredpotion.Image = ((System.Drawing.Image)(resources.GetObject("pctredpotion.Image")));
            this.pctredpotion.Location = new System.Drawing.Point(538, 98);
            this.pctredpotion.Name = "pctredpotion";
            this.pctredpotion.Size = new System.Drawing.Size(30, 30);
            this.pctredpotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctredpotion.TabIndex = 11;
            this.pctredpotion.TabStop = false;
            // 
            // pctbluepotion
            // 
            this.pctbluepotion.BackColor = System.Drawing.Color.Transparent;
            this.pctbluepotion.Image = ((System.Drawing.Image)(resources.GetObject("pctbluepotion.Image")));
            this.pctbluepotion.Location = new System.Drawing.Point(495, 98);
            this.pctbluepotion.Name = "pctbluepotion";
            this.pctbluepotion.Size = new System.Drawing.Size(30, 30);
            this.pctbluepotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbluepotion.TabIndex = 10;
            this.pctbluepotion.TabStop = false;
            this.pctbluepotion.Click += new System.EventHandler(this.pctbluepotion_Click);
            // 
            // pctbow
            // 
            this.pctbow.Image = global::Quest.Properties.Resources.활;
            this.pctbow.Location = new System.Drawing.Point(451, 98);
            this.pctbow.Name = "pctbow";
            this.pctbow.Size = new System.Drawing.Size(30, 30);
            this.pctbow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbow.TabIndex = 9;
            this.pctbow.TabStop = false;
            // 
            // pctsword
            // 
            this.pctsword.Image = global::Quest.Properties.Resources.무한의대검;
            this.pctsword.Location = new System.Drawing.Point(408, 98);
            this.pctsword.Name = "pctsword";
            this.pctsword.Size = new System.Drawing.Size(30, 30);
            this.pctsword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctsword.TabIndex = 8;
            this.pctsword.TabStop = false;
            // 
            // pctteemo
            // 
            this.pctteemo.BackColor = System.Drawing.Color.Transparent;
            this.pctteemo.Image = ((System.Drawing.Image)(resources.GetObject("pctteemo.Image")));
            this.pctteemo.Location = new System.Drawing.Point(250, 98);
            this.pctteemo.Name = "pctteemo";
            this.pctteemo.Size = new System.Drawing.Size(30, 30);
            this.pctteemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctteemo.TabIndex = 7;
            this.pctteemo.TabStop = false;
            // 
            // pctmasterei
            // 
            this.pctmasterei.BackColor = System.Drawing.Color.Transparent;
            this.pctmasterei.Image = ((System.Drawing.Image)(resources.GetObject("pctmasterei.Image")));
            this.pctmasterei.Location = new System.Drawing.Point(293, 98);
            this.pctmasterei.Name = "pctmasterei";
            this.pctmasterei.Size = new System.Drawing.Size(30, 30);
            this.pctmasterei.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctmasterei.TabIndex = 6;
            this.pctmasterei.TabStop = false;
            // 
            // pctaxe
            // 
            this.pctaxe.Image = global::Quest.Properties.Resources.도끼;
            this.pctaxe.Location = new System.Drawing.Point(365, 98);
            this.pctaxe.Name = "pctaxe";
            this.pctaxe.Size = new System.Drawing.Size(30, 30);
            this.pctaxe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctaxe.TabIndex = 5;
            this.pctaxe.TabStop = false;
            // 
            // pctyasuo
            // 
            this.pctyasuo.BackColor = System.Drawing.Color.Transparent;
            this.pctyasuo.Image = global::Quest.Properties.Resources.과학충11;
            this.pctyasuo.Location = new System.Drawing.Point(205, 98);
            this.pctyasuo.Name = "pctyasuo";
            this.pctyasuo.Size = new System.Drawing.Size(30, 30);
            this.pctyasuo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctyasuo.TabIndex = 4;
            this.pctyasuo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1114, 600);
            this.Controls.Add(this.pctplayer);
            this.Controls.Add(this.pctyasuo);
            this.Controls.Add(this.pctteemo);
            this.Controls.Add(this.pctinvenredpotion);
            this.Controls.Add(this.pctinvenbluepotion);
            this.Controls.Add(this.pctinvenbow);
            this.Controls.Add(this.pctinvensword);
            this.Controls.Add(this.pctinvenaxe);
            this.Controls.Add(this.pctmasterei);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pctbow);
            this.Controls.Add(this.pctsword);
            this.Controls.Add(this.pctaxe);
            this.Controls.Add(this.pctredpotion);
            this.Controls.Add(this.pctbluepotion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctinvenredpotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctinvenbluepotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctinvenbow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctinvensword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctinvenaxe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctredpotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbluepotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctsword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctteemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctmasterei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctaxe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctyasuo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmovedown;
        private System.Windows.Forms.Button btnmoveright;
        private System.Windows.Forms.Button btnmoveleft;
        private System.Windows.Forms.Button btnmoveup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnattackdown;
        private System.Windows.Forms.Button btnattackright;
        private System.Windows.Forms.Button btnattackup;
        private System.Windows.Forms.Button btnattackleft;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txtmastereihp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtyasuohp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtteemohp;
        private System.Windows.Forms.Label txtplayerhp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctyasuo;
        private System.Windows.Forms.PictureBox pctaxe;
        private System.Windows.Forms.PictureBox pctmasterei;
        private System.Windows.Forms.PictureBox pctteemo;
        private System.Windows.Forms.PictureBox pctsword;
        private System.Windows.Forms.PictureBox pctbow;
        private System.Windows.Forms.PictureBox pctbluepotion;
        private System.Windows.Forms.PictureBox pctredpotion;
        private System.Windows.Forms.PictureBox pctplayer;
        private System.Windows.Forms.PictureBox pctinvenredpotion;
        private System.Windows.Forms.PictureBox pctinvenbluepotion;
        private System.Windows.Forms.PictureBox pctinvenbow;
        private System.Windows.Forms.PictureBox pctinvensword;
        private System.Windows.Forms.PictureBox pctinvenaxe;
    }
}

