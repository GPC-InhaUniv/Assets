using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party
{
    class BirthdayParty : Party
    {
        private int CakeSize;
        private string cakeWriting;
        public BirthdayParty(int numberOfPeople, bool fancyoption,string cakeWrite)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyoption;
            this.cakeWriting = cakeWrite;
            calculateCakeSize();
            CalculateCostOfDecorations();
        }

        public override int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations();
                calculateCakeSize();
            }
        }
        private void calculateCakeSize()
        {
            if (numberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }

        public string CakeWriting
        {
            get
            {
                return cakeWriting;
            }
            set
            {
                int MaxLength = 0;

                if (CakeSize == 8)
                {
                    MaxLength = 16;
                }
                else
                    MaxLength = 40;

                if (MaxLength < value.Length)
                {
                    MessageBox.Show(CakeSize + "크기의 케이크에는 더이상 글자를 쓸 수 없습니다.");
                    if (MaxLength > cakeWriting.Length)
                        MaxLength = cakeWriting.Length;
                    cakeWriting = value.Substring(0, MaxLength);
                }
                else
                    cakeWriting = value;
            }
        }

        public override decimal calculateCost()
        {
            decimal totalcost = costOfDecorations + (CostOfFoodPerPerson * numberOfPeople);
            decimal CakeCost;
            if (CakeSize == 8)
                CakeCost = 40M + cakeWriting.Length * 0.25M;
            else
                CakeCost = 75M + cakeWriting.Length * 0.25M;

            return totalcost + CakeCost;
        }

    }
}
