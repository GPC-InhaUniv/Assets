namespace DogRunnig
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
            this.pBDog4 = new System.Windows.Forms.PictureBox();
            this.pBDog3 = new System.Windows.Forms.PictureBox();
            this.pBDog2 = new System.Windows.Forms.PictureBox();
            this.pBDog1 = new System.Windows.Forms.PictureBox();
            this.pBTrack = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.udDog = new System.Windows.Forms.NumericUpDown();
            this.udMoney = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.laText = new System.Windows.Forms.Label();
            this.btBets = new System.Windows.Forms.Button();
            this.laAlBat = new System.Windows.Forms.Label();
            this.laBobBat = new System.Windows.Forms.Label();
            this.laJoeBat = new System.Windows.Forms.Label();
            this.laBats = new System.Windows.Forms.Label();
            this.laBatName = new System.Windows.Forms.Label();
            this.rBAl = new System.Windows.Forms.RadioButton();
            this.rBBob = new System.Windows.Forms.RadioButton();
            this.rBJoe = new System.Windows.Forms.RadioButton();
            this.laMiniBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBDog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTrack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // pBDog4
            // 
            this.pBDog4.Image = global::DogRunnig.Properties.Resources.dog;
            this.pBDog4.Location = new System.Drawing.Point(35, 221);
            this.pBDog4.Name = "pBDog4";
            this.pBDog4.Size = new System.Drawing.Size(100, 50);
            this.pBDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBDog4.TabIndex = 4;
            this.pBDog4.TabStop = false;
            // 
            // pBDog3
            // 
            this.pBDog3.Image = global::DogRunnig.Properties.Resources.dog;
            this.pBDog3.Location = new System.Drawing.Point(35, 156);
            this.pBDog3.Name = "pBDog3";
            this.pBDog3.Size = new System.Drawing.Size(100, 50);
            this.pBDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBDog3.TabIndex = 3;
            this.pBDog3.TabStop = false;
            // 
            // pBDog2
            // 
            this.pBDog2.Image = global::DogRunnig.Properties.Resources.dog;
            this.pBDog2.Location = new System.Drawing.Point(35, 81);
            this.pBDog2.Name = "pBDog2";
            this.pBDog2.Size = new System.Drawing.Size(100, 50);
            this.pBDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBDog2.TabIndex = 2;
            this.pBDog2.TabStop = false;
            // 
            // pBDog1
            // 
            this.pBDog1.Image = ((System.Drawing.Image)(resources.GetObject("pBDog1.Image")));
            this.pBDog1.Location = new System.Drawing.Point(35, 13);
            this.pBDog1.Name = "pBDog1";
            this.pBDog1.Size = new System.Drawing.Size(100, 50);
            this.pBDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBDog1.TabIndex = 1;
            this.pBDog1.TabStop = false;
            // 
            // pBTrack
            // 
            this.pBTrack.Image = global::DogRunnig.Properties.Resources.racetrack;
            this.pBTrack.Location = new System.Drawing.Point(13, 13);
            this.pBTrack.Name = "pBTrack";
            this.pBTrack.Size = new System.Drawing.Size(807, 269);
            this.pBTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBTrack.TabIndex = 0;
            this.pBTrack.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.udDog);
            this.groupBox1.Controls.Add(this.udMoney);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btStart);
            this.groupBox1.Controls.Add(this.laText);
            this.groupBox1.Controls.Add(this.btBets);
            this.groupBox1.Controls.Add(this.laAlBat);
            this.groupBox1.Controls.Add(this.laBobBat);
            this.groupBox1.Controls.Add(this.laJoeBat);
            this.groupBox1.Controls.Add(this.laBats);
            this.groupBox1.Controls.Add(this.laBatName);
            this.groupBox1.Controls.Add(this.rBAl);
            this.groupBox1.Controls.Add(this.rBBob);
            this.groupBox1.Controls.Add(this.rBJoe);
            this.groupBox1.Controls.Add(this.laMiniBet);
            this.groupBox1.Location = new System.Drawing.Point(13, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 177);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "베팅 설정";
            // 
            // udDog
            // 
            this.udDog.Location = new System.Drawing.Point(302, 143);
            this.udDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udDog.Name = "udDog";
            this.udDog.Size = new System.Drawing.Size(42, 25);
            this.udDog.TabIndex = 16;
            this.udDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udMoney
            // 
            this.udMoney.Location = new System.Drawing.Point(213, 143);
            this.udMoney.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udMoney.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udMoney.Name = "udMoney";
            this.udMoney.Size = new System.Drawing.Size(40, 25);
            this.udMoney.TabIndex = 15;
            this.udMoney.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "번 개에게";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(533, 139);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(268, 32);
            this.btStart.TabIndex = 13;
            this.btStart.Text = "경주 시작";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // laText
            // 
            this.laText.AutoSize = true;
            this.laText.Location = new System.Drawing.Point(259, 148);
            this.laText.Name = "laText";
            this.laText.Size = new System.Drawing.Size(37, 15);
            this.laText.TabIndex = 11;
            this.laText.Text = "원을";
            // 
            // btBets
            // 
            this.btBets.Location = new System.Drawing.Point(428, 133);
            this.btBets.Name = "btBets";
            this.btBets.Size = new System.Drawing.Size(86, 38);
            this.btBets.TabIndex = 9;
            this.btBets.Text = "베팅하기";
            this.btBets.UseVisualStyleBackColor = true;
            this.btBets.Click += new System.EventHandler(this.btBets_Click);
            // 
            // laAlBat
            // 
            this.laAlBat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laAlBat.Location = new System.Drawing.Point(533, 113);
            this.laAlBat.Name = "laAlBat";
            this.laAlBat.Size = new System.Drawing.Size(268, 23);
            this.laAlBat.TabIndex = 8;
            this.laAlBat.Text = "al bat";
            // 
            // laBobBat
            // 
            this.laBobBat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laBobBat.Location = new System.Drawing.Point(533, 82);
            this.laBobBat.Name = "laBobBat";
            this.laBobBat.Size = new System.Drawing.Size(268, 23);
            this.laBobBat.TabIndex = 7;
            this.laBobBat.Text = "bobbat";
            // 
            // laJoeBat
            // 
            this.laJoeBat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laJoeBat.Location = new System.Drawing.Point(533, 51);
            this.laJoeBat.Name = "laJoeBat";
            this.laJoeBat.Size = new System.Drawing.Size(268, 23);
            this.laJoeBat.TabIndex = 6;
            this.laJoeBat.Text = "joe bat";
            // 
            // laBats
            // 
            this.laBats.AutoSize = true;
            this.laBats.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.laBats.Location = new System.Drawing.Point(530, 25);
            this.laBats.Name = "laBats";
            this.laBats.Size = new System.Drawing.Size(77, 15);
            this.laBats.TabIndex = 5;
            this.laBats.Text = "베팅 상황";
            // 
            // laBatName
            // 
            this.laBatName.AutoSize = true;
            this.laBatName.Location = new System.Drawing.Point(162, 148);
            this.laBatName.Name = "laBatName";
            this.laBatName.Size = new System.Drawing.Size(45, 15);
            this.laBatName.TabIndex = 4;
            this.laBatName.Text = "label1";
            // 
            // rBAl
            // 
            this.rBAl.AutoSize = true;
            this.rBAl.Location = new System.Drawing.Point(10, 108);
            this.rBAl.Name = "rBAl";
            this.rBAl.Size = new System.Drawing.Size(40, 19);
            this.rBAl.TabIndex = 3;
            this.rBAl.TabStop = true;
            this.rBAl.Text = "Al";
            this.rBAl.UseVisualStyleBackColor = true;
            this.rBAl.CheckedChanged += new System.EventHandler(this.rBAl_CheckedChanged);
            // 
            // rBBob
            // 
            this.rBBob.AutoSize = true;
            this.rBBob.Location = new System.Drawing.Point(10, 83);
            this.rBBob.Name = "rBBob";
            this.rBBob.Size = new System.Drawing.Size(55, 19);
            this.rBBob.TabIndex = 2;
            this.rBBob.TabStop = true;
            this.rBBob.Text = "Bob";
            this.rBBob.UseVisualStyleBackColor = true;
            this.rBBob.CheckedChanged += new System.EventHandler(this.rBBob_CheckedChanged);
            // 
            // rBJoe
            // 
            this.rBJoe.AutoSize = true;
            this.rBJoe.Location = new System.Drawing.Point(10, 58);
            this.rBJoe.Name = "rBJoe";
            this.rBJoe.Size = new System.Drawing.Size(51, 19);
            this.rBJoe.TabIndex = 1;
            this.rBJoe.TabStop = true;
            this.rBJoe.Text = "Joe";
            this.rBJoe.UseVisualStyleBackColor = true;
            this.rBJoe.CheckedChanged += new System.EventHandler(this.rBJoe_CheckedChanged);
            // 
            // laMiniBet
            // 
            this.laMiniBet.AutoSize = true;
            this.laMiniBet.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.laMiniBet.Location = new System.Drawing.Point(7, 25);
            this.laMiniBet.Name = "laMiniBet";
            this.laMiniBet.Size = new System.Drawing.Size(128, 17);
            this.laMiniBet.TabIndex = 0;
            this.laMiniBet.Text = "최소 베팅 금액";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pBDog4);
            this.Controls.Add(this.pBDog3);
            this.Controls.Add(this.pBDog2);
            this.Controls.Add(this.pBDog1);
            this.Controls.Add(this.pBTrack);
            this.Name = "Form1";
            this.Text = "개 경주 게임 - 최대원";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBDog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTrack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label laText;
        private System.Windows.Forms.Button btBets;
        private System.Windows.Forms.Label laAlBat;
        private System.Windows.Forms.Label laBobBat;
        private System.Windows.Forms.Label laJoeBat;
        private System.Windows.Forms.Label laBats;
        private System.Windows.Forms.Label laBatName;
        private System.Windows.Forms.RadioButton rBAl;
        private System.Windows.Forms.RadioButton rBBob;
        private System.Windows.Forms.RadioButton rBJoe;
        private System.Windows.Forms.Label laMiniBet;
        public System.Windows.Forms.PictureBox pBDog1;
        public System.Windows.Forms.PictureBox pBDog2;
        public System.Windows.Forms.PictureBox pBDog3;
        public System.Windows.Forms.PictureBox pBDog4;
        public System.Windows.Forms.PictureBox pBTrack;
        private System.Windows.Forms.NumericUpDown udDog;
        private System.Windows.Forms.NumericUpDown udMoney;
    }
}

