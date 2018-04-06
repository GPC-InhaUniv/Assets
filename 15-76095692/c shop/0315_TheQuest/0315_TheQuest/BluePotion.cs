using System;

using System.Drawing;

namespace _0315_TheQuest
{
    public class BluePotion : Weapon, IPotion
    {
        public override string Name
        {
            get => "P_Blue";
        }

        public BluePotion(Game game, Point location) : base(game, location)
        {
            used = false;
        }

        private bool used;
        public bool Used
        {
            get => used;
            set => used = value;
        }

        public override void Attack(Direction direction, Random random)
        {
            if (used == false)
            {
                game.IncreasePlayerHealth(5, random);
                used = true;
            }
        }

    }
}
