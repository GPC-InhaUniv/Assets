using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        GreyHound[] C_greyhounds = new GreyHound[4];
        Players[] C_Players = new Players[3];


        public Form1()
        {
            InitializeComponent();

            for(int iArrayCount = 0; iArrayCount < 4; iArrayCount++)
            {
                C_greyhounds[iArrayCount] = new GreyHound();
            }

            for (int iArrayCount = 0; iArrayCount < 3; iArrayCount++)
            {
                C_Players[iArrayCount] = new Players();
            }

            C_Players[0].PlaceBet(7, 3);
            C_Players[1].PlaceBet(43, 2);
            C_Players[2].PlaceBet(64, 1);



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Joe_Button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Betting_GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Race_Button_Click(object sender, EventArgs e)
        {

        }

        private void Joe_BetState_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
