using System;
using System.Drawing;

namespace Quest2
{
    class Bat : Enemy
    {
       
        public Bat(Game game, Point location) : base(game, location, 6)
        {
            maxDamage = 2;
            boundaries = game.Boundaries;
        }

        public override void Move(Random random)
        {
            int AI = random.Next(4);
            if (AI % 2 == 0)
            {
                MoveControl(FindPlayerDirection(),random); 
            }
            else
            {
                MoveControl((Direction)random.Next(4),random);
            }
        }
    }
}

