using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwang_dog_race
{
    public class Bet
    {

        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            //누가 얼만큼 어떤개한테 겅었는지 나타내는 문자열을 반환
            //0이면 베팅을 하지 않았다는 내용의 문자열을 반환

            //name+" bets "+Amount+" on dog # "+dog
            if (Amount == 0)
            {
                return Bettor.Name + " hasn't placed a bet";
            }
            else
            {
                return Bettor.Name + " bets " + Amount + " on dog # " + Dog;
            }
        }

        public int PayOut(int WinningDog)
        {
            
            if (WinningDog == Dog)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
            
        }
    }
}
