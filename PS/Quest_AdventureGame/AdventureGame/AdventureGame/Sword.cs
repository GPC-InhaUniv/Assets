using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AdventureGame
{
    class Sword : Item
    {
        public Sword(GameView gameView, Point location) : base (gameView, location) { }

        public override string Name { get { return "Sword"; } }

        public override void Use(Direction direction, Random random)
        {
            if(!DamageEnemy(direction, 10, 3, random))
            {
                if(!DamageEnemy(ClockwiseDirection(direction), 10, 3, random))
                {
                    DamageEnemy(CounterClockwiseDirection(direction), 10, 3, random);
                }
            }               
                
        }
    }
}
