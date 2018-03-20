using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hfcs_Lab2_QuestGame
{
    class Sword : Weapon
    {

        public Sword(Game game, Point location, Random random) : base(game, location)
        {
            
        }

        public override string Name { get { return "Sword"; } }

        public override void Attack(Direction direction, Random random)
        {
            //switch (direction)
            //{
            //    case Direction.Up:
            //        foreach (Enemy enemy in game.Enemies)
            //        {
            //            if(enemy.enemyimage.Location.X < Location.X)
            //            {
            //                DamageEnemy(direction,10,3,random);
            //            }
            //        }
            //        break;
            //    case Direction.Down:
            //        foreach (Enemy enemy in game.Enemies)
            //        {
            //            if (enemy.enemyimage.Location.X > Location.X)
            //            {
            //                DamageEnemy(direction, 10, 3, random);
            //            }
            //        }
            //        break;
            //    case Direction.Left:
            //        foreach (Enemy enemy in game.Enemies)
            //        {
            //            if (enemy.enemyimage.Location.Y < Location.Y)
            //            {
            //                DamageEnemy(direction, 10, 3, random);
            //            }
            //        }
            //        break;
            //    case Direction.Right:
            //        foreach (Enemy enemy in game.Enemies)
            //        {
            //            if (enemy.enemyimage.Location.Y > Location.Y)
            //            {
            //                DamageEnemy(direction, 10, 3, random);
            //            }
            //        }
            //        break;
            //}
            DamageEnemy(direction, 20, 3, random);
        }

    }
}
