using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    class BirthdayParty : Party
    {
        private int cakesize;
        private string cakeWriting = "";
        public const int CostOfFoodPerPerson = 25;
        private bool fancyDecorations;

        public decimal CostOfDecorations
        {
            get
            {
                return costOfDecorations;
            }
            set
            {
                CalculateCostOfDecorations(fancyDecorations);
            }
        }
     
 
        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
                CalculateCakeSize();
                this.CakeWriting = cakeWriting;
            }
        }
        private void CalculateCakeSize()
        {
            if (numberOfPeople <= 4)
                cakesize = 8;
            else cakesize = 16;
        }


        public string CakeWriting
        {
            get
            {
                return this.cakeWriting;
            }
            set
            {
                int maxLength;
                if (cakesize == 8)
                    maxLength = 16;
                else
                    maxLength = 40;

                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters for a " + cakesize + " inch cake");
                    if (maxLength > this.cakeWriting.Length)
                        maxLength = this.cakeWriting.Length;
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else
                    this.cakeWriting = value;

            }
        }


        public BirthdayParty(int numberOfPeople, bool fancyDecorations) : base(numberOfPeople, fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        } 

   
        public override decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);
            decimal CakeCost;
            if (cakesize == 8)
                CakeCost = 40M + cakeWriting.Length * .25M;
             else
                CakeCost = 75M + cakeWriting.Length * .25M;

            return TotalCost + CakeCost;
        }
    
     


    }
}

