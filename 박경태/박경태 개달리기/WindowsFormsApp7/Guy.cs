using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    class Guy
    {
        public string Name; // 사람 이름
        public Bet MyBet; // 베팅 내역을 저장할 Bet 인스턴스
        public int cash; // 지금 가지고 있는 현금 액수

        // 마지막 두 필드는 폼에서 이 사람을 나타낼 GUI 컨트롤입니다.
        public RadioButton MyRadioButton; // 라디오 버튼
        public Label MyLabel; // 레이블

        // 라벨과 텍스트를 표시해준다.
        //Bet 버튼을 누르면 변경된다.
        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + "의 보유 금액은 " + cash + "달러입니다.";

            if(MyBet == null)
            {
                MyLabel.Text = "배팅하시오.";
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();
            }
        }

        // 배팅 내역을 초기화해준다.
        public void ClearBet()
        {
            MyBet = null;
        }

        // 배팅내역을 필드에 저장한다.
        // 배팅금액이 보유금액보다 작으면 트루, 적으면 펄스를 리턴해준다.
        public bool PlaceBet(int Amount, int Dog)
        {
            MyBet = new Bet() { Amount = Amount, DogNumber = Dog, Bettor = this };

            MyLabel.Text = MyBet.GetDescription();

            if(Amount < cash)
            {
                return true;
            }
            else
            {
                MyLabel.Text = "금액이 부족합니다. 배팅할 수 없습니다.";
                return false;
            }
        }

        // 배팅 결과를 처리해준다.
        public void Collect(int WinnerDog, int Amount, int GuyDogNumber)
        {
            MyBet = new Bet() { DogNumber = GuyDogNumber, Amount = Amount, Bettor = this };
            cash += MyBet.PayOut(WinnerDog);
        }
    }
}