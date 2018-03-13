using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party
{
    class DinnerParty : Party
    {
        private decimal costOfBeveragesPerPerson;
        private bool healthyoption = false;


       

        public DinnerParty(int numberOfPeople, bool healthyoption, bool fancyoption)
        {
            this.numberOfPeople = numberOfPeople;
            this.healthyoption = healthyoption;
            this.fancyDecorations = fancyoption;
            SetHealthyOption(healthyoption);
            CalculateCostOfDecorations();

        }
        

        public void SetHealthyOption(bool option) {
            
                healthyoption = option;
            
                
                if (healthyoption == true)
                    costOfBeveragesPerPerson = 5.0M;
                else
                    costOfBeveragesPerPerson = 20.0M;
            

        }

        public override decimal calculateCost()
        {
            decimal total = costOfDecorations + ((CostOfFoodPerPerson + costOfBeveragesPerPerson) * numberOfPeople);
            if (healthyoption == true)
            {
                return total * 0.95M;
            }
            else
                return total;
        }
    }
}
