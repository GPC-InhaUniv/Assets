using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulationrace
{
    public class Bet
    {
        public int Amount; //배팅금액
        public int Dog; //배팅한 개의 넘버
        public Guy Bettor; //베팅한 사람에 해당하는 객체


        public string GetDescription()
        {
            //누가 얼만큼을 어떤 개한테 걸었는지 나타내는 문자열을 반환합니다(예: "JoE bets 8 on dog#4")
            //베팅금액이 0이면 베팅을 하지 않았다는 내용의 문자열(예:"joe hasn't placed a bet")을 반환

            String strGD;

            if (Amount == 0) // 베팅금액이 0이면 베팅을 하지 않았다는
                strGD = Bettor.Name + "는 배팅하지 않았습니다.";
            else //누가 몇번 개에게 얼만큼 배팅했는가.
                strGD = Bettor.Name + "는" + Dog + "번의 개한테" +Amount + "만큼 배팅했습니다.";
        
            return strGD; //스트링 변수에 저장하여 반환함.
        }

   
        public int PayOut(int WinningDog)
        {
            //우승한 개의 번호가 매개변수로 전달됩니다.
           
            if (Dog == WinningDog)
                return Amount; //베팅한 개가 우승했으면 베팅 액수를 반환합니다.
            else
                return -Amount; //우승하지 못했다면 베팅액수에 마이너스를 붙여 반환합니다.
        }
    }
}
