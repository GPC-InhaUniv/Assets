using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 캐슬린_계산기
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerparty;

        public Form1()
        {
            InitializeComponent();
            dinnerparty = new DinnerParty();
            dinnerparty.CalculateCostOfDecoration(chbFancy.Checked);
            dinnerparty.SetHealthyOption(chbHealth.Checked);
            DisplayDinnerPartyCost();
        }

        private void numericUDPeople_ValueChanged(object sender, EventArgs e)
        {
            numericUDPeople.Maximum = 20;
            numericUDPeople.Minimum = 5;
            dinnerparty.SetPartyOptions((int)numericUDPeople.Value, chbFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void chbHealth_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.SetHealthyOption(chbHealth.Checked);                            
            DisplayDinnerPartyCost();
        }

        private void chbFancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.CalculateCostOfDecoration(chbFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerparty.CalculateCost(chbHealth.Checked);
            lbCost2.Text = Cost.ToString("C");
        }
    }
}
