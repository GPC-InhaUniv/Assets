using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    public class Guy
    {
        public string name;
        public Bet myBet;
        public int cash;

        public RadioButton myRadioButton;
        public Label myLabel;

        // 닝겐 생성자 초기화
        public Guy(string name, int cash, RadioButton myRadioButton, Label myLabel)
        {
            this.name = name;
            this.cash = cash;
            this.myRadioButton = myRadioButton;
            this.myLabel = myLabel;
        }

        // 라디오 버튼의 텍스트 영역에 닝겐 데이터 저장
        public void UpdateLabels()
        {
            myRadioButton.Text = string.Format("{0} has {1} bucks", name, cash);
        }

        // 베팅 금액 초기화
        public void ClearBet()
        {
            myBet.amount = 0;
        }
        
        // 베팅 메소드, 객체를 그때 그때 생성
        public bool PlaceBet(int Amount, int Dog)
        {
            if(Amount <= cash && Amount > 0 )
            {
                myBet = new Bet(Amount, Dog, this);
                return true;
            }
            else
            {
                return false;
            }
        }

        // 경기 결과에 대한 보유 캐쉬 증감 및 차감
        public void Collect(int winner)
        {
            cash += myBet.PayOut(winner);
        }

        
    }
}
