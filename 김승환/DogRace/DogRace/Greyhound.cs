using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{
    public class Greyhound
    {
        public int startingPosition;
        public int racetrackLength;
        public PictureBox myPictureBox = null;
        public int location = 0;
        public Random randomizer;

        public Greyhound(int startingPosition, int racetrackLength, PictureBox myPictureBox)
        {
            this.startingPosition = startingPosition;
            this.racetrackLength = racetrackLength;
            this.myPictureBox = myPictureBox;
        }

        public bool Run()
        {
            randomizer = new Random();

            int distance = randomizer.Next(1, 50);

            Move(distance);

            location += distance;

            if (distance >= racetrackLength - startingPosition)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move(int distance)
        {
            Point p = myPictureBox.Location;
            p.X += distance;
            myPictureBox.Location = p;
        }

        public void TakeStartingPostion()
        {
            Move(-location);

            location = 0;
        }
    }
}
