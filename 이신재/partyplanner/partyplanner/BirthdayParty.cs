using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partyplanner
{
    class BirthdayParty
    {
        private int numberOfPeople;
        public decimal CostofDecrations;
        public int CakeSize;
        
        public const int CostofFoodPerPerson = 25;
        private bool fancyDecorations;
        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculatecostOfDecorations(fancyDecorations);
                CalculateCakeSize();
                this.CakeWriting = cakeWriting;
            }
        }
        

        public BirthdayParty(int numberOfPeople,
            bool fancyDecorations, string cakeWriting)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            CalculateCost();
            this.CakeWriting = cakeWriting;
            CalculatecostOfDecorations(fancyDecorations);
        }

        private void CalculateCakeSize()
        {
           
            if(NumberOfPeople<=4)
            {
                CakeSize = 8;
            }
            else
                CakeSize = 40;
        }

        private string cakeWriting = "";
        public string CakeWriting
        {
            get { return this.cakeWriting;  }
            set
            {
                int maxLength;
                if (CakeSize == 8)
                    maxLength = 16;
                else
                    maxLength = 40;

                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters for a " + CakeSize + "inch cake");
                }
                if (maxLength > this.cakeWriting.Length)
                {
                    maxLength = this.cakeWriting.Length;

                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }

                else
                    this.cakeWriting = value; 
            }
        }
        public void CalculatecostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
            {
                CostofDecrations = (NumberOfPeople * 15.00m) + 50m;
            }
            else
                CostofDecrations = (NumberOfPeople * 7.5m) + 30m;
        }

        public decimal CalculateCost()
        {
            decimal TotalCost = CostofDecrations + (CostofFoodPerPerson * NumberOfPeople);
            decimal CakeCost;
            if (CakeSize == 8)
                CakeCost = 40m + CakeWriting.Length * .25m;
            else
                CakeCost = 75m + CakeWriting.Length * .25m;

            return TotalCost + CakeCost;
        }

        
    }
}
