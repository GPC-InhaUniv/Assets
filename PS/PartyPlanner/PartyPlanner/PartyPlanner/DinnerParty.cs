using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;
        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(isFancy);
            }
        }

        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;

        private bool isFancy;

        public DinnerParty(int numberOfPeople, bool isFancy, bool isHealthy)
        {
            NumberOfPeople = numberOfPeople;
            this.isFancy = isFancy;
            SetHealthyOption(isHealthy);
            //CalculateCostOfDecorations(isFancy);
        }
               
        public void SetHealthyOption(bool isHealthy)
        {
            if (isHealthy)
            {
                CostOfBeveragesPerPerson = 5.00M;
            } else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool isFancy)
        {
            if (isFancy)
            {
                CostOfDecorations = (numberOfPeople * 15.00M) + 50M;
            } else
            {
                CostOfDecorations = (numberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool isHealthy)
        {
            decimal totalCost = CostOfDecorations + ( ( CostOfBeveragesPerPerson + CostOfFoodPerPerson ) * NumberOfPeople );

            if (isHealthy)
            {
                return totalCost * .95M;
            } else
            {
                return totalCost;
            }
        }

        public void SetPartyOptions(int people, bool isFancy)
        {
            numberOfPeople = people;
            //CalculateCostOfDecorations(isFancy);
        }

        public int GetNumberOfPeople()
        {
            return numberOfPeople;
        }

    }
}
