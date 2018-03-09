using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulation
{
    class Bet
    {
        public int Amount;  //save betting money variable
        public int Dog;     //save betting Dog variable
       // public Guy Bettor;

        public Bet()
        {
            //initialize variables
            Amount = 0;
            Dog = 0;

        }
        public string GetDescription()
        {

            //do not use
            return "";
        }

        public int PayOut(int Winner)
        {
            //do not use
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
