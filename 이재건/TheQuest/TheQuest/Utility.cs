
using System.Drawing;

namespace TheQuest
{
    enum Direction
    {
        Right,
        Left,
        Up,
        Down,
    }

    enum EnemyList
    {
        Bat,
        Ghost,
        Ghoul,
    }

    enum WeaponList
    {
        Sword,
        Bow,
        Mace,
        RedPortion,
        BluePortion,
    }

    enum PortionList
    {
        bluePortion,
        redPortion,
    }



    struct  Utility
    {
        public const int GHOSTHP = 5;
        public const int GHOULHP = 10;
        public const int BATHP = 3;

        public const int GHOSTAD = 3;
        public const int BATAD = 2;
        public const int GHOULAD = 4;

       
        public static readonly Point SwordInventoryPosition = new Point(89, 318);
        public static readonly Point BowInventoryPosition = new Point(164,318);
        public static readonly Point MaceInventoryPosition = new Point(237,318);
        public static readonly Point BluePortionInventoryPosition = new Point(317,318);
        public static readonly Point RedPortionInventoryPosition = new Point(377, 318);


    }
}
