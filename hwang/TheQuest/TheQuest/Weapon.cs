using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    abstract class Weapon : Mover
    {
        protected Game game;
        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }

        private Point location;
        public Point Location { get { return location; } }

        public Weapon(Game game, Point location) 
            : base(game, location)
        {
            this.game = game;
            this.location = location;
            pickedUp = false;
        }


        //오버로드//
        public  bool NearBy(Point enemiesLocation, Point playerLocation ,int distance )
        {
            //Math.Abs 절대값을 반환하는 기호  이게 없을경우  한쪽방향밖에 구분을 못함//
            if (Math.Abs(playerLocation.X - enemiesLocation.X) < distance&&
                (Math.Abs(playerLocation.Y - enemiesLocation.Y) < distance))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PickUpWeapon()
        {
            pickedUp = true;
        }
        public abstract string Name { get; }

        public abstract void Attack(MoveDirection direction, Random random);

        protected bool DamageEnemy(MoveDirection direction , int radius , int damage , Random random)
        {
            Point playerLocation = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach(Enemy enemy in game.Enemies)
                {
                    if(NearBy(enemy.Location , playerLocation, radius))
                    {
                        enemy.Damaged(damage, random);
                        return true;
                    }
                }
               // target = Move(direction, target, game.Boundaries);
            }
            return false;
        }
    }
}
