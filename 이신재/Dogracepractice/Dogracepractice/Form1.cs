using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dogracepractice
{
    public partial class Form1 : Form
    {


        Greyhound[] dog;
        Guy[] guy;
        
       
       

        public Form1()
        {
            guy = new Guy[3]; //인스턴스생성(메모리공간만 확보되어 있는 상태)
            dog = new Greyhound[4];
           




            InitializeComponent();

            label1.Text = "Minimum bet: " + (int)numericbetamount.Value; 
            //최소 배팅양 => 윈도우 폼 실행시 변함없는 값이지만 numericbetamount의 minimum값을 따라가므로 그 값을 넣어준다.

            int startposition = background.Left; 
            //startpositon은 백그라운드(레이스트랙)의 왼쪽을 기준으로 잡는다.
            int racetracklength = background.Size.Width;
            // 레이스트랙 길이는 백그라운드(레이스트랙)의 사이즈중 넓이의 값으로 잡는다.

            guy[0] = new Guy() { Name = "Joe", Cash = 100, MyBet = null, MyRadioButton = btnjoe, MyLabel = txtjoe };
            //Guy의 인스턴스. 공간확보만 돼 있던 메모리에 데이터를 채워넣는다.
            guy[1] = new Guy() { Name = "Bob", Cash = 100, MyBet = null, MyRadioButton = btnbob, MyLabel = txtbob };
            guy[2] = new Guy() { Name = "Joe", Cash = 100, MyBet = null, MyRadioButton = btnai, MyLabel = txtai };


            dog[0] = new Greyhound() //Greyhound의 인스턴스. 각각의 공간확보만 돼 있던 메모리에 데이터를 채워넣는다.
            {
                MyPictureBox = dogpicture1,
                StartingPosition = startposition,
                RacetrackLength = racetracklength
            };

            dog[1] = new Greyhound()
            {
                MyPictureBox = dogpicture2,
                StartingPosition = startposition,
                RacetrackLength = racetracklength
            };

            dog[2] = new Greyhound()
            {
                MyPictureBox = dogpicture3,
                StartingPosition = startposition,
                RacetrackLength = racetracklength
            };

            dog[3] = new Greyhound()
            {
                MyPictureBox = dogpicture4,
                StartingPosition = startposition,
                RacetrackLength = racetracklength
            };


            ResetForm();
        }

        public void ResetForm() //1회 경주가 끝나면 각각의 guy인스턴스와 dog인스턴스를 for문으로 초기화한다.
        {
            // 개 위치 시작 위치로 이동
            for (int dognum = 0; dognum < 4; dognum++)
                dog[dognum].TakeStartingPosition(); //Greyhound 클래스의 TakeStartingPosition메소드

            // 현금 보유액 갱신 및 베팅 상황 보이기
            for (int guynum = 0; guynum < 3; guynum++)
                guy[guynum].UpdateLabels(); //Guy 클래스의 UpdateLabels메소드

        }







        private void btnbet_Click(object sender, EventArgs e)
        {
            if (btnjoe.Checked) //joe의 radiobutton을 체크했을 때 
            {
                if (guy[0].PlaceBet((int)numericbetamount.Value, (int)numericdognumber.Value)) 
                    //[0] 번째의 guy객체가 PlaceBet메소드를 (numericbetamount와 numericdognumber를 int값으로 형변환 한 값을 매개변수로 적용)
                {
                    guy[0].UpdateLabels(); //if문을 만족하면 UpdateLabels메소드를 돌린다.
                }
                else
                {
                    MessageBox.Show("Betting amount is bigger than joe's cash...."); 
                    //가지고있는 Cash가 Amount(베팅량)보다 적을 경우 메시지창을 띄운다.
                }
            }
            else if (btnbob.Checked )
            {
                if (guy[1].PlaceBet((int)numericbetamount.Value, (int)numericdognumber.Value))
                {
                    guy[1].UpdateLabels();
                }
                else
                {
                    MessageBox.Show("Betting amount is bigger than bob's cash....");
                }
            }
            else
            {
                if (guy[2].PlaceBet((int)numericbetamount.Value, (int)numericdognumber.Value))
                {
                    guy[2].UpdateLabels();
                }
                else
                {
                    MessageBox.Show("Betting amount is bigger than ai's cash....");
                }
            }
        }

        


        private void btnrace_Click(object sender, EventArgs e)
        {
            bool Winner = false;
            //게임이 끝나기 전까지 winner가 없는 상태이므로
            int DogNum = 0;
            
            while(!Winner)
            {
                for(DogNum=0; DogNum<4 && Winner==false; DogNum++)
                    //dog중에 아직 winner가 없는 경우 dog4마리를 각각 Run()으로 돌린다.
                {
                    Winner = dog[DogNum].Run();
                }

            }

            MessageBox.Show("We have a Winner = Dog #" + DogNum);
            //winner가 나왔을 경우 승리한 dog를 메시지창에 출력한다.

            for(int guynum=0; guynum<3; guynum++)
            {
                guy[guynum].Collect(DogNum);
            }
            ResetForm();
            
        }

        private void btnjoe_CheckedChanged(object sender, EventArgs e) 
            // Joe 의 roundbutton을 선택 시 changelabel의 text를 Joe로 변경한다.
        {
            changelabel.Text = "Joe";
        }

        private void btnbob_CheckedChanged(object sender, EventArgs e)
        {
            changelabel.Text = "Bob";
        }

        private void btnai_CheckedChanged(object sender, EventArgs e)
        {
            changelabel.Text = "AI";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtjoe_Click(object sender, EventArgs e)
        {
           
        }

        private void txtbob_Click(object sender, EventArgs e)
        {

        }

        private void txtai_Click(object sender, EventArgs e)
        {

        }
    }
}
