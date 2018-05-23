using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest
{
    class MeleeMinion : Minion
    {
        public MeleeMinion(Point location,Game game) : base(location,game, 6)
        {
            name = "MeleeMinion";
            movement = 10;
        }

        public override void Move(Random random)
        {
            int condition = random.Next(0, 2);
            if (condition == 0)
            {
                targetPlayerMove(random);
            }
            else
            {
                condition = random.Next(0, 4);
                switch (condition)
                {
                    case 0:
                        way = MinionActive.위쪽이동;
                        location.Y -= movement;
                        if (location.Y < game.Boundaries.Top)
                            location.Y = game.Boundaries.Top;
                        break;
                    case 1:
                        way = MinionActive.아래쪽이동;
                        location.Y += movement;
                        if (location.Y > game.Boundaries.Bottom)
                            location.Y = game.Boundaries.Bottom;
                        break;

                    case 2:
                        way = MinionActive.왼쪽이동;
                        location.X -= movement;
                        if (location.X < game.Boundaries.Left)
                            location.X = game.Boundaries.Left;
                        break;
                    case 3:
                        way = MinionActive.오른쪽이동;
                        location.X += movement;
                        if (location.X > game.Boundaries.Right)
                            location.X = game.Boundaries.Right;
                        break;
                }
                if (NearBy(game.PlayerLocation, 30) == true)
                {
                    game.MinionAttack(3, random);
                    way = MinionActive.공격;
                }
            }

        }
        

    }
}
