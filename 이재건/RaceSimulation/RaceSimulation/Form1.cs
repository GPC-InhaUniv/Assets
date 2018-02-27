using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceSimulation
{

    public partial class Form1 : Form
    {
        Greyhound[] greyhounds = new Greyhound[4];  //4 Greyhounds 
        Guy[] guys = new Guy[3];                     //3 Guys for betting
        Cheating cheat = new Cheating();                //this is cheating class!
        int collectmoney = 0;       //for jackpot variable
        bool bjackpot = false;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SetGreyHounds();            //set greyhound array
            SetGuys();                  //set 3 guys
            SetRadioButton();           //initialize radiobutton

        }


        private void RaceButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int winner = CalculateWinner();   //if click race button call calculatewinnder func
            sw.Stop();
            Timer.Text = "1등 강아지는 : " + winner + "  기록: " + sw.ElapsedMilliseconds.ToString() + "msec";

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //do not use
        }

        private void JoeButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = guys[0].Name;      //set Label name joe
        }

        private void BobButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = guys[1].Name;   //set Label name bob
        }

        private void JackButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = guys[2].Name;   //set Label name jack
        }

        private void BetButton_Click(object sender, EventArgs e)
        {
            SetButton();            //if click betting button call func
        }

        private void SetButton()
        {
            string checkname = NameLabel.Text;                  //for check who want bet
            string checkdog = Convert.ToString(DogUpDown.Value);    //for check dog number
            string checkCash = Convert.ToString(CashUpDown.Value);      //for check cash value
            int dognum = (int)DogUpDown.Value;          //dognumber
            int amount = (int)CashUpDown.Value;         //cash value

            if (checkname == "Joe")             //if select joe and click button run below codes
            {
                guys[0].PlaceBet(amount, dognum);
                JoeTextBox.Text = checkname + " Bets Dog Number " + checkdog + " $" + checkCash;

            }
            if (checkname == "Bob") //if select bob and click button run below codes
            {
                guys[1].PlaceBet(amount, dognum);
                BobTextBox.Text = checkname + " Bets Dog Number " + checkdog + " $" + checkCash;

            }
            if (checkname == "Jack")    //if select jack and click button run below codes
            {
                guys[2].PlaceBet(amount, dognum);
                JackTextBox.Text = checkname + " Bets Dog Number " + checkdog + " $" + checkCash;

            }

            //for cheat calcueage Which dog most chosed
            cheat.GetCount(Convert.ToInt32(checkdog));


        }


        private void SetGreyHounds()      //set dog image to greyhound array
        {
            for (int i = 0; i < 4; i++)
            {
                greyhounds[i] = new Greyhound();
            }
            greyhounds[0].MyPictureBox = dog1;
            greyhounds[1].MyPictureBox = dog2;
            greyhounds[2].MyPictureBox = dog3;
            greyhounds[3].MyPictureBox = dog4;

        }
        private void SetGuys()          //set guy's name
        {
            guys[0] = new Guy();
            guys[0].SetGuy("Joe");
            guys[1] = new Guy();
            guys[1].SetGuy("Bob");
            guys[2] = new Guy();
            guys[2].SetGuy("Jack");
        }
        private void SetRadioButton()       //set radio text
        {
            JoeButton.Text = guys[0].MyRadioButton.Text;
            BobButton.Text = guys[1].MyRadioButton.Text;
            JackButton.Text = guys[2].MyRadioButton.Text;
        }

        private int CalculateWinner()          //this tis main func
        {
            int winnernumber = 0;
            if (cheat.MaxSelect() != -1)               //for calculating cheat if anyone choose dog it doesn't run
                greyhounds[cheat.MaxSelect()].cheatDog = true;      //cheat.maxselect() func is return max chosed dugnumber(0,1,2,3) , it change greyhound's cheatdog value

            int i = 0;
            for (;;)      //run until anydog arrive goal line
            {
                if (greyhounds[i].Run())        //any dog arrive goal line , it return true
                {

                    string ending = i + 1 + " 번 강아지 1등!!!!";
                    winnernumber = i + 1;
                    if (MessageBox.Show(ending, "경주종료", MessageBoxButtons.OK) == DialogResult.OK)  //show message box which dog winner!
                    {
                        for (int k = 0; k < 4; k++)         //reset guys and greyhounds
                        {
                            if (k < 3)              //if k==4 that is indexofarragneError  because there are 3 guys in this program
                            {
                                if (bjackpot)
                                {
                                    guys[k].Collect(i + 1, bjackpot, collectmoney);

                                }
                                else
                                    collectmoney += guys[k].Collect(i + 1, bjackpot, -1);         //get money! if i+1 == guys[k].choosedognumber  else lose guys.money
                                guys[k].UpdateLabels();         //chagne current money
                            }

                            greyhounds[k].takeStartingPosition();       //reset greyhound 
                        }

                        SetRadioButton();

                        cheat.reset();      //reset cheat number

                    }
                    break;
                }
                else   //until any dog arrive goal line, Update Every frame that background and change greyhound through i++
                {
                    backgroundpicture.Update();
                    i++;
                }
                if (i == 4)     //for rotaing 0~3 greyhound
                    i = 0;
            }
            SetJackPotBox();

            return winnernumber;
        }


        private void CashUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            //do not use
        }

        private void CashUpDown_ValueChanged(object sender, EventArgs e)
        {
            //do not use
        }

     

        private void SetJackPotBox()                //jackpot manage function
        {
            if (bjackpot)
            {
                OffJackPot();
                bjackpot = false;
            }

            if (collectmoney >= JackPotBar.Maximum)
            {
                OnJackPot();
            }
            else
                bjackpot = false;

            CurrentCash.Text = "JackPot: $" + collectmoney;  //Print Current JackPot Money

            SetJackPot();   //reset jackpot
        }

        private void SetJackPot()   //collect cash that guy's cash loss
        {
            if (collectmoney >= JackPotBar.Maximum)
                JackPotBar.Value = JackPotBar.Maximum;   //for protecting jackpot value over maximum value
            else
            {
                if (JackPotBar.Value + collectmoney >= JackPotBar.Maximum)//에러방지
                    JackPotBar.Value = JackPotBar.Maximum;
                else
                    JackPotBar.Value += collectmoney;  //jackpot value plus collectmoney that lose guys betted the game 
            }
        }


        private void OffJackPot()
        {
            JackPotOnOff.Checked = false;
            JackPotOnOff.ForeColor = Color.Black;
            JackPotOnOff.Text = "JackPotoff";
            CurrentCash.ForeColor = Color.Black;
            JackPotBar.Value = 0;
            collectmoney = 0;
            
            //expect result : check :off fontcolor :black  current cashcolor:black,0 
        }
        private void OnJackPot()
        {
            JackPotOnOff.Checked = true;
            JackPotOnOff.ForeColor = Color.Red;
            JackPotOnOff.Text = "JackPotOn!!!!";
            CurrentCash.ForeColor = Color.Red;
            bjackpot = true;
        }


    }
}
