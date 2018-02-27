using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dogracepractice
{
    class Bet
    {
        public int Amount;//베팅한 금액
        public int Dog;//베팅한 개의 번호

        public Guy Bettor;//베팅한 사람에 해당하는 guy객체

       

        public string Getdiscription()
        {
            string description;


            if (Amount==0)//Amount값을 선택하지 않았을 경우
            {
                description = Bettor.Name + " Bet please";
            }
            else
            {
                description = Bettor.Name + " bets " + Amount + " on dog #" + Dog;
            }
            return description;
        }

        public int PayOut(int Winner) // 경기결과 더하거나 뺄 Amount값을 반환한다. (winner값을 매개변수로 받음)
        {
            if(Dog == Winner)
            {
                return Amount; //베팅한 dog가 이긴 dog일 경우 (+)Amount를 반환하여 보유 cash에 더한다.
            }
            else
            {
                return -Amount; //베팅한 dog가 이긴 dog가 아닐경우 -Amount를 반환하여 보유cash에서 뺀다.
            }

            
            
            
        }
    }
}
