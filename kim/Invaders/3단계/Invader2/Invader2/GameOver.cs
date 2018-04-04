using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invader2
{
    class GameOver : EventArgs
    {

        public int Life { get; private set; }
        public GameOver(int life)
        {
            Life = life;

        }

    }
}
