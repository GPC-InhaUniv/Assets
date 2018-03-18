using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Bat : Enemy
    {

        public Bat(Game game, Point location)
            : base(game, location, 6)
        {
        }
        public override void Move(Random random)
        {
            if (EnemiesLife >= 1)
            {
                int batmove = random.Next(1, 2);
                if (batmove == 1)
                {
                    base.location=Move(FindPlayer(game.PlayerLocation), game.Boundaries);
                }
                if (NearPlayer())
                {
                    game.DamagedPlayer(2, random);
                }
            }
        }
    }
}
