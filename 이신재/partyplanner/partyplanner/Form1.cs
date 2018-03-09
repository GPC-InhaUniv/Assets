using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partyplanner
{
    public partial class dinnerparty : Form
    {
        DinnerParty mydinnerparty;
        BirthdayParty mybirthdayParty;
        public dinnerparty()
        {
            InitializeComponent();
            mydinnerparty = new DinnerParty((int)numericUpDown1.Value, 
                                                 checkhelthy.Checked,
                                                 checkfancy.Checked);
            
            DisplayDinnerPartyCost();

            mybirthdayParty = new BirthdayParty((int)numericPeople.Value,
                                                checkbfancy.Checked,
                                                textcakedeco.Text);
            DisplayBirthdayPartyCost();
            
        }
        private void DisplayBirthdayPartyCost()
        {
            textcakedeco.Text = mybirthdayParty.CakeWriting;
            decimal Cost = mybirthdayParty.CalculateCost();
            labeltotalcost.Text = Cost.ToString("c");
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = mydinnerparty.CalculateCost(checkhelthy.Checked);
            txtcost.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            mydinnerparty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void checkfancy_CheckedChanged(object sender, EventArgs e)
        {
            mydinnerparty.CalculateCostOfDecorations(checkfancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkhelthy_CheckedChanged(object sender, EventArgs e)
        {
            mydinnerparty.SetHealtyOption(checkhelthy.Checked);
            DisplayDinnerPartyCost();
        }
        

        private void txtcost_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcost_Click(object sender, EventArgs e)
        {

        }

        private void numericPeople_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtcost_TextCanged(object sender, EventArgs e)
        {
        
        }

        private void textcakedeco_TextChanged(object sender, EventArgs e)
        {
            mybirthdayParty.CakeWriting = textcakedeco.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
