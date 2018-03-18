using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class RedPotion : Weapon, IDrinkable
    {

        private bool potionUsed = false;
        public bool PotionUsed { get { return potionUsed; } }

        public RedPotion(Game game, Point location)
            : base(game, location)
        {
            potionUsed = false;
        }

        
        public override string Name { get { return "RedPotion"; } }


        public override void Attack(MoveDirection direction, Random random)
        {
            switch (direction)
            {
                case MoveDirection.MoveUP:
                    if (!potionUsed)
                    {
                        game.IncreasePlayerHealth(10, random);
                        Used();
                    }
                    break;
                case MoveDirection.MoveDown:
                    if (!potionUsed)
                    {
                        game.IncreasePlayerHealth(10, random);
                        Used();

                    }
                    break;
                case MoveDirection.MoveLeft:
                    if (!potionUsed)
                    {
                        game.IncreasePlayerHealth(10, random);
                        Used();
                    }
                    break;
                case MoveDirection.MoveRight:
                    if (!potionUsed)
                    {
                        game.IncreasePlayerHealth(10, random);
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
