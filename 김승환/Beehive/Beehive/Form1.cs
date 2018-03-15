using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive
{
    public partial class Form1 : Form
    {
        Queen queen;

        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(1, new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(2, new string[] { "Egg care", "Baby bee tutoring"});
            workers[2] = new Worker(3, new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(4, new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });

            queen = new Queen(workers);
        }

        private void buttonAssignJob_Click(object sender, EventArgs e)
        {
            queen.AssignWork(comboBoxWokerBeeJob.Text, (int)numericUpDownShiifts.Value);
        }

        private void buttonNextShift_Click(object sender, EventArgs e)
        {
            textBoxReport.Text = queen.WorkNextShift();
        }

    }
}
