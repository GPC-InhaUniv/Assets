using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceproblem
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numericUpDown1.Value, healthyBox.Checked, fancyBox.Checked); 
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, CakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayDinnerPartyCost() //파티비용을 다시 계산하고 cost레이블에 비용을 집어넣는 역할을 합니다.
        {
            decimal Cost = dinnerParty.CalculateCost(healthyBox.Checked);

            costLabel.Text = Cost.ToString("c");
        }
        private void DisplayBirthdayPartyCost() //자동으로 변경이 일어날 때마다 비용라벨이 갱신, 모든 이벤트 핸들에 들어감!!
        {
            decimal Cost = birthdayParty.CalculateCost();

            birthdatCost.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) //v
        {
            
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;

            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //팬시박스
        {
            dinnerParty.CalculateCostDecorations(fancyBox.Checked);

            DisplayDinnerPartyCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //헬씨체크
        {
            dinnerParty.SetHealthyOption(healthyBox.Checked);

            DisplayDinnerPartyCost();
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPepple = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(fancyBirthday.Checked);
            DisplayBirthdayPartyCost();
        }

        private void CakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWrithing = CakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
