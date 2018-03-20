using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    /*
     * 정면
     * 공격반경 30
     * 데미지 1
     */
    class Bow: Weapon
    {
        private int attackRange = 60; // 30 + 30
        private int damage = 1;

        public Bow(Game game, Point location)
            : base(game, location) { }

        public override string Name { get { return "Bow"; } }
        public override void Attack(Direction dir, Random random, Form1 form)
        {
            showAttackRange(dir, form);
            DamageEnemy(dir, attackRange, damage, random);
        }

        public override void showAttackRange(Direction dir, Form1 form)
        {
            drawAttackRange(dir, attackRange, form);
            System.Threading.Thread.Sleep(150);
            form.Refresh();
        }
    }
}
