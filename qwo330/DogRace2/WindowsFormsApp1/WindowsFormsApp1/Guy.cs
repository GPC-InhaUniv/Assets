using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash; // have money
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void updateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }

        public void ClearBet() // reset my bet so it;s zero
        {
            MyBet.Amount = 0;
        }

        public bool PlaceBet(int Amount, int Dog) 
        {
            if (Cash >= Amount)
            {
                MyBet = new Bet() { Amount = Amount, Dog = Dog, Bettor = this };
                return true;
            }
            return false;
        }

        public void Collect(int Winner) // my bet to pay out
        {
            Cash += MyBet.PayOut(Winner);
            updateLabels();
        }
    }
}
