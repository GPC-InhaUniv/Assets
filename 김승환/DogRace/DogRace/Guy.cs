using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    public class Guy
    {
        public string name;
        public Bet myBet;
        public int cash;

        public RadioButton myRadioButton;
        public Label myLabel;

        public Guy(string name, int cash, RadioButton myRadioButton, Label myLabel)
        {
            this.name = name;
            this.cash = cash;
            this.myRadioButton = myRadioButton;
            this.myLabel = myLabel;
        }

        public void UpdateLabels()
        {
            myRadioButton.Text = string.Format("{0} has {1} bucks", name, cash);
        }

        public void ClearBet()
        {
            myBet.amount = 0;
        }
        
        public bool PlaceBet(int Amount, int Dog)
        {
            if(Amount <= cash && Amount > 0 )
            {
                myBet = new Bet(Amount, Dog, this);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int winner)
        {
            cash += myBet.PayOut(winner);
        }
    }

}
