using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
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
                if (locationToCheck.Y- location.Y >= 0 && location.Y + distance <= locationToCheck.Y && Math.Abs(location.X- locationToCheck.X) < distance)
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

        public bool MoveToInventory(string name)
        {
            if (name == "sword")
            {
                location.X = 89;
                location.Y = 318;
                return true;
            }
            else if (name == "bow")
            {
                location.X = 164;
                location.Y = 318;
                return true;
            }
            else if (name == "mace")
            {
                location.X = 237;
                location.Y = 318;
                return true;
            }
            else if (name == "bluePortion")
            {
                location.X = 317;
                location.Y = 318;
                return true;
            }
            else if(name=="redPortion")
            {
                location.X = 377;
                location.Y = 318;
                return true;
            }

            return false;
        }
    }
}
