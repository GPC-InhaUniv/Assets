using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Invader_Hwangyunu
{
    enum ShipType
    {
        Star,
        SpaceShip,
        Saucer,
        Bug,
        Satellite,
    }

    class Invader
    {

        private const int HorizontalInterval = 10;
        private const int VerticalInterval = 40;

        private Bitmap image;

        private Point invaderlocation;  //내가 작성
        public Point InvaderLocation { get { return invaderlocation; } }
        public ShipType InvaderType { get; private set; }

        public Rectangle Area
        {
            get
            {
                return new Rectangle(invaderlocation, image.Size);
            }
        }
        public int Score { get; private set; }

        public Invader(ShipType invaderType, Point location , int score)
        {
            this.InvaderType = invaderType;
            this.invaderlocation = location;
            this.Score = score;
            image = InvaderImage(0);
        }

        public Point MoveLocation(Direction direction )
        {
            Point newEnemyLocation = invaderlocation;
            switch (direction)
            {
                case Direction.Right:
                 //   if (newEnemyLocation.X + HorizontalInterval <= boundaries.Right)

                        newEnemyLocation.X += HorizontalInterval;
                    break;
                case Direction.Left:
                 //   if (newEnemyLocation.X - HorizontalInterval >= boundaries.Left)

                        newEnemyLocation.X -= HorizontalInterval;
                    break;
                case Direction.Down:
                    newEnemyLocation.Y += VerticalInterval;
                    break;
                default: break;

                  
            }
            return newEnemyLocation;
        }
        public void Move(Direction direction)
        {
            invaderlocation = MoveLocation(direction);
        }
        
        public void Draw(Graphics g, int animationCell)
        {

            g.DrawImage(InvaderImage(animationCell), Area);
           // InvaderImage(animationCell);
        }
        
        private Bitmap InvaderImage(int animationCell)
        {
            if (InvaderType == ShipType.Star)
            {
                Bitmap[] invaderStar = new Bitmap[4];
                invaderStar[0] = new Bitmap(Properties.Resources.star1);
                invaderStar[1] = new Bitmap(Properties.Resources.star2);
                invaderStar[2] = new Bitmap(Properties.Resources.star3);
                invaderStar[3] = new Bitmap(Properties.Resources.star4);

                return invaderStar[animationCell];
            }
            else if (InvaderType == ShipType.SpaceShip)
            {

                Bitmap[] invaderSpaceShip = new Bitmap[4];
                invaderSpaceShip[0] = new Bitmap(Properties.Resources.spaceship1);
                invaderSpaceShip[1] = new Bitmap(Properties.Resources.spaceship2);
                invaderSpaceShip[2] = new Bitmap(Properties.Resources.spaceship3);
                invaderSpaceShip[3] = new Bitmap(Properties.Resources.spaceship4);

                return invaderSpaceShip[animationCell];
            }
            else if (InvaderType == ShipType.Saucer)
            {
                Bitmap[] invaderSaucer = new Bitmap[4];
                invaderSaucer[0] = new Bitmap(Properties.Resources.flyingsaucer1);
                invaderSaucer[1] = new Bitmap(Properties.Resources.flyingsaucer2);
                invaderSaucer[2] = new Bitmap(Properties.Resources.flyingsaucer3);
                invaderSaucer[3] = new Bitmap(Properties.Resources.flyingsaucer4);

                return invaderSaucer[animationCell];
            }
            else if (InvaderType == ShipType.Bug)
            {
                Bitmap[] invaderBug = new Bitmap[4];
                invaderBug[0] = new Bitmap(Properties.Resources.bug1);
                invaderBug[1] = new Bitmap(Properties.Resources.bug2);
                invaderBug[2] = new Bitmap(Properties.Resources.bug3);
                invaderBug[3] = new Bitmap(Properties.Resources.bug4);

                return invaderBug[animationCell];
            }
            else
            {
                Bitmap[] invaderSatellite = new Bitmap[4];
                invaderSatellite[0] = new Bitmap(Properties.Resources.satellite1);
                invaderSatellite[1] = new Bitmap(Properties.Resources.satellite2);
                invaderSatellite[2] = new Bitmap(Properties.Resources.satellite3);
                invaderSatellite[3] = new Bitmap(Properties.Resources.satellite4);
                return invaderSatellite[animationCell];

            }


        }
    }
}
