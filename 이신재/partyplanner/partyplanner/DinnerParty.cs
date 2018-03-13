namespace partyplanner
{
    class DinnerParty
    {
        const int CostOfFoodPerPerson = 25; // 값이 변하지 않음

        public decimal CostOfBeveragesPerPerson = 20m;//1인당 음료비
        public decimal CostOfDecorations;//장식비

        private int numberOfPeople;//파티 참가자 수 - 배후필드
        private bool fancyDecorations; //fancy옵션 체크여부
       
        public int NumberOfPeople//numberOfPeople 프로퍼티
        {

            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }
        

        public DinnerParty(int NumberOfPeople, bool HealthyOption, bool FancyDecoration)//DinnerParty의 생성자
        {
            NumberOfPeople = numberOfPeople;
            this.fancyDecorations = FancyDecoration;
            
            SetHealtyOption(HealthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }
       

      
        
        public void SetHealtyOption(bool healtyoption) //헬시 옵션 주류옵션 선택시 비용
        {
            if(healtyoption)
            {
                CostOfBeveragesPerPerson = 5.00m;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00m;
            }
        }



        public void CalculateCostOfDecorations(bool checkfancy) //데코레이션 비용 계산
        {
            fancyDecorations = checkfancy;
            if(checkfancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50.00M; 
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            }
        }

       




        public decimal CalculateCost(bool HealthyOption) //총 비용 계산
        {
            decimal TotalCost = CostOfDecorations +
                ((CostOfBeveragesPerPerson + CostOfFoodPerPerson)*NumberOfPeople);
            if(HealthyOption == true)
            {
                TotalCost = TotalCost * 0.95M;
                return TotalCost;
            }

            return TotalCost;
        }

        
    }

    
}
