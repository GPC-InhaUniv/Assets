using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Invader_Hwangyunu
{
    class Shot
    {
        private const int moveInterval = 20;
        private const int width = 5;
        private const int height = 15;

        public Point Location { get; private set; }

        private Direction direction;
        private Rectangle boundaries;
        private Game game;

        public Shot(Point location , Direction direction,Rectangle boundaries , Game game)
        {
            this.Location = location;
            this.direction = direction;
            this.boundaries = boundaries;
            this.game = game;
        }

        public void Draw(Graphics g)
        {
          //  using (Brushes pen = new Brushes(Color.Yellow))
            //    g.FillRectangle(pen,game.playerShip.PlayerLocation ,new Rectangle(0, 0, 5, 10));


        }
        public bool Move()
        {
            Point shotLocation = Location;
            switch (direction)
            {
                case Direction.Up:
                    //if (shotLocation.Y - moveInterval <= boundaries.Right )
                        shotLocation.Y -= moveInterval;
                    break;
                case Direction.Down:
                    //if (shotLocation.Y + moveInterval >= boundaries.Left)
                        shotLocation.Y += moveInterval;
                    break;
                default: break;
            }

            Location = shotLocation;
            if (Location.Y < boundaries.Top || Location.Y >boundaries.Bottom)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
