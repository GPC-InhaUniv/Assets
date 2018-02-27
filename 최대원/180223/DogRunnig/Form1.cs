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

namespace DogRunnig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setDog();
            SetMan();
            setting();

            udMoney.Text = "0";
            udDog.Text = "1";
            laMiniBet.Text = laMiniBet.Text + " : " + udMoney.Minimum + "원";
        }

        //선언 및 초기화 ==================================================================================

        //소지금
        int BatMoney = 5;

        //선택 된 사람 번호
        int ManNum = 0;

        //베팅 가능한 최대 인원수
        int maxstart = 3;

        //사람과 개 선언
        Man[] player = new Man[3];
        Dog[] dog = new Dog[4];

        

        //개 초기화
        void setDog()
        {
            dog[0] = new Dog
            {
                PictureBox = pBDog1,
                StartPosition = pBDog1.Location,
                RaceTrackLength = pBTrack.Size.Width
            };
            dog[1] = new Dog
            {
                PictureBox = pBDog2,
                StartPosition = pBDog2.Location,
                RaceTrackLength = pBTrack.Size.Width
            };
            dog[2] = new Dog
            {
                PictureBox = pBDog3,
                StartPosition = pBDog3.Location,
                RaceTrackLength = pBTrack.Size.Width
            };
            dog[3] = new Dog
            {
                PictureBox = pBDog4,
                StartPosition = pBDog4.Location,
                RaceTrackLength = pBTrack.Size.Width
            };
        }

        //사람 초기화
        void SetMan()
        {
            player[0] = new Man
            {
                Name = "Joe",
                Money = BatMoney,
                RadioButton = rBJoe,
                Label = laJoeBat
            };
            player[1] = new Man
            {
                Name = "Bob",
                Money = BatMoney,
                RadioButton = rBBob,
                Label = laBobBat
            };
            player[2] = new Man
            {
                Name = "Al",
                Money = BatMoney,
                RadioButton = rBAl,
                Label = laAlBat
            };
        }

        //처음 시작 시 몇가지 세팅
        void setting()
        {
            for(int i = 0; i < 3; i++)
            {
                player[i].update();
                player[i].Label.Text = "아직 베팅하지 않았습니다.";
            }
        }

        //각 버튼 사용 ==================================================================================
        //베팅하기 버튼 클릭
        private void btBets_Click(object sender, EventArgs e)
        {
            //해당 플레이어 라디오 버튼 상태 확인
            if (player[ManNum].RadioButton.Enabled)
            {
                //bat객체를 생성하고 하위 필드 정의하고 배팅하기 함수 실행
                player[ManNum].Mybet = new Bet() { Man = player[ManNum], Amount = int.Parse(udMoney.Text), dog = int.Parse(udDog.Text) };

                //베팅이 가능한지 확인
                if (!player[ManNum].PlaceBat(player[ManNum].Mybet.Amount, player[ManNum].Mybet.dog))
                {
                    //불가능한 경우 0원 베팅
                    player[ManNum].Mybet.Amount = 0;

                    //보유 금액이 최소 베팅 금액보다 작으면 해당 라디오 버튼 비활성화
                    if (player[ManNum].Money < udMoney.Minimum)
                    {
                        player[ManNum].RadioButton.Enabled = false;
                        maxstart--;
                    }
                }
            }
            //베팅 여부에 따라 메세지 출력
            player[ManNum].Label.Text = player[ManNum].Mybet.GetDescription();
        }

        //각 플레이어의 라디오 버튼을 체크하면 보유 금액이 갱신됨
        //Joe의 라디오 버튼 체크
        private void rBJoe_CheckedChanged(object sender, EventArgs e)
        {
            ManNum = 0;
            laBatName.Text = player[ManNum].Name;
        }

        //Bob의 라디오 버튼 체크
        private void rBBob_CheckedChanged(object sender, EventArgs e)
        {
            ManNum = 1;
            laBatName.Text = player[ManNum].Name;
        }

        //Al의 라디오 버튼 체크
        private void rBAl_CheckedChanged(object sender, EventArgs e)
        {
            ManNum = 2;
            laBatName.Text = player[ManNum].Name;
        }

        //경주 시작
        private void btStart_Click(object sender, EventArgs e)
        {
            int start = 0; //베팅된 인원수 체크
            for(int i = 0; i < 3; i++) {
                if (player[i].RadioButton.Enabled)
                {
                    //라디오 버튼이 활성화 된 사람만 베팅 여부 체크
                    if (player[i].Mybet != null)
                    {
                        start++;
                    }
                    else
                    {
                        MessageBox.Show(player[i].Name + "이 아직 베팅하지 않았습니다!");
                    }
                }
            }

            //베팅 가능한 사람 == 베팅 한 사람 일때 베팅 시작
            if ( start == maxstart && maxstart > 0)
            {
                RunStart();
            }
            else if( maxstart == 0 )
            {
                //베팅 가능한 사람이 아무도 없을때
                MessageBox.Show("모두 사이좋게 망했습니다. \n더 이상 경기 할 수 없습니다.");
            }
        }

        //메소드 ==================================================================================
        //경주 시작, 승리한 개의 번호를 리턴
        void RunStart()
        {
            bool Runstop = false;
            int winner = 0;

            Random Speed = new Random();
            for (int j = 0; j < 4; j++)
            {
                dog[j].Random = Speed;
            }

            //각 개중에 먼저 도착한 개가 나올떄까지 달림
            while (!Runstop)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (!Runstop)
                    {
                        if (dog[i].Run())
                        {
                            Runstop = true; //이긴 개가 true를 호출
                            winner = i + 1; //우승한 개의 번호 저장
                        }
                    }
                }
                Thread.Sleep(50);
            }

            //우승한 개가 나오면 while문을 빠져나와서 경기 종료 함수 실행
            RunEnd(winner);
        }

        //경기 종료, 베팅 정산
        void RunEnd(int win)
        {
            MessageBox.Show(win + "번 개의 승리!");

            //플레이어 베팅정보 초기화
            for (int i = 0; i < 3; i++)
            {
                if (player[i].RadioButton.Enabled)
                {
                    player[i].Mybet.PayOut(win);
                    player[i].Collect(win);
                    player[i].CleanBat();
                    player[i].Mybet = null;
                    player[i].update();
                    player[i].Label.Text = "아직 베팅하지 않았습니다.";
                } 
            }

            //강아지 원위치
            for (int j = 0; j < 4; j++)
            {
                dog[j].SetStartPosition();
            }
        }

    }
}
