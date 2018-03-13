using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party
{
    class DinnerParty : Party
    {
        /// 수정
        public override int NumberOfPeople
        {
            get { return base.NumberOfPeople;  }
            set
            {
                base.NumberOfPeople = value;
                //CalculateCostOfDecorations(fancyDecorations);
            }
        }
  
        public decimal CostOfBeveragesPerPerson;

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
            : base(numberOfPeople, fancyDecorations)
        {
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }
        /// 수정 종료
        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            // 각 person의 토탈 금액 drinks and foods
            //decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + base.CostOfFoodPerPerson) * NumberOfPeople);
            decimal totalCost = base.CalculateCost() + CostOfBeveragesPerPerson * NumberOfPeople;
    
            if (healthyOption) totalCost *= 0.95M;
            if (NumberOfPeople > 12) totalCost += 100M;

            return totalCost;
        }

        public void SetPartyOptions(int people, bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }

        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }
    }
}
