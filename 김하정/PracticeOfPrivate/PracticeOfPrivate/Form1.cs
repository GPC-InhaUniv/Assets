using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeOfPrivate
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty; //흑흑 책 잘보기
                                 //자꾸 지역에 선언해놓고 전역변수로 부르지말기
                                 //문제생기면 좀 찾아보기
                                 //잠재적 수정 사항표시 좀 제대로 보기


       
        public Form1()
        {
           
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numericUpDown1.Value, checkBox2.Checked, checkBox1.Checked);
            
                DisplayDinnerPartyCost();

           

        }
        






        //총비용을 계산하여 자동으로 디스플레이 해준다.
        private void DisplayDinnerPartyCost() 
        {
            decimal Cost = dinnerParty.CalculateCost(checkBox2.Checked);
            costLabel.Text = Cost.ToString("c2" );
        }

        //참가자 수에 따른 파티 비용.
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }
        //데코레이션 추가. 그리고 그에따른 값변화를 보여줌.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecotations(checkBox1.Checked);
            DisplayDinnerPartyCost();
        }
        //헬스 옵션 추가. 그리고 그에따른 값변화를 보여줌
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthOption(checkBox2.Checked);
            DisplayDinnerPartyCost();
        }









        //실수로 만든 코드.

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
