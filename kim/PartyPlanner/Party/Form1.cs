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

        DinnerParty dinnerparty;
        BirthdayParty birthdayparty;
       
        public Form1()
        {
            InitializeComponent();
            dinnerparty = new DinnerParty((int)Numbtn1.Value, HealtyCheck.Checked, FancyCheck1.Checked);
            birthdayparty = new BirthdayParty((int)Numbtn2.Value,FancyCheck2.Checked,CakeWritingBox.Text);

            DisplayCost();
        }

        private void Numbtn1_ValueChanged(object sender, EventArgs e)
        {
            dinnerparty.NumberOfPeople = (int)Numbtn1.Value;
            birthdayparty.NumberOfPeople = (int)Numbtn2.Value;
            DisplayCost();
        }

        private void FancyCheckBox_Checked(object sender, EventArgs e)
        {
            dinnerparty.FancyDecorations = FancyCheck1.Checked;
            birthdayparty.FancyDecorations = FancyCheck2.Checked;
            DisplayCost();
        }

        private void DisplayCost()
        {
            decimal birthdayPartyCost = birthdayparty.calculateCost();
            decimal dinnerpartyCost = dinnerparty.calculateCost();

            DinnerCost.Text = dinnerpartyCost.ToString("c");
            CostTextBox2.Text = birthdayPartyCost.ToString("c");
        }

        private void HealtyCheck_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.SetHealthyOption(HealtyCheck.Checked);
            DisplayCost();
        }

        private void CakeWritingBox_TextChanged(object sender, EventArgs e)
        {
            birthdayparty.CakeWriting = CakeWritingBox.Text;
            DisplayCost();
        }
    }
}
