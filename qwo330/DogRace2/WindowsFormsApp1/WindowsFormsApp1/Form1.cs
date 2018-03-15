using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int Winner;
        int who = 0; //defalut
        int dog_num = 4;
        int people_num = 3;
        int RacetrackLength;
        int StartingPosition;

        Greyhound[] dogs;
        Guy[] guys;
        TextBox[] txtBoxs;
        Random Randomizer;

        public Form1()
        {
            InitializeComponent();
            Randomizer = new Random();

            dogs = new Greyhound[dog_num];
            guys = new Guy[people_num];
            txtBoxs = new TextBox[people_num];

            RacetrackLength = pictureBox1.Size.Width;
            StartingPosition = dog1.Location.X;

            txtBoxs[0] = textBox1;
            txtBoxs[1] = textBox2;
            txtBoxs[2] = textBox3;

            init();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            who = 0; // Joe
            l_bettor.Text = guys[who].Name;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            who = 1; // Bob
            l_bettor.Text = guys[who].Name;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            who = 2; // Al
            l_bettor.Text = guys[who].Name;
        }

        private void btn_bet_Click(object sender, EventArgs e)
        {
            int amount, dog;
            string str;
            str = ud_betHow.Value.ToString();

            Int32.TryParse(str, out amount);

            str = ud_dogNum.Value.ToString();
            Int32.TryParse(str, out dog);

            if (guys[who].PlaceBet(amount, dog))
            {
                guys[who].PlaceBet(amount, dog);
                txtBoxs[who].Text = guys[who].MyBet.GetDescription();
            }
            else MessageBox.Show("금액이 부족합니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool finish = false;
            while(Winner == -1)
            {
                for(int i = 0; i < 4; i++)
                {
                    finish = dogs[i].Run();
                    if (finish) Winner = i;
                }
                System.Threading.Thread.Sleep(10);
            }
            Winner += 1; // 배열과 다름
            MessageBox.Show("winner - dog #" + (Winner) + "!!");

            for (int i = 0; i < people_num; i++)
            {
                guys[i].Collect(Winner);
            }
            reset(); // 처음 상태로 초기화
        }

        public void init()
        {
            guys[0] = new Guy() { Name = "Joe", Cash = 50, MyRadioButton = radioButton1};
            guys[1] = new Guy() { Name = "Bob", Cash = 75, MyRadioButton = radioButton2 };
            guys[2] = new Guy() { Name = "Al", Cash = 45, MyRadioButton = radioButton3 };

            dogs[0] = new Greyhound()
            {
                MyPictureBox = dog1,
                StartingPosition = StartingPosition,
                RacetrackLength = RacetrackLength,
                Randomizer = Randomizer
            };

            dogs[1] = new Greyhound()
            {
                MyPictureBox = dog2,
                StartingPosition = StartingPosition,
                RacetrackLength = RacetrackLength,
                Randomizer = Randomizer
            };

            dogs[2] = new Greyhound()
            {
                MyPictureBox = dog3,
                StartingPosition = StartingPosition,
                RacetrackLength = RacetrackLength,
                Randomizer = Randomizer
            };

            dogs[3] = new Greyhound()
            {
                MyPictureBox = dog4,
                StartingPosition = StartingPosition,
                RacetrackLength = RacetrackLength,
                Randomizer = Randomizer
            };
            reset();
        }

        public void reset()
        {
            Winner = -1;

            dogs[0].TakeStartingPosition();
            dogs[1].TakeStartingPosition();
            dogs[2].TakeStartingPosition();
            dogs[3].TakeStartingPosition();

            guys[0].PlaceBet(0, 0);
            guys[1].PlaceBet(0, 0);
            guys[2].PlaceBet(0, 0);

            txtBoxs[0].Text = guys[0].MyBet.GetDescription();
            txtBoxs[1].Text = guys[1].MyBet.GetDescription();
            txtBoxs[2].Text = guys[2].MyBet.GetDescription();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
