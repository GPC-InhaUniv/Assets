using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner
{
    public partial class Form1 : Form
    {

        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numericNumOfPeople.Value, cbHealthyOpt.Checked, cbFancyDeco.Checked);

            dinnerParty.SetHealthyOption(cbHealthyOpt.Checked);
            dinnerParty.CalculateCostOfDecorations(cbHealthyOpt.Checked);

            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(cbHealthyOpt.Checked);

            lblDisplayCalculatedCost.Text = Cost.ToString();        // "c" 통화값으로 서식 지정
        }

        private void numericNumOfPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int) numericNumOfPeople.Value;

            dinnerParty.CalculateCostOfDecorations(cbFancyDeco.Checked);

            DisplayDinnerPartyCost();
        }

        private void cbFancyDeco_CheckedChanged(object sender, EventArgs e)
        {            
            dinnerParty.CalculateCostOfDecorations(cbFancyDeco.Checked);

            DisplayDinnerPartyCost();
        }

        private void cbHealthyOpt_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(cbHealthyOpt.Checked);

            DisplayDinnerPartyCost();
        }
    }
}
