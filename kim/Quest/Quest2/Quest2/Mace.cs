using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest2
{
    class Mace : Weapon
    {

        public Mace(Game game, Point location) : base(game, location)
        {
            this.radius = 30;
        }
        public override string Name
        {
            get
            {
                return "Mace";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            bool SuccessAttack = false;
            int IntegerDirection = (int)direction;
            if (SuccessAttack == false)
            {
                SuccessAttack = DamageEnemy((Direction)(IntegerDirection % 4), radius, 3, random);
                SuccessAttack = DamageEnemy((Direction)((IntegerDirection + 1) % 4), radius, 3, random);
                SuccessAttack = DamageEnemy((Direction)((IntegerDirection + 2) % 4), radius, 3, random);
                SuccessAttack = DamageEnemy((Direction)((IntegerDirection + 3) % 4), radius, 3, random);

            }

        }

    }
}
