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
            Point Ghostlocation = base.Lcation;
            Random random = new Random();
            Random random2 = new Random();
            int rand = random.Next(1, 5);
            int rand2 = random2.Next(3);

            if (rand2 == 0)
            {
                if (player.Lcation.X < Ghostlocation.X)
                    Ghostlocation.X -= rand;
                if (player.Lcation.X > Ghostlocation.X)
                    Ghostlocation.X += rand;

                if (player.Lcation.Y < Ghostlocation.Y)
                    Ghostlocation.Y -= rand;
                if (player.Lcation.Y > Ghostlocation.Y)
                    Ghostlocation.Y += rand;
            }

            base.Lcation = Ghostlocation;
        }
    }
}
