using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Quest2
{
    class Player : Mover
    {
        

        public Player(Game game , Point location) : base ( game,location)
        {

        }
        public void Move(Direction direction)
        {
            
            location = Move(direction, game.Boundaries);
            
        }
    }
}
