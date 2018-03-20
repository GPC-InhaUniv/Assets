using System;
using System.Drawing;

namespace TheQuest
{

    abstract class Mover
    {

        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point point)
        {
            this.game = game;
            this.location = point;
        }

        public bool NearbyObject(Point locationToCheck, int distance)
        {
            //Console.WriteLine("플레이어 위치: x" + locationToCheck.X + " y: " + locationToCheck.Y);
            //Console.WriteLine("몬스터 위치 : x" + Location.X + " Y:" + Location.Y);

            if (Math.Abs(location.X - locationToCheck.X) < distance &&
                (Math.Abs(location.Y - locationToCheck.Y) < distance))
            {
                return true;
            }
            else return false;
        }

        public bool NearbyObject(Point locationToCheck, int distance,Direction direction)
        {
            //Console.WriteLine("플레이어 위치 : x" + Location.X + " Y:" + Location.Y);
            //Console.WriteLine("위치: x" + locationToCheck.X + " y: " + locationToCheck.Y);
          
            if(direction==Direction.Up)
            {
                if (location.Y-locationToCheck.Y  >= 0 && location.Y -distance <= locationToCheck.Y && Math.Abs(location.X - locationToCheck.X) < distance)
                    return true;
            }
            else if (direction == Direction.Down)
            {
                if (locationToCheck.Y- location.Y >= 0 && location.Y + distance >= locationToCheck.Y && Math.Abs(location.X- locationToCheck.X) < distance)
                    return true;
            }
            else if (direction == Direction.Right)
            {
                if (locationToCheck.X-location.X>=0&& location.X+distance >= locationToCheck.X && Math.Abs(location.Y - locationToCheck.Y) < distance)
                    return true;
            }
            else if (direction == Direction.Left)
            {
                if (location.X-locationToCheck.X>= 0 && location.X - distance <= locationToCheck.X && Math.Abs(location.Y - locationToCheck.Y) < distance)
                    return true;
            }


            return false;
        }


        public Point MoveObject(Direction direction, Rectangle boundaries)
        {
            Point newLocation = location;
            //Debug.Write(" X :" + newLocation.Y + " Y " + newLocation.Y);
            switch (direction)
            {
                case Direction.Up:

                    if (newLocation.Y - MoveInterval > boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval < boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval > boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval < boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default:
                    break;

            }
            // Debug.Write(" X :" + newLocation.Y + " Y " + newLocation.Y);
            return newLocation;
        }

        public bool MoveToInventory(Weapon weapon)
        {
            if ( weapon is Sword)
            {
                location = Utility.SwordInventoryPosition;
                return true;
            }
            else if (weapon is Bow)
            {
                location = Utility.BowInventoryPosition;
                return true;
            }
            else if (weapon is Mace)
            {
                location = Utility.MaceInventoryPosition;
                return true;
            }
            else if (weapon is BluePotion)
            {
                location = Utility.BluePortionInventoryPosition;
                return true;
            }
            else if (weapon is RedPotion)
            {
                location = Utility.RedPortionInventoryPosition;
                return true;
            }

            return false;
        }
    }
}
