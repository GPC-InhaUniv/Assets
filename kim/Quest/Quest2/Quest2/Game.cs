using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Quest2
{
    class Game
    {

        private Player Player;

        public List<Enemy> Enemies;
        public Weapon WeaponInRoom;

        public Point PlayerLocation { get { return Player.Location; } }
        public int PlayerHitPoints { get { return Player.HitPoints; } }



        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public Game (Rectangle boundaries)
        {
            this.boundaries = boundaries;
            Player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 10));
        }

        public void Move(Direction direction,Random random)
        {
           
            Player.Move(direction);
            foreach(Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
            
        }


        // --------- Level -------------

        private int level = 0;
        public int Level { get { return level; } }

        public void NewLevel(Random random)
        {
            level++;
            switch(level)
            {
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
            }
        }
        //---------------랜덤 스폰---------------
        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10, boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

       // -------------- 전투 --------------

        public void GiveDamageToPlayer(int maxDamage,Random random)
        {
            Player.Hit(maxDamage, random);
        }

        public void Attack(Direction direction, Random random)
        {
            Player.Attack(direction, random);

        }


    }
}
