using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner2._0
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)UDPeople.Value, cbDecoUpgrade.Checked, cbNonAlcohol.Checked);
            DinnerChangeCost();

            birthdayParty = new BirthdayParty((int)UDPeopleBirth.Value, cbDecoUpgradeBirth.Checked, tbBirthdayText.Text);
            BirthdayChangeCost();
        }

        //DinnerParty start ==================================================
        private void UDPeople_ValueChanged(object sender, EventArgs e)
        {
            DinnerChangeCost();
        }

        private void cbNonAlcohol_CheckedChanged(object sender, EventArgs e)
        {
            DinnerChangeCost();
        }

        private void cbDecoUpgrade_CheckedChanged(object sender, EventArgs e)
        {
            DinnerChangeCost();
        }

        private void DinnerChangeCost()
        {
            dinnerParty.NumberOfPeople = (int)UDPeople.Value;
            dinnerParty.CalculateCostDeco(cbDecoUpgrade.Checked);
            dinnerParty.SetAlcoholParty(cbNonAlcohol.Checked);
            lbCost.Text = "$ " + dinnerParty.CalculateCost(cbNonAlcohol.Checked).ToString("f2");
        }
        //DinnerParty end ==================================================

        //BirthdayParty start ==================================================
        private void UDPeopleBirth_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = ("축하 메세지 (" + tbBirthdayText.Text.Length.ToString() + " / " + birthdayParty.MaxLangth.ToString() + ")");
            BirthdayChangeCost();
        }

        private void cbDecoUpgradeBirth_CheckedChanged(object sender, EventArgs e)
        {
            BirthdayChangeCost();
        }

        private void tbBirthdayText_TextChanged(object sender, EventArgs e)
        {
            label4.Text = ("축하 메세지 (" + tbBirthdayText.Text.Length.ToString() + " / " + birthdayParty.MaxLangth.ToString() + ")");
            BirthdayChangeCost();   
        }

        private void BirthdayChangeCost()
        {
            birthdayParty.NumberOfPeople = (int)UDPeopleBirth.Value;
            birthdayParty.CalculateCostDeco(cbDecoUpgradeBirth.Checked);
            birthdayParty.CalculateCakeSize();
            birthdayParty.CakeWriting = tbBirthdayText.Text;
            lbCostBirth.Text = "$ " + birthdayParty.CalculateCost().ToString("f2");
            tbBirthdayText.Text = birthdayParty.CakeWriting;
        }
        //BirthdayParty end ==================================================
    }
}
