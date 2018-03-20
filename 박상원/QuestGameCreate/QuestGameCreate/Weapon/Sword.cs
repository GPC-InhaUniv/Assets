using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using QuestGameCreate.Util;

namespace QuestGameCreate.Weapon
{
    class Sword : Model.Weapon
    {
        public Sword(Controller.Game game,Point location)
            :base(game,location)
        {

        }


        public override string Name { get { return "Sword"; } }
        public override void Attack(Direction direction, Random random)
        {

        }
    }
}
