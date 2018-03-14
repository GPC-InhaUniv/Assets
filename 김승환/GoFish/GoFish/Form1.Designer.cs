namespace GoFish
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
            this.labelMyName = new System.Windows.Forms.Label();
            this.textBoxMyName = new System.Windows.Forms.TextBox();
            this.buttonGameStart = new System.Windows.Forms.Button();
            this.labelGameProgress = new System.Windows.Forms.Label();
            this.textBoxGameProgress = new System.Windows.Forms.TextBox();
            this.labelBooks = new System.Windows.Forms.Label();
            this.textBoxBooks = new System.Windows.Forms.TextBox();
            this.labelYourHand = new System.Windows.Forms.Label();
            this.listBoxYourHand = new System.Windows.Forms.ListBox();
            this.buttonAskCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMyName
            // 
            this.labelMyName.AutoSize = true;
            this.labelMyName.Location = new System.Drawing.Point(12, 9);
            this.labelMyName.Name = "labelMyName";
            this.labelMyName.Size = new System.Drawing.Size(69, 12);
            this.labelMyName.TabIndex = 0;
            this.labelMyName.Text = "Your Name";
            // 
            // textBoxMyName
            // 
            this.textBoxMyName.Location = new System.Drawing.Point(12, 24);
            this.textBoxMyName.Name = "textBoxMyName";
            this.textBoxMyName.Size = new System.Drawing.Size(191, 21);
            this.textBoxMyName.TabIndex = 1;
            // 
            // buttonGameStart
            // 
            this.buttonGameStart.Location = new System.Drawing.Point(209, 24);
            this.buttonGameStart.Name = "buttonGameStart";
            this.buttonGameStart.Size = new System.Drawing.Size(116, 23);
            this.buttonGameStart.TabIndex = 2;
            this.buttonGameStart.Text = "Start the Game!";
            this.buttonGameStart.UseVisualStyleBackColor = true;
            this.buttonGameStart.Click += new System.EventHandler(this.buttonGameStart_Click);
            // 
            // labelGameProgress
            // 
            this.labelGameProgress.AutoSize = true;
            this.labelGameProgress.Location = new System.Drawing.Point(12, 65);
            this.labelGameProgress.Name = "labelGameProgress";
            this.labelGameProgress.Size = new System.Drawing.Size(94, 12);
            this.labelGameProgress.TabIndex = 3;
            this.labelGameProgress.Text = "Game Progress";
            // 
            // textBoxGameProgress
            // 
            this.textBoxGameProgress.Location = new System.Drawing.Point(12, 80);
            this.textBoxGameProgress.Multiline = true;
            this.textBoxGameProgress.Name = "textBoxGameProgress";
            this.textBoxGameProgress.Size = new System.Drawing.Size(313, 261);
            this.textBoxGameProgress.TabIndex = 4;
            // 
            // labelBooks
            // 
            this.labelBooks.AutoSize = true;
            this.labelBooks.Location = new System.Drawing.Point(12, 355);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(40, 12);
            this.labelBooks.TabIndex = 5;
            this.labelBooks.Text = "Books";
            // 
            // textBoxBooks
            // 
            this.textBoxBooks.Location = new System.Drawing.Point(12, 370);
            this.textBoxBooks.Multiline = true;
            this.textBoxBooks.Name = "textBoxBooks";
            this.textBoxBooks.Size = new System.Drawing.Size(313, 114);
            this.textBoxBooks.TabIndex = 6;
            // 
            // labelYourHand
            // 
            this.labelYourHand.AutoSize = true;
            this.labelYourHand.Location = new System.Drawing.Point(330, 9);
            this.labelYourHand.Name = "labelYourHand";
            this.labelYourHand.Size = new System.Drawing.Size(64, 12);
            this.labelYourHand.TabIndex = 7;
            this.labelYourHand.Text = "Your Hand";
            // 
            // listBoxYourHand
            // 
            this.listBoxYourHand.FormattingEnabled = true;
            this.listBoxYourHand.ItemHeight = 12;
            this.listBoxYourHand.Location = new System.Drawing.Point(331, 24);
            this.listBoxYourHand.Name = "listBoxYourHand";
            this.listBoxYourHand.Size = new System.Drawing.Size(208, 424);
            this.listBoxYourHand.TabIndex = 8;
            // 
            // buttonAskCard
            // 
            this.buttonAskCard.Location = new System.Drawing.Point(331, 455);
            this.buttonAskCard.Name = "buttonAskCard";
            this.buttonAskCard.Size = new System.Drawing.Size(208, 29);
            this.buttonAskCard.TabIndex = 9;
            this.buttonAskCard.Text = "Ask for a Card";
            this.buttonAskCard.UseVisualStyleBackColor = true;
            this.buttonAskCard.Click += new System.EventHandler(this.buttonAskCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 498);
            this.Controls.Add(this.buttonAskCard);
            this.Controls.Add(this.listBoxYourHand);
            this.Controls.Add(this.labelYourHand);
            this.Controls.Add(this.textBoxBooks);
            this.Controls.Add(this.labelBooks);
            this.Controls.Add(this.textBoxGameProgress);
            this.Controls.Add(this.labelGameProgress);
            this.Controls.Add(this.buttonGameStart);
            this.Controls.Add(this.textBoxMyName);
            this.Controls.Add(this.labelMyName);
            this.Name = "Form1";
            this.Text = "Go Fish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMyName;
        private System.Windows.Forms.TextBox textBoxMyName;
        private System.Windows.Forms.Button buttonGameStart;
        private System.Windows.Forms.Label labelGameProgress;
        private System.Windows.Forms.TextBox textBoxGameProgress;
        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.TextBox textBoxBooks;
        private System.Windows.Forms.Label labelYourHand;
        private System.Windows.Forms.ListBox listBoxYourHand;
        private System.Windows.Forms.Button buttonAskCard;
    }
}

