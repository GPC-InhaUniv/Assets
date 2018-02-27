using System;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Collections.Generic;

namespace DogRace
{
    public partial class Form1 : Form
    {
        Greyhound[] greyhound = new Greyhound[4];
        Guy[] guy = new Guy[3];
        bool[] betCount = { false, false, false };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string path = "CashDataBase.txt";
                StreamReader streamReader = new StreamReader(path);

                int startingPosition = dogPictureBox1.Right - racePictureBox.Left;
                int racetrackLength = racePictureBox.Size.Width;
                int num = 0;

                greyhound[0] = new Greyhound(startingPosition, racetrackLength, dogPictureBox1);
                greyhound[1] = new Greyhound(startingPosition, racetrackLength, dogPictureBox2);
                greyhound[2] = new Greyhound(startingPosition, racetrackLength, dogPictureBox3);
                greyhound[3] = new Greyhound(startingPosition, racetrackLength, dogPictureBox4);

                List<string[]> list = new List<string[]>();

                string[] cols;

                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    cols = line.Split(',');

                    list.Add(cols);
                    num++;
                }

                streamReader.Close();

                guy[0] = new Guy(list[0][0], Int32.Parse(list[0][1]), radioButton1, bettorLabel1);
                guy[1] = new Guy(list[1][0], Int32.Parse(list[1][1]), radioButton2, bettorLabel2);
                guy[2] = new Guy(list[2][0], Int32.Parse(list[2][1]), radioButton3, bettorLabel3);

                foreach (Guy g in guy)
                {
                    g.UpdateLabels();
                }
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("No Text Data");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bettorNameLabel.Text = guy[0].name;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bettorNameLabel.Text = guy[1].name;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            bettorNameLabel.Text = guy[2].name;
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountNumericUpDown.Value);
            int dog = Convert.ToInt32(dogNumNumericUpDown.Value);

            if (bettorNameLabel.Text == guy[0].name)
            {
                if (guy[0].PlaceBet(amount, dog))
                {
                    guy[0].myLabel.Text = guy[0].myBet.GetDescription();
                    betCount[0] = true;
                }
            }
            else if(bettorNameLabel.Text == guy[1].name)
            {
                if (guy[1].PlaceBet(amount, dog))
                {
                    guy[1].myLabel.Text = guy[1].myBet.GetDescription();
                    betCount[1] = true;
                }
            }
            else if(bettorNameLabel.Text == guy[2].name)
            {
                if(guy[2].PlaceBet(amount, dog))
                {
                    guy[2].myLabel.Text = guy[2].myBet.GetDescription();
                    betCount[2] = true;
                }
            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            if (betCount[0] == true && betCount[1] == true && betCount[2] == true)
            {
                int winner = 0;
                bool raceFinish = true;
                raceButton.Enabled = false;
                int startingPosition = dogPictureBox1.Right - racePictureBox.Left;

                while (raceFinish)
                {
                    for (int i = 0; i < greyhound.Length; i++)
                    {
                        greyhound[i].Run();
                        if (greyhound[i].location >= greyhound[i].racetrackLength)
                        {
                            winner = i;
                            raceFinish = false;
                        }
                        Thread.Sleep(10);
                        DoubleBuffered = false;

                        racePictureBox.Update();
                    }
                }

                foreach (Greyhound g in greyhound)
                {
                    g.TakeStartingPostion();
                }

                foreach(Guy g in guy)
                {
                    g.Collect(winner);
                    g.UpdateLabels();
                }

                MessageBox.Show(string.Format("Race has been finished! Dog {0} is winner", winner), "Notice");

                for(int i = 0; i < betCount.Length; i++)
                {
                    betCount[i] = false;
                    guy[i].ClearBet();
                    guy[i].myLabel.Text = guy[i].myBet.GetDescription();
                }

                StreamWriter streamWriter = new StreamWriter("CashDataBase.txt", false);

                for(int i = 0; i < 3; i++)
                {
                    string data = guy[i].name + ", " + guy[i].cash;
                    streamWriter.WriteLine(data);
                }
                streamWriter.Close();

                raceButton.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("All guys have to bet! Try again", "Notice");
            }
        }

        private void rechargeButton_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                guy[0].cash += 500;
            }
            if (radioButton2.Checked)
            {
                guy[1].cash += 500;
            }
            if (radioButton3.Checked)
            {
                guy[2].cash += 500;
            }

            foreach (Guy g in guy)
            {
                g.UpdateLabels();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("CashDataBase.txt", false);

            for (int i = 0; i < 3; i++)
            {
                string data = guy[i].name + ", " + guy[i].cash;
                streamWriter.WriteLine(data);
            }
            streamWriter.Close();
        }
    }
}
