using System;
using System.Drawing;

namespace TheQuest
{
    class Ghost : Enemy
    {
        private int attackDamage = Utility.GHOSTAD;

        public Ghost(Game game, Point location) : base(game, location, Utility.GHOSTHP)
        {

        }
        public override void Move(Random random)
        {
            if (base.NearPlayer())
            {
                AttackPlayer(attackDamage, random);
            }
            else
            {
                if ((random.Next(1, 4) == 1))  //33%의 확률로 플레이어에게 이동
                {
                    Direction direction = FindPlayerDirection(game.PlayerLocation);
                    base.location = MoveObject(direction, game.Boundaries);
                }
                else
                {
                    Direction direction = (Direction)random.Next(1, 5);
                    base.location = MoveObject(direction, game.Boundaries);
                }
            }
        }
    }
}
