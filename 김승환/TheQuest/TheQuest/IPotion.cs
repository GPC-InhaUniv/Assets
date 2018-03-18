using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    public interface IPotion
    {
        bool Used { get; }
    }

    public class RedPotion : Weapon, IPotion
    {
        public override string Name
        {
            get => "Red Potion";
        }

        public RedPotion(Game game, Point location) : base(game, location)
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
            if(used == false)
            {
                game.IncreasePlayerHealth(10, random);
                used = true;
            }
        }
       
    }

    public class BluePotion : Weapon, IPotion
    {
        public override string Name
        {
            get => "Blue Potion";
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
