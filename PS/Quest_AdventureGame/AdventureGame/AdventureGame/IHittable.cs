using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    interface IHittable
    {
        int HitPoints { get; }

        void Hit(int maxDamage, Random random);

    }
}
