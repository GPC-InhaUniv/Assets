using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Quest2
{
    class Ghoul : Enemy
    {
        
        public Ghoul(Game game, Point location) : base(game, location, 10)
        {
            maxDamage = 4;
            boundaries = game.Boundaries;
        }


        public override void Move(Random random)
        {


            int AI = random.Next(3);


            if (AI % 3 != 0)
            {

                MoveControl(FindPlayerDirection(),random);
            }
            else
            {
               MoveControl(Direction.Stop,random);
            }
            
           

        }
    }
}
