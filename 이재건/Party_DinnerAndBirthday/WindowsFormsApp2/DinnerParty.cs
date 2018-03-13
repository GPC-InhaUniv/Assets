using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class DinnerParty:Party
    {
       
        public decimal CostOfBeveragesPerPerson;



        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancy):base(numberOfPeople,fancy)
        {
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancy);
        }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
                CostOfBeveragesPerPerson = 5.00M;
            else
                CostOfBeveragesPerPerson = 20.00M;
        }

        
        public  decimal CalculateCost(bool healthyOption)
        {
            //decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodperPerson) * numberOfPeople); //public으로 할시 costofdecorations 값이 변경된
            //numberofpeople 값을 받지 못하여 costofdecoration 값이 업데이트 되지 않았다.

            decimal totalCost = base.CalculateCost()+ (CostOfBeveragesPerPerson * NumberOfPeople);
            if (healthyOption)
                return totalCost * .95M;
            else
                return totalCost;
        }

        public void SetPartyOptions(bool fancy)
        {
            CalculateCostOfDecorations(fancy);
        }

        //public int GetNumberOfPeople()
        //{
        //    return numberOfPeople;
        //}



    }
}
