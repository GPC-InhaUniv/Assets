using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner2._0
{
    abstract class Party
    {
        public const int CostOfFoodPerPeople = 25;

        private int numberOfPeople;
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set { numberOfPeople = value; }
        }
        private decimal costOfdeco;
        public decimal CostofDeco
        {
            get { return costOfdeco; }
            set { costOfdeco = value; }
        }
        public decimal TotalCost;

        public void CalculateCostDeco(bool deco)
        {
            if (deco)
            {
                CostofDeco = (numberOfPeople * 15M) + 50M;
            }
            else CostofDeco = (numberOfPeople * 7.5M) + 30M;
        }

        public abstract decimal CalculateCost();
        public abstract decimal CalculateCost(bool NonAlcoholable);
    }

}
