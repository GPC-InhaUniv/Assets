using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_Planner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerparty;

        public Form1()
        {
            InitializeComponent();
            dinnerparty = new DinnerParty((int)numericNumberOfPeople.Value, CheckBoxHealthyOption.Checked, CheckBoxFancy.Checked);
            DisplayDinnerPartyCost();
        }
        
        private void CheckBoxFancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.CalculateCostOfDecorations(CheckBoxFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void CheckBoxHealthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.SetHealthyOption(CheckBoxHealthyOption.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerparty.CalculateCost(CheckBoxHealthyOption.Checked);
            CostShowLabel.Text = Cost.ToString("c");
        }

        private void NumericNumberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerparty.NumberOfPeople = (int)numericNumberOfPeople.Value;
            DisplayDinnerPartyCost();
        }

    }
}
