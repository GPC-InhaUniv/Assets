using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SlimeRace
{
    public partial class Form1 : Form
    {
        Slime[] slimes = new Slime[4];
        Guy[] guys = new Guy[3];
        int eventNum = 0;
        public Form1()
        {
            InitializeComponent();
            SetupGame();    
        }

        private void SetupGame()         //초기 폼 설정
        {
            slimes[0] = new Slime(89, 900, slime1, "핑크슬라임");
            slimes[1] = new Slime(89, 900, slime2, "태비슬라임");
            slimes[2] = new Slime(89, 900, slime3, "헌터슬라임");
            slimes[3] = new Slime(89, 900, slime4, "붐슬라임");

            guys[0] = new Guy("박준명", null, 75, user1, user1Lable);
            guys[1] = new Guy("이신재", null, 85, user2, user2Lable);
            guys[2] = new Guy("김판주", null, 65, user3, user3Lable);

            guys[0].UpdateLabels();     //레이블 초기 표시
            guys[1].UpdateLabels();    
            guys[2].UpdateLabels();
            eventSlime1.Hide();         //이벤트 이미지 숨김
            eventSlime2.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)   //라디오 첫번째 버튼 체크시  
        {
            bettingName.Text = guys[0].name;    //레이블 내용이 변경;
            bettingUpDown.Value = 5;      // 버튼이 달라질 시 베팅 값 최솟값으로 초기화
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)   //라디오 두번째 버튼 체크시  
        {
            bettingName.Text = guys[1].name; ;
            bettingUpDown.Value = 5;     
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)   //라디오 세번째 버튼 체크시  
        {
            bettingName.Text = guys[2].name; ;
            bettingUpDown.Value = 5;     
        }

        private void betting_Click(object sender, EventArgs e)                 //베팅 버튼
        {
            if (user1.Checked)        //라디오 첫번째 버튼이 체크 되있을 경우
            {
                int amount = int.Parse(String.Concat(bettingUpDown.Value));    //베팅 금액을 받을 변수 선언.
                int slime = int.Parse(String.Concat(choiceUpDown.Value)) ;    //베팅한 슬라임 번호를 받을 변수 선언.
                guys[0].PlaceBet(amount, slime); //베팅의 내용으로 Bet 객체 생성.
                guys[0].UpdateLabels();          //그 내용을 레이블에 표시
            }
            else if (user2.Checked)   //라디오 두번째 버튼이 체크 되있을 경우
            {
                int amount = int.Parse(String.Concat(bettingUpDown.Value));
                int slime = int.Parse(String.Concat(choiceUpDown.Value)) ;
                guys[1].PlaceBet(amount, slime);
                guys[1].UpdateLabels();
            }
            else                            //레디오 세번째 버튼이 체크 되있을 경우
            {
                int amount = int.Parse(String.Concat(bettingUpDown.Value));
                int slime = int.Parse(String.Concat(choiceUpDown.Value)) ;
                guys[2].PlaceBet(amount, slime);
                guys[2].UpdateLabels();
            }


        }

        private void race_Click(object sender, EventArgs e)   //레이스 버튼
        {
            BottonLock();                     //경기 시작 버튼 후 버튼 비활성화
            bool result = false;              //while문을 멈추기 위한 변수
            
            while (!result)                   //result 값이 true가 아닐경우 까지 실행
            {
                for (int i = 0; i < slimes.Length; i++)   //슬라임 배열들을 움직이게 하기 위한 for문
                {
                    result = slimes[i].Run(); //이동 시키고 결승점 까지 도착했는지 결과값을 받음.
                    Thread.Sleep(60);         //60밀리세컨만큼 지연
                    if(result == true)        //결승점을 한 슬라임이 통과 했을 경우
                    {
                        MessageBox.Show("우승 슬라임은 " + (i+1) + "번 입니다.~!", "경기 결과");
                        for (int j = 0; j < guys.Length; j++)        //경기 결과를 계산하기 위한 for 문
                        {
                            guys[j].Collect(i+1,eventNum); // 경기 결과를 보내줌.
                            guys[j].ClearBet();            //베팅 내역 초기화
                            guys[j].UpdateLabels();        //결과에 따른 변화 레이블에 표시
                        }
                        break; 
                    }
                    map.Refresh();                         //잔상을 없애기 위한 메소드
                }
            }
            for (int i = 0; i < slimes.Length; i++)           //경기가 끝난후 모든 슬라임을 제자리로 보낼 for문
            {
                slimes[i].TakeStartingPosition();
            }
            BottonOpen();                         //경기 종류 후 버튼 활성화
            Event();                              //럭키슬라임,타르슬라임 이벤트
        }

        void BottonLock()                        //경기 시작시 버튼 잠그는 부분
        {
            betting.Enabled = false;
            race.Enabled = false;
           
        }
        
        void BottonOpen()                        //경기 종료시 버튼 활성화하는  부분
        {
            betting.Enabled = true;
            race.Enabled = true;
        }

        private void slime1_Click(object sender, EventArgs e)  //첫번째 슬라임 클릭시 정보
        {
            MessageBox.Show("이름: "+slimes[0].slimeName+ "\n\n특징: 그저 흔한 너무 귀여운 슬라임입니다.!", "1번 슬라임정보");
        }

        private void slime2_Click(object sender, EventArgs e)  //두번째 슬라임 클릭시 정보
        {
            MessageBox.Show("이름: " + slimes[1].slimeName + "\n\n특징: 고양이 모습을 한 이 치명적 슬라임은 \n일반속도는 느리지만 가끔 높은 점프를 합니다.!", "2번 슬라임정보");
        }

        private void slime3_Click(object sender, EventArgs e)  //세번째 슬라임 클릭시 정보
        {
            MessageBox.Show("이름: " + slimes[2].slimeName + "\n\n특징: 날쎈 모습만큼 빠른 속도를 가지고 있지만\n선천적으로 기복이 있는 편입니다.!", "3번 슬라임정보");
        }

        private void slime4_Click(object sender, EventArgs e)  //네번째 슬라임 클릭시 정보
        {
            MessageBox.Show("이름: " + slimes[3].slimeName + "(※이 슬라임은 보상을 2배로 줍니다. 한방가즈아~!)\n\n특징: 불덩이 같은 이 슬라임은 평소엔 움직임이" +
                "\n없지만 낮은 확률로 폭발을 일으킵니다.!" , "4번 슬라임정보");
        }

        void Event()                              //럭키슬라임,타르슬라임 이벤트 발생 부분.
        {
            eventSlime1.Hide();                   //기존에 있던 럭키이미지 숨기기 
            eventSlime2.Hide();                   //기존에 있던 타르이미지 숨기기 
            eventNum = 0;                         //이벤트번호도 초기화
            Random random = new Random();         //랜덤을 위한 새로운 객체 선언
            int p​robability = random.Next(0,100); //0부터 100까지 수 중 하나를 변수에 저장
            if(probability < 25)                  //약 25% 확률
            {
                eventSlime1.Show();               //럭키슬라임 이미지 출력
                MessageBox.Show("오오! 럭키슬라임이 경기장에 찾아왔어여!\n요번판은 돈을 잃지 않습니다.!", "이벤트");
                eventNum = 1;                     //럭키슬라임 이벤터 넘버.
            }else if(probability >= 25 && probability < 50)   //약 25% 확률
            {
                eventSlime2.Show();               //타르슬라임 이미지 출력
                MessageBox.Show("오오! 타르슬라임이 경기장에 찾아왔어여!\n요번판은 보상과 잃는 돈이 두배가 됩니다.!", "이벤트");
                eventNum = 2;                     //타르슬라임 이벤터 넘버.
            }   
        }

       
    }
}
