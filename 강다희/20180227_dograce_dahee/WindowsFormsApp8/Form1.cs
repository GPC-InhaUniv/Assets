using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private Guy[] guys;
        private Greyhound[] dogs;

        public Form1()
        {
            InitializeComponent();

            guys = new Guy[3]; //판돈을 거는 사람들의 이름+소지금액

            guys[0] = new Guy() { Name = "joe", Cash = 3000 };
            guys[1] = new Guy() { Name = "bob", Cash = 3000 };
            guys[2] = new Guy() { Name = "al", Cash = 3000 };

            dogs = new Greyhound[4]; //각 개의 픽쳐박스 이름+시작위치(x축)+경기장의길이

            dogs[0] = new Greyhound() { MyPictureBox = dog01, StartingPosition = 29, RacetrackLength = 632 };
            dogs[1] = new Greyhound() { MyPictureBox = dog02, StartingPosition = 29, RacetrackLength = 632 };
            dogs[2] = new Greyhound() { MyPictureBox = dog03, StartingPosition = 29, RacetrackLength = 632 };
            dogs[3] = new Greyhound() { MyPictureBox = dog04, StartingPosition = 29, RacetrackLength = 632 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}