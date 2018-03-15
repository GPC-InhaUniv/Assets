using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();

            //초기화
            dinnerParty = new DinnerParty();
            dinnerParty.SetNonalcoholic(false);
            dinnerParty.DecorationCost(true);
            dinnerParty.SetPartyOption(5, Fancy.Checked);
            DisplayDinnerPartyCost();
        }

        //가격 계산
        void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(Nonalcoholic.Checked);
            LbText.Text = Cost.ToString("c");
        }

        //인원수에 맞춰 가격 최신화
        private void UDNumber_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetPartyOption((int)UDNumber.Value, Fancy.Checked);
            DisplayDinnerPartyCost();
        }

        //팬시 옵션 체크 여부에 따른 최신화
        private void Fancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.DecorationCost(Fancy.Checked);
            DisplayDinnerPartyCost();
        }

        //음료 설정 여부에 따른 최신화
        private void Nonalcoholic_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetNonalcoholic(Nonalcoholic.Checked);
            DisplayDinnerPartyCost();
        }
    }

    
}
