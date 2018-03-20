using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 실습2_The_Quest
{
    class Ghost : Monster
    {
        public Ghost(Point location, Game game, int damage, int lifepoint) : base(location, game, 0, 8)
        {
        }

        public override void Move(Player player, Rectangle rectangle)
        {
            Point Ghoullocation = base.Lcation;
            Random random = new Random();
            int rand = random.Next(1, 5);
            int rand2 = random.Next(2);

            if (rand2 == 0 || rand2 == 1)
            {
                if (player.Lcation.X < Ghoullocation.X)
                    Ghoullocation.X -= rand;
                if (player.Lcation.X > Ghoullocation.X)
                    Ghoullocation.X += rand;
                if (player.Lcation.Y < Ghoullocation.X)
                    Ghoullocation.Y -= rand;
                if (player.Lcation.Y > Ghoullocation.Y)
                    Ghoullocation.Y += rand;
            }
        }
    }
}
