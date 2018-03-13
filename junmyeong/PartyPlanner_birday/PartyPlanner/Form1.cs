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
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, healthyBox.Checked, fancyBox.Checked);   //초기설정
            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);
            DisplayDinnerPartyCost();
            DisplayBirthdayCost();
            
        }

        private void DisplayDinnerPartyCost()                    //Label 초기화
        {
            decimal Cost = dinnerParty.CalculateCost(healthyBox.Checked);
            costLabel.Text = "$" + Cost.ToString("f2");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)   //명수변경
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
            
        }

        private void DisplayBirthdayCost()                    //Label 초기화
        {
            CakeWriting();
            decimal Cost = birthdayParty.CalculateCost();
            birthdayCost.Text = "$" + Cost.ToString("f2") ;
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
       {
            DisplayBirthdayCost();
            
        }
        
        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(fancyBirthday.Checked);
            DisplayBirthdayCost();
        }

        private void CakeWriting()
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            cakeWriting.Text = birthdayParty.CakeWriting;
        }
    }
}
