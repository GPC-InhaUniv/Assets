using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AdventureGame
{
    class Mace : Item
    {
        public Mace(GameView gameView, Point location) : base(gameView, location) { }

        public override string Name
        {
            get
            {
                return "Mace";
            }
        }

        public override void Use(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, 20, 6, random))
            {
                Direction nextAttackDirection = ClockwiseDirection(direction);
                for (int i = 0; i < 3; i++)
                {
                    if (DamageEnemy(nextAttackDirection, 20, 6, random))
                    {
                        break;
                    }
                    nextAttackDirection = ClockwiseDirection(direction);
                }
            }
        }
    }
}
