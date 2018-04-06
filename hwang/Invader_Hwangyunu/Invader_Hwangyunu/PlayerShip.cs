using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Invader_Hwangyunu
{
    class PlayerShip
    {
        private const int HorizontalInterval = 10;

        private Bitmap image = new Bitmap(Properties.Resources.player);

        public Point PlayerLocation { get { return location; } }

        private Point location;  //내가 작성

        private Game game;

        public Rectangle Area { get
            {
                return new Rectangle(location, image.Size);
            } }
        public bool Alive = true;

        public PlayerShip(Point location, Game game)
        {
            this.location = location;
            this.game = game;
        }


        public void Draw(Graphics g)
        {
           
            
            if (!Alive)
            {

            }
            else
            {
                g.DrawImage(Properties.Resources.player, Area);

            }
        }
        public Point MoveLocation(Direction direction, Rectangle boundaries)
        {
            Point newPlayerLocation = location;
            switch (direction)
            {
                case Direction.Right:
                    if (newPlayerLocation.X + HorizontalInterval <= boundaries.Right-100)
                        newPlayerLocation.X += HorizontalInterval;
                    break;
                case Direction.Left:
                    if (newPlayerLocation.X - HorizontalInterval >= boundaries.Left+100)
                        newPlayerLocation.X -= HorizontalInterval;
                    break;
                default: break;
            }
            return newPlayerLocation;

        }
        public void Move(Direction direction)
        {
            location = MoveLocation(direction, game.Boudaries);

        }
    }
}
