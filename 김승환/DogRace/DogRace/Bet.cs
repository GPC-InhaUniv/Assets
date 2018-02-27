using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{

    public class Bet
    {
        public int amount;
        public int dog;
        public Guy bettor;

        //베팅 생성자 초기화
        public Bet(int amount, int dog, Guy bettor)
        {
            this.amount = amount;
            this.dog = dog;
            this.bettor = bettor;
        }

        // 베팅 내역 출력
        public string GetDescription()
        {
            string description = "";

            if(this.amount > 0)
            {
                description = string.Format("{0} bets {1} bucks on dog #{2}", bettor.name, amount, dog);

                return description;
            }
            else
            {
                description = string.Format("{0} hasn't placed any bet", bettor.name);

                return description; 
            }
        }
        
        // 베팅 승패 여부에 대한 캐쉬 증감 차감 
        public int PayOut(int winner)
        {
            if(dog == winner)
            {
                return amount;
            }
            else
            {
                return -amount;
            }
        }
    }
}
