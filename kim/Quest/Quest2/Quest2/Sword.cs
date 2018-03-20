using System;
using System.Drawing;

namespace Quest2
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location)
        {
            this.radius = 40;
            maxDamage = 3;
        }
        public override string Name { get { return "Sword"; } }

        public override void Attack(Direction direction, Random random)
        {
            bool SuccessAttack = false;
            int IntegerDirection = (int)direction;
            if (SuccessAttack == false)
            {
                SuccessAttack = DamageEnemy((Direction)(IntegerDirection % 4), radius,  random);
            }
            if (SuccessAttack == false)
            {  
                SuccessAttack = DamageEnemy((Direction)((IntegerDirection + 1) % 4), radius,  random);
            }
            if (SuccessAttack == false)
            {
                SuccessAttack = DamageEnemy((Direction)((IntegerDirection + 3) % 4), radius,  random);
            }

        }
    }
}
