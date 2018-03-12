namespace DogRaces
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbTrack = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRace = new System.Windows.Forms.Button();
            this.numDogNumber = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numBucks = new System.Windows.Forms.NumericUpDown();
            this.btBets = new System.Windows.Forms.Button();
            this.lbAlBets = new System.Windows.Forms.Label();
            this.lbBobBets = new System.Windows.Forms.Label();
            this.lbJoeBets = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.rbAl = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pbDog1 = new System.Windows.Forms.PictureBox();
            this.pbDog2 = new System.Windows.Forms.PictureBox();
            this.pbDog3 = new System.Windows.Forms.PictureBox();
            this.pbDog4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTrack
            // 
            this.pbTrack.Image = ((System.Drawing.Image)(resources.GetObject("pbTrack.Image")));
            this.pbTrack.Location = new System.Drawing.Point(14, 15);
            this.pbTrack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbTrack.Name = "pbTrack";
            this.pbTrack.Size = new System.Drawing.Size(625, 251);
            this.pbTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrack.TabIndex = 0;
            this.pbTrack.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRace);
            this.groupBox1.Controls.Add(this.numDogNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numBucks);
            this.groupBox1.Controls.Add(this.btBets);
            this.groupBox1.Controls.Add(this.lbAlBets);
            this.groupBox1.Controls.Add(this.lbBobBets);
            this.groupBox1.Controls.Add(this.lbJoeBets);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.rbAl);
            this.groupBox1.Controls.Add(this.rbBob);
            this.groupBox1.Controls.Add(this.rbJoe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 291);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(688, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // btRace
            // 
            this.btRace.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btRace.Location = new System.Drawing.Point(595, 184);
            this.btRace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRace.Name = "btRace";
            this.btRace.Size = new System.Drawing.Size(86, 41);
            this.btRace.TabIndex = 11;
            this.btRace.Text = "Race!";
            this.btRace.UseVisualStyleBackColor = true;
            this.btRace.Click += new System.EventHandler(this.btRace_Click);
            // 
            // numDogNumber
            // 
            this.numDogNumber.Location = new System.Drawing.Point(371, 195);
            this.numDogNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numDogNumber.Size = new System.Drawing.Size(63, 25);
            this.numDogNumber.TabIndex = 10;
            this.numDogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "bucks on dog number";
            // 
            // numBucks
            // 
            this.numBucks.Location = new System.Drawing.Point(147, 195);
            this.numBucks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numBucks.Size = new System.Drawing.Size(63, 25);
            this.numBucks.TabIndex = 8;
            this.numBucks.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btBets
            // 
            this.btBets.Location = new System.Drawing.Point(55, 194);
            this.btBets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btBets.Name = "btBets";
            this.btBets.Size = new System.Drawing.Size(86, 29);
            this.btBets.TabIndex = 7;
            this.btBets.Text = "Bets";
            this.btBets.UseVisualStyleBackColor = true;
            this.btBets.Click += new System.EventHandler(this.btBets_Click);
            // 
            // lbAlBets
            // 
            this.lbAlBets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAlBets.Location = new System.Drawing.Point(330, 141);
            this.lbAlBets.Name = "lbAlBets";
            this.lbAlBets.Size = new System.Drawing.Size(351, 28);
            this.lbAlBets.TabIndex = 6;
            this.lbAlBets.Text = "Al hasn\'t placed a bet";
            this.lbAlBets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBobBets
            // 
            this.lbBobBets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBobBets.Location = new System.Drawing.Point(330, 105);
            this.lbBobBets.Name = "lbBobBets";
            this.lbBobBets.Size = new System.Drawing.Size(351, 28);
            this.lbBobBets.TabIndex = 6;
            this.lbBobBets.Text = "Bob hasn\'t placed a bet";
            this.lbBobBets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbJoeBets
            // 
            this.lbJoeBets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbJoeBets.Location = new System.Drawing.Point(330, 68);
            this.lbJoeBets.Name = "lbJoeBets";
            this.lbJoeBets.Size = new System.Drawing.Size(351, 28);
            this.lbJoeBets.TabIndex = 6;
            this.lbJoeBets.Text = "Joe hasn\'t placed a bet";
            this.lbJoeBets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(327, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bets";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(9, 200);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(30, 15);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Joe";
            // 
            // rbAl
            // 
            this.rbAl.AutoSize = true;
            this.rbAl.Location = new System.Drawing.Point(11, 140);
            this.rbAl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAl.Name = "rbAl";
            this.rbAl.Size = new System.Drawing.Size(40, 19);
            this.rbAl.TabIndex = 3;
            this.rbAl.Text = "Al";
            this.rbAl.UseVisualStyleBackColor = true;
            this.rbAl.Click += new System.EventHandler(this.rbName_Click);
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.Location = new System.Drawing.Point(11, 104);
            this.rbBob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(55, 19);
            this.rbBob.TabIndex = 2;
            this.rbBob.Text = "Bob";
            this.rbBob.UseVisualStyleBackColor = true;
            this.rbBob.Click += new System.EventHandler(this.rbName_Click);
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.Checked = true;
            this.rbJoe.Location = new System.Drawing.Point(11, 66);
            this.rbJoe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(51, 19);
            this.rbJoe.TabIndex = 1;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Joe";
            this.rbJoe.UseVisualStyleBackColor = true;
            this.rbJoe.Click += new System.EventHandler(this.rbName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum bet: 5 bucks";
            // 
            // pbDog1
            // 
            this.pbDog1.Image = ((System.Drawing.Image)(resources.GetObject("pbDog1.Image")));
            this.pbDog1.Location = new System.Drawing.Point(32, 40);
            this.pbDog1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbDog1.Name = "pbDog1";
            this.pbDog1.Size = new System.Drawing.Size(73, 25);
            this.pbDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog1.TabIndex = 2;
            this.pbDog1.TabStop = false;
            // 
            // pbDog2
            // 
            this.pbDog2.Image = ((System.Drawing.Image)(resources.GetObject("pbDog2.Image")));
            this.pbDog2.Location = new System.Drawing.Point(32, 91);
            this.pbDog2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbDog2.Name = "pbDog2";
            this.pbDog2.Size = new System.Drawing.Size(73, 25);
            this.pbDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog2.TabIndex = 2;
            this.pbDog2.TabStop = false;
            // 
            // pbDog3
            // 
            this.pbDog3.Image = ((System.Drawing.Image)(resources.GetObject("pbDog3.Image")));
            this.pbDog3.Location = new System.Drawing.Point(32, 155);
            this.pbDog3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbDog3.Name = "pbDog3";
            this.pbDog3.Size = new System.Drawing.Size(73, 25);
            this.pbDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog3.TabIndex = 2;
            this.pbDog3.TabStop = false;
            // 
            // pbDog4
            // 
            this.pbDog4.Image = ((System.Drawing.Image)(resources.GetObject("pbDog4.Image")));
            this.pbDog4.Location = new System.Drawing.Point(32, 220);
            this.pbDog4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbDog4.Name = "pbDog4";
            this.pbDog4.Size = new System.Drawing.Size(73, 25);
            this.pbDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog4.TabIndex = 2;
            this.pbDog4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 541);
            this.Controls.Add(this.pbDog4);
            this.Controls.Add(this.pbDog3);
            this.Controls.Add(this.pbDog2);
            this.Controls.Add(this.pbDog1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.pbTrack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbAlBets;
        private System.Windows.Forms.Label lbBobBets;
        private System.Windows.Forms.Label lbJoeBets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.RadioButton rbAl;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRace;
        private System.Windows.Forms.NumericUpDown numDogNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numBucks;
        private System.Windows.Forms.Button btBets;
        private System.Windows.Forms.PictureBox pbDog1;
        private System.Windows.Forms.PictureBox pbDog2;
        private System.Windows.Forms.PictureBox pbDog3;
        private System.Windows.Forms.PictureBox pbDog4;
    }
}

