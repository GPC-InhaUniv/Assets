using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    class Teemo : Monster
    {
        public Teemo(Game game, Point location) : base(game, location, 6){ }
        
        public override void Move(Random random)
        {
            if (random.Next(1, 2) == 2)
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            else
            {
                location = Move((enumDirection)random.Next(1, 4), game.Boundaries);
            }
            if (NearPlayer() ==true)
            {
                
            }
            
        }
    }
}
