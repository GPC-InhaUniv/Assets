namespace CardGames
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
            this.listBoxDeck1 = new System.Windows.Forms.ListBox();
            this.listBoxDeck2 = new System.Windows.Forms.ListBox();
            this.buttonMoveToDeck2 = new System.Windows.Forms.Button();
            this.buttonMoveToDeck1 = new System.Windows.Forms.Button();
            this.labelDeck1 = new System.Windows.Forms.Label();
            this.labelDeck2 = new System.Windows.Forms.Label();
            this.buttonResetDeck1 = new System.Windows.Forms.Button();
            this.buttonResetDeck2 = new System.Windows.Forms.Button();
            this.buttonShuffleDeck1 = new System.Windows.Forms.Button();
            this.buttonShuffleDeck2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDeck1
            // 
            this.listBoxDeck1.FormattingEnabled = true;
            this.listBoxDeck1.ItemHeight = 12;
            this.listBoxDeck1.Location = new System.Drawing.Point(12, 36);
            this.listBoxDeck1.Name = "listBoxDeck1";
            this.listBoxDeck1.Size = new System.Drawing.Size(137, 196);
            this.listBoxDeck1.TabIndex = 0;
            // 
            // listBoxDeck2
            // 
            this.listBoxDeck2.FormattingEnabled = true;
            this.listBoxDeck2.ItemHeight = 12;
            this.listBoxDeck2.Location = new System.Drawing.Point(225, 36);
            this.listBoxDeck2.Name = "listBoxDeck2";
            this.listBoxDeck2.Size = new System.Drawing.Size(137, 196);
            this.listBoxDeck2.TabIndex = 1;
            // 
            // buttonMoveToDeck2
            // 
            this.buttonMoveToDeck2.Location = new System.Drawing.Point(155, 82);
            this.buttonMoveToDeck2.Name = "buttonMoveToDeck2";
            this.buttonMoveToDeck2.Size = new System.Drawing.Size(64, 42);
            this.buttonMoveToDeck2.TabIndex = 2;
            this.buttonMoveToDeck2.Text = ">>";
            this.buttonMoveToDeck2.UseVisualStyleBackColor = true;
            this.buttonMoveToDeck2.Click += new System.EventHandler(this.buttonMoveToDeck2_Click);
            // 
            // buttonMoveToDeck1
            // 
            this.buttonMoveToDeck1.Location = new System.Drawing.Point(155, 149);
            this.buttonMoveToDeck1.Name = "buttonMoveToDeck1";
            this.buttonMoveToDeck1.Size = new System.Drawing.Size(64, 43);
            this.buttonMoveToDeck1.TabIndex = 3;
            this.buttonMoveToDeck1.Text = "<<";
            this.buttonMoveToDeck1.UseVisualStyleBackColor = true;
            this.buttonMoveToDeck1.Click += new System.EventHandler(this.buttonMoveToDeck1_Click);
            // 
            // labelDeck1
            // 
            this.labelDeck1.AutoSize = true;
            this.labelDeck1.Location = new System.Drawing.Point(12, 9);
            this.labelDeck1.Name = "labelDeck1";
            this.labelDeck1.Size = new System.Drawing.Size(49, 12);
            this.labelDeck1.TabIndex = 4;
            this.labelDeck1.Text = "Deck #1";
            // 
            // labelDeck2
            // 
            this.labelDeck2.AutoSize = true;
            this.labelDeck2.Location = new System.Drawing.Point(223, 9);
            this.labelDeck2.Name = "labelDeck2";
            this.labelDeck2.Size = new System.Drawing.Size(49, 12);
            this.labelDeck2.TabIndex = 5;
            this.labelDeck2.Text = "Deck #2";
            // 
            // buttonResetDeck1
            // 
            this.buttonResetDeck1.Location = new System.Drawing.Point(26, 265);
            this.buttonResetDeck1.Name = "buttonResetDeck1";
            this.buttonResetDeck1.Size = new System.Drawing.Size(110, 30);
            this.buttonResetDeck1.TabIndex = 6;
            this.buttonResetDeck1.Text = "Reset Deck #1";
            this.buttonResetDeck1.UseVisualStyleBackColor = true;
            this.buttonResetDeck1.Click += new System.EventHandler(this.buttonResetDeck1_Click);
            // 
            // buttonResetDeck2
            // 
            this.buttonResetDeck2.Location = new System.Drawing.Point(237, 265);
            this.buttonResetDeck2.Name = "buttonResetDeck2";
            this.buttonResetDeck2.Size = new System.Drawing.Size(110, 30);
            this.buttonResetDeck2.TabIndex = 6;
            this.buttonResetDeck2.Text = "Reset Deck #2";
            this.buttonResetDeck2.UseVisualStyleBackColor = true;
            this.buttonResetDeck2.Click += new System.EventHandler(this.buttonResetDeck2_Click);
            // 
            // buttonShuffleDeck1
            // 
            this.buttonShuffleDeck1.Location = new System.Drawing.Point(26, 322);
            this.buttonShuffleDeck1.Name = "buttonShuffleDeck1";
            this.buttonShuffleDeck1.Size = new System.Drawing.Size(110, 30);
            this.buttonShuffleDeck1.TabIndex = 6;
            this.buttonShuffleDeck1.Text = "Shuffle Deck #1";
            this.buttonShuffleDeck1.UseVisualStyleBackColor = true;
            this.buttonShuffleDeck1.Click += new System.EventHandler(this.buttonShuffleDeck1_Click);
            // 
            // buttonShuffleDeck2
            // 
            this.buttonShuffleDeck2.Location = new System.Drawing.Point(237, 322);
            this.buttonShuffleDeck2.Name = "buttonShuffleDeck2";
            this.buttonShuffleDeck2.Size = new System.Drawing.Size(110, 30);
            this.buttonShuffleDeck2.TabIndex = 6;
            this.buttonShuffleDeck2.Text = "Shuffle Deck #2";
            this.buttonShuffleDeck2.UseVisualStyleBackColor = true;
            this.buttonShuffleDeck2.Click += new System.EventHandler(this.buttonShuffleDeck2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 380);
            this.Controls.Add(this.buttonShuffleDeck2);
            this.Controls.Add(this.buttonResetDeck2);
            this.Controls.Add(this.buttonShuffleDeck1);
            this.Controls.Add(this.buttonResetDeck1);
            this.Controls.Add(this.labelDeck2);
            this.Controls.Add(this.labelDeck1);
            this.Controls.Add(this.buttonMoveToDeck1);
            this.Controls.Add(this.buttonMoveToDeck2);
            this.Controls.Add(this.listBoxDeck2);
            this.Controls.Add(this.listBoxDeck1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDeck1;
        private System.Windows.Forms.ListBox listBoxDeck2;
        private System.Windows.Forms.Button buttonMoveToDeck2;
        private System.Windows.Forms.Button buttonMoveToDeck1;
        private System.Windows.Forms.Label labelDeck1;
        private System.Windows.Forms.Label labelDeck2;
        private System.Windows.Forms.Button buttonResetDeck1;
        private System.Windows.Forms.Button buttonResetDeck2;
        private System.Windows.Forms.Button buttonShuffleDeck1;
        private System.Windows.Forms.Button buttonShuffleDeck2;
    }
}

