using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;                    //기본 인당 음식비(상수설정)
        bool fancyDecorations;                                 //팬시 옵션 체크 여부
        private int numberOfPeople;                            //파티 참가자 수(배후필드)
        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations); //명수가 바뀔시 장식비 변경
            }
        }
        public decimal CostOfBeveragesPerPerson;              //1인당 음료 비
        public decimal CostOfDecorations;                     //장식비

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations) 
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

        public void SetHealthyOption(bool check)                //헬씨옵션 
        {
            if (check == false)
                CostOfBeveragesPerPerson = 20M;
            else
                CostOfBeveragesPerPerson = 5M;
        }

        public void CalculateCostOfDecorations(bool check)     //팬시옵션
        {
            fancyDecorations = check;
            if (check == false)
                CostOfDecorations = 30M + (NumberOfPeople * 7.5M);
            else
                CostOfDecorations = 50M + (NumberOfPeople * 15M);
        }

        public decimal CalculateCost(bool check)               //총비용
        {
            decimal total;
           if (check == false)
                total = (CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople + CostOfDecorations;
           else
                total = ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople + CostOfDecorations) *0.95M;

            return total;
        }
    }
}
