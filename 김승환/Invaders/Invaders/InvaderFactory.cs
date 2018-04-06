using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    public abstract class InvaderFactory
    {
        public static Bitmap getInvaderImage(Type InvaderType, int animationCell)
        {
            switch (InvaderType)
            {
                case Type.Bug:
                    if (animationCell == 0) return Properties.Resources.bug1;
                    else if (animationCell == 1) return Properties.Resources.bug2;
                    else if (animationCell == 2) return Properties.Resources.bug3;
                    else return Properties.Resources.bug4;
                case Type.Satellite:
                    if (animationCell == 0) return Properties.Resources.satellite1;
                    else if (animationCell == 1) return Properties.Resources.satellite2;
                    else if (animationCell == 2) return Properties.Resources.satellite3;
                    else return Properties.Resources.satellite4;
                case Type.Saucer:
                    if (animationCell == 0) return Properties.Resources.flyingsaucer1;
                    else if (animationCell == 1) return Properties.Resources.flyingsaucer2;
                    else if (animationCell == 2) return Properties.Resources.flyingsaucer3;
                    else return Properties.Resources.flyingsaucer4;
                case Type.Spaceship:
                    if (animationCell == 0) return Properties.Resources.spaceship1;
                    else if (animationCell == 1) return Properties.Resources.spaceship2;
                    else if (animationCell == 2) return Properties.Resources.spaceship3;
                    else return Properties.Resources.spaceship4;
                case Type.Star:
                    if (animationCell == 0) return Properties.Resources.star1;
                    else if (animationCell == 1) return Properties.Resources.star2;
                    else if (animationCell == 2) return Properties.Resources.star3;
                    else return Properties.Resources.star4;
                case Type.Boss:
                    return Properties.Resources.Boss;
                default:
                    return null;
            }
        }
    }
}
