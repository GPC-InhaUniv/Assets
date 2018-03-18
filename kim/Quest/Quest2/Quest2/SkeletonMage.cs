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
        Rectangle boundaries;
             


        public SkeletonMage(Game game, Point location) : base (game,location, 30)
        {
            boundaries = game.Boundaries;
            maxDamage = 4;
           
        }
        
        Direction NewDirection;

        public override void Move(Random random)
        {
            int bosspattern = random.Next(10);



            if (HitPoints > 20)
            {
                moving(random);
                if (NearPlayer())
                {
                    game.GiveDamageToPlayer(maxDamage, random);
                }
            }

            else if (HitPoints > 10)
            {
                
                moving(random);
                if (base.Nearby(game.PlayerLocation, 50))
                {
                    game.GiveDamageToPlayer(maxDamage, random);
                }
                    
                

            }
            else
            {
                moving(random);  

                maxDamage = game.PlayerHitPoints / 2;
                if (base.Nearby(game.PlayerLocation, 15))
                {
                    game.GiveDamageToPlayer(maxDamage, random);
                }


            }
            
            

            
        }

        public void moving(Random random)
        {
            int bosspattern = random.Next(4);
            if (bosspattern % 2 == 0)
            {

                NewDirection = FindPlayerDirection();
            }
            else
            {
                NewDirection = (Direction)random.Next(4);
            }
            switch (NewDirection)
            {
                case Direction.Up:
                    if (location.Y - MoveInterval >= boundaries.Top)
                    {
                        location.Y -= MoveInterval;
                    }

                    break;
                case Direction.Down:
                    if (location.Y + MoveInterval <= boundaries.Bottom)
                    {
                        location.Y += MoveInterval;
                    }
                    break;
                case Direction.Left:
                    if (location.X - MoveInterval >= boundaries.Left)
                    {
                        location.X -= MoveInterval;
                    }
                    break;
                case Direction.Right:
                    if (location.X + MoveInterval <= boundaries.Right)
                    {
                        location.X += MoveInterval;
                    }
                    break;
                default:
                    break;
            }
        }

    }
}
