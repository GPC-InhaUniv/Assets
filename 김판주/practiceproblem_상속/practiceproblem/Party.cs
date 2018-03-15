using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproblem
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;

        public decimal CostOfDecorations = 0;

        private bool fancyDecorations;

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
        }



        private int numberOfPeople;
        public virtual int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value; 
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        public void CalculateCostOfDecorations(bool fancy) // 파티 참가자 전체에 대한 장식비 계산
        {
            fancyDecorations = fancy;
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public virtual decimal CalculateCost()
        {
            decimal totalCost = CostOfDecorations + ( CostOfFoodPerPerson * NumberOfPeople);

            if (NumberOfPeople > 12)
            {
                return totalCost += 100M;
            }
            else
            {
                return totalCost;
            }

        }


    }
}
