using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PracticeOfPrivate
{
    public class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;
        public int NumberOfPeople   //속성
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecotations(fancyDecorations);
            }
        }

        private bool fancyDecorations;

        public Decimal CostOfBeveragesPerPerson;
        public Decimal CostOfDecorations = 0;
        
       


       

        //객체를 만들때의 생성자
        public DinnerParty(int numberOfPeople, bool healthOPtion, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            CalculateCostOfDecotations(fancyDecorations);
            SetHealthOption(healthOPtion);
        }



        public void SetHealthOption(bool healthOPtion)
        {
            if (healthOPtion)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecotations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            }
        }

        public decimal CalculateCost(bool healthOPtion)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);

            if (healthOPtion)
            {
                return totalCost * 0.95M;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
