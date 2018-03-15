using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeSystem2
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" },17);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" },114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "String patrol" },149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" },155);

            queen = new Queen(workers,275);
        }

        private void AssignBtn_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(WorkList.Text, (int)Shift.Value))
            {
                MessageBox.Show(WorkList.Text + " 를" + Shift.Value + " 시간만큼 벌에게 할당했습니다");
               
            }
            else
                MessageBox.Show(WorkList.Text + " 라는 일을 할 수 있는 벌이 없습니다 \r\n");
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            Report.Text = queen.WorkTheNextShift();
        }
    }
}
