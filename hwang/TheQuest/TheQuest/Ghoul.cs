using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace TheQuest
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10)
        {
        }
        public override void Move(Random random)
        {
            if (EnemiesLife >= 1)
            {
                int ghoulmove = random.Next(1, 3);
                if (ghoulmove == 1 || ghoulmove == 2)
                {
                    base.location = Move(FindPlayer(game.PlayerLocation), game.Boundaries);
                }
                if (NearPlayer())
                {
                    game.DamagedPlayer(2, random);
                }
            }
        }
    }    
}
