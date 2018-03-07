using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Bet
    {
        public int Amount;
        public int Dog; // num of dog
        public Guy Bettor; // who placed the bet


        public string GetDescription()
        {
            string info;
            if(Amount == 0) info = Bettor.Name + " hasn't placed a bet";
            else info = Bettor.Name + " bets " + Amount + " on dog #" + Dog;
                        
            return info;
        }

        public int PayOut(int Winner)
        {
            if (Winner == Dog) return Amount;
            else return -Amount;
        }
    }
}
