using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InvadersGame
{
    class PlayerShip
    {
        private const int horizontalInterval = 10;
        public Point Location { get; private set; }
        public Rectangle Area { get { return new Rectangle(Location, image.Size); } }
        private bool isAlive;
        private int deadShipHeight;

        private Rectangle boundaries;

        Point newLocation = new Point();

        public Bitmap image = Properties.Resources.player;

        public PlayerShip(Rectangle boundaries, Point location)
        {
            this.boundaries = boundaries;
            this.Location = location;
            isAlive = true;
        }

        public Point Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                
                    newLocation = new Point((Location.X - horizontalInterval), Location.Y);         // 왼쪽으로 위치 이동
                    if ((newLocation.X < (boundaries.Width - 100)) && (newLocation.X > 50))         // 경계일 경우 제자리
                        Location = newLocation;
                        break;
             
                case Direction.Right:
                    
                    newLocation = new Point((Location.X + horizontalInterval), Location.Y);
                    if ((newLocation.X < (boundaries.Width - 100)) && (newLocation.X > 50))
                        Location = newLocation;
                        break;
                default: break;        
            }
            return Location;
        }

        public void Draw(Graphics g, int animationCell)
        {
            if (!isAlive)
            {
                
            }
            else
            {
                g.DrawImage(Properties.Resources.player, Location);
            }
        }
    }
}
