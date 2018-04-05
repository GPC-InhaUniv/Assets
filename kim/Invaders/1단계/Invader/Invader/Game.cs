using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Invader
{
    class Game
    {
        private Rectangle boundaries;
        PlayerShip Player;
        
        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            
            Player = new PlayerShip(boundaries);
           
        }
        public void MovePlayer(Direction direction)
        {
            Player.Move(direction);
            
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Black, new Rectangle(0,0,1152,864));
            Player.Draw(g);
        }
    }
}
