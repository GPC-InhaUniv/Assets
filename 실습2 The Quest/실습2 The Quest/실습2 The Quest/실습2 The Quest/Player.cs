using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 실습2_The_Quest
{
    class Player : Mover
    {
        private List<Weapon>inventory =new List<Weapon>();
        public List<string> weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }
        private int lifePoint;          // 생성자로 생성
        public int LifePoint
        {
            get { return LifePoint; }
        }

        public Player(Point location, Game game) : base(location, game)
        {
            lifePoint = 10;
        }

        public void PlayerIsHit(Monster monster)
        {
            lifePoint -= monster.Damage;
        }

        public void Move(Direction direction)
        {
            Move(direction, game.Boundaries);
        }

        //public void Attack(Direction direction)
        //{
        //    if (base.Nearby(game.Monsters[0].Lcation, 10) == true)
        //    {

        //    }
        //}
    }
}
