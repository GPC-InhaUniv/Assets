using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numUD.Value, checkHealth.Checked, checkDeco.Checked);         
            dinnerParty.CalculateCostOfDecorations(checkDeco.Checked);
            //dinnerParty.SetHealthyOption(checkHealth.Checked);
            //numUD.Value = 5;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(checkHealth.Checked); // ???
            labelCost.Text = Cost.ToString("c");
        }

        private void numUD_ValueChanged(object sender, EventArgs e)
        {
            //dinnerParty.SetPartyOptions((int)numUD.Value, checkDeco.Checked);
            dinnerParty.NumberOfPeople = (int)numUD.Value;
            DisplayDinnerPartyCost();
        }
        
        private void checkDeco_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(checkDeco.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkHealth_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(checkHealth.Checked); 
            DisplayDinnerPartyCost();
        }
    }
}
