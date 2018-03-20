using System.Drawing;

namespace TheQuest
{
    class Weapon:Mover
    {
        public bool UsePostion=false;

        public Weapon(Game game,Point location,string name):base(game,location)
        {
            this.name = name;
            pickedUp = false;
        }

        private string name;
        public string Name { get { return name;} }

        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }

        public void WeaponPickup(Weapon weapon)
        {
            if (MoveToInventory(weapon))
                pickedUp = true;

        }
     
    }
}
