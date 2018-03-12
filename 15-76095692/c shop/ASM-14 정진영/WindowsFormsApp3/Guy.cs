using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Guy
    {
        public string Name; //사람이름
        public Bet MyBet;//베팅 내역을 저장할 수 있는 bet인스턴스
        public int Cash;//지금 가지고 있는 돈액수

        public RadioButton MyRadioButton;
        public Label MyLabel;

        //Bet에서 Guy의 객체를 필요로한다 그래서 만들어줬음 그런데 하다보니 객체랑 인스턴스랑 무슨 차이인지 찾아봐도 이해가 안됨
        //선생님이 명쾌하게 알려줬으면 좋겠음 이거 생각하다 뇌가 정지해서 작업이 진행 안됨
        public Guy(string Name, Bet MyBet, int Cash, RadioButton MyRadioButton, Label MyLabel)
        {
            this.Name = Name;
            this.MyBet = MyBet;
            this.Cash = Cash;
            this.MyRadioButton = MyRadioButton;
            this.MyLabel = MyLabel;
        }


        public void UpdateLabels()
        {
            //레이블에 배팅네역을 표시하고 라디오버튼에 붙일 레이블에는 현재 현금 보유액을 표시해준다
            //("Joe has 43 bucks")
            //Console.WriteLine(Name + " has " + MyBet + " bucks");
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
            if (MyBet == null)
            {
                MyLabel.Text = Name+" hasn't placed any bets";
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();
            }
        }

        public void ClearBet()
        {
            //Reset my bet so it's zero
            MyBet.Amount = 0;
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            //새로 베팅을 하고 베팅 내역을 mybet필드에 저장한다. <-배팅한내용은 bet 인스턴스로 표현할거라 했다.
            //베팅에 필요한만큼 현금을 보유하고있으면 참을 반환합니다.
            if (Amount <= Cash)
            {
                //MyBet 필드에 저장해야함, 배팅내용은 Bet '인스턴스'로 표현한다. '인스턴스'
                /*인스턴스 예재.
                public CoOrds(int x, int y)
                {
                    this.x = x;
                    this.y = y;
                }
                */
                MyBet = new Bet(Amount, Dog, this);//MyBet 필드에 저장할건데 지금은 인스턴스가 없음. 만들어야함. 만들러감. bet클레스로
                //Name이 빨간불이다 왜지..인스턴스라고 해당 클레스에 모든값을 넘겨주지 않아도 되는듯

                return true;
            }
            return false;
        }

        public void Collect(int Winner)//베팅결과를 처리하는 부분
        {
            Cash += MyBet.PayOut(Winner);
        }
        
    }
}
