using System.Drawing;
namespace Invader2
{
    class FlyWeight
    {  
        private Bitmap bitmap;

        public Bitmap InvaderImage(int animationCell,InvaderType Type)
        {
            if (Type == InvaderType.Bug)
            {
                switch (animationCell)
                {
                    case 1:
                        bitmap = Properties.Resources.bug1;
                        return bitmap;

                    case 2:
                        bitmap = Properties.Resources.bug2;
                        return bitmap;

                    case 3:
                        bitmap = Properties.Resources.bug3;
                        return bitmap;

                    case 4:
                        bitmap = Properties.Resources.bug4;
                        return bitmap;
                    default:
                        bitmap = Properties.Resources.bug1;
                        return bitmap;


                }
            }
            else if (Type == InvaderType.Saucer)
            {
                switch (animationCell)
                {
                    case 1:
                        bitmap = Properties.Resources.flyingsaucer1;
                        return bitmap;

                    case 2:
                        bitmap = Properties.Resources.flyingsaucer2;
                        return bitmap;

                    case 3:
                        bitmap = Properties.Resources.flyingsaucer3;
                        return bitmap;

                    case 4:
                        bitmap = Properties.Resources.flyingsaucer4;
                        return bitmap;
                    default:
                        bitmap = Properties.Resources.flyingsaucer1;
                        return bitmap;


                }
            }
            else if (Type == InvaderType.Satellite)
            {
                switch (animationCell)
                {
                    case 1:
                        bitmap = Properties.Resources.satellite1;
                        return bitmap;

                    case 2:
                        bitmap = Properties.Resources.satellite2;
                        return bitmap;

                    case 3:
                        bitmap = Properties.Resources.satellite3;
                        return bitmap;

                    case 4:
                        bitmap = Properties.Resources.satellite4;
                        return bitmap;
                    default:
                        bitmap = Properties.Resources.satellite1;
                        return bitmap;


                }
            }
            else if (Type == InvaderType.Star)
            {
                switch (animationCell)
                {
                    case 1:
                        bitmap = Properties.Resources.star1;
                        return bitmap;

                    case 2:
                        bitmap = Properties.Resources.star2;
                        return bitmap;

                    case 3:
                        bitmap = Properties.Resources.star3;
                        return bitmap;

                    case 4:
                        bitmap = Properties.Resources.star4;
                        return bitmap;
                    default:
                        bitmap = Properties.Resources.star1;
                        return bitmap;


                }
            }
            else if (Type == InvaderType.SpaceShip)
            {
                switch (animationCell)
                {
                    case 1:
                        bitmap = Properties.Resources.spaceship1;
                        return bitmap;

                    case 2:
                        bitmap = Properties.Resources.spaceship2;
                        return bitmap;

                    case 3:
                        bitmap = Properties.Resources.spaceship3;
                        return bitmap;

                    case 4:
                        bitmap = Properties.Resources.spaceship4;
                        return bitmap;
                    default:
                        bitmap = Properties.Resources.spaceship1;
                        return bitmap;


                }
            }
            return bitmap;
        }

        public Bitmap ShotImage(int animationCell)
        {
            switch (animationCell)
            {
                case 1:
                    bitmap = Properties.Resources.Bullet1;
                    return bitmap;
                case 2:
                    bitmap = Properties.Resources.Bullet2;
                    return bitmap;
                default:
                    bitmap = Properties.Resources.Bullet;
                    return bitmap;
            }
        }

        public Bitmap BossImage(int animationCell)
        {
            switch(animationCell)
            {
                case 1:
                    bitmap = Properties.Resources.Boss2;
                    return bitmap;
                case 2:
                    bitmap = Properties.Resources.Boss3;
                    return bitmap;
                default:
                    bitmap = Properties.Resources.Boss1;
                    return bitmap;
            }
        }
    }
}
