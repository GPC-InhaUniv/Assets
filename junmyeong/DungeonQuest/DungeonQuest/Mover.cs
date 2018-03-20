using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest
{
    abstract class  Mover
    {
        protected int movement;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;
        protected Mover (Game game , Point location)
        {
            this.game = game;
            this.location = location;
        }

        public virtual void Move(Direction direction, Rectangle boundaries)
        {
            if(direction == Direction.위쪽)
            {
                if (location.Y - movement >= boundaries.Top)
                    location.Y -= movement;
                else
                    location.Y = boundaries.Top;
            }
            else if(direction == Direction.아래쪽)
            {
                if (location.Y + movement <= boundaries.Bottom - 10)
                    location.Y += movement;
                else
                    location.Y = boundaries.Bottom - 10;
            }
            else if(direction == Direction.왼쪽)
            {
                if (location.X - movement >= boundaries.Left)
                    location.X -= movement;
                else
                    location.X = boundaries.Left;
            }
            else
            {
                if (location.X + movement <= boundaries.Right)
                    location.X += movement;
                else
                    location.X = boundaries.Right;
            }
          
        }
        public bool NearBy(Point target, int distance)
        {
            if (Math.Abs(location.X - target.X) > distance || Math.Abs(location.Y - target.Y) > distance)
                return false;
            else
                return true;
        }


        

    }
}
