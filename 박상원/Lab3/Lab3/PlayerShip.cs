using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    class PlayerShip
    {
        Game game;
        public enum Direction
        {
            Left,
            Right,
            Up,
            Down,
        }

        private Point location;
        protected Rectangle Area { get; private set; } // 피격 박스용
        private Rectangle boundaries;
        public Point Location { get { return location; } }

        private const int moveInterval = 10;

        public PlayerShip(Game game,Point getLocation)
        {
            this.game = game;
            location = getLocation;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Properties.Resources.player, location);
        }

        public void Move(Direction direction)
        {
            switch(direction)
            {
                case Direction.Left:
                    if(location.X > game.boundaries.Left)
                    {
                        location.X -= moveInterval;
                    }
                    break;
                case Direction.Right:
                    if(location.X <= game.boundaries.Right-75)
                    {
                        location.X += moveInterval;
                    }
                    break;
            }
        }
    }
}
