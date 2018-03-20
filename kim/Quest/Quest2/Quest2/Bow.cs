using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest2
{
    class Bow : Weapon
    {

        public Bow(Game game, Point location) : base(game, location)
        {
            this.radius = 60;
        }
        public override string Name { get { return "Bow"; } }

        public override void Attack(Direction direction, Random random)
        {
            bool SuccessAttack = false;
            int IntegerDirection = (int)direction;
            if (SuccessAttack == false)
            {
                SuccessAttack = DamageEnemy((Direction)(IntegerDirection % 4), radius, 3, random);
              

            }

        }

    }
}
