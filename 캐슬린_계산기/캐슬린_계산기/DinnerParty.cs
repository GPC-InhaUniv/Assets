using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 캐슬린_계산기
{
    class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;
        private int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;

        // private로 지정된 NumberOfPeople(파티참여인원)을 numericUDPeople.Value로부터 받아서 클래스 내부에서 값을 지정해준다.
        public void SetPartyOptions(int people, bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecoration(fancy);
        }

        // 파티참여인원의 수를 반환해준다.
        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }

        // 유기농 음식 체크란이 트루이면 5달러로 계산, 펄스이면 20달러로 계산
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

        // 화려한 장식에 대한 추가비용 발생 함수
        public void CalculateCostOfDecoration(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        // 술을 마시지 않으면 5퍼센트 할인된 가격을 받는다.
        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);

            if (healthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
