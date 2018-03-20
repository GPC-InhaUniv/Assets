using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace dahee_quest
{
    public class Player : Mover
    {
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }

        public Player(Game game, Point location) : base(game, location)
        {
            hitPoints = 10;
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
        }
    }
}