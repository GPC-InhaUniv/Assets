using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class DinnerParty
    {
        public decimal CostBeveragePerPerson;
        public decimal CostDecoration;
        int numberOfPeople;

        public const int CostOfFoodPerPeople = 25;


        //인원 수 갱신 후 데코 비용 계산 
        public void SetPartyOption(int people, bool fancy)
        {
            numberOfPeople = people;
            DecorationCost(fancy);
        }

        //파티 인원수를 알아 낼 때
        public int GetNumberOfPeople()
        {
            return numberOfPeople;
        }

        //음료 설정에 따른 가격 설정
        public void SetNonalcoholic(bool nonalcoholic)
        {
            if (nonalcoholic)
            {
                CostBeveragePerPerson = 5M;
            }
            else CostBeveragePerPerson = 20M;
        }

        //데코 설정에 다른 가격 설정
        public void DecorationCost(bool decoration)
        {
            if (decoration)
            {
                CostDecoration = (numberOfPeople * 15M) + 50M;
            }
            else CostDecoration = (numberOfPeople * 7.5M) + 30M;
        }

        //총 비용 계산
        public decimal CalculateCost(bool nonalcoholic)
        {
            decimal TotalCost = CostDecoration + ((CostBeveragePerPerson + CostOfFoodPerPeople) * numberOfPeople);

            if (nonalcoholic)
            {
                return TotalCost = TotalCost * 0.95M;
            }
            else return TotalCost;
        }

        
    }
}
