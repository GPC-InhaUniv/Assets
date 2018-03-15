using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTallGuy_Click(object sender, EventArgs e)
        {
            Scaryscary fingersTheClown = new Scaryscary("big Shoes", 14);
            Funnyfunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as Scaryscary;
            someOtherScaryClown.ScareLittleChilren();
        }
    }
}
