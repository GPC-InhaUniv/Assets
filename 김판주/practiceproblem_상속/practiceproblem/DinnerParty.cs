using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproblem
{
    
    class DinnerParty : Party 
    {

        public decimal CostOfBeveragesPerPerson; // 1인당 음료저장


        public DinnerParty(int numberOfPeople, bool HealthyOption, bool fancyDecorations)
            :base (numberOfPeople, fancyDecorations)
        {
            SetHealthyOption(HealthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }


 
        public void SetHealthyOption(bool healthyOption)  // 헬씨 옵션을 적용하는가?
        {
            
            if (healthyOption) //헬씨옵션 체크박스가 트루면
            {
                CostOfBeveragesPerPerson = 5.00M; //알콜음료가 필요없는 이들은 5
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M; //알콤음료가 필요한 이들은 20
            }

        }

        public decimal CalculateCost(bool healthyOption)// 총비용, 장식비와 1인당 식비 및 음료비를 바탕으로 총비용을 구해서 반환 !헬씨옵션을 선택했다면 할인율을 적용해서 반환
        {
            decimal totalCost = base.CalculateCost() + (CostOfBeveragesPerPerson * NumberOfPeople); //베이스클래에서는 개인의 음식마다 계산을
            //이곳에선 그값 ( 베이스클래에서의 가겨계산함수에다가 사람수와 개인당 음료금액을 곱한 값을 줍니다.

            if (healthyOption)
            {
                return totalCost * 0.95M; //술을 먹지 않으면 5%할인율 적용
            }
            else
            {
                return totalCost;
            }

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
