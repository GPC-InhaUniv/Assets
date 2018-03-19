using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Weapon : Mover
    {
        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }

        public abstract string Name { get; }

        public Weapon(Game game, Point location)
            : base(game, location) { pickedUp = false; }

        public void PickUpWeapon() { pickedUp = true; }

        public abstract void Attack(Direction dir, Random random, Form1 form);

        public abstract void showAttackRange(Direction dir, Form1 form);

        public void drawAttackRange(Direction dir, int attackRange, Form1 form)
        {
            Color hiteffect = Color.FromArgb(0x30, 0x00, 0x00, 0xff);
            Graphics graphics = form.CreateGraphics();
            Pen pen = new Pen(hiteffect, 1.0f);
            Rectangle rec;

            int size = 30;

            switch (dir)
            {
                case Direction.up:
                case Direction.Up:
                    rec = new Rectangle(game.PlayerLocation.X, game.PlayerLocation.Y - attackRange + size, size, attackRange);
                    graphics.DrawRectangle(pen, rec);
                    break;
                case Direction.right:
                case Direction.Right:
                    rec = new Rectangle(game.PlayerLocation.X, game.PlayerLocation.Y, attackRange, size);
                    graphics.DrawRectangle(pen, rec);
                    break;
                case Direction.Down:
                    rec = new Rectangle(game.PlayerLocation.X, game.PlayerLocation.Y, size, attackRange);
                    graphics.DrawRectangle(pen, rec);
                    break;
                case Direction.left:
                case Direction.Left:
                    rec = new Rectangle(game.PlayerLocation.X - attackRange + size, game.PlayerLocation.Y, attackRange, size);
                    graphics.DrawRectangle(pen, rec);
                    break;
            }
        }

        public bool Nearby(Direction dir, Point targetLocation, Point playerLocation, int attackRange)
        {
            int size = 30; // Abs값
            switch (dir)
            {
                case Direction.up:
                case Direction.Up:
                    if (
                        (playerLocation.Y - targetLocation.Y) < attackRange
                        && 0 < (playerLocation.Y - targetLocation.Y)
                        && Math.Abs(playerLocation.X - targetLocation.X) < size
                        )
                        return true;
                    break;
                case Direction.right:
                case Direction.Right:
                    if ((playerLocation.X - targetLocation.X) > -attackRange
                        && 0 > (playerLocation.X - targetLocation.X)
                        && Math.Abs(playerLocation.Y - targetLocation.Y) < size
                        )
                        return true;
                    break;
                case Direction.Down:
                    if ((playerLocation.Y - targetLocation.Y) > -attackRange
                        && 0 > (playerLocation.Y - targetLocation.Y)
                        && Math.Abs(playerLocation.X - targetLocation.X) < size
                        )
                        return true;
                    break;
                case Direction.left:
                case Direction.Left:
                    if ((playerLocation.X - targetLocation.X) < attackRange
                        && 0 < (playerLocation.X - targetLocation.X)
                        && Math.Abs(playerLocation.Y - targetLocation.Y) < size
                        )
                        return true;
                        break;
            }
            return false;
        }

        protected bool DamageEnemy(Direction dir, int attackRange, int damage, Random random)
        {
            Point WeaponLocation = game.PlayerLocation;//??

            for(int distance = 0; distance < attackRange; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(dir, enemy.Location, WeaponLocation, attackRange) && !enemy.Dead)
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                //WeaponLocation = Move(dir, game.Boundaries);  ??
            }
            return false;
        }
    }
}
