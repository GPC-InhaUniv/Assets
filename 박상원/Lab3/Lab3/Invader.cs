using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Character
{
    class Invader
    {
        public enum ShipType
        {
            bug,
            flyingsaucer,
            satellite,
            spaceship,
            star,
        }
        // Invader 이동을 위한 값
        private const int horizonMove = 10;
        private const int verticalMove = 40;

        private Bitmap image;

        private Point location;
        public Point Location { get { return location; } }

        private ShipType invaderType;
        public ShipType InvaderType { get { return invaderType; } }

    }
}
