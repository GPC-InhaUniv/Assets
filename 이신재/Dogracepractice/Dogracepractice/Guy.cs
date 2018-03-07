using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Dogracepractice
{
    class Guy
    {
        public string Name;     //사람이름
        public Bet MyBet;       //베팅내역을 저장한 bet인스턴스
        public int Cash;        //지금 가지고 있는 현금액수
            //마지막 두 필드는 폼에서 이사람을 나타낼 gui컨트롤이다
        public RadioButton MyRadioButton;       //라디오버튼
        public Label MyLabel;       //레이블
        
        

        
        public void UpdateLabels()
        {

            MyRadioButton.Text = Name + "has" + Cash + "bucks";
            if (MyBet==null) //MyBet 이 Null 일 경우
            {
                MyLabel.Text = Name + " hasn't placed a bet ";
            }
            else
            {
                 MyLabel.Text = MyBet.Getdiscription();
            }

           
            //레이블에 베팅내역을 표시하고 라디오버튼에 붙일 레이블에는
            //현재 현금 보유액을 표시해준다("joe has 43 bucks")와 같은식으로
        }

        public void ClearBet()
        {
            MyBet.Amount=0;//베팅값 초기화 
           
        }


        public bool PlaceBet(int Amount, int Dog) //false를 반환하면 Form1의 btnbet_Click 메소드에서 else에 해당하는 출력을 하게된다.
        {
            if(Cash<=Amount)
                if(MyBet != null || Amount >Cash) //MyBet가 null값이거나 보유Cash보다 베팅값(Amount)이 클 경우 false를 반환한다.
                {
                    return false;
                }

                    //그 외의 true값을 반환하게 되면 Form1의 btnbet_Click 메소드의 if에 해당하는 출력을 하게 된다.
                MyBet = new Bet() { Amount = Amount, Dog = Dog, Bettor = this };

                
            
            //새로 베팅을 하고 배팅 내역을 MyBet필드에 저장한다..
            //베팅에 필요한 만큼 현금을 보유하고 있으면 참을 반환한다.
            return true;
        }

        public void Collect(int Winner) 
           
        {
            Cash += MyBet.PayOut(Winner);
            //winner를 매개변수로 받고 Bet 클래스의 PayOut메소드의 Amount값을 Cash값에 더한다.
            ClearBet(); //계산이 끝난 후에는 베팅 값을 초기화한다.
        }
    }
}
