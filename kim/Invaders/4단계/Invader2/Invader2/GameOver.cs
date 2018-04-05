using System;
using System.Drawing;

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
