using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRacing
{
    class Guy
    {
        public string Name;     // 사람 이름
        public Bet MyBet;       // 배팅 내역을 저장할 Bet 인스턴스
        public int Cash;        // 지금 가지고 있는 현금 액수

        // 마지막 두 필드는 폼에서 이 사람을 나타낼 GUI 컨트롤이다.
        public RadioButton MyRadioButton;       // 라디오 버튼
        public Label MyLabel;       // 레이블

        public void UpdateLabels()
        {
            // 레이블에 배팅 내역을 표시하고 라디오버튼에 붙일 레이블에는
            // 현재 현금 보유액을 표시한다.("Joe has 43 bucks" 같은 식으로)
            
            if(MyBet != null)
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            else
            {
                //MyLabel.Text = MyBet.GetDescription();
            }
                     
            MyRadioButton.Text = Name + " has " + Cash + " bucks";

        }

        public void ClearBet()
        {
            // Reset my bet so it's zero
            MyBet = null;
            UpdateLabels();
        }

        public bool PlaceBet(int Amount, int Dog)
        {

            // 새로 배팅을 하고 (Bet 새로 인스턴스를 만든다)
            // 배팅 내역을 MyBet 필드에 저장한다 (Bet 객체에 자신 알림)
            // 배팅에 필요한 만큼 현금을 보유하고 있으면 참을 반환한다.

            MyBet = new Bet() { Amount = 0, Dog = 0, Bettor = this };
            
            if (Cash >= Amount)
            {
                return true;
            }

            Cash -= Amount;
            UpdateLabels();

            return false;
        }

        public void Collect(int Winner)
        {
            // 베팅 결과를 처리하는 부분 (돈을 지불해야 하는지 판단)
            if (MyBet != null)
                Cash += MyBet.PayOut(Winner);       // Bet.PayOut()에서 반환한 결과를 
                                                    // 자신이 가진 금액에 더함
            ClearBet();

        }

    }
}
