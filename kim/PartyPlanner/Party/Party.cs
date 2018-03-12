using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Party
{
    class Party
    {
        protected int numberOfPeople;
        protected decimal costOfDecorations;
        protected bool fancyDecorations = true;

        public const int CostOfFoodPerPerson = 25;

        protected void CalculateCostOfDecorations()
        {
            if (fancyDecorations == true)
            {
                costOfDecorations = 50.0M + (numberOfPeople * 15.0M);
            }
            else
                costOfDecorations = 30.0M + (numberOfPeople * 7.5M);

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
                CalculateCostOfDecorations();
               
            }
        }

        public virtual decimal calculateCost() { return 0; }
        public bool FancyDecorations
        {
            get
            {
                return fancyDecorations;
            }
            set
            {
                fancyDecorations = value;
                CalculateCostOfDecorations();
            }
        }

    }
}
