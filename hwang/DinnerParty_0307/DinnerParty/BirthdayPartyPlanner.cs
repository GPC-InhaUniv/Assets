using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    class BirthdayPartyPlanner
    {
        public const int BirthdayPartyFee = 25;

        private int numberOfPeople;
        private decimal costOfDecoration;
        private decimal costOfWriting;

        private bool birthdayFancy;
        private bool cakeWritingOption;
    
        private int cakeSize;
        //private string cakeWriting;


        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecoration(birthdayFancy);
                CalculateCostOfWritingCost(cakeWritingOption);

            }
        }


        public BirthdayPartyPlanner(int numberOfPeople ,bool birthdayFancy,bool cakeWritingOption)
        {
            NumberOfPeople = numberOfPeople;
            this.birthdayFancy = birthdayFancy;
            this.cakeWritingOption = cakeWritingOption;
            CalculateCostOfDecoration(birthdayFancy);
            CalculateCostOfWritingCost(cakeWritingOption);

        }


        public void CalculateCostOfDecoration(bool birthdayFancy)
        {
            if (birthdayFancy)
            {
                costOfDecoration = numberOfPeople * 15m + 50m;
            }
            else
            {
                costOfDecoration = numberOfPeople * 7.5m + 30m;
            }
            CalucilateCakeSize();
            if (cakeSize == 8)
            {
                costOfDecoration += 40;
            }
            else if(cakeSize==16)
            {
                costOfDecoration += 75;
            }
        }

        public void CalculateCostOfWritingCost(bool cakeWritingOption)
        {
            if (cakeWritingOption)
            {
                costOfWriting = 25m;
            }
            else
            {
                costOfWriting = 0m;
            }
        }

        public void CalucilateCakeSize()
        {
            if (numberOfPeople <= 4)
            {
                cakeSize = 8;
            }
            else
            {
                cakeSize = 16;
            }
        }

        public string WriteCake(string cakeWriting)
        {
            if(cakeSize == 8)
            {
                if (cakeWriting.Length < 17)
                {
                    return "Your message : "+cakeWriting;
                }
                else
                {
                    return "Your message is too long to write in this area";
                }
            }
            if(cakeSize == 16)
            {
                if (cakeWriting.Length < 40)
                {
                    return "Your message : " + cakeWriting;
                }
                else
                {
                    return "Your message is too long to write in this area";
                }
            }

            return "";
        }

        public decimal CalculateCost()
        {
            decimal BirthdayPartyCost = (BirthdayPartyFee * numberOfPeople) + costOfDecoration + costOfWriting;

            return BirthdayPartyCost;
        }
    }
}
