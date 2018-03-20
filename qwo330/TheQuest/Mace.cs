using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    /*
     * 4방향 전체공격
     * 공격범위 20
     * 데미지 6
     */
    class Mace : Weapon
    {
        private int attackRange = 50; // size + 20
        private int damage = 6;

        public Mace(Game game, Point location)
            : base(game, location) { }

        public override string Name { get { return "Mace"; } }
        public override void Attack(Direction dir, Random random, Form1 form)
        {
            showAttackRange(dir, form);

            if(DamageEnemy(dir, attackRange, damage, random)) return;
            if (DamageEnemy(dir + 1, attackRange, damage, random)) return;
            if (DamageEnemy(dir + 2, attackRange, damage, random)) return;
            if (DamageEnemy(dir - 2, attackRange, damage, random)) return;
        }

        public override void showAttackRange(Direction dir, Form1 form)
        {
            drawAttackRange(dir, attackRange, form);
            drawAttackRange(dir + 1, attackRange, form);
            drawAttackRange(dir + 2, attackRange, form);
            drawAttackRange(dir - 2, attackRange, form);
            System.Threading.Thread.Sleep(150);
            form.Refresh();
        }
    }
}
