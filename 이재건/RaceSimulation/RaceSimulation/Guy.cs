using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RaceSimulation
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;


        public void SetGuy(string n)            //set and initialize  name, cash, radio..
        {
            Name = n;
            MyLabel = new Label();
            MyBet = new Bet();
            MyRadioButton = new RadioButton();
            Cash = 45;
            string temptext = Name + " has $" + Cash;
            MyRadioButton.Text = temptext;


        }

        public void UpdateLabels()
        {
            string temptext = Name + " has $" + Cash;
            MyRadioButton.Text = temptext;

        }
        public void ClearBet()
        {
            MyBet = new Bet();
            Cash = MyBet.Amount;


        }
        public bool PlaceBet(int Amount, int Dog)
        {
            if (Amount > Cash)      //if amount(Guy bet cash value) is bigger than Guy's cash
            {
                MessageBox.Show(Name + " has less money you must have more " + (Amount - Cash) + "!!!!");
                MyBet.Amount = 0;
                MyBet.Dog = 0;
                return false;

                //can't bet
            }

            else
            {

                MyBet.Amount = Amount;
                MyBet.Dog = Dog;
                return true;
            }
        }

        public int Collect(int Winner, bool jackpoton, int jackpotmoney)   //winner = dognumber 
        {
            if (MyBet.Dog == Winner)    //if dognumber that guy was chosed same winner dognum , Get money!
            {
                if (jackpoton)
                    Cash += MyBet.Amount * 2 + jackpotmoney;
                else
                    Cash += MyBet.Amount * 2;
                MyBet.Amount = 0;  //reset Betted Cah
                MyBet.Dog = 0;      //reset Chossed DogNum
                return 0;
            }
            else
            {
                Cash -= MyBet.Amount;   //Lose Money
                return MyBet.Amount;  //for collect jackpotmoney
            }
        }

    }
}
