using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hwang_dog_race
{
    public class Guy
    {
        public string Name;
        public Bet Mybet;
        public int cash;
        public bool Startrace = false;

        //사람을 나타낼 gui컨트롤
        public RadioButton myRadioButton;
        public Label MyLabel;

      

        public void UpdateLabel()
        {
            //레이블에 베팅 내역을 표시하고 라디오버튼에 붙일 레이블에는
            //현재 현금 보유액을 표시해 줍니다. (" 조는 몇벅스 가지고있다 " 같은 식으로)

            

            myRadioButton.Text = Name+" has "+cash+" bucks";
            



        }

        public void ClearBet()
        {

            myRadioButton.Text = Name + " has " + cash + " bucks";
            MyLabel.Text = Name + " bet";
            Startrace = false;


            //reset my bet so it is zero

        }

        public bool PlaceBet(int Amount,int Dog)
        {

            //새로 베팅을하고 베팅 내역을 My Bet필드에 저장합니다.
            //베팅에 필요한 만큼 현금을 보유하고있으면 참을 반환
            Mybet = new Bet() { Amount = Amount, Dog = Dog, Bettor = this };

            if (cash >= Amount)
            {
                MyLabel.Text = Mybet.GetDescription();
                Startrace = true;

                return true;
            }
            else
            {
                MessageBox.Show(Name + "'s not enough money");
                return false;
            }





        }

        public void Collect(int WinningDog)
        {
            //결과처리
            //if()
            cash = cash + Mybet.PayOut(WinningDog);
        }

    }
}
