using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class RedPotion : Weapon , IDrinkable
        {


        private bool used;
        public bool Used { get { return used; } }

        public RedPotion(Game game, Point location)
            : base(game, location)
        {
            used = false;
        }

        
        public override string Name { get { return "RedPotion"; } }


        public override void Attack(MoveDirection direction, Random random)
        {
            switch (direction)
            {
                case MoveDirection.MoveUP:
                    if (!used)
                    {
                        game.IncreasePlayerHealth(10, random);
                        used = true;
                    }
                    break;
                case MoveDirection.MoveDown:
                    if (!used)
                    {
                        game.IncreasePlayerHealth(10, random);
                        used = true;
                    }
                    break;
                case MoveDirection.MoveLeft:
                    if (!used)
                    {
                        game.IncreasePlayerHealth(10, random);
                        used = true;
                    }
                    break;
                case MoveDirection.MoveRight:
                    if (!used)
                    {
                        game.IncreasePlayerHealth(10, random);
                        used = true;
                    }
                    break;

            }

        }

    }
    
}
