using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace ReDogsRace
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public TextBox MyText;


        //생성자 - 매개변수로는 이름, 돈, 라디오 버튼, 텍스트박스를 받는다.
        public Guy(string name, int money, RadioButton label, TextBox text)
        {
            Name = name;
            Cash = money;
            MyRadioButton = label;
            MyText = text;
        }

        //라디오 버튼 업데이트 - 폼 로딩, 캐시 충전, 레이스 종료 시에 각 객체가 가진 돈을 라벨에 표시
        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash + "bucks";
        }

        //베팅 정보 텍스트박스를 초기화
        public void ClearBet()
        {
            MyText.Text = string.Empty;
        }


        /*베팅 - 객체생성 (전달값으로는 베팅 금액, 개의 번호, 베팅자(각 객체 자신))
         * 베팅 하는 돈이 자신이 가진돈과 비교하여 베팅을 하는지 못하는지 설정.
        */
        public void PlaceBet(int Amount, int Dog)
        {

            if (Amount <= Cash)
            {
                MyBet = new Bet(Amount, Dog, this);
                MyText.Text = MyBet.GetDescription();

            }
            else
            {
                MyText.Text = " Not have Enough Bucks";
                MyBet = new Bet(0, Dog, this);
            }
          
        }

        /* Bet객체에 우승 개 번호 전달
         * 
            */
        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
        }

    }
}
