namespace GenericLinkedList
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
            this.Insertbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.LinkedListText = new System.Windows.Forms.RichTextBox();
            this.PrintNode = new System.Windows.Forms.Button();
            this.insertAtbtn = new System.Windows.Forms.Button();
            this.insertvalueUpDown = new System.Windows.Forms.NumericUpDown();
            this.insertPostionUpDown = new System.Windows.Forms.NumericUpDown();
            this.deletePositionUpdown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.insertvalueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertPostionUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePositionUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // Insertbtn
            // 
            this.Insertbtn.Location = new System.Drawing.Point(28, 211);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(75, 23);
            this.Insertbtn.TabIndex = 0;
            this.Insertbtn.Text = "Insert";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(236, 211);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 23);
            this.Deletebtn.TabIndex = 1;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // LinkedListText
            // 
            this.LinkedListText.Location = new System.Drawing.Point(14, 12);
            this.LinkedListText.Name = "LinkedListText";
            this.LinkedListText.Size = new System.Drawing.Size(503, 138);
            this.LinkedListText.TabIndex = 2;
            this.LinkedListText.Text = "";
            // 
            // PrintNode
            // 
            this.PrintNode.Location = new System.Drawing.Point(341, 211);
            this.PrintNode.Name = "PrintNode";
            this.PrintNode.Size = new System.Drawing.Size(75, 23);
            this.PrintNode.TabIndex = 3;
            this.PrintNode.Text = "PrintNode";
            this.PrintNode.UseVisualStyleBackColor = true;
            this.PrintNode.Click += new System.EventHandler(this.PrintNode_Click);
            // 
            // insertAtbtn
            // 
            this.insertAtbtn.Location = new System.Drawing.Point(128, 211);
            this.insertAtbtn.Name = "insertAtbtn";
            this.insertAtbtn.Size = new System.Drawing.Size(75, 23);
            this.insertAtbtn.TabIndex = 4;
            this.insertAtbtn.Text = "insertAt";
            this.insertAtbtn.UseVisualStyleBackColor = true;
            this.insertAtbtn.Click += new System.EventHandler(this.insertAtbtn_Click);
            // 
            // insertvalueUpDown
            // 
            this.insertvalueUpDown.Location = new System.Drawing.Point(28, 172);
            this.insertvalueUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.insertvalueUpDown.Name = "insertvalueUpDown";
            this.insertvalueUpDown.Size = new System.Drawing.Size(75, 21);
            this.insertvalueUpDown.TabIndex = 5;
            this.insertvalueUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.insertvalueUpDown.ValueChanged += new System.EventHandler(this.insertvalueUpDown_ValueChanged);
            // 
            // insertPostionUpDown
            // 
            this.insertPostionUpDown.Location = new System.Drawing.Point(128, 172);
            this.insertPostionUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.insertPostionUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.insertPostionUpDown.Name = "insertPostionUpDown";
            this.insertPostionUpDown.Size = new System.Drawing.Size(77, 21);
            this.insertPostionUpDown.TabIndex = 6;
            this.insertPostionUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // deletePositionUpdown
            // 
            this.deletePositionUpdown.Location = new System.Drawing.Point(236, 172);
            this.deletePositionUpdown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.deletePositionUpdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deletePositionUpdown.Name = "deletePositionUpdown";
            this.deletePositionUpdown.Size = new System.Drawing.Size(75, 21);
            this.deletePositionUpdown.TabIndex = 7;
            this.deletePositionUpdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "InsertPos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "DeletePos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletePositionUpdown);
            this.Controls.Add(this.insertPostionUpDown);
            this.Controls.Add(this.insertvalueUpDown);
            this.Controls.Add(this.insertAtbtn);
            this.Controls.Add(this.PrintNode);
            this.Controls.Add(this.LinkedListText);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Insertbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.insertvalueUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertPostionUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePositionUpdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.RichTextBox LinkedListText;
        private System.Windows.Forms.Button PrintNode;
        private System.Windows.Forms.Button insertAtbtn;
        private System.Windows.Forms.NumericUpDown insertvalueUpDown;
        private System.Windows.Forms.NumericUpDown insertPostionUpDown;
        private System.Windows.Forms.NumericUpDown deletePositionUpdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

