using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class DinnerParty : Party
    {
        public decimal CostOfBeveragesPerPerson;              //1인당 음료 비

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations) : base (numberOfPeople, fancyDecorations)
        {
            SetHealthyOption(healthyOption);
        }

        public void SetHealthyOption(bool check)                //헬씨옵션 
        {
            if (check == false)
                CostOfBeveragesPerPerson = 20M;
            else
                CostOfBeveragesPerPerson = 5M;
        }

        public decimal CalculateCost(bool check)               //총비용
        {
            decimal total = base.CalculateCost();
            if (check == false)
                total += CostOfBeveragesPerPerson  * NumberOfPeople ;
           else
                total += (CostOfBeveragesPerPerson * NumberOfPeople) *0.95M;

            return total;
        }
    }
}
