using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location)
            : base(game, location)
        {

        }

        public override string Name { get { return "Sword"; } }
        public override void Attack(MoveDirection direction, Random random)
        {
            switch (direction)
            {

                case MoveDirection.MoveUP:

                    DamageEnemy(direction, 30, 3, random);
                    
                    if (!DamageEnemy(direction, 30, 3, random))
                    {
                        DamageEnemy(direction + 2, 30, 3, random);
                    }
                    if (!DamageEnemy(direction + 2, 30, 3, random))
                    {
                        DamageEnemy(direction + 3, 30, 3, random);

                    }
                                       



                    break;

                case MoveDirection.MoveDown: 

                    DamageEnemy(direction, 30, 3, random);

                    if (!DamageEnemy(direction, 30, 3, random))
                    {
                        DamageEnemy(direction + 1, 30, 3, random);
                    }
                    if (!DamageEnemy(direction + 1, 30, 3, random))
                    {
                        DamageEnemy(direction + 2, 30, 3, random);

                    }
                    break;

                case MoveDirection.MoveLeft:
                    DamageEnemy(direction, 30, 3, random);

                    if (!DamageEnemy(direction, 30, 3, random))
                    {
                        DamageEnemy(direction - 2, 30, 3, random);
                    }
                    if (!DamageEnemy(direction - 2, 30, 3, random))
                    {
                        DamageEnemy(direction - 1, 30, 3, random);

                    }
                    break;

                case MoveDirection.MoveRight:
                    DamageEnemy(direction, 30, 3, random);
                    if (!DamageEnemy(direction, 30, 3, random))
                    {
                        DamageEnemy(direction - 2, 30, 3, random);
                    }
                    if (!DamageEnemy(direction - 2, 30, 3, random))
                    {
                        DamageEnemy(direction - 3, 30, 3, random);

                    }
                    break;

                default: break;
            }
        }
    }

    class Bow : Weapon
    {
        public Bow(Game game, Point location) 
            : base(game, location)
        {
        }
        public override string Name { get { return "Bow"; } }
        public override void Attack(MoveDirection direction, Random random)
        {
            switch(direction)
            {
                case MoveDirection.MoveUP:
                    DamageEnemy(direction, 60, 1, random);
                    break;
                case MoveDirection.MoveDown:
                    DamageEnemy(direction, 60, 1, random);

                    break;
                case MoveDirection.MoveLeft:
                    DamageEnemy(direction, 60, 1, random);

                    break;
                case MoveDirection.MoveRight:
                    DamageEnemy(direction, 60, 1, random);

                    break;
                default: break;
            }
        }
    }
    class Mace : Weapon
    {
        public Mace(Game game, Point location)
            : base(game, location)
        {
        }
        public override string Name { get { return "Mace"; } }
        public override void Attack(MoveDirection direction, Random random)
        {
            switch (direction)
            {
                case MoveDirection.MoveUP:
                    DamageEnemy(direction, 18, 6, random);
                    DamageEnemy(direction+1, 20, 6, random);
                    DamageEnemy(direction+2, 20, 6, random);
                    DamageEnemy(direction+3, 20, 6, random);

                    break;
                case MoveDirection.MoveDown:
                    DamageEnemy(direction, 18, 6, random);
                    DamageEnemy(direction + 1, 20, 6, random);
                    DamageEnemy(direction + 2, 20, 6, random);
                    DamageEnemy(direction -1, 20, 6, random);
                    break;
                case MoveDirection.MoveLeft:
                    DamageEnemy(direction, 18, 6, random);
                    DamageEnemy(direction + 1, 20, 6, random);
                    DamageEnemy(direction - 1, 20, 6, random);
                    DamageEnemy(direction - 2, 20, 6, random);
                    break;
                case MoveDirection.MoveRight:
                    DamageEnemy(direction, 18, 6, random);
                    DamageEnemy(direction - 1, 20, 6, random);
                    DamageEnemy(direction - 2, 20, 6, random);
                    DamageEnemy(direction - 3, 20, 6, random);

                    break;
                default: break;
            }
        }
    }

    class Bomb : Weapon
    {
        public Bomb(Game game, Point location) 
            : base(game, location)
        {
        }

        public override string Name { get { return "Bomb"; } }
        public override void Attack(MoveDirection direction, Random random)
        {
            switch (direction)
            {
                case MoveDirection.MoveUP:
                    DamageEnemy(direction, 300, 20, random);
                    break;
                case MoveDirection.MoveDown:
                    DamageEnemy(direction, 300, 20, random);

                    break;
                case MoveDirection.MoveLeft:
                    DamageEnemy(direction, 300, 20, random);

                    break;
                case MoveDirection.MoveRight:
                    DamageEnemy(direction, 300, 20, random);
                    break;
                default: break;
            }

        }
    }
}
