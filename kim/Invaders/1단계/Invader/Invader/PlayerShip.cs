using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Invader
{
    class PlayerShip
    {
        private const int MoveLength = 10;
        private Point location;
        private Rectangle Area;
        public bool Alive { get; private set; }
        public PictureBox test;
        public PlayerShip(Rectangle Area)
        {
            Alive = true;
            this.Area = Area;
            this.location.X = Area.Width/2;
            this.location.Y = Area.Height - 50;
            
           
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(Properties.Resources.player, this.location);
        }
        public void Move(Direction direction)
        {
            if (Alive)
            {
                switch (direction)
                {
                    case Direction.Left:
                        if (Area.Left < this.location.X)
                        {
                            this.location.X -= MoveLength;
                            Console.WriteLine(this.location.X);
                        }
                        break;
                    case Direction.Right:
                        if (Area.Right > this.location.X)
                        {
                            this.location.X += MoveLength;
                            Console.WriteLine(this.location.X);
                        }
                        break;
                }
            }
            
        }


    }
}
