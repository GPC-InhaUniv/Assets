using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulationrace
{
    public partial class Form1 : Form
    {

        Greyhound[] Dogs;
        Guy[] guys;
        Random MyRandomizer = new Random();
        

        public Form1()
        {
            InitializeComponent();

            string temp = " :";

            labMbet.Text += temp += Betupdown.Minimum;
                

            RadioButton s = new RadioButton();

            guys = new Guy[3];

            guys[0] = new Guy()
            {
                Name = "Joe",
                MyBet = null,
                MyLabel = labJoe, // mylabel은 이곳에서 하나씩 지정해줬습니다.
                MyradioButton = rbJoe, //myradiobuttoneh도 마찬가지로 가이배열하나마다 지정해줬습니다.
                Cash = 75
            };
            guys[1] = new Guy()
            {
                Name = "Bob",
                MyBet = null,
                MyLabel = labBob,
                MyradioButton = rbbob,
                Cash = 75
            };
            guys[2] = new Guy()
            {
                Name = "AI",
                MyBet = null,
                MyLabel = labAI, 
                MyradioButton = rbAI,
                Cash = 75
            };

            Dogs = new Greyhound[4];

            Dogs[0] = new Greyhound()
            {
                MypictureBox = Dognum1,
                StartingPosition = Racetrack.Left, //레이스트랙 픽쳐박스의 좌측 가장자리 픽셀 반환...레이스트랙의 시작위치
                RacetrackLength = Racetrack.Width - Dognum1.Width, // 레이스트랙안에서 경주개가 달려갈 거리
                Randomizer = MyRandomizer
            };
            Dogs[1] = new Greyhound()
            {
                MypictureBox = Dognum2,
                StartingPosition = Racetrack.Left,
                RacetrackLength = Racetrack.Width - Dognum2.Width,
                Randomizer = MyRandomizer
            };
            Dogs[2] = new Greyhound()
            {
                MypictureBox = Dognum3,
                StartingPosition = Racetrack.Left,
                RacetrackLength = Racetrack.Width - Dognum3.Width,
                Randomizer = MyRandomizer
            };
            Dogs[3] = new Greyhound()
            {
                MypictureBox = Dognum4,
                StartingPosition = Racetrack.Left,
                RacetrackLength = Racetrack.Width - Dognum4.Width,
                Randomizer = MyRandomizer
            };
            //폼 다시 구성
            ResetForm();

        }
        public void ResetForm() //폼을 초기화하는 변수
        {
            for (int i=0; i < 4; i++)
                Dogs[i].TakeStartingPosition(); //경주 개들의 시작위치를 재설정함

            for (int j = 0; j < 3; j++)
                guys[j].UpdateLables(); //선수들의 현재 재정상황을 알려주는 라벨을 갱신합니다.
        }
        

        private void btnRace_Click(object sender, EventArgs e) //레이스버튼을 클릭합니다.
        {
            int dogNum = 0; //반복문에 이용할 변수 선언

            bool winner = false; // winner의 값을 false로 설정함 // 우승시에 true가 나와야 while문이 종료함

            //레이스버튼을 누를 떄 베팅하지 않은 사람이 있다면?
            for(int i=0; i<3; i++)
            {
                if (guys[i].MyBet == null) //0~2로 반복할때 베팅한 금액이 없는 사람이 있다면
                {
                    MessageBox.Show("아직" + guys[i].Name + "가 배팅하지 않았습니다."); //메시지박스를 출력합니다.
                    return;
                }
                    
            }
            //경주를 시작합니다.
            while (!winner) //while문으로 winner의 현재값인 false부터 run의 값으로 true가 나올때까지 반복
            {
                for (dogNum = 0; dogNum < 4 && winner == false; dogNum++) // 0~3으로 각각 실행할때 winnerrk false여야 실행함(둘다만족하는 조건)
                {
                    winner = Dogs[dogNum].Run(); // flase라면 계속 경주 개는 달림.
                }
                System.Threading.Thread.Sleep(10); // 천천히 실행함...
            }

            //우승견을 알려줍니다.

            MessageBox.Show("우승한 개는" + dogNum + "번 개입니다."); //while문이 끝나면 메시지박스를 출력합니다. 

            //상금을 배당합시다.
            for(int i = 0; i<3; i++)  //각각 베팅한 사람들에게 베팅을 처리함 
               
                guys[i].Collect(dogNum); //배팅결과를 처리하도록합니다.
         

            ResetForm(); //경기가 끝난 후 폼을 재설정합니다.
           
            

        }

       

        private void radioButton1_Click(object sender, EventArgs e) //라디오버튼 클릭시 해당 이름을 출력
        {
            if (rbJoe.Checked)
                viewname.Text = "Joe";
            else if (rbbob.Checked)
                viewname.Text = "Bob";
            else
                viewname.Text = "AI";
        }

        private void button1_Click(object sender, EventArgs e) //Bet 버튼을 클릭할 때
        {
            if (rbJoe.Checked) //라디오버튼 joe가 선택됐다면...
            {
                if (guys[0].PlaceBet((int)Betupdown.Value, (int)dogupdown.Value)) //placebet 함수는 현재 배팅한금액과 배팅한 개의 번호를 필요로 함

                    guys[0].UpdateLables();// 해당 선수의 라벨을 업데이트함
                else
                    MessageBox.Show("이미 배팅했거나 배팅금액이 현재 보유액보다 큽니다.");

            }
            else if (rbbob.Checked)
            {
                if (guys[1].PlaceBet((int)Betupdown.Value, (int)dogupdown.Value))

                    guys[1].UpdateLables();
                else
                    MessageBox.Show("이미 배팅했거나 배팅금액이 현재 보유액보다 큽니다.");
            }
            else if (rbAI.Checked)
            {
                if (guys[2].PlaceBet((int)Betupdown.Value, (int)dogupdown.Value))
                    guys[2].UpdateLables();
                else
                    MessageBox.Show("이미 배팅했거나 배팅금액이 현재 보유액보다 큽니다.");
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Dognum1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("1번 트랙을 달리는 개입니다.");
        }

        private void Dognum2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2번 트랙을 달리는 개입니다.");
        }

        private void Dognum3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3번 트랙을 달리는 개입니다.");
        }

        private void Dognum4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4번 트랙을 달리는 개입니다.");
        }
    }
}
