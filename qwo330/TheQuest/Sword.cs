using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    /*
     * 정면 > 시계방향 > 반시계방향 순으로 공격 체크
     * 공격반경 10
     * 데미지 3
     */
    class Sword : Weapon
    {
        private int attackRange = 40; // size + 10
        private int damage = 3;
        
            public Sword(Game game, Point location)
            : base(game, location) { }

        public override string Name { get { return "Sword"; } }
        public override void Attack(Direction dir, Random random, Form1 form)
        {
            showAttackRange(dir, form);

            if (DamageEnemy(dir, attackRange, damage, random)) return;
            else if (DamageEnemy(dir + 1, attackRange, damage, random)) return;
            else if (DamageEnemy(dir - 1, attackRange, damage, random)) return;

        }

        public override void showAttackRange(Direction dir, Form1 form)
        {
            drawAttackRange(dir, attackRange, form);
            drawAttackRange(dir + 1, attackRange, form);
            drawAttackRange(dir - 1, attackRange, form);
            System.Threading.Thread.Sleep(150);
            form.Refresh();
        }

        
    }
}
