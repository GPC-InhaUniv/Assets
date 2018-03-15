using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox;
        public int Location = 0; // ?
        public Random Randomizer;

        public bool Run()
        {
            Point p = MyPictureBox.Location;
            p.X += Randomizer.Next(1,4);
            MyPictureBox.Location = p;

            if (MyPictureBox.Location.X > RacetrackLength) return true;
            return false;
        }

        public void TakeStartingPosition()
        {
            Point p = MyPictureBox.Location;
            p.X = StartingPosition;
            MyPictureBox.Location = p;
        }


    }
}
