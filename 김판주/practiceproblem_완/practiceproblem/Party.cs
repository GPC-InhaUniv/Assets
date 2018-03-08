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

        private bool fancyDecorations; // 보호수준....

       

        public Party(int numberOfPeople, bool fancyDecorations) //초기화
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
        }


            public void CalculateCostOfDecorations(bool fancy) //생일파티 메소드
        {
            fancyDecorations = fancy;
            if (fancy)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        }


        private int numberOfPeople; //디너파티 메소드
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

        public virtual decimal CalculateCost() //12명 이상이면 100달러 더~
        {
            decimal totalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);

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
