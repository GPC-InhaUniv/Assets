using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Shield : Weapon ,IDrinkable
    {
        public Shield(Game game, Point location) : base(game, location)
        {
        }

        public override string Name { get { return "Shield"; } }

        private bool used;
        public bool Used { get { return used; } }

        public override void Attack(MoveDirection direction, Random random)
        {
            switch (direction)
            {
                case MoveDirection.MoveUP:

                    break;
                case MoveDirection.MoveDown:

                    break;
                case MoveDirection.MoveLeft:

                    break;
                case MoveDirection.MoveRight:

                    break;
            }
        }
    }
}
