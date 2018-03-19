using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    class Yasuo : Monster
    {
        public Yasuo(Game game, Point location) : base(game, location, 8)  { }

        public override void Move(Random random)
        {
            if (random.Next(1, 3) == 3)
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);

            }
            else if((random.Next(1,3) == 2) || (random.Next(1,3)==1))
            {
                location = Move(0, game.Boundaries);
            }
           
            if (NearPlayer())
            {
                game.HitPlayer((int)random.Next(1,3), random);
            }
        }
    }
}
