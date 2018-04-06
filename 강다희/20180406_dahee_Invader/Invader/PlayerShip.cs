using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invader
{
    public class PlayerShip
    {
        public Point Location;
        public bool Alive;
        public Rectangle Area;

        public void Draw(Graphics g)
        {
            g.DrawImage(Properties.Resources.player, 350, 450);
        }

        public void Move(Game.Direction direction)
        {
        }
    }
}