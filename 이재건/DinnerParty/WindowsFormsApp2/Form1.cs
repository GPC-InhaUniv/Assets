using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PartyForm : Form
    {
        DinnerParty dinnerParty;

        public PartyForm()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)NumofPeopleUpDown.Value, healthyBox.Checked, fancyBox.Checked);  //초기화 작업 사람수,healthybox check,데코레이션 체크 유무

            dinnerParty.SetHealthyOption(healthyBox.Checked);   //health의 check에 따라 beverage 값 변동
            dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);  //CostOfDecorations 값 변동
            //dinnerParty.SetPartyOptions(fancyBox.Checked);  //fancy의 check 에 따라 decoration 값 변동
            DisplayDinnerPartyCost();   //총괄적인 계산 및 출력.
        }

        private void PartyForm_Load(object sender, EventArgs e)
        {
          //do not use


        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthyBox.Checked);
            costTextbox.Text = Cost.ToString("c");
        }

        private void NumofPeopleUpDown_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)NumofPeopleUpDown.Value;
            dinnerParty.SetPartyOptions(fancyBox.Checked);

            // dinnerParty.numberOfPeople = (int)NumofPeopleUpDown.Value;
            DisplayDinnerPartyCost();
        }

        private void DecorationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void HealthyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
