using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _0315_TheQuest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8) { }
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
        //public override void Move(Random random)//1/3의 확률로 플레이어를 향해 움직이고 2/3확률로 제자리에 머무름
        //{
        //    int HitPoints = 8;
        //    if (HitPoints >= 1)
        //    {

        //    }
        //}
    }
}
