using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Party
    {
        private const int costOfFoodPerPerson = 25;
        private bool fancyDecorations;

        protected int numberOfPeople;
        protected decimal costOfDecorations = 0;

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.fancyDecorations = fancyDecorations;
            this.numberOfPeople = numberOfPeople;
        }

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

        public virtual void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
                costOfDecorations = (numberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (numberOfPeople * 7.50M) + 30M;
        }

        public virtual decimal CalculateCost()
        {
            decimal TotalCost = costOfDecorations + (costOfFoodPerPerson * numberOfPeople);
            if (numberOfPeople > 12)
                TotalCost += 100M;

            return TotalCost;
        }
    }
}
