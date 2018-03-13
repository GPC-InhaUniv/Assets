using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public decimal CostOfDecorations;                     //장식비
        private bool fancyDecorations;                                 //팬시 옵션 체크 여부

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
                CalculateCostOfDecorations(fancyDecorations); //명수가 바뀔시 장식비 변경
            }
        }

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            CalculateCostOfDecorations(fancyDecorations);
        }


        public void CalculateCostOfDecorations(bool check)     //팬시옵션
        {
            fancyDecorations = check;
            if (check == false)
                CostOfDecorations = 30M + (NumberOfPeople * 7.5M);
            else
                CostOfDecorations = 50M + (NumberOfPeople * 15M);
        }

        public virtual decimal CalculateCost()
        {
            decimal total = CostOfDecorations + (CostOfFoodPerPerson * numberOfPeople); 
            if (numberOfPeople > 12)
                total += 100M;

            return total;
        }
    }
}
