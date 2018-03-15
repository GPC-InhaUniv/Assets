using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    class DinnerPartyPlanner
    {
        public const int foodPeople = 25;

        private int numberOfPeople;
        public decimal CostOfBeveragePerson;
        public decimal CostOfDecoration ;

        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                //사람 수가 바뀔때 즉시 계산//
                SetFancyOption(fancyOption);
                SetHealthyOption(healthyOption);
            }
        }

        private bool fancyOption;
        private bool healthyOption;


        //생성자  소문자가 겹쳐서 this사용//
        public DinnerPartyPlanner(int numberOfPeople,bool healthyOption,bool fancyOption)
        {
            //프로그램 시작시 바로 가격 출력//
            NumberOfPeople = numberOfPeople;
            this.fancyOption = fancyOption;
            this.healthyOption = healthyOption;
   
            SetHealthyOption(healthyOption);
            SetFancyOption(fancyOption);

        }


        public void SetHealthyOption(bool HealthyOption)
        {
            if (HealthyOption)
            {
                CostOfBeveragePerson = 5m * numberOfPeople;

            }
            else
            {
                CostOfBeveragePerson = 20m * numberOfPeople;
            }
           
        }

        public void SetFancyOption(bool fancy)
        {
            if (fancy)
            {
                CostOfDecoration = (numberOfPeople * 20m)+ 50m ;
            }
            else
            {
                CostOfDecoration = (numberOfPeople * 10m)+10m ;
            }
        }

 
        public void SetPartyOption(int people , bool fancy)
        {
            NumberOfPeople = people;
            SetFancyOption(fancy);
        }

       

        public decimal CalculateCost(bool discountCoupon)
        {
            decimal TotalCost = (foodPeople * NumberOfPeople) + CostOfBeveragePerson + CostOfDecoration;

            if (discountCoupon)
            {
                return TotalCost * 0.95m;
            }
            else
            {
                return TotalCost;
            }
        }
    }
}
