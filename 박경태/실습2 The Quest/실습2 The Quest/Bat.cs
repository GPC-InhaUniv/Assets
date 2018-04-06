using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 실습2_The_Quest
{
    class Bat : Monster
    {
        public Bat(Point location, Game game, int damage, int lifepoint) : base(location, game, 0, 6)
        {
        }

        public override void Move(Player player, Rectangle rectangle)
        {
            Point Batlocation = base.Lcation;
            Random random = new Random();
            int rand = random.Next(5);
            int rand2 = random.Next(1);

            if (rand2 == 0)
            {
                if (player.Lcation.X < Batlocation.X)
                    Batlocation.X -= rand;
                if (player.Lcation.X > Batlocation.X)
                    Batlocation.X += rand;

                if (player.Lcation.Y < Batlocation.Y)
                    Batlocation.Y -= rand;
                if (player.Lcation.Y > Batlocation.Y)
                    Batlocation.Y += rand;
            }

            base.Lcation = Batlocation;
        }
    }
}
