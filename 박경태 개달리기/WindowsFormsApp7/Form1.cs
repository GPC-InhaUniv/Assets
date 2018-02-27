using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        // 객체 생성
        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];
        Random NumRand = new Random();
        int[] GuyAmount = new int[3];           // 각 사람들이 건 배팅금액
        int[] GuyDogNumber = new int[3];        // 각 사람들이 건 개의 번호

        // 객체를 모두 초기화 해준다.
        public Form1()
        {
            InitializeComponent();

            // 객체 초기화
            guys[0] = new Guy() { Name = "Joe", cash = 0, MyBet = null, MyLabel = JoeLabel, MyRadioButton = JoeRadio, };
            guys[1] = new Guy() { Name = "Bob", cash = 100, MyBet = null, MyLabel = BobLabel, MyRadioButton = BobRadio };
            guys[2] = new Guy() { Name = "Al", cash = 100, MyBet = null, MyLabel = AlLabel, MyRadioButton = AlRadio };

            dogs[0] = new Greyhound() { MyPictureBox = Greyhound1, StartingPosition = 22, RaceTrackLength = 590, Randomizer = NumRand, MyBackGround = BackGround };
            dogs[1] = new Greyhound() { MyPictureBox = Greyhound2, StartingPosition = 22, RaceTrackLength = 590, Randomizer = NumRand, MyBackGround = BackGround };
            dogs[2] = new Greyhound() { MyPictureBox = Greyhound3, StartingPosition = 22, RaceTrackLength = 590, Randomizer = NumRand, MyBackGround = BackGround };
            dogs[3] = new Greyhound() { MyPictureBox = Greyhound4, StartingPosition = 22, RaceTrackLength = 590, Randomizer = NumRand, MyBackGround = BackGround };

            for (int i = 0; i < 3; i++)
            {
                guys[i].UpdateLabels();
            }
        }

        // 개의 번호를 1 ~ 4번까지만 고를 수 있도록 미니멈과 맥시멈을 설정
        private void HoundNumeric_ValueChanged(object sender, EventArgs e)
        {
            HoundNumeric.Maximum = 4;
            HoundNumeric.Minimum = 1;
        }

        // 달러의 배팅 금액을 5 ~ 15달러까지만 베팅할 수 있도록 미니멈과 맥시멈 설정
        private void BetNumeric_ValueChanged(object sender, EventArgs e)
        {
            BetNumeric.Maximum = 15;
            BetNumeric.Minimum = 0;
        }

        // Joe의 라디오버튼이 눌리게 되면 왼쪽 하단에 있는 라벨 이름이 자기 이름으로 바뀌도록 설정
        private void JoeRadio_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = "Joe";
        }

        // Bob의 라디오버튼이 눌리게 되면 왼쪽 하단에 있는 라벨 이름이 자기 이름으로 바뀌도록 설정
        private void BobRadio_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = "Bob";
        }

        // Al의 라디오버튼이 눌리게 되면 왼쪽 하단에 있는 라벨 이름이 자기 이름으로 바뀌도록 설정
        private void AlRadio_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = "Al";
        }

        // 베팅버튼 클릭시 버튼이 클릭되어 있는 자기 자신의 라벨 상태만 변하도록 설정
        private void button1_Click(object sender, EventArgs e)
        {
            bool[] bAmount = new bool[3];

            if(JoeRadio.Checked == true)
            {
                // 만약 보유금액보다 베팅하는 금액이 적은경우, 트루를 반환하고
                // 만약 보유금액보다 베팅하는 금액이 큰 경우, 펄스를 반환한다.
                bAmount[0] = guys[0].PlaceBet((int)BetNumeric.Value, (int)HoundNumeric.Value);

                // 결과값에 따라 트루가 나온다면 배팅을 할 수 있고
                // 펄스가 나온다면 베팅을 할 수 없게 만든다.
                if (bAmount[0] == true)
                {
                    GuyAmount[0] = (int)BetNumeric.Value;
                    GuyDogNumber[0] = (int)HoundNumeric.Value;
                }
            }

            else if (BobRadio.Checked == true)
            {
                bAmount[1] = guys[1].PlaceBet((int)BetNumeric.Value, (int)HoundNumeric.Value);
                if (bAmount[1] == true)
                {
                    GuyAmount[1] = (int)BetNumeric.Value;
                    GuyDogNumber[1] = (int)HoundNumeric.Value;
                }
            }

            else if (AlRadio.Checked == true)
            {
                bAmount[2] = guys[2].PlaceBet((int)BetNumeric.Value, (int)HoundNumeric.Value);
                if (bAmount[2] == true)
                {
                    GuyAmount[2] = (int)BetNumeric.Value;
                    GuyDogNumber[2] = (int)HoundNumeric.Value;
                }
            }
        }

        // 레이스 버튼을 클릭시 개들이 경주를 시작하고, 결과창이 띄워진다.
        // 확인버튼을 누를 시 개들이 스타트라인으로 옮겨진다.
        private void RaceButton_Click(object sender, EventArgs e)
        {
            bool[] bDogs = new bool[4];
            button1.Enabled = false;

            while (true)
            {

                for(int i = 0; i < 4; i++)
                {
                    bDogs[i] = dogs[i].Run();
                }

                if(bDogs[0] == true)
                {
                    // 우승한 개가 몇번인지 표시해준다.
                    MessageBox.Show("1번 멍멍이 우승!!", "결과");

                    // 경주가 끝난 후 스타트라인으로 초기화 시켜준다.
                    for (int i = 0; i < 4; i++)
                    {
                        dogs[i].TakeStartingPosition();
                    }

                    // 우승한 개를 맞춘 사람에게는 배팅한 만큼 돈을 더해주고
                    // 틀린 사람에게는 배팅한 만큼 돈을 빼준다.
                    for(int i = 0; i < 3; i++)
                    {
                        guys[i].Collect(1, GuyAmount[i], GuyDogNumber[i]);
                        guys[i].ClearBet();
                        guys[i].UpdateLabels();

                        // 베팅하지않고 누르면 기존에 가지고 있는 값들이 들어가므로 초기화해준다.
                        GuyAmount[i] = 0;
                        GuyDogNumber[i] = 0;
                    }

                    break;
                }
                else if(bDogs[1] == true)
                {
                    MessageBox.Show("2번 멍멍이 우승!!!", "결과");

                    for (int i = 0; i < 4; i++)
                    {
                        dogs[i].TakeStartingPosition();
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        guys[i].Collect(2, GuyAmount[i], GuyDogNumber[i]);
                        guys[i].ClearBet();
                        guys[i].UpdateLabels();

                        GuyAmount[i] = 0;
                        GuyDogNumber[i] = 0;
                    }

                    break;
                }
                else if(bDogs[2] == true)
                {
                    MessageBox.Show("3번 멍멍이 우승!!!", "결과");

                    for (int i = 0; i < 4; i++)
                    {
                        dogs[i].TakeStartingPosition();
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        guys[i].Collect(3, GuyAmount[i], GuyDogNumber[i]);
                        guys[i].ClearBet();
                        guys[i].UpdateLabels();

                        GuyAmount[i] = 0;
                        GuyDogNumber[i] = 0;
                    }

                    break;
                }
                else if(bDogs[3] == true)
                {
                    MessageBox.Show("4번 멍멍이 우승!!!", "결과");

                    for (int i = 0; i < 4; i++)
                    {
                        dogs[i].TakeStartingPosition();
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        guys[i].Collect(4, GuyAmount[i], GuyDogNumber[i]);
                        guys[i].ClearBet();
                        guys[i].UpdateLabels();

                        GuyAmount[i] = 0;
                        GuyDogNumber[i] = 0;
                    }

                    break;
                }
            }
            button1.Enabled = true;
        }
    }
}
