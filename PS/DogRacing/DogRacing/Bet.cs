using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRacing
{
    class Bet
    {
        public int Amount;      // 배팅한 금액
        public int Dog;         // 배팅한 개의 번호
        public Guy Bettor;      //배팅한 사람에 해당하는 Guy 객체

        public string GetDescription()
        {

            // 누가 얼만큼을 어떤 개한테 걸었는지 나타내는 문자열을 반환 (Joe bets 8 on dog #4)
            // 베팅 금액이 0이면 베팅을 하지 않았다는 내용의 문자열을 반환(Joe hasn't placed a bet)
            
            if (Amount == 0)
            {
                return Bettor.Name + " bets " + Amount + " on dog #" + Dog;
            }
            else
            {
                return Bettor.Name + " hasn't placed a bet.";
            }
            
        }

        public int PayOut(int Winner)
        {
            // 우승한 개의 번호가 매개변수로 전달됨
            // 베팅한 개가 우승했으면 베팅 액수를 반환
            // 우승하지 못했다면 베팅 액수에 마이너스를 붙여서 반환
            if (Winner == Dog)
            {
                return Amount*2;
            } else
            {
                return - Amount;
            }            
            
        }            
               
    }
}
