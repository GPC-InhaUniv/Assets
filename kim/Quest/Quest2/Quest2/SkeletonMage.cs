using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Quest2
{
    class SkeletonMage : Enemy
    {
       

        public SkeletonMage(Game game, Point location) : base (game,location, 30)
        {
            boundaries = game.Boundaries;
            maxDamage = 3;
           
        }
        
        Direction NewDirection;

        public override void Move(Random random)
        {
            int AI = random.Next(10);


            if (HitPoints > 20)
            {


                if (AI % 3 == 0)
                {

                    MoveControl(FindPlayerDirection(), random);
                }
                else
                {
                    MoveControl(Direction.Stop, random);
                }
            }

            else if (HitPoints > 10)
            {

                if (AI % 2 == 0)
                {

                    MoveControl(FindPlayerDirection(), random);
                }
                else
                {
                    MoveControl(Direction.Stop, random);
                }

                if (base.Nearby(game.PlayerLocation, 50))
                {
                    game.GiveDamageToPlayer(maxDamage, random);
                }
                    
                

            }
            else
            {
                MoveControl(FindPlayerDirection(), random);

                maxDamage = game.PlayerHitPoints / 2;
                if (base.Nearby(game.PlayerLocation, 15))
                {
                    game.GiveDamageToPlayer(maxDamage, random);
                }


            }
            
            

            
        }

       

    }
}
