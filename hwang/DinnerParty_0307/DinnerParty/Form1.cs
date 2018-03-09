using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public partial class Form1 : Form
    {
        DinnerPartyPlanner dinnerPartyPlanner;

        BirthdayPartyPlanner birthdayPartyPlanner;

        public Form1()
        {
            InitializeComponent();
            dinnerPartyPlanner = new DinnerPartyPlanner(Convert.ToInt32(NumberOfPeople.Value), HealthyCheck.Checked, FancyCheck.Checked);
            DisplayCost();

            birthdayPartyPlanner = new BirthdayPartyPlanner(Convert.ToInt32(NumberOfPeople2.Value), FancyOption2.Checked, WritingOption.Checked);
            DisplayBirthdayCost();

        }

        private void NumberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerPartyPlanner.NumberOfPeople = Convert.ToInt32(NumberOfPeople.Value);
            dinnerPartyPlanner.SetFancyOption(FancyCheck.Checked);
            dinnerPartyPlanner.SetHealthyOption(HealthyCheck.Checked);

          

            DisplayCost();


        }

        private void FancyCheck_CheckedChanged(object sender, EventArgs e)
        {
            dinnerPartyPlanner.SetFancyOption(FancyCheck.Checked);
            DisplayCost();

        }

        private void HealthyCheck_CheckedChanged(object sender, EventArgs e)
        {
            dinnerPartyPlanner.SetHealthyOption(HealthyCheck.Checked);
            if (HealthyCheck.Checked== true)
            {
                CouponCheck.Checked = true;
            }
            else
            {
                CouponCheck.Checked = false;

            }
            DisplayCost();
        }


        private void CouponOption_CheckedChanged(object sender, EventArgs e)
        {
            DisplayCost();
        }

        private void DisplayCost()
        {
            decimal Cost = dinnerPartyPlanner.CalculateCost(CouponCheck.Checked);
            TotalCost.Text = Cost.ToString("c");
        }

        private void NumberOfPeople2_ValueChanged(object sender, EventArgs e)
        {
            birthdayPartyPlanner.NumberOfPeople = Convert.ToInt32(NumberOfPeople2.Value);
            birthdayPartyPlanner.CalculateCostOfDecoration(FancyOption2.Checked);
            birthdayPartyPlanner.CalculateCostOfWritingCost(WritingOption.Checked);
            DisplayBirthdayCost();

        }

        private void FancyOption2_CheckedChanged(object sender, EventArgs e)
        {
            birthdayPartyPlanner.CalculateCostOfDecoration(FancyOption2.Checked);
            DisplayBirthdayCost();

        }

        private void WritingOption_CheckedChanged(object sender, EventArgs e)
        {
            birthdayPartyPlanner.CalculateCostOfWritingCost(WritingOption.Checked);
            if (WritingOption.Checked)
            {
                WritingBox.Enabled = true;
            }
            else
            {
                WritingBox.Enabled = false;
            }
            DisplayBirthdayCost();

        }

        private void DisplayBirthdayCost()
        {
            decimal Cost = birthdayPartyPlanner.CalculateCost();
            TotalCost2.Text = Cost.ToString("c");
        }

        private void Ok_Click(object sender, EventArgs e)
        {
          MessageBox.Show(birthdayPartyPlanner.WriteCake(WritingBox.Text));
            WritingBox.Text = "";
        }
    }
}
