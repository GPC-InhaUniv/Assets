namespace PuppyRace
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
            this.pbTrack = new System.Windows.Forms.PictureBox();
            this.pbDog1 = new System.Windows.Forms.PictureBox();
            this.pbDog2 = new System.Windows.Forms.PictureBox();
            this.pbDog3 = new System.Windows.Forms.PictureBox();
            this.pbDog4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IbName = new System.Windows.Forms.Label();
            this.btRace = new System.Windows.Forms.Button();
            this.numDogNumber = new System.Windows.Forms.NumericUpDown();
            this.numBucks = new System.Windows.Forms.NumericUpDown();
            this.btBets = new System.Windows.Forms.Button();
            this.lbAlBets = new System.Windows.Forms.Label();
            this.lbBobBets = new System.Windows.Forms.Label();
            this.lbJoeBets = new System.Windows.Forms.Label();
            this.rbAl = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBucks)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTrack
            // 
            this.pbTrack.Image = ((System.Drawing.Image)(resources.GetObject("pbTrack.Image")));
            this.pbTrack.Location = new System.Drawing.Point(9, 7);
            this.pbTrack.Name = "pbTrack";
            this.pbTrack.Size = new System.Drawing.Size(600, 203);
            this.pbTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrack.TabIndex = 0;
            this.pbTrack.TabStop = false;
            this.pbTrack.Click += new System.EventHandler(this.pbTrack_Click);
            // 
            // pbDog1
            // 
            this.pbDog1.Image = ((System.Drawing.Image)(resources.GetObject("pbDog1.Image")));
            this.pbDog1.Location = new System.Drawing.Point(25, 15);
            this.pbDog1.Name = "pbDog1";
            this.pbDog1.Size = new System.Drawing.Size(65, 24);
            this.pbDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog1.TabIndex = 1;
            this.pbDog1.TabStop = false;
            // 
            // pbDog2
            // 
            this.pbDog2.Image = ((System.Drawing.Image)(resources.GetObject("pbDog2.Image")));
            this.pbDog2.Location = new System.Drawing.Point(25, 61);
            this.pbDog2.Name = "pbDog2";
            this.pbDog2.Size = new System.Drawing.Size(65, 24);
            this.pbDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog2.TabIndex = 2;
            this.pbDog2.TabStop = false;
            // 
            // pbDog3
            // 
            this.pbDog3.Image = ((System.Drawing.Image)(resources.GetObject("pbDog3.Image")));
            this.pbDog3.Location = new System.Drawing.Point(25, 117);
            this.pbDog3.Name = "pbDog3";
            this.pbDog3.Size = new System.Drawing.Size(65, 24);
            this.pbDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog3.TabIndex = 3;
            this.pbDog3.TabStop = false;
            // 
            // pbDog4
            // 
            this.pbDog4.Image = ((System.Drawing.Image)(resources.GetObject("pbDog4.Image")));
            this.pbDog4.Location = new System.Drawing.Point(25, 169);
            this.pbDog4.Name = "pbDog4";
            this.pbDog4.Size = new System.Drawing.Size(65, 24);
            this.pbDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog4.TabIndex = 4;
            this.pbDog4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.IbName);
            this.groupBox1.Controls.Add(this.btRace);
            this.groupBox1.Controls.Add(this.numDogNumber);
            this.groupBox1.Controls.Add(this.numBucks);
            this.groupBox1.Controls.Add(this.btBets);
            this.groupBox1.Controls.Add(this.lbAlBets);
            this.groupBox1.Controls.Add(this.lbBobBets);
            this.groupBox1.Controls.Add(this.lbJoeBets);
            this.groupBox1.Controls.Add(this.rbAl);
            this.groupBox1.Controls.Add(this.rbBob);
            this.groupBox1.Controls.Add(this.rbJoe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 167);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "bucks on dog number";
            // 
            // IbName
            // 
            this.IbName.AutoSize = true;
            this.IbName.Location = new System.Drawing.Point(6, 142);
            this.IbName.Name = "IbName";
            this.IbName.Size = new System.Drawing.Size(25, 12);
            this.IbName.TabIndex = 11;
            this.IbName.Text = "Joe";
            this.IbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // btRace
            // 
            this.btRace.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btRace.Location = new System.Drawing.Point(487, 126);
            this.btRace.Name = "btRace";
            this.btRace.Size = new System.Drawing.Size(100, 38);
            this.btRace.TabIndex = 9;
            this.btRace.Text = "Race!";
            this.btRace.UseVisualStyleBackColor = true;
            this.btRace.Click += new System.EventHandler(this.btRace_Click);
            // 
            // numDogNumber
            // 
            this.numDogNumber.Location = new System.Drawing.Point(396, 139);
            this.numDogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDogNumber.Name = "numDogNumber";
            this.numDogNumber.Size = new System.Drawing.Size(75, 21);
            this.numDogNumber.TabIndex = 10;
            this.numDogNumber.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numBucks
            // 
            this.numBucks.Location = new System.Drawing.Point(144, 140);
            this.numBucks.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numBucks.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBucks.Name = "numBucks";
            this.numBucks.Size = new System.Drawing.Size(75, 21);
            this.numBucks.TabIndex = 9;
            this.numBucks.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btBets
            // 
            this.btBets.Location = new System.Drawing.Point(52, 139);
            this.btBets.Name = "btBets";
            this.btBets.Size = new System.Drawing.Size(86, 21);
            this.btBets.TabIndex = 8;
            this.btBets.Text = "Bets";
            this.btBets.UseVisualStyleBackColor = true;
            this.btBets.Click += new System.EventHandler(this.btBets_Click);
            // 
            // lbAlBets
            // 
            this.lbAlBets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAlBets.Location = new System.Drawing.Point(326, 97);
            this.lbAlBets.Name = "lbAlBets";
            this.lbAlBets.Size = new System.Drawing.Size(261, 18);
            this.lbAlBets.TabIndex = 7;
            this.lbAlBets.Text = "Al hasn\'t placed a bet";
            // 
            // lbBobBets
            // 
            this.lbBobBets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBobBets.Location = new System.Drawing.Point(326, 73);
            this.lbBobBets.Name = "lbBobBets";
            this.lbBobBets.Size = new System.Drawing.Size(261, 18);
            this.lbBobBets.TabIndex = 6;
            this.lbBobBets.Text = "Bob hasn\'t placed a bet";
            // 
            // lbJoeBets
            // 
            this.lbJoeBets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbJoeBets.Location = new System.Drawing.Point(326, 49);
            this.lbJoeBets.Name = "lbJoeBets";
            this.lbJoeBets.Size = new System.Drawing.Size(261, 18);
            this.lbJoeBets.TabIndex = 5;
            this.lbJoeBets.Text = "Joe hasn\'t placed a bet";
            // 
            // rbAl
            // 
            this.rbAl.AutoSize = true;
            this.rbAl.Location = new System.Drawing.Point(9, 92);
            this.rbAl.Name = "rbAl";
            this.rbAl.Size = new System.Drawing.Size(34, 16);
            this.rbAl.TabIndex = 4;
            this.rbAl.TabStop = true;
            this.rbAl.Text = "Al";
            this.rbAl.UseVisualStyleBackColor = true;
            this.rbAl.CheckedChanged += new System.EventHandler(this.rbAl_CheckedChanged);
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.Location = new System.Drawing.Point(9, 70);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(45, 16);
            this.rbBob.TabIndex = 3;
            this.rbBob.TabStop = true;
            this.rbBob.Text = "Bob";
            this.rbBob.UseVisualStyleBackColor = true;
            this.rbBob.CheckedChanged += new System.EventHandler(this.rbBob_CheckedChanged);
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.Location = new System.Drawing.Point(9, 48);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(43, 16);
            this.rbJoe.TabIndex = 2;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Joe";
            this.rbJoe.UseVisualStyleBackColor = true;
            this.rbJoe.CheckedChanged += new System.EventHandler(this.rbJoe_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(323, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum bet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbDog4);
            this.Controls.Add(this.pbDog3);
            this.Controls.Add(this.pbDog2);
            this.Controls.Add(this.pbDog1);
            this.Controls.Add(this.pbTrack);
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBucks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrack;
        private System.Windows.Forms.PictureBox pbDog1;
        private System.Windows.Forms.PictureBox pbDog2;
        private System.Windows.Forms.PictureBox pbDog3;
        private System.Windows.Forms.PictureBox pbDog4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbAlBets;
        private System.Windows.Forms.Label lbBobBets;
        private System.Windows.Forms.Label lbJoeBets;
        private System.Windows.Forms.RadioButton rbAl;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRace;
        private System.Windows.Forms.NumericUpDown numDogNumber;
        private System.Windows.Forms.NumericUpDown numBucks;
        private System.Windows.Forms.Button btBets;
        private System.Windows.Forms.Label IbName;
        private System.Windows.Forms.Label label3;
    }
}

