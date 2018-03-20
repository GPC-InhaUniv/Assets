using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _0315_TheQuest
{
    public class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location) { }
        public override string Name { get { return "Mace"; } }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(Direction.Left, 6, 6, random);
            DamageEnemy(Direction.Right, 6, 6, random);
            DamageEnemy(Direction.Up, 6, 6, random);
            DamageEnemy(Direction.Down, 6, 6, random);
        }
    }
}