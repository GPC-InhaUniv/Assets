using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class DinnerParty
    {
        const int CostOfFoodperPerson = 25;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;
        private bool fancyDecoration = false;
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
                CalculateCostOfDecorations(fancyDecoration);
            }
        }




        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancy)
        {
            NumberOfPeople = numberOfPeople;
            fancyDecoration = fancy;
            SetHealthyOption(healthyOption);

        }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
                CostOfBeveragesPerPerson = 5.00M;
            else
                CostOfBeveragesPerPerson = 20.00M;
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecoration = fancy;
            if (fancyDecoration)
                CostOfDecorations = (numberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (numberOfPeople * 7.50M) + 30M;
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodperPerson) * numberOfPeople); //public으로 할시 costofdecorations 값이 변경된
                                                                                                                         //numberofpeople 값을 받지 못하여 costofdecoration 값이 업데이트 되지 않았다.

            if (healthyOption)
                return totalCost * .95M;
            else
                return totalCost;
        }

        public void SetPartyOptions(bool fancy)
        {
            fancyDecoration = fancy;
            CalculateCostOfDecorations(fancy);
        }

        //public int GetNumberOfPeople()
        //{
        //    return numberOfPeople;
        //}



    }
}
