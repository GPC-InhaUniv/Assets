using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRacing
{   

    public partial class Form1 : Form
    {
        Guy[] guys;
        Greyhound[] greyhounds;       
        
        public Form1()
        {            
            InitializeComponent();

            guys = new Guy[3];
            greyhounds = new Greyhound[4];
            Random randomizer = new Random();

            // 객체 생성
            guys[0] = new Guy() { Cash = 50, MyRadioButton = rbJoe, Name = "Joe", MyLabel = lbJoeBet, MyBet = null };
            guys[1] = new Guy() { Cash = 75, MyRadioButton = rbBob, Name = "Bob", MyLabel = lbBobBet, MyBet = null };
            guys[2] = new Guy() { Cash = 45, MyRadioButton = rbAl, Name = "Al", MyLabel = lbAlBet, MyBet = null };
                       
            greyhounds[0] = new Greyhound() { StartingPosition = 30, RacetrackLength = 941, Location = 30, MyPictureBox = pbDog1, Randomizer = randomizer };
            greyhounds[1] = new Greyhound() { StartingPosition = 30, RacetrackLength = 941, Location = 30, MyPictureBox = pbDog2, Randomizer = randomizer };
            greyhounds[2] = new Greyhound() { StartingPosition = 30, RacetrackLength = 941, Location = 30, MyPictureBox = pbDog3, Randomizer = randomizer };
            greyhounds[3] = new Greyhound() { StartingPosition = 30, RacetrackLength = 941, Location = 30, MyPictureBox = pbDog4, Randomizer = randomizer };

            // 폼 재구성
            ResetForm();

        }

        public void ResetForm()
        {
            for (int i = 0; i < 3; i++)
            {
                guys[i].UpdateLabels();     // 레이블 초기화
            }

            for (int i = 0; i < 4; i++)
            {
                greyhounds[i].TakeStartingPosition();       // 개 시작 위치로 이동
            }
        }

        // 플레이어들의 라디오버튼이 눌렸을 때
        private void rbName_Click(object sender, EventArgs e)
        {
            if (rbJoe.Checked)
            {
                lbName.Text = "Joe";
            }
            else if (rbBob.Checked)
            {
                lbName.Text = "Bob";
            }
            else
            {
                lbName.Text = "Al";
            }
        }

        // Bets 버튼 눌렀을 때
        private void btnBets_Click(object sender, EventArgs e)
        {
            if (rbJoe.Checked)
            {
                if (guys[0].PlaceBet((int)numericAmount.Value, (int)numericDog.Value))
                    guys[0].UpdateLabels();
                else
                    MessageBox.Show("이미 배팅했거나, 배팅액이 현재 현금 보유액보다 큽니다.");
            }
            else if (rbBob.Checked)
            {
                if (guys[1].PlaceBet((int)numericAmount.Value, (int)numericDog.Value))
                    guys[1].UpdateLabels();
                else
                    MessageBox.Show("이미 배팅했거나, 배팅액이 현재 현금 보유액보다 큽니다.");
            }
            else
            {
                if (guys[2].PlaceBet((int)numericAmount.Value, (int)numericDog.Value))
                    guys[2].UpdateLabels();
                else
                    MessageBox.Show("이미 배팅했거나, 배팅액이 현재 현금 보유액보다 큽니다.");
            }
            
        }

        // Race! 버튼 눌렀을 때
        private void btnRace_Click(object sender, EventArgs e)
        {
            int winner = 0;
            bool isWinner = false;

            // 우승한 개가 가려질 때까지 개들을 경주시킵니다.
            while (!isWinner)
            {
                for(int i=0; i<4; i++)
                {
                    try
                    {
                        isWinner = greyhounds[i].Run();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    

                    if (isWinner)
                    {
                        winner = i + 1;
                        break;
                    }
                }
            }
            

            // 승리할 경우 나오는 창
            MessageBox.Show("We have a winner - Dog #" + winner);

            // 개들을 시작위치로 옮김
            ResetForm();
        
            // 플레이어들에게 결과 반영
            for(int i=0; i<3; i++)
            {
                guys[i].Collect(winner);
            }

        }
    }
}
