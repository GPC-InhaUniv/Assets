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
        public List<Monster> Monsters;
        public List<Weapon> Weapons;
        public Bat bat;
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
            this.boundaries = rectangle;
            player = new Player(new Point(76, 138), this);          // Point는 캐릭터의 시작 위치
            bat = new Bat(new Point(292, 138), this, 5, 6);         // 박쥐 시작위치 292, 138
            //Monsters = new List<Monster>()
            //{
            //    new Bat( {}
            //}
        }

        public void MoveIsAll(Direction direction)
        {
            player.Move(direction);
            bat.Move(this.player, this.Boundaries);
        }

        public void PlayerHit()
        {
            this.player.PlayerIsHit(this.bat);
        }

        public void CheckedWeapon()
        {

        }
    }
}
