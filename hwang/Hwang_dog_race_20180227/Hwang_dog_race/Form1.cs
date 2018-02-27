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
        Guy[] guy = new Guy[3];
        public int winnerdog;




        public Form1()
        {
            InitializeComponent();
           
            
            /*
            for (int i = 0; i < 4; i++)
            {
                dogs[i] = new Dog();
            }

  

            dogs[0].MyPictureBox = dog1;
            dogs[1].MyPictureBox = dog2;
            dogs[2].MyPictureBox = dog3;
            dogs[3].MyPictureBox = dog4;

            dogs[0].StartingPositionY = 40;
            dogs[1].StartingPositionY = 90;
            dogs[2].StartingPositionY = 140;
            dogs[3].StartingPositionY = 190;
            */

            dogs[0] = new Dog() { MyPictureBox = dog1, StartingPositionY = 40 };
            dogs[1] = new Dog() { MyPictureBox = dog2, StartingPositionY = 90 };
            dogs[2] = new Dog() { MyPictureBox = dog3, StartingPositionY = 140 };
            dogs[3] = new Dog() { MyPictureBox = dog4, StartingPositionY = 190 };

            guy[0] = new Guy() { Name = "Joe", cash = 10, myRadioButton = radioButton1, MyLabel = label5, Mybet = null };
            guy[1] = new Guy() { Name = "Bob", cash = 500, myRadioButton = radioButton2, MyLabel = label6, Mybet = null };
            guy[2] = new Guy() { Name = "Al", cash = 500, myRadioButton = radioButton3, MyLabel = label7, Mybet = null };

            guy[0].UpdateLabel();
            guy[1].UpdateLabel();
            guy[2].UpdateLabel();

            label4.Text ="Minimum bet: "+ numericUpDown1.Minimum.ToString()+" bucks";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = guy[0].Name;
            label9.Text = guy[0].Name;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = guy[1].Name;
            label9.Text = guy[1].Name;


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = guy[2].Name;
            label9.Text = guy[2].Name;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Joe")
            {
                guy[0].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            }
            if (label1.Text == "Bob")
            {
                guy[1].PlaceBet((int)numericUpDown1.Value, (int) numericUpDown2.Value);
            }
            if (label1.Text == "Al")
            {
                guy[2].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //게임 시작전 위치 초기화//
            for (int i = 0; i < 4; i++)
            {
                dogs[i].TakeStartingPosition();
            }


            //베팅을 해야 경주시작가능
            if (guy[0].Startrace==true&& guy[1].Startrace == true&& guy[2].Startrace == true)
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
                //winnerdog//
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
                //winnerdog 출력//
                MessageBox.Show("We have a winner - dog # " + winnerdog.ToString());

                //베팅 현황 업데이트//
                guy[0].Collect(winnerdog);
                guy[0].UpdateLabel();

                guy[1].Collect(winnerdog);
                guy[1].UpdateLabel();

                guy[2].Collect(winnerdog);
                guy[2].UpdateLabel();

                //경기가 끝나면 위치 초기화//
                for (int i = 0; i < 4; i++)
                {
                    dogs[i].TakeStartingPosition();
                }
                //베팅 초기화//
                for (int i = 0; i < 3; i++)
                {
                    guy[i].ClearBet();
                }

            }
            //베팅을 하지 않았을경우 출력//
            else
            {
                MessageBox.Show("베팅을 해주세요");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //준비운동//
            dogs[(int)numericUpDown3.Value-1].WarmUp();

            while (dogs[(int)numericUpDown3.Value-1].Run() == true )
            {
                    dogs[(int)numericUpDown3.Value-1].Run();

            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            //준비운동을 하고있는 개가 있을경우 위치 초기화//
            for (int i = 0; i < 3; i++)
            {
                dogs[i].TakeStartingPosition();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Joe")
            {
                guy[0].cash = guy[0].cash + (int)numericUpDown4.Value;
                guy[0].UpdateLabel();
                

            }
            if (label1.Text == "Bob")
            {
                guy[1].cash = guy[0].cash + (int)numericUpDown4.Value;
                guy[1].UpdateLabel();

            }
            if (label1.Text == "Al")
            {
                guy[2].cash = guy[0].cash + (int)numericUpDown4.Value;
                guy[2].UpdateLabel();

            }
        }
    }
}
