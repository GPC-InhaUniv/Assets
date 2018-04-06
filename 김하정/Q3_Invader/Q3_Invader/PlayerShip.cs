using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Q3_Invader
{
    class PlayerShip
    {
        public Point Location { get; private set; }
        public Rectangle Area { get; private set; }
        public bool Alive;
        private const int MoveInterval = 10;



        public void Draw(Graphics g, int animationCell)
        {
            g.DrawImage(Properties.Resources.player, 0, 0, 50, 40);
        }

        public void Move(Direction direction)
        {
            if (direction == Direction.Left)
            {
                Point newLocation = new Point(Location.X - MoveInterval, Location.Y);
                Location = newLocation;
            }

            else if (direction == Direction.Right)
            {
                Point newLocation = new Point(Location.X + MoveInterval, Location.Y);
                Location = newLocation;
            }
            else Location = Location;
        }

    }
}
