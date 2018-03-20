using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace TheQuest
{
    class BluePotion : Weapon, IDrinkable
    {


        private bool used;
        public bool Used { get { return used; } }

        public BluePotion(Game game, Point location)
            : base(game, location)
        {
            used = false;
        }

        public override string Name { get { return "BluePotion"; } }

        public override void Attack(MoveDirection direction, Random random)
        {
            switch (direction)
            {
                case MoveDirection.MoveUP:
                    if (!used){
                        game.IncreasePlayerHealth(5, random);
                        used = true;
                    }
                    break;
                case MoveDirection.MoveDown:
                    if (!used){
                        game.IncreasePlayerHealth(5, random);
                        used = true;
                    }
                    break;
                case MoveDirection.MoveLeft:
                    if (!used){
                        game.IncreasePlayerHealth(5, random);
                        used = true;
                    }
                    break;
                case MoveDirection.MoveRight:
                    if (!used){
                        game.IncreasePlayerHealth(5, random);
                        used = true;
                    }
                    break;


            }

        }

    }
}
