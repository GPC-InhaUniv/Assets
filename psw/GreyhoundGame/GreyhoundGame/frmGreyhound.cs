using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GreyhoundGame
{
    public partial class frmGreyhound : Form
    {
        private Guy[] _listOfGuys = null;
        private Greyhound[] _listOfDogs = null;
        private int _flag = 0;
        private bool _enableRaceBtn = false;

        public frmGreyhound()
        {
            InitializeComponent();          
            
        }

        private void frmGreyhound_Load(object sender, EventArgs e)
        {
            try
            {
                if (numBucks.Value == 5000)
                    lbl베팅정보.Text = "최소배팅 금액 : 5000 원";

                FillArrays();

                if (!this._enableRaceBtn)
                    btnStart.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void FillArrays()
        {
            Random myRandom = new Random(); // myRandom 생성

            _listOfGuys = new Guy[3] // _listOfGuys 생성
            {
                new Guy() 
                { 
                    Name = "Joe", 
                    Cash = 100000,  // 초기 보유 금액 설정
                    MyBet = new Bet(), 
                    MyLabel = lblJoe, 
                    MyRadioButton = rdbJoe
                },

                new Guy()
                { 
                    Name = "Bob", 
                    Cash = 100000,  // 초기 보유 금액 설정
                    MyBet = new Bet(),  
                    MyLabel = lblBob, 
                    MyRadioButton = rdbBob
                },

                new Guy() 
                { 
                    Name = "Al", 
                    Cash = 100000,  // 초기 보유 금액 설정
                    MyBet = new Bet(), 
                    MyLabel = lblAl, 
                    MyRadioButton = rdbAl
                }
            };

            _listOfDogs = new Greyhound[4] // _listOfDogs 생성
            {
                new Greyhound() 
                { 
                    RacetrackLength = pBoxRaceTrack.Width - 70,  // 레이스 트랙 길이 설정
                    StartingPosition = pBoxRaceTrack.Location.X, 
                    Randomizer = myRandom, // 랜덤값을 Randomizer에 저장
                    MyPictureBox = pBoxDog1
                },

                new Greyhound()
                { 
                    RacetrackLength = pBoxRaceTrack.Width - 70,  // 레이스 트랙 길이 설정
                    StartingPosition = pBoxRaceTrack.Location.X, 
                    Randomizer = myRandom, // 랜덤값 저장
                    MyPictureBox = pBoxDog2
                },

                new Greyhound() 
                { 
                    RacetrackLength = pBoxRaceTrack.Width - 70,  // 레이스 트랙 길이 설정
                    StartingPosition = pBoxRaceTrack.Location.X, 
                    Randomizer = myRandom, // 랜덤값 저장
                    MyPictureBox = pBoxDog3
                },

                new Greyhound() 
                { 
                    RacetrackLength = pBoxRaceTrack.Width - 70,  // 레이스 트랙 길이 설정
                    StartingPosition = pBoxRaceTrack.Location.X, 
                    Randomizer = myRandom, // 랜덤값 저장
                    MyPictureBox = pBoxDog4
                }
            };

            for (int i = 0; i < _listOfGuys.Length; i++)
            {
                _listOfGuys[i].MyBet.Better = _listOfGuys[i];
                _listOfGuys[i].UpdateLabels();
            }

            PlaceDogPicturesAtStart();
        }

        private void btnStart_Click(object sender, EventArgs e) // 스타트 버튼 클릭시
        {
            try
            {
                RaceButtonWorking(); // 함수 호출
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e) // 종료 버튼 클릭시
        {
            this.Close(); // 폼 종료
        }

        private void rdbJoe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJoe.Checked)
            {
                this._flag = 1;
                lblGuyName.Text = this._listOfGuys[0].Name; // 라디오 박스에 체크시 베팅 버튼 옆에 이름 표시
            }
        }

        private void rdbBob_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBob.Checked)
            {
                this._flag = 2;
                lblGuyName.Text = this._listOfGuys[1].Name; // 라디오 박스에 체크시 베팅 버튼 옆에 이름 표시
            }
        }

        private void rdbAl_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAl.Checked)
            {
                this._flag = 3;
                lblGuyName.Text = this._listOfGuys[2].Name; // 라디오 박스에 체크시 베팅 버튼 옆에 이름 표시
            }
        }

        public void BetsButtonWorking()
        {
            int bucksNumber = 0; // 베팅입력 초기값
            int dogNumber = 0; // 경주견 번호 초기값

            if (!rdbJoe.Checked && !rdbBob.Checked && !rdbAl.Checked)
            {
                MessageBox.Show("반드시 한사람은 선택해야 합니다.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bucksNumber = Convert.ToInt32(numBucks.Value);
            dogNumber = Convert.ToInt32(numDogNo.Value);

            if (IsExceedBetLimit(bucksNumber)) // 베팅입력 상한 함수 요청
            {
                MessageBox.Show("최대 한마리에 15000원.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _enableRaceBtn = true; // 한명이라도 베팅시 레이스 버튼 활성화

            if (this._flag == 1)
            {
                this._listOfGuys[0].PlaceBet(bucksNumber, dogNumber);
            }
            else if (this._flag == 2)
            {
                this._listOfGuys[1].PlaceBet(bucksNumber, dogNumber);
            }
            else if (this._flag == 3)
            {
                this._listOfGuys[2].PlaceBet(bucksNumber, dogNumber);
            }
        }

        public bool IsExceedBetLimit(int amount) // 베팅입력 상한 설정 함수
        {
            if (amount > 15000 && amount > 5000)
                return true;

            return false;
        }

        private void btnBets_Click(object sender, EventArgs e) // 베팅 버튼
        {
            try
            {
                BetsButtonWorking(); // 베팅 버튼 작동 함수 요청

                if (this._enableRaceBtn)
                    btnStart.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RaceButtonWorking() // 레이스 버팅 작동
        {
            btnBets.Enabled = false; // 베팅 버튼 비활성
            btnStart.Enabled = false; // 시작 버튼 비활성

            bool winnerDogFlag = false; // 승리 경주견 판정 초기값
            int winningDogNo = 0; // 승리 경주견 번호 저장 변수 초기화

            while (!winnerDogFlag) // 승리 경주견 함수가 true가 반환 될때까지 반복
            {
                for (int i = 0; i < _listOfDogs.Length; i++)
                {
                    if (this._listOfDogs[i].Run())
                    {
                        winnerDogFlag = true; // 승리 경주견 true 반환
                        winningDogNo = i;
                    }

                    pBoxRaceTrack.Refresh(); // 레이스 트랙 초기화
                }
            }

            MessageBox.Show("승리 경주견은  # " + (winningDogNo + 1) + "!", "경기 끝");

            for (int j = 0; j < _listOfGuys.Length; j++)
            {
                this._listOfGuys[j].Collect(winningDogNo + 1);
                this._listOfGuys[j].ClearBet(); // 모든 베팅 초기화
            }

            PlaceDogPicturesAtStart();

            btnBets.Enabled = true; // 경주끝 베팅 버튼 활성화
        }

        public void PlaceDogPicturesAtStart() // 경주견 스타트 라인으로 모두 초기화
        {
            for (int k = 0; k < _listOfDogs.Length; k++)
                _listOfDogs[k].TakeStartingPosition();
        }     
    }
}
