using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuest
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10)
        {//생성자는 base class에서 처리합니다.
        }

        public override void Move(Random random)
        {
            if (HitPoints > 0 && random.Next(10) > 6)
            {
                if (game.PlayerLocation.X < location.X && game.PlayerLocation.Y < location.Y)
                {
                    location.X -= (int)FindPlayerDirection(game.PlayerLocation);
                    location.Y -= (int)FindPlayerDirection(game.PlayerLocation);
                }
                else if (game.PlayerLocation.X > location.X && game.PlayerLocation.Y > location.Y)
                {
                    location.X += (int)FindPlayerDirection(game.PlayerLocation);
                    location.Y += (int)FindPlayerDirection(game.PlayerLocation);
                }
                else if (game.PlayerLocation.X > location.X && game.PlayerLocation.Y < location.Y)
                {
                    location.X += (int)FindPlayerDirection(game.PlayerLocation);
                    location.Y -= (int)FindPlayerDirection(game.PlayerLocation);
                }
                else if (game.PlayerLocation.X < location.X && game.PlayerLocation.Y > location.Y)
                {
                    location.X -= (int)FindPlayerDirection(game.PlayerLocation);
                    location.Y += (int)FindPlayerDirection(game.PlayerLocation);
                }
                else if (game.PlayerLocation.X > location.X && game.PlayerLocation.Y > location.Y)
                {
                    location.X += (int)FindPlayerDirection(game.PlayerLocation);
                    location.Y += (int)FindPlayerDirection(game.PlayerLocation);
                }
                else if (game.PlayerLocation.X == location.X && game.PlayerLocation.Y == location.Y)
                {
                    location.X += (int)FindPlayerDirection(game.PlayerLocation) - (int)FindPlayerDirection(game.PlayerLocation);
                    location.Y += (int)FindPlayerDirection(game.PlayerLocation) - (int)FindPlayerDirection(game.PlayerLocation);
                }
                else if (game.PlayerLocation.X > location.X)
                {
                    location.X += (int)FindPlayerDirection(game.PlayerLocation);
                }
                else if (game.PlayerLocation.Y > location.Y)
                {
                    location.Y += (int)FindPlayerDirection(game.PlayerLocation);
                }
                else if (game.PlayerLocation.X < location.X)
                {
                    location.X -= (int)FindPlayerDirection(game.PlayerLocation);
                }
                else if (game.PlayerLocation.Y < location.Y)
                {
                    location.Y -= (int)FindPlayerDirection(game.PlayerLocation);
                }
            }
            else
            {
                return;
            }
            if (NearPlayer())
            {
                game.HitPlayer(4, random);
            }
        }
    }

}

