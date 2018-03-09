using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0306_PartyPlanner_test
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            Console.WriteLine("Form1 s");
            InitializeComponent();
            dinnerParty = new DinnerParty((int)NumberOfPeopleUpDown.Value, HealthyCheckBox.Checked, FancyCheckBox.Checked);//NumberOfPeople 
            DisplayDinnerPartyCost();
            
        }
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(HealthyCheckBox.Checked);
            //costLabel.Text = Cost.ToString("c");//"c"
            //Console.WriteLine(Cost);
            costLabel.Text = Cost.ToString("c2");//"c"
        }

        private void NumberOfPeopleUpDown_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)NumberOfPeopleUpDown.Value;
            //dinnerParty.SetPartyOption((int)NumberOfPeopleUpDown.Value, FancyCheckBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void FancyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(FancyCheckBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void HealthyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(HealthyCheckBox.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
