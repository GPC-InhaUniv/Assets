using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReDogsRace
{
    public partial class Form1 : Form
    {
        // 배열 생성
        Guy[] Bettors = new Guy[3];
        Greyhound[] Dogs = new Greyhound[4];


        public Form1()
        {
            InitializeComponent();
            //객체 생성
            Dogs[0] = new Greyhound(PicDog1);
            Dogs[1] = new Greyhound(PicDog2);
            Dogs[2] = new Greyhound(PicDog3);
            Dogs[3] = new Greyhound(PicDog4);

            Bettors[0] = new Guy("Joe", 100, Bettor1, BetInfo1);
            Bettors[1] = new Guy("Bob", 100, Bettor2, BetInfo2);
            Bettors[2] = new Guy("Al", 100, Bettor3, BetInfo3);
        }

        //Form 로딩과 동시에 호출
        private void Form1_Load(object sender, EventArgs e)
        {

            Min_Bet_Cost.Text = BetCost.Value.ToString();
            Start_Btn.Enabled = false;
            CashCharge.Enabled = false;
            for (int i = 0; i < 3; i++)
            {
                Bettors[i].UpdateLabels();
            }
        }

        private void Bet_Btn_Click(object sender, EventArgs e)
        {
            Betting();
        }

        private void Start_Btn_Click(object sender, EventArgs e)
        {
            Racing();

        }

        public void Racing()
        {
            bool FinishRace = false;

            // Start Button Disable : 레이스 시작과 동시에 버튼 비활성화

            Start_Btn.Enabled = false;

            //FinishRace = True : End Race
            while (FinishRace == false)
            {
                for (int i = 0; i < 4; i++)
                {
                    FinishRace = Dogs[i].Run();
                    
                   
                    if (FinishRace == true)
                    {
                        MessageBox.Show("We have a Winner - Dog #" + (i + 1), "Winner");

                        //플레이어들의 자금관리
                        for (int j = 0; j < 3; j++)
                        {

                            Bettors[j].Collect(i + 1);
                            Bettors[j].UpdateLabels();

                        }
                        //Dog Speed Bonus
                        for (int k = 0; k < 4; k++)
                        {
                            if (k == i)
                            {
                                Dogs[k].WinDog();
                            }
                            else
                                Dogs[k].LoseDog();

                            // ----아래 코드는 현재 개들의 보너스 스피드가 몇인지 확인하는 메세지창 출력
                            // MessageBox.Show(k.ToString()+"dog's BonusSpeed" + Dogs[k].Bonus);
                        }
                        break;
                    }
                    System.Threading.Thread.Sleep(5);
                    BackGround.Refresh();
                }
               
            }
            //Dogs Position Reset
            for (int i = 0; i < 4; i++)
            {
                Dogs[i].TakeStartingPosition();
            }
            //Bet intfo Reset
            for (int i = 0; i < 3; i++)
            {

                Bettors[i].ClearBet();
            }

        }

        public void Betting()
        {
            if (Bettor1.Checked == true)
            {
                Bettors[0].PlaceBet((int)BetCost.Value, (int)BetDogNum.Value);

            }
            else if (Bettor2.Checked == true)
            {
                Bettors[1].PlaceBet((int)BetCost.Value, (int)BetDogNum.Value);

            }
            else if (Bettor3.Checked == true)
            {
                Bettors[2].PlaceBet((int)BetCost.Value, (int)BetDogNum.Value);

            }

            // 베팅 정보칸의 텍스트값이 비어있지 않다면 스타트 버튼 활성화;
            if (Bettors[0].MyText.Text != string.Empty && Bettors[1].MyText.Text != string.Empty && Bettors[2].MyText.Text != string.Empty)
            {
                Start_Btn.Enabled = true;
            }
        }

        private void CashCharge_Click(object sender, EventArgs e)
        {
            //Form2의 객체를 생성하고 생성자로 Form1을 전달
            //Form2에서 Form1의 메소드를 사용하기 위한 과정
            Form2 CashShop = new Form2(this);
            //Form2 창 열기
            CashShop.Show();

        }

        /* 캐시 충전 메소드 
         * Amount 값은 Form2의 Text값
         */
        public void ChargeCash(int Amount)
        {
            if (Bettor1.Checked == true)
            {
                Bettors[0].Cash += Amount;
                Bettors[0].UpdateLabels();
            }
            else if (Bettor2.Checked == true)
            {
                Bettors[1].Cash += Amount;
                Bettors[1].UpdateLabels();

            }
            else if (Bettor3.Checked == true)
            {
                Bettors[2].Cash += Amount;
                Bettors[2].UpdateLabels();
            }
            else
            {
                MessageBox.Show("충전하실 플레이어를 선택하세요");
            }
        }

        // 아래는 라디오버튼이 눌렸을때에만 캐시샵 활성화를 위한 메소드
        
        private void Bettor1_CheckedChanged(object sender, EventArgs e)
        {
            EnableCachBtn();
        }

        private void Bettor2_CheckedChanged(object sender, EventArgs e)
        {
            EnableCachBtn();
        }

        private void Bettor3_CheckedChanged(object sender, EventArgs e)
        {
            EnableCachBtn();
        }

        public void EnableCachBtn()
        {
            CashCharge.Enabled = true;
        }
    }
}
