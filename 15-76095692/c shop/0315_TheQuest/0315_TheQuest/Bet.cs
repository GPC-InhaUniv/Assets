using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _0315_TheQuest
{
    class Bet : Enemy
    {
        public Bet(Game game, Point location)
            : base(game, location, 6)
        {//생성자는 base class에서 처리합니다.
        }

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
        //class Bet : Enemy
        //{
        //    public Bet(Game game, Point location) : base (game, location, 6) { }

        //    public override void Move(Random random)//50%확률로 플레이어를 향해 이동 or 임의의 방향으로 이동
        //    {
        //        //FindPlayerDirection
        //        int HitPoints = 6;
        //        if(HitPoints >= 1)
        //        {
        //            if (random.Next(2) == 1)//50%확률은 만듬
        //            {
        //                //location.X += 20;
        //                //location.Y -= 5;
        //                //FindPlayerDirection();
        //                //game.Move(Direction.Down, random);
        //                //base.location = Move(direction, game.Boundaries);
        //            }
        //        }
        //    }
        //}
    }
}
