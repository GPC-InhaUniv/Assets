using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuppyRace

{
    class Guy
    {
        public string Name;                 // 사람 이름
        public Bet MyBet;                   // 베팅 내역을 저장할 Bet 인스턴스
        public int Cash;                    // 지금 가지고 있는 현금 액수

        // 마지막 두 필드는 폼에서 이 사람을 나타낼 GUI 컨트롤
        public RadioButton MyRadioButton;   // 라디오 버튼
        public Label MyLabel;               // 레이블

        // 레이블 베팅 내역 표시
        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash + " bucks";

            if (MyBet == null)
                MyLabel.Text = Name + " hasn't placed a bet";
            else
                MyLabel.Text = MyBet.GetDescription();
        }

        // 베팅 리셋
        public void ClearBet()
        {
            MyBet = null;
        }

        // 지정한 개에 베팅하는 함수
        public bool PlaceBet(int Amount, int Dog)
        {
            // 이미 배팅했거나, 베팅액이 현재 현금 보유액보다 크면 false 반환
            if (MyBet != null || Amount > Cash)
                return false;

            MyBet = new Bet() { Amount = Amount, Dog = Dog, Bettor = this };
            return true;
        }

        // 베팅 결과를 처리하는 함수
        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            ClearBet();
        }
    }
}
