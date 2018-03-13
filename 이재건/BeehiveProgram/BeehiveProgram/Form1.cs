using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeehiveProgram
{
    public partial class MainForm : Form
    {
        Queen queen;
        Worker[] workers;

        public MainForm()
        {
            InitializeComponent();

            workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenacne", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing","Egg care", "Baby bee tutoring",
                                                    "Hive maintenacne", "Sting patrol" }, 155);
            queen = new Queen(workers);
        }

        private void nextshiftbutton_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == true)
                MessageBox.Show("The job '" + workerBeeJob.Text + "'will be done in " + shifts.Value + " shifts", "The queen bee says..");
            else
            {
                MessageBox.Show("There is no Bee can Work " + workerBeeJob.Text);
            }
        }
    }
}
