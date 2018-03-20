using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 실습2_The_Quest
{
    class Game
    {
        private Random randomLocation;
        public List<Monster> Monsters;
        public List<Weapon> Weapons;
        private Player player;
        public Point PlayerLocation
        {
            get { return player.Lcation; }
        }

        public int PlayerLifePoint
        {
            get { return player.LifePoint; }
        }

        private int level = 0;
        public int Level
        {
            get { return level; }
        }

        private Rectangle boundaries;
        public Rectangle Boundaries
        {
            get { return boundaries; }
        }

        public Game(Rectangle rectangle)
        {
            randomLocation = new Random();
            this.boundaries = rectangle;
            player = new Player(new Point(76, 138), this);          // Point는 캐릭터의 시작 위치
            Monsters = new List<Monster>()
            {
                new Bat(new Point(randomLocation.Next(75, 492),randomLocation.Next(56, 205)), this, 1, 5),
                new Ghost(new Point(randomLocation.Next(75, 492), randomLocation.Next(56, 205)), this, 2, 8),
                new Ghoul(new Point(randomLocation.Next(75, 492), randomLocation.Next(56, 205)), this, 3, 10),
            };
            Weapons = new List<Weapon>()
            {
                new Sword(new Point(randomLocation.Next(75, 492), randomLocation.Next(56, 205)), this),
            };
        }

        public void MoveIsAll(Direction direction)
        {
            player.Move(direction);
            foreach (Monster monster in Monsters)
            {
                monster.Move(this.player, this.Boundaries);
            }
        }

        public void PlayerHit()
        {
            this.player.PlayerIsHit(this.Monsters[0]);
        }

        public void CheckedWeapon()
        {

        }
    }
}
