using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DogRaces
{
    public partial class Form1 : Form
    {
        private Guy[] guys;
        private Greyhound[] dogs;
        private Random rand;

        public Form1()
        {
            InitializeComponent();

            guys = new Guy[3];
            dogs = new Greyhound[4];
            rand = new Random();

            // 각 참가자의 이름과 보유 액등을 초기화
            guys[0] = new Guy() { Name = "Joe", Cash = 50, MyRadioButton = rbJoe, MyLabel = lbJoeBets, MyBet = null };
            guys[1] = new Guy() { Name = "Bob", Cash = 75, MyRadioButton = rbBob, MyLabel = lbBobBets, MyBet = null };
            guys[2] = new Guy() { Name = "Al", Cash = 45, MyRadioButton = rbAl, MyLabel = lbAlBets, MyBet = null };

            // 시작 위치는 28, 개의 길이는 75, 트랙의 길이는 450(PictureBox의 Length가 아니라 직접 잼)
            dogs[0] = new Greyhound() { MyPictureBox = pbDog1, StartingPosition = 28, RacetrackLength = 450, Randomizer = rand };
            dogs[1] = new Greyhound() { MyPictureBox = pbDog2, StartingPosition = 28, RacetrackLength = 450, Randomizer = rand };
            dogs[2] = new Greyhound() { MyPictureBox = pbDog3, StartingPosition = 28, RacetrackLength = 450, Randomizer = rand };
            dogs[3] = new Greyhound() { MyPictureBox = pbDog4, StartingPosition = 28, RacetrackLength = 450, Randomizer = rand };

            // 폼 재구성
            ResetForm();
        }

        public void ResetForm()
        {
            // 개 위치 시작 위치로 이동
            for(int i=0; i<4; i++)
                dogs[i].TakeStartingPosition();

            // 현금 보유액 및 베팅 상황 보이기
            for (int i = 0; i < 3; i++)
                guys[i].UpdateLabels();
            
        }

        private void btBets_Click(object sender, EventArgs e)
        {
            // 베팅 시작
            if (rbJoe.Checked)  //if문 배팅을두번이나할때
            {
                if (guys[0].PlaceBet((int)numBucks.Value, (int)numDogNumber.Value))
                    guys[0].UpdateLabels();
                else
                    MessageBox.Show("이미 배팅했거나, 베팅액이 현재 현금 보유액보다 큽니다.");
            }
            else if (rbBob.Checked)
            {
                if (guys[1].PlaceBet((int)numBucks.Value, (int)numDogNumber.Value))
                    guys[1].UpdateLabels();
                else
                    MessageBox.Show("이미 배팅했거나, 베팅액이 현재 현금 보유액보다 큽니다.");
            }
            else
            {
                if (guys[2].PlaceBet((int)numBucks.Value, (int)numDogNumber.Value))
                    guys[2].UpdateLabels();
                else
                    MessageBox.Show("이미 배팅했거나, 베팅액이 현재 현금 보유액보다 큽니다.");
            }
        }

        private void btRace_Click(object sender, EventArgs e)
        {
            bool isWinner = false;
            int nDogNum = 0;

            // 베팅이 완료되지 않았다면 에러 메세지 
            for (int i = 0; i < 3; i++)
            {
                if (guys[i].MyBet == null)
                {
                    MessageBox.Show(guys[i].Name + "이(가) 아직 베팅하지 않았습니다.");
                    return;
                }
            }

            // 경주 시작
            while (!isWinner)
            {
                for (nDogNum = 0; nDogNum < 4 && isWinner == false; nDogNum++)
                {
                    isWinner = dogs[nDogNum].Run();
                }
                System.Threading.Thread.Sleep(10); // 10초 지연
            }
            
            // 우승견을 메세지로 띄움
            MessageBox.Show("We have a winner - dog #" + nDogNum + "!");

            // 상금 배당하기
            for (int i = 0; i < 3; i++)
                guys[i].Collect(nDogNum);

            // 폼 리셋함
            ResetForm();
        }

        private void rbName_Click(object sender, EventArgs e)
        {
            // 라디오 버튼을 클릭할 때 마다 그에 해당하는 이름 출력
            if (rbJoe.Checked)
                lbName.Text = "Joe";
            else if (rbBob.Checked)
                lbName.Text = "Bob";
            else
                lbName.Text = "Al";
        }  
    }
}
