using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner2._0
{
    class DinnerParty : Party
    {
        public decimal CostBeveragePerPerson;

        public DinnerParty(int numberOfPeople, bool decoUpgrade, bool nonAlcohol)
        {
            NumberOfPeople = numberOfPeople;
            CalculateCostDeco(decoUpgrade);
            SetAlcoholParty(nonAlcohol);
            TotalCost = CalculateCost(nonAlcohol);
        }

        public void SetAlcoholParty(bool NonAlcoholable)
        {
            if (NonAlcoholable)
            {
                CostBeveragePerPerson = 5M;
            }
            else CostBeveragePerPerson = 20M;
        }

        public override decimal CalculateCost(bool NonAlcoholable)
        {
            decimal TotalCost = CostofDeco + ((CostBeveragePerPerson + CostOfFoodPerPeople) * NumberOfPeople);

            if (NonAlcoholable)
            {
                return TotalCost = TotalCost * 0.95M;
            }
            else return TotalCost;
        }

        public override decimal CalculateCost()
        {
            return 0M;
        }
    }
}
