using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    class Masterei : Monster
    {
        public Masterei(Game game, Point location): base(game ,location, 10)  {  }

        public override void Move(Random random)
        {
            if (random.Next(1, 2) == 2)
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries));

            }
            else
            {
                location = Move((enumDirection)random.Next(1, 4), game.Boundaries);
            }
            if (NearPlayer())
            {
                game.HitPlayer(1, maxDamage); //여기부터
            }
            
        }
            

    }
}
