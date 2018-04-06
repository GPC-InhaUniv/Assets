using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PracticeInvaders
{
    
    public class Shot
    {
        private const int moveInterval = 20;
        private const int width = 8;
        private const int height = 20;

        public Point Location { get; private set; }

        private Direction direction;
        private Rectangle boundaries;

        Point moveShot = new Point();
        

        public Shot(Point location, Direction direction, Rectangle boundaries)
        {
            this.Location = location;
            this.direction = direction;
            this.boundaries = boundaries;
            
        }

        public void Draw(Graphics g)
        {
           
            g.DrawImage(Properties.Resources.laser2,Location);

        }

        public bool Move()
         {

            if (Location.Y > boundaries.Top)
            {
                moveShot = new Point(Location.X, Location.Y - moveInterval);
                Location = moveShot;
                return true;
            }
            return false;
           
            //총알을 위로 움직이며
            // 총알이 게임 영역 내부에 있다면 true 반환
        }   
    }
}
