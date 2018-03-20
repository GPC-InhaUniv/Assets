using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AdventureGame
{
    public class Bat : Enemy
    {        
        public Bat(GameView gameView, Point location, int hitPoints) : base(gameView, location, 6) { }

        public override void Move(Random random)
        {
            
        }
    }
}
