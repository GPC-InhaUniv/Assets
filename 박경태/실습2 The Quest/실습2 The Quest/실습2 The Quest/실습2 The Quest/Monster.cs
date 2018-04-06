using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 실습2_The_Quest
{
    public enum Monsters
    {
        Ghoul,
        Ghost,
        Bat,
    }
    abstract class Monster : Mover
    {
        private int damage;
        public int Damage
        {
            get { return damage; }
        }
        private int lifepoint;
        public int LifePoint
        {
            get { return lifepoint; }
        }
        public Monster(Point location, Game game, int damage, int lifepoint) : base(location, game)
        {
            this.damage = damage;
            this.lifepoint = lifepoint;
        }

        public abstract void Move(Player player, Rectangle rectangle); // 움직임

        /*public void MonsterHit()*/     // 맞았는지
        // 맞았는지

    }
}
