using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0306_PartyPlanner_test
{
    class DinnerParty
    {
        decimal CostOfBeveragesPerPerson;//1인당 음료비를 저장
        decimal CostOfDecoration = 0;//장식비
        private int numberOfPeople;//파티 참가자수
        //public int NumberOfPeople;
        const int CostOfFoodPerPerson = 25;//음식값
        private bool fancyDecorations;

        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set { numberOfPeople = value; ; CalculateCostOfDecorations(fancyDecorations); }
        }


        public DinnerParty(int numberOfPeople ,bool HealthyOption, bool FancyDecorations )
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = FancyDecorations;
            SetHealthyOption(HealthyOption);
            CalculateCostOfDecorations(FancyDecorations);
        }



       /* 
        public void SetPartyOption(int people, bool FancyDecorations)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(FancyDecorations);
        }
        
        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }*/
        public void CalculateCostOfDecorations(bool FancyOption)//장식비를 계산
        {
            Console.WriteLine("장식비를 시작계산");
            fancyDecorations = FancyOption;
            if (FancyOption == true)
            {
                CostOfDecoration = (NumberOfPeople * 15.00M) + 50.00M;
                Console.WriteLine("장식비 체크시 계산");
            }
            else
            {
                CostOfDecoration = (NumberOfPeople * 7.50M) + 30.00M;
                Console.WriteLine("장식비 비채크시 계산");
            }
            Console.WriteLine("장식비를 끝계산");
        }
        public void SetHealthyOption(bool HealthyOption)//헬씨 옵션
        {
            if (HealthyOption == true)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else CostOfBeveragesPerPerson = 20.00M;
        }
        public decimal CalculateCost(bool HealthyOption)//총 비용 계산
        {
            decimal TotalCost = CostOfDecoration + ((CostOfBeveragesPerPerson+CostOfFoodPerPerson)*NumberOfPeople);

            if (HealthyOption == true)
            {
                return TotalCost = TotalCost * 0.95M;
            }
            else
            {
                return TotalCost;
            }
            
        }
    }
}
