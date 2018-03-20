using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuestGameCreate.Util
{
    abstract class Attack
    {
        private const int AttackRange = 10;
        private Point location;

        public Point Location { get { return location; } }
        protected Controller.Game game;

        enum Direction
        {
            AttackUP,
            AttackDOWN,
            AttackLEFT,
            AttackRIGHT,
        }

        public Attack(Controller.Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        
    }
}
