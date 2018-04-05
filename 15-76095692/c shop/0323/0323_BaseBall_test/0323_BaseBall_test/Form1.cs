using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0323_BaseBall_test
{
    public partial class Form1 : Form
    {
        Ball ball = new Ball();
        Pitcher pitcher;
        Fan fan;
        public Form1()
        {
            InitializeComponent();
            pitcher = new Pitcher(ball);
            fan = new Fan(ball);
        }

        private void PlayBallButton_Click(object sender, EventArgs e)
        {
            BallEventArgs ballEventArgs = new BallEventArgs((int)TrajectoryNumericUpDown.Value, (int)DistanceNumericUpDown.Value);
            ball.OnBallInPlay(ballEventArgs);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You just cliked on Form1");
        }
        private void SaySomething(object sender, EventArgs e)
        {
            MessageBox.Show("something");
        }
        private void SaySomethingElse(object sender, EventArgs e)
        {
            MessageBox.Show("Something else");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Click += new EventHandler(SaySomething);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Click += new EventHandler(SaySomethingElse);
        }
    }
}
