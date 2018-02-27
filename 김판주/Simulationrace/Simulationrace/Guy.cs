using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulationrace
{
    public class Guy
    {
    
        public string Name;

        public Bet MyBet; //베팅내역을 저장할 Bet 인스턴스

        public int Cash; // 지금가지고 있는 현금 액수

        //마지막 두 필드는 폼에서 이 사람 을 나타낼 GUI 컨트롤
        public RadioButton MyradioButton;
        public Label MyLabel; 
       

        public void UpdateLables()
        {
            //레이블에 현재 베팅내역을 표시하기

            MyradioButton.Text = Name + "는" + Cash + " 만큼 가졌다."; //각자 선수의 라디오버튼의 텍스트를 현재 상태로 업데이트함.

            if (MyBet == null) //만약 베팅금액이 없다면...
                MyLabel.Text = Name + "는 배팅하지 않았습니다.";
            else
                MyLabel.Text = MyBet.GetDescription(); //strGD = Bettor.Name + "는" + Dog + "번의 개한테" + Amount + "만큼 배팅했습니다.";
        }

        public void ClearBet()//Reset my bet so it's zero
        {
            MyBet = null;
        }
        public bool PlaceBet(int Amount, int Dog) //(guys[0].PlaceBet((int)Bupdown.Value, (int)dogupdown.Value))
        {
            //새로 베팅을 하고 베팅 내역을 MyBet 필드에 저장!
            //베팅에 필요한 만큼 현금을 보유하고 있으면  True을 반환합니다.

            if (MyBet != null || Amount > Cash) //배팅한 금액이 있거나 배팅금액이 보유 금액보다 크다면
                return false; //오류
            else
                MyBet = new Bet() { Amount = Amount, Dog = Dog, Bettor = this }; // 배팅이 제대로 됐다면 마이벳에 배팅금, 개의 번호, 배팅한사람)
            return true;
        }

        public void Collect(int WinningDog)
        {
            Cash += MyBet.PayOut(WinningDog); //우승한 개의 번호를 맞힌 사람에게는 배팅한 금액만큼을 반환합니다.

            ClearBet();
           
        }
    }


    
}
