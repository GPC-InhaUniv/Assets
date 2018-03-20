using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 실습2_The_Quest
{
    class Sword : Weapon
    {
        public Sword(Point location, Game game) : base(location, game, 3, 10)
        {
        }

        public override void Attack(Direction direction)
        {
            int LifePoint = game.bat.LifePoint;
            switch (direction)
            {
                case Direction.Up:
                    if (game.PlayerLocation.Y - game.bat.Lcation.X <= base.Range)
                        LifePoint -= base.Damage;
                    break;
                case Direction.Down:
                    if (game.PlayerLocation.Y - game.bat.Lcation.X >= -base.Range)
                        LifePoint -= base.Damage;
                    break;
                case Direction.Right:
                    if (game.PlayerLocation.X - game.bat.Lcation.X <= base.Range)
                        LifePoint -= base.Damage;
                    break;
                case Direction.Left:
                    if (game.PlayerLocation.X - game.bat.Lcation.X <= base.Range)
                        LifePoint -= base.Damage;
                    break;
            }
        }
    }
}
