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

        private bool potionUsed = false;
        public bool PotionUsed { get { return potionUsed; } }

        public BluePotion(Game game, Point location)
            : base(game, location)
        {
            potionUsed = false;
        }

        public override string Name { get { return "BluePotion"; } }

        public override void Attack(MoveDirection direction, Random random)
        {
            switch (direction)
            {
                case MoveDirection.MoveUP:
                    if (!potionUsed)
                    {
                        game.IncreasePlayerHealth(5, random);
                        Used();
                    }
                    break;
                case MoveDirection.MoveDown:
                    if (!potionUsed)
                    {
                        game.IncreasePlayerHealth(5, random);
                        Used();

                    }
                    break;
                case MoveDirection.MoveLeft:
                    if (!potionUsed)
                    {
                        game.IncreasePlayerHealth(5, random);
                        Used();
                    }
                    break;
                case MoveDirection.MoveRight:
                    if (!potionUsed)
                    {
                        game.IncreasePlayerHealth(5, random);
                        Used();
                    }
                    break;

            }

        }
        public bool Used()
        {
            return potionUsed = true;
        }
    }
}
