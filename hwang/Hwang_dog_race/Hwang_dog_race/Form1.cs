using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hwang_dog_race
{
    public partial class Form1 : Form
    {
        Dog[] dogs = new Dog[4];
        Guy[] boy = new Guy[3];
        public int winnerdog;

       


        public Form1()
        {
            InitializeComponent();

            dogs[0] = new Dog() { StartingPosition = 75, RacetrackLength = 510, MyPictureBox = dog1 };
            dogs[1] = new Dog() { StartingPosition = 75, RacetrackLength = 510, MyPictureBox = dog2 };
            dogs[2] = new Dog() { StartingPosition = 75, RacetrackLength = 510, MyPictureBox = dog3  };
            dogs[3] = new Dog() { StartingPosition = 75, RacetrackLength = 510, MyPictureBox = dog4};


            boy[0] = new Guy() { Name = "Joe", cash = 10, myRadioButton = radioButton1, MyLabel = label5, Mybet = null };
            boy[1] = new Guy() { Name = "Bob", cash = 500, myRadioButton = radioButton2, MyLabel = label6, Mybet = null };
            boy[2] = new Guy() { Name = "Al", cash = 500, myRadioButton = radioButton3, MyLabel = label7, Mybet = null };

            boy[0].UpdateLabel();
            boy[1].UpdateLabel();
            boy[2].UpdateLabel();

            label4.Text ="Minimum bet: "+ numericUpDown1.Minimum.ToString()+" bucks";





        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = boy[0].Name;
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = boy[1].Name;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = boy[2].Name;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Joe")
            {
                boy[0].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            }
            if (label1.Text == "Bob")
            {
                boy[1].PlaceBet((int)numericUpDown1.Value, (int) numericUpDown2.Value);
            }
            if (label1.Text == "Al")
            {
                boy[2].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //베팅을 해야 경주시작가능
            if (boy[0].Startrace==true&& boy[1].Startrace == true&& boy[2].Startrace == true)
            {
                //레이스 한번 누르면 바로 감  false , 한번누르면 한번감 true//

                while (dogs[0].Run() == false && dogs[1].Run() == false && dogs[2].Run() == false
                          && dogs[3].Run() == false)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        dogs[i].Run();

                    }
                }
                if (dogs[0].Run() == true)
                {
                    winnerdog = 1;
                }
                if (dogs[1].Run() == true)
                {
                    winnerdog = 2;
                }
                if (dogs[2].Run() == true)
                {
                    winnerdog = 3;
                }
                if (dogs[3].Run() == true)
                {
                    winnerdog = 4;
                }
                MessageBox.Show("we have a winner - dog # " + winnerdog.ToString());

                boy[0].Collect(winnerdog);
                boy[0].UpdateLabel();

                boy[1].Collect(winnerdog);
                boy[1].UpdateLabel();

                boy[2].Collect(winnerdog);
                boy[2].UpdateLabel();

                for (int i = 0; i < 4; i++)
                {
                    dogs[i].TakeStartingPosition();
                }

                for (int i = 0; i < 3; i++)
                {
                    boy[i].ClearBet();
                }

            }
            else
            {
                MessageBox.Show("베팅을 해주세요");
            }

        }
    }
}
