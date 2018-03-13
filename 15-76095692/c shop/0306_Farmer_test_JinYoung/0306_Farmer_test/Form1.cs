using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0306_Farmer_test
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer(15,30);
        }

        private void CowUpDown_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)CowUpDown.Value;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("i need {0} bags of feed for {1} cows", farmer.BagsOfFeed, farmer.NumberOfCows);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            farmer.feedMultiplier = 5;
        }
    }
}
