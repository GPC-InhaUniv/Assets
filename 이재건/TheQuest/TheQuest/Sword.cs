using System.Drawing;

namespace TheQuest
{
    class Sword:Weapon
    {
        public Sword(Game game,Point location):base(game,location,WeaponList.Sword.ToString())
        {

        }

        private int maxDamage = 5;
        public int MaxDamage { get { return maxDamage; } }


    }
}
