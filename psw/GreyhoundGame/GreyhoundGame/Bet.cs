using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreyhoundGame
{
    public class Bet
    {
        public int Amount { get; set;} // 베팅한 금액
        public int Dog { get; set;} // 베팅한 개의 번호
        public Guy Better {get; set;} // 베팅한 사람에 해당하는 Guy 객체

        public string GetDescription()
        {
            // 누가 얼만큼을 어떤 개한테 걸었는지 나타내는 문자열을 반환
            // (예 : Joe bets 8 on dog #4)
            // 베팅액이 0이면 베팅을 하지 않았다는 내용의 문자열
            // (예 : Joe hasn't placed a bet)을 반환합니다.

            if (this.Amount == 0)
            {
                return this.Better.Name + " 는(은) 어느 개에도 배팅 없음";
            }
            else
            {
                return this.Better.Name + " 는(은) " + this.Better.MyBet.Dog.ToString() + " 개에 " + this.Better.MyBet.Amount.ToString() + " 원 배팅";
            }
        }

        public int PayOut(int Winner)
        {
            // 우승한 개의 번호가 매개변수로 전달됩니다.
            // 베팅한 개가 우승했으면 베팅 액수를 반환합니다.
            // 우승하지 못했다면 베팅 액수에 마이너스를 붙여서 반환합니다.

            if (this.Better.MyBet.Dog == Winner) // 경주견이 승리하였을 경우
            {
                return this.Amount; // 베팅 금액 반환
            }
            else
            {
                return -this.Amount; // 베팅 금액 차감하여 반환
            }
        }
    }
}
