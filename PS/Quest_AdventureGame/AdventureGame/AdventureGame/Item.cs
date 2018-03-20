using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AdventureGame
{
    public abstract class Item : GameObject
    {
        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }

        public Item(GameView gameView, Point location) : base (gameView, location)
        {
            this.gameView = gameView;
            this.location = location;
            pickedUp = false; 
        }

        public void PickUpItem() { pickedUp = true; }

        public abstract string Name { get; }

        public abstract void Use(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = gameView.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in gameView.Enemies)
                {
                    if(Nearby(enemy.Location, target, radius))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }

                target = Move(direction, target, gameView.Boundaries);
            }

            return false;
        }                          

        protected Direction ClockwiseDirection(Direction direction)
        {
            Direction clockwiseDirection = direction;
            switch (direction)
            {
                case Direction.Up:
                    clockwiseDirection = Direction.Right;
                    break;
                case Direction.Right:
                    clockwiseDirection = Direction.Down;
                    break;
                case Direction.Down:
                    clockwiseDirection = Direction.Left;
                    break;
                case Direction.Left:
                    clockwiseDirection = Direction.Up;
                    break;
            }
            return clockwiseDirection;
        }

        protected Direction CounterClockwiseDirection(Direction direction)
        {
            Direction counterClockwiseDirection = direction;
            switch (direction)
            {
                case Direction.Up:
                    counterClockwiseDirection = Direction.Left;
                    break;                
                case Direction.Left:
                    counterClockwiseDirection = Direction.Down;
                    break;
                case Direction.Down:
                    counterClockwiseDirection = Direction.Right;
                    break;
                case Direction.Right:
                    counterClockwiseDirection = Direction.Up;
                    break;
            }
            return counterClockwiseDirection;
        }

    }
}
