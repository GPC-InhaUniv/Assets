using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGame
{
    public class Guy
    {
        public string Name; //사람이름
        public Bet MyBet;   //베팅 내역을 저장할 bet 인스턴스
        public int Cash;    //지금 가지고 있는 현금 액수

        //마지막 두 필드는 폼에서 이 사람을 나타낼 GUI컨트롤 입니다.
        public RadioButton Buttons;
        public Label Labels;

        public void UpdateLabels()
        {
            //레이블에 '베팅 내역'을 표시하고 
            //라디오 버튼에 붙일 레이블에는 현재 현금 보유액을 표시해 줍니다.
            Buttons.Text = Name + "는(은) 현재" + Cash + "달러를 가지고 있습니다.";
            Labels.Text = MyBet.GetDescription();   //베팅내역을 표시할떄 bet class에서 만들어준 GetDescription 메소드를 가져왔다.

        }

        //bet을 초기화
        public void ClearBet()
        {
            MyBet = null;
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            //새로 베팅을 하고 베팅 내역을 My Bet 필드에 저장 합니다.
            //베팅에 필요한 만큼 현금을 보유하고 있으면 참을 반환합니다.

            //bet으로 객체를 만들어주고 bet의 Amount와 Dog, Bettor 안에 PlaceBet의 Amount와 Dog을 넣어준다.
            MyBet = new Bet() { Amount = Amount, Dog= Dog, Bettor = this};

            if (Amount <= Cash)
            {
                return false;

            }
            else
            {
                return true;
            }


        }

        //베팅 결과를 처리하는 부분.//bet에서 만들어준 함수를 이용
        //베팅결과에 따라 돈을 더해주고 빼준다.
        //베팅 결과 초기화.
        public void Collect(int Winner) 
        {
            Cash += MyBet.PayOut(Winner);
            ClearBet();
        }


    }
}
