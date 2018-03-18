//completed
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    public abstract class Weapon : Mover
    {
        protected Game game;
        private bool pickedUp;
        public bool PickedUp
        {
            get => pickedUp;
        }
        private Point location;
        public Point Location
        {
            get => location;
        }

        public Weapon(Game game, Point location) : base(game, location)
        {
            this.game = game;
            this.location = location;
            pickedUp = false;
        }

        public void PickUpWeapon()
        {
            pickedUp = true;
        }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);
        
        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for(int distance = 0; distance < radius; distance++)
            {
                foreach(Enemy enemy in game.Enemies)
                {
                    Point enemyBody = enemy.Location;
                    if (Nearby(enemy.Location, target, radius))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }
    }

    public class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location)
        {

        }

        public override string Name
        {
            get => "Sword";
        }

        public override void Attack(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, 10, 3, random))
            {
                direction = (Direction)(((int)direction + 1) % 4);
                if (!DamageEnemy(direction, 10, 3, random))
                {
                    direction = (Direction)(((int)direction + 1) % 4);
                    DamageEnemy(direction, 10, 3, random);
                }
            }
        }
    }

    public class Bow : Weapon
    {
        public Bow(Game game, Point location) : base(game, location)
        {

        }

        public override string Name
        {
            get => "Bow";
        }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(direction, 30, 1, random);
        }
    }
public class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location)
        {

        }

        public override string Name
        {
            get => "Mace";
        }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(Direction.Left, 6, 6, random);
            DamageEnemy(Direction.Right, 6, 6, random);
            DamageEnemy(Direction.Up, 6, 6, random);
            DamageEnemy(Direction.Down, 6, 6, random);
        }
    }
}
