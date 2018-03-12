using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleQueue
{
    public partial class Form1 : Form
    {

        CircleQueue mycirclequeue;

        string text = "";
        int value = 0;
        public Form1()
        {
            InitializeComponent();
            mycirclequeue = new CircleQueue();
            mycirclequeue.InitQueue();
            text = "Waiting For Command..";
            UpdateText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EnqeueBtn_Click(object sender, EventArgs e)
        {
            if (EnqueueValue.Text == "")
                MessageBox.Show("Please Input Value Before Enqueue");
            else
            {
                if (mycirclequeue.Enqueue(value))
                {
                    text = "Enqueue Button Clicked- " + value + " Enqueue at " + (CircleQueue.Nextpos);


                    // ResetNextPostionToZero();

                }
                else
                {

                    text = "CircleQueue is Full!! can't enqueue... ResetSize please! Current EndPosition :" + (CircleQueue.Nextpos);
                }
            }

            UpdateText();
        }

        private void UpdateText()
        {
            TextBox.Text = text;
        }

        private void EnqueueValue_TextChanged(object sender, EventArgs e)
        {
            value = Convert.ToInt32(EnqueueValue.Text);
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            text = "Show CircleQueue Information\r\n";
            text += mycirclequeue.ShowQueueInfo();
            UpdateText();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DequeueBtn_Click(object sender, EventArgs e)
        {
            text = mycirclequeue.Dequeue();
            UpdateText();
        }
    }
}
