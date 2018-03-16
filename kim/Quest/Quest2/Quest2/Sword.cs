using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest2
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location)
        {

        }
        public override string Name { get { return "Sword"; } }

        public override void Attack(Direction direction, Random random)
        {
            bool SuccessAttack = false;
            int IntegerDirection = (int)direction;
            if (SuccessAttack == false)
            {
                SuccessAttack = DamageEnemy((Direction)(IntegerDirection % 4), 100, 3, random);
                SuccessAttack = DamageEnemy((Direction)((IntegerDirection + 1) % 4), 100, 3, random);
                SuccessAttack = DamageEnemy((Direction)((IntegerDirection + 3) % 4) + 2, 100, 3, random);

            }

        }
    }
}
