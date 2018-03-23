using System;
using System.Drawing;

namespace Quest2
{
    class Mace : Weapon
    {

        public Mace(Game game, Point location) : base(game, location)
        {
            this.radius = 30;
            maxDamage = 5;
        }
        public override WeaponName Name
        {
            get
            {
                return WeaponName.Mace;
            }
        }
        public override void Attack(Direction direction, Random random)
        {
            bool SuccessAttack = false;
            int IntegerDirection = (int)direction;
            if (SuccessAttack == false)
            {
                SuccessAttack = DamageEnemy((Direction)(IntegerDirection % 4), radius,  random);
                SuccessAttack = DamageEnemy((Direction)((IntegerDirection + 1) % 4), radius,  random);
                SuccessAttack = DamageEnemy((Direction)((IntegerDirection + 2) % 4), radius,  random);
                SuccessAttack = DamageEnemy((Direction)((IntegerDirection + 3) % 4), radius,  random);
            }
        }
    }
}
