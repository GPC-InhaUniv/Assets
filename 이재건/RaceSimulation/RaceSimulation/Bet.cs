using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulation
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public Bet()
        {
            Amount = 0;

            Dog = 0;

        }
        public string GetDescription()
        {
            return "";
        }

        public int PayOut(int Winner)
        {
            if (Winner == Dog)
            {

            }
            else
            {

            }
            return 0;
        }

    }
}
