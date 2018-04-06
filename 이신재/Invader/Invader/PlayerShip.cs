using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Invader
{
    class PlayerShip
    {

        public const int MoveInterval = 10;
        public Point Location;
        public Rectangle boundaries;
        public Bitmap image = Properties.Resources.player;
        public bool Alive { get; private set; }
        
        public PlayerShip(Rectangle boundaries, Point location)
        {
            this.boundaries = boundaries;
            this.Location = location;
            Alive = true;
        }
       
        public void Draw(Graphics g, Point location)
        {
            g.DrawImage(image,Location);
        }
        public void Move(enumDirection direction)
            {
            if (Alive)
            {
                if (direction == enumDirection.Left)
                {
                    
                    Point newLocation = new Point((Location.X - MoveInterval), Location.Y);
                    if ((newLocation.X < (boundaries.Width - 100)) && (newLocation.X > 50))
                        Location = newLocation;
                }
                else if (direction == enumDirection.Right)
                {
                    Point newLocation = new Point((Location.X + MoveInterval), Location.Y);
                    if ((newLocation.X < (boundaries.Width - 100)) && (newLocation.X > 50))
                        Location = newLocation;
                }
            }
        }
        

        
    }
}
