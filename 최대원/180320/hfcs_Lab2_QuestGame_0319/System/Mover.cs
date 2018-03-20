using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hfcs_Lab2_QuestGame
{
    enum Direction
    {
        Up,
        Down,
        Left,
        Right,
    }

    abstract class Mover
    {
        protected PictureBox imageLocation;
        protected Point Location
        {
            get { return imageLocation.Location; }
            set { imageLocation.Location = value; }
        }
        protected Game game;
        protected int moveInterval;

        public Mover(Game game)
        {
            this.game = game;
        }

        public Mover(Game game, PictureBox imageLocation)
        {
            this.game = game;
            this.imageLocation = imageLocation;
        }

        public bool NearBy(Point enemyPos, int distance)
        {
            if (Math.Abs(Location.X - enemyPos.X) < distance && Math.Abs(Location.Y - enemyPos.Y) < distance)
            {
                return true;
            }
            else return false;
        }

        public Point Move(Direction direction, int distance)
        {
            Point MovePos = Location;
            switch(direction) {
                case Direction.Up:
                    if (MovePos.Y - distance > game.Boundaries.Top) { MovePos.Y -= distance; }
                    break;
                case Direction.Down:
                    if (MovePos.Y + distance < game.Boundaries.Bottom) { MovePos.Y += distance; }
                    break;
                case Direction.Left:
                    if (MovePos.X - distance > game.Boundaries.Left) { MovePos.X -= distance; }
                    break;
                case Direction.Right:
                    if (MovePos.X + distance < game.Boundaries.Right) { MovePos.X += distance; }
                    break;
            }
            return MovePos;
        }

    }
}
