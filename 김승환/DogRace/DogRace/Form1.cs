using System;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Collections.Generic;

namespace DogRace
{
    // Form 클래스 내부에서 객체 배열 미리 선언
    // betCount 배열을 생성하여 베팅을 했는지 여부 저장
    public partial class Form1 : Form
    {
        Greyhound[] greyhound = new Greyhound[4];
        Guy[] guy = new Guy[3];
        bool[] betCount = { false, false, false };

        public Form1()
        {
            InitializeComponent();
        }

        // Form이 로딩되었을 때 데이터를 쓰기/읽기를 하는 Stream R/W 선언
        // 또한 객체도 미리 생성
        // 읽어들인 데이터는 리스트 형태로 저장

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string path = "CashDataBase.txt";
                StreamReader streamReader = new StreamReader(path);

                int startingPosition = dogPictureBox1.Right - racePictureBox.Left;
                int racetrackLength = racePictureBox.Size.Width;
                int num = 0;

                // 경주견 객체 생성
                greyhound[0] = new Greyhound(startingPosition, racetrackLength, dogPictureBox1);
                greyhound[1] = new Greyhound(startingPosition, racetrackLength, dogPictureBox2);
                greyhound[2] = new Greyhound(startingPosition, racetrackLength, dogPictureBox3);
                greyhound[3] = new Greyhound(startingPosition, racetrackLength, dogPictureBox4);

                // 데이터 저장 리스트
                List<string[]> list = new List<string[]>();

                string[] cols;

                // 리스트에 데이터를 집어 넣음
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    cols = line.Split(',');

                    list.Add(cols);
                    num++;
                }

                streamReader.Close();

                // 사람들 객체 생성
                guy[0] = new Guy(list[0][0], Int32.Parse(list[0][1]), radioButton1, bettorLabel1);
                guy[1] = new Guy(list[1][0], Int32.Parse(list[1][1]), radioButton2, bettorLabel2);
                guy[2] = new Guy(list[2][0], Int32.Parse(list[2][1]), radioButton3, bettorLabel3);

                // 각각 사람들의 돈을 라디오버튼 옆에 최신화
                foreach (Guy g in guy)
                {
                    g.UpdateLabels();
                }
            }
            // 파일을 찾을 수 없는 경우 메시지를 출력하여 파일이 없는 것을 인지시키고 폼 종료
            catch(FileNotFoundException)
            {
                MessageBox.Show("No Text Data");
            }
        }

        // 라디오 버튼 선택지
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bettorNameLabel.Text = guy[0].name;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bettorNameLabel.Text = guy[1].name;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            bettorNameLabel.Text = guy[2].name;
        }

        // 베팅 버튼 클릭 이벤트
        private void betButton_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountNumericUpDown.Value);
            int dog = Convert.ToInt32(dogNumNumericUpDown.Value);

            // 라디오버튼의 텍스트 값을 이용하여 베팅 여부 파악
            if (bettorNameLabel.Text == guy[0].name)
            {
                if (guy[0].PlaceBet(amount, dog))
                {
                    guy[0].myLabel.Text = guy[0].myBet.GetDescription();
                    betCount[0] = true;
                }
            }
            else if(bettorNameLabel.Text == guy[1].name)
            {
                if (guy[1].PlaceBet(amount, dog))
                {
                    guy[1].myLabel.Text = guy[1].myBet.GetDescription();
                    betCount[1] = true;
                }
            }
            else if(bettorNameLabel.Text == guy[2].name)
            {
                if(guy[2].PlaceBet(amount, dog))
                {
                    guy[2].myLabel.Text = guy[2].myBet.GetDescription();
                    betCount[2] = true;
                }
            }
        }

        // 레이스 시작 버튼 이벤트 
        private void raceButton_Click(object sender, EventArgs e)
        {
            // 베팅 여부를 모두 파악하고 모두 베팅상태일 때 레이스를 시작
            if (betCount[0] == true && betCount[1] == true && betCount[2] == true)
            {
                int winner = 0;
                bool raceFinish = true;
                raceButton.Enabled = false;
                int startingPosition = dogPictureBox1.Right - racePictureBox.Left;

                //레이스가 종료할 때 까지 무한 반복
                while (raceFinish)
                {
                    for (int i = 0; i < greyhound.Length; i++)
                    {
                        if (greyhound[i].Run())
                        {
                            winner = i;
                            raceFinish = false;
                            break;
                        }
                        // while 처리속도 제어
                        Thread.Sleep(10);
                        DoubleBuffered = false;

                        racePictureBox.Update();
                    }
                }
                // 멍멍이들 위치 초기화
                foreach (Greyhound g in greyhound)
                {
                    g.TakeStartingPostion();
                }
                // 닝겐들 보유 캐쉬 업데이트 및 라디오버튼에 캐쉬 내역 업데이트
                foreach(Guy g in guy)
                {
                    g.Collect(winner);
                    g.UpdateLabels();
                }

                MessageBox.Show(string.Format("Race has been finished! Dog {0} is winner", winner), "Notice");

                // 베팅 정도 초기화
                for(int i = 0; i < betCount.Length; i++)
                {
                    betCount[i] = false;
                    guy[i].ClearBet();
                    guy[i].myLabel.Text = guy[i].myBet.GetDescription();
                }

                // 스트림라이터로 파일에 쓰기
                StreamWriter streamWriter = new StreamWriter("CashDataBase.txt", false);

                for(int i = 0; i < 3; i++)
                {
                    string data = guy[i].name + ", " + guy[i].cash;
                    streamWriter.WriteLine(data);
                }
                streamWriter.Close();

                raceButton.Enabled = true;
                
            }

            else
            {
                MessageBox.Show("All guys have to bet! Try again", "Notice");
            }
        }

        // 캐쉬 충전 버튼
        private void rechargeButton_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                guy[0].cash += 500;
            }
            if (radioButton2.Checked)
            {
                guy[1].cash += 500;
            }
            if (radioButton3.Checked)
            {
                guy[2].cash += 500;
            }

            foreach (Guy g in guy)
            {
                g.UpdateLabels();
            }
        }

        // Form이 강제로 닫히는 경우를 대비하여 다시 한번 닝겐들 정보를 파일에 최산화
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("CashDataBase.txt", false);

            for (int i = 0; i < 3; i++)
            {
                string data = guy[i].name + ", " + guy[i].cash;
                streamWriter.WriteLine(data);
            }
            streamWriter.Close();
        }
    }
}
