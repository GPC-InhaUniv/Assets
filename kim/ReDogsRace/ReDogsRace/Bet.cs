using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDogsRace
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        //생성자 - Guy에서 각 객체가 베팅한 돈과 개의 번호, 그리고 베팅자객체를 받는다.
        
        public Bet(int Money, int DogNum, Guy Player)
        {
            Amount = Money;
            Dog = DogNum;
            Bettor = Player;
        }
        public string GetDescription()
        {
            //Dog를 설정하지 않으면 베팅하지 않는다고 인식
            if (Dog == 0)
            {
                Amount = 0;
                return Bettor.Name + " hasn't placed a bet";
            }
            else
                return Bettor.Name + " bets " + Amount + " on dog #" + Dog;
        }
        //우승 개와 각 객체들이 베팅한 개와 비교하여 베팅금액 변경
        public int PayOut(int Winner)
        {
            if (Winner == Dog)
                return Amount;
            else
                return -Amount;
        }

    }
}
