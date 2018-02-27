using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuppyRace

{
    class Bet
    {
        public int Amount;  // 베팅한 금액
        public int Dog;     // 베팅한 개의 번호
        public Guy Bettor;  // 베팅한 사람에 해당하는 Guy 객체

        public string GetDescription()
        {
            // 누가 얼만큼을 어떤 개한테 걸었는지 나타내는 문자열을
            // 반환합니다(예: "Joe bets 8 on dog #4").
            // 베팅 금액이 0이면 베팅을 하지 않았다는 문자열
            // (예: "Joe hasn't placed a bet")을 반환합니다.

            string strDesc;

            if (Amount == 0)
                strDesc = Bettor.Name + " hasn't placed a bet";
            else
                strDesc = Bettor.Name + " bets " + Amount + " on dog #" + Dog;

            return strDesc;
        }

        public int PayOut(int Winner)
        {
            // 우승한 개의 번호가 매개변수로 전달됩니다.
            // 베팅한 개가 우승했으면 베팅 액수를 반환합니다.
            // 우승하지 못했다면 베팅 액수에 마이너스를 붙여서 반환합니다.

            if (Dog == Winner)
                return Amount;
            else
                return -Amount;
        }
    }
}
