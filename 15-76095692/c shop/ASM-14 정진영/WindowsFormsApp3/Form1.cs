using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GuyArray();
            MinimumBetLabelControl();
            DogArray();
        }

        //폼을 실행했을때 동작함
        //일단.. 개들의 배열을 만들어서 GreyHound 를 넣어야겠지
        //guy 배열도 만들어야한다
        //bet은...........보고오자// bet은 일종의 계산작업만 하니까 배열은 필요없다

        //GreyHound[]배열 // 시작할때 폼은 이들 배열 모두를 초기화 해야합니다(Guy[]배열 포함)
        //dogs배열에는 참조변수가 네개 들어가는데, 각각 서로 다른 greyhound클래스 인스턴스를 가르킵니다....greyhound에도 인스턴스가 필요하다고? 일단 그냥만들자

        GreyHound[] dogs = new GreyHound[4]; //만들었음.. 값을 넣어야하는건 아는데 뭘 넣어야하나...

        /*
        public int StartingPosition;//PictureBox 시작위치
        public int RacetrackLength;//경주트랙길이
        public PictureBox MyPictureBox = null; //이 개의 pictureBox 객체
        public int Location = 0;//경주 트랙에서의 위치
        public Random Randomizer;// random 객체 인스턴스
        */
        //dogs[0] = (); ...배열을 보고오자
        public void DogArray()//메소드 안에서는 가능하네... 왜?
        {
            
            //Randomizer...이걸 넣고 있는게 맞나? 뭘 넣고 뭐가 필요한지 잘 모르니까 일단 중지...
            //먼저... 픽쳐박스 안들어간다 현재 컨텍스트에 없다 - 방법 찾음(배열에 값넣는법 잘못함,그런데 Guy는 잘만되는듯..)
            int startingPosition = dog1.Right - backGround.Left;
            int raceTrackLength = backGround.Size.Width;

            dogs[0] = new GreyHound()
            {
                MyPictureBox = dog1,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            dogs[1] = new GreyHound()
            {
                MyPictureBox = dog2,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            dogs[2] = new GreyHound()
            {
                MyPictureBox = dog3,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            dogs[3] = new GreyHound()
            {
                MyPictureBox = dog4,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
        }
        
        
        Guy[] guys = new Guy[3];
        /*
        public string Name; //사람이름
        public Bet MyBet;//베팅 내역을 저장할 수 있는 bet인스턴스
        public int Cash;//지금 가지고 있는 돈액수

        public RadioButton MyRadioButton;
        public Label MyLabel;
         */
        public void GuyArray()
        {
            guys[0] = new Guy("Joe", null, 50, JoeRadioButton, JoeLabel);//bet에는 뭘 넣어야할지 몰라 null로 했다 기억해둘것
            guys[1] = new Guy("Bob", null, 72, BobRadioButton, BobLabel);
            guys[2] = new Guy("Al", null, 45, AlRadioButton, AlLabel);
        }

        //이제 뭘해야할지 모르겠음..
        //일단 배팅최소액은 이 컨트롤의 최소값하고 일치시켜야합니다. <- 이걸보니 변동을 줄 수 있게 만들라는 말인듯함
        public void MinimumBetLabelControl()
        {
            MinimumBetLabel.Text = "Minimum Bet:"+ BetUpDown.Minimum + "bucks";// public Form1()에서 구동되는거 확인함 "it is work!!"
            //추후 게임시작전 모드를 만들어서 최소 베팅금액의 제한을 변동시키면 될듯 ex:맛보기 or 멸망전
            //아니면 Race 버튼을 클릭할때마다 count+=1 해서 count>= 5 이상이면 최소 배팅금액이 올라간다던지
            //그런데 하나하나 호출해서 작동시켜야하니 나중에 하나의 메서드로 묶어야할듯
            guys[0].UpdateLabels();
            guys[1].UpdateLabels();
            guys[2].UpdateLabels();
            //JoeRadioButton.Text = "Joe has " + guys[0].Cash + " bucks";
            //BobRadioButton.Text = "Bob has " + guys[1].Cash + " bucks";
            //AlRadioButton.Text = "Al has " + guys[2].Cash + " bucks";

            //GuyNameLabel.Text = "Joe";//흠.... 라디오버튼이 선택되면 바꿔야하는데..시간이 없으니까 버튼클릭으로 처리하자

        }

        private void JoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GuyNameLabel.Text = "Joe";
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GuyNameLabel.Text = "Bob";
        }

        private void AlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GuyNameLabel.Text = "Al";
        }

        private void button1_Click(object sender, EventArgs e)//버튼을 클릭하면 변화하는것들 - textbox,갖고있는 돈
        {
            //bob이 베팅을 하면 bob의 guy객체에서 레이블과 라디오버튼 텍스트를 고쳐줍니다.
            
            
            if (GuyNameLabel.Text == "Joe" && JoeLabel.Text == "Joe hasn't placed any bets")
            {
                guys[0].PlaceBet((int)BetUpDown.Value, (int)DogUpDown.Value);
                guys[0].Cash = guys[0].Cash - (int)BetUpDown.Value;
                guys[0].UpdateLabels();
            }
            else if (GuyNameLabel.Text == "Bob" && BobLabel.Text == "Bob hasn't placed any bets")
            {
                guys[1].PlaceBet((int)BetUpDown.Value, (int)DogUpDown.Value);
                guys[1].Cash = guys[1].Cash - (int)BetUpDown.Value;
                guys[1].UpdateLabels();
            }
            else if (GuyNameLabel.Text == "Al" && AlLabel.Text == "Al hasn't placed any bets")
            {
                guys[2].PlaceBet((int)BetUpDown.Value, (int)DogUpDown.Value);
                guys[2].Cash = guys[2].Cash - (int)BetUpDown.Value;
                guys[2].UpdateLabels();
            }
            else
            {
                MessageBox.Show(GuyNameLabel.Text + "는 이미 베팅을 했습니다");
            }
            

        }//베팅 시스템까지 끝남

        private void button2_Click(object sender, EventArgs e)//race - 경주가 시작함, 결과가 나옴, 결과값에 따라서 돈을 변경해줘야함, 경기가 끝나면 팝업이 떠야함
        {
            //greyHound를 써야함.....배열마저 완성 하러가자
            
            button2.Enabled = false;

            bool winnerDog = false;
            int winningDogNo = 0;
            
            while (!winnerDog)
            {
                for (int i = 0; i < dogs.Length; i++)
                {
                    
                    if (dogs[i].Run())
                    {
                        winnerDog = true;
                        winningDogNo = i;
                    }
                    System.Threading.Thread.Sleep(3);
                    Application.DoEvents();
                    //backGround.Refresh(); 이거랑 위에있는거랑 효율차이는 잘 모르겠음
                }
            }
            MessageBox.Show("We have a winner - dog # " + (winningDogNo + 1) + "!");
            
            //C# for 문은 루프 안에 있는 문장들을 반복적으로 실행할 때 사용한다.
            //for 루프는 일반적으로 카운터 변수를 이용해 일정 범위 동안 for 루프 안의 블럭을 실행한다.
            foreach (Guy guy in guys)
            {
                if (guy.MyBet != null)
                {
                    Console.WriteLine("guy를 초기화중");
                    guy.Collect(winningDogNo);
                    guy.MyBet = null;
                    guy.UpdateLabels();
                }
            }
            foreach (GreyHound dog in dogs)
            {
                Console.WriteLine("개위치를 초기화중");
                dog.TackeStartingPosition();
                
            }

            button2.Enabled = true;
            
        }

        /*private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.)
            if (GuyNameLabel.Text == "Joe")
            {
                BetUpDown.Maximum = guys[0].Cash;
                BetUpDown.Minimum = guys[0].Cash;
            }
            if (GuyNameLabel.Text == "Bob")
            {
                BetUpDown.Maximum = guys[1].Cash;
                BetUpDown.Minimum = guys[1].Cash;
            }
            if (GuyNameLabel.Text == "Al")
            {
                BetUpDown.Maximum = guys[2].Cash;
                BetUpDown.Minimum = guys[2].Cash;
            }



        }*/
    }
}
