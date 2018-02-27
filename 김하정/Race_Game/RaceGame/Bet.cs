using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceGame
{
    public class Bet
    {
        public int Amount; //베팅한 금액
        public int Dog; //베팅한 개의 번호
        public Guy Bettor; //베팅한 사람에 해당하는 Guy객체

        public string GetDescription()      //함수를 만들면 반환되는 값을 먼저 만들자.
        {
            /*누가 얼만큼을 어떤 개한테 걸었는지 나타내는 문자열을 반환합니다. 
             * 베팅금액이 0이면 베팅을 하지 않았다는 내용의 문자열을 반환한다.*/
            string NowBet;

            if (Amount == 0)
            {
                NowBet = Bettor.Name + "는(은) 베팅을 하지 않았습니다.";
            }
            else
            {
                NowBet = Bettor.Name+"는(은)" + Dog+"번 개에"+Amount+"를 걸었습니다.";
            }
            return NowBet;

            
        }
        public int PayOut(int Winner)
        {
            //우승한 개의 번호가 매개변수로 전달됩니다. 
            // 베팅한 개가 우승했으면 베팅 액수를 반환합니다. 
            //우승하지 못했다면 베팅 액수에 마이너스를 붙여서 반환합니다.

            if (Dog == Winner)
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
