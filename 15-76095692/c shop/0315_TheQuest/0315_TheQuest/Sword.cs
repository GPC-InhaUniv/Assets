using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _0315_TheQuest
{
    public class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location) { }
        public override string Name { get { return "BFSword"; } }

        public override void Attack(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, 10, 3, random))
            {
                direction = (Direction)(((int)direction + 1) % 4);
                if (!DamageEnemy(direction, 10, 3, random))
                {
                    direction = (Direction)(((int)direction + 1) % 4);
                    DamageEnemy(direction, 10, 3, random);
                }
            }
        }
    }
}