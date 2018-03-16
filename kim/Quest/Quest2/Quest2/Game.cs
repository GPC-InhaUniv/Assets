using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Quest2
{
    class Game
    {
        private Player Player;
       
        public Point PlayerLocation { get { return Player.Location; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public Game (Rectangle boundaries)
        {
            this.boundaries = boundaries;
            Player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 10));
        }

        public void Move(Direction direction)
        {
           
            Player.Move(direction);

        }
    }
}
