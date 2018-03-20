using System.Drawing;

namespace TheQuest
{
    class Bow:Weapon
    {
        public Bow(Game game, Point location) : base(game, location, WeaponList.Bow.ToString())
        {

        }
    }
}
