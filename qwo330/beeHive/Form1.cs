﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beeHive
{
    public partial class Form1 : Form
    {
        Queen queen;

        public Form1()
        {
            InitializeComponent();
            workerBeeJob.Items.Add("Nectar collector");
            workerBeeJob.Items.Add("Honey manufacturing");
            workerBeeJob.Items.Add("Egg care");
            workerBeeJob.Items.Add("Baby bee tutoring");
            workerBeeJob.Items.Add("Hive maintenance");
            workerBeeJob.Items.Add("Sting patrol");

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care",
                "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155);

            queen = new Queen(workers);
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("No workers are available to do the job '" + workerBeeJob.Text + "'", "The queen bee says...");
            else MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in " + shifts.Value + " shifts", "The queen bee says...");
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
