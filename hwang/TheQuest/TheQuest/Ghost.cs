using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace TheQuest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location)
            : base(game, location, 8)
        {
        }
        public override void Move(Random random)
        {
            if (EnemiesLife >= 1)
            {
                int Ghost = random.Next(1, 3);
                if (Ghost == 1)
                {
                    base.location = Move(FindPlayer(game.PlayerLocation), game.Boundaries);
                }
                if (NearPlayer())
                {
                    game.DamagedPlayer(3, random);
                }
            }
        }
    }
}
