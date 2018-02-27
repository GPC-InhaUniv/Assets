using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GreyhoundGame
{
    public class Guy
    {
        public string Name { get; set; }
        public Bet MyBet { get; set; } // 베팅 내역을 저장할 Bet 인스턴스
        public int Cash { get; set; } // 보유 금액
        public RadioButton MyRadioButton { get; set; } // 라디오 버튼에 나타낼 텍스트
        public Label MyLabel { get; set; }

        public void UpdateLabels()
        {
            // 레이블에 베팅 내역을 표시하고 라디오버튼에 붙일 레이블에는
            // 현재 현금 보유액을 표시해줍니다. (Joe has 43 bucks같은 식으로)

            this.MyRadioButton.Text = this.Name + " 는(은) " + this.Cash.ToString() + " 원 보유";
            this.MyLabel.Text = this.MyBet.GetDescription(); // 우측 텍스트 박스에 표시할 내용
        }

        public void ClearBet() // 베팅 초기화
        {
            this.MyBet.Amount = 0;
            this.MyRadioButton.Text = this.Name + " 는(은) " + this.Cash.ToString() + " 원 보유";
            this.MyLabel.Text = this.Name + " 는(은)어느 개에도 배팅 없음"; // 우측 텍스트 박스에 표시할 내용
        }

        public bool PlaceBet(int amount, int dogNumber)
        {
            if (amount < this.Cash)
            {
                this.MyBet = new Bet() { Amount = amount, Dog = dogNumber, Better = this };
                UpdateLabels();

                return true;
            }
            return false;
        }

        public void Collect(int Winner) // Collect에 int Winner 변수 선언
        {
            if (this.Cash > 0)
            {
                this.Cash += this.MyBet.PayOut(Winner); // Bet 클래스에서 반환된 베팅 금액을 보유 금액에 합산
            }
        }
    }
}
