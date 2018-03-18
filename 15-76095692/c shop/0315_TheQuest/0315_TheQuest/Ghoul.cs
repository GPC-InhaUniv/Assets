using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _0315_TheQuest
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10) { }
        public override void Move(Random random)
        {
            if (HitPoints > 0 && random.Next(10) > 5)
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
                switch (random.Next(1, 4))
                {
                    case 1:
                        location.Y -= (int)Direction.Up;
                        break;
                    case 2:
                        location.Y += (int)Direction.Down;
                        break;
                    case 3:
                        location.X -= (int)Direction.Left;
                        break;
                    case 4:
                        location.X -= (int)Direction.Right;
                        break;
                }
            if (NearPlayer())
            {
                game.HitPlayer(2, random);
            }
        }
        //public override void Move(Random random)//히트 포인트가 1이상 남아있을때만 이동해서 공격함. 2/3확률로 플렝이어를향해 이동 1/3확률로 가만히 있음
        //{
        //    int HitPoints = 10;
        //    if (HitPoints >= 1)
        //    {

        //    }
        //}
    }
}
