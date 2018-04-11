using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    class GameOverEventArgs : EventArgs
    {
        int life = 2;

        public int PlayerHit()
        {
            life--;
            return life;
        }

        

    }
}
