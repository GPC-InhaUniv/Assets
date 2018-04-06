using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Invader
{
    
    class Invader
    {
        
        private const int HorizontalInterval = 10;
        private const int VerticalInterval = 40;

        private Bitmap image;
        private Bitmap[] imageArray;
        public Point Location { get; private set; }

        public enumShipType InvaderType {get; private set;}
        
        public Rectangle Area
        {
            get
            {
                return new Rectangle(Location, image.Size);
            }
        }
        public int Score { get; private set; }
        
        public Invader(enumShipType invaderType, Point location, int score)
        {
            this.InvaderType = InvaderType;
            this.Location = location;
            this.Score = score;
        }

        public void Draw(Graphics g, int animationCell)
        {

            Graphics invaderGraphics = g;
            image = imageArray[animationCell];
            g.DrawImage(image, Location);
           
            
        }
        
        public void Move(enumDirection direction)
        {

        }
        private void creatShipTypeArray()
        {
            imageArray = new Bitmap[4];
            switch (InvaderType)
            {
                case enumShipType.Bug:
                    imageArray[0] = Properties.Resources.bug1;
                    imageArray[1] = Properties.Resources.bug2;
                    imageArray[2] = Properties.Resources.bug3;
                    imageArray[3] = Properties.Resources.bug4;
                    break;
                case enumShipType.Satellite:
                    imageArray[0] = Properties.Resources.satellite1;
                    imageArray[1] = Properties.Resources.satellite2;
                    imageArray[2] = Properties.Resources.satellite3;
                    imageArray[3] = Properties.Resources.satellite4;
                    break;
                case enumShipType.Saucer:
                    imageArray[0] = Properties.Resources.flyingsaucer1;
                    imageArray[1] = Properties.Resources.flyingsaucer2;
                    imageArray[2] = Properties.Resources.flyingsaucer3;
                    imageArray[3] = Properties.Resources.flyingsaucer4;
                    break;
                case enumShipType.Spaceship:
                    imageArray[0] = Properties.Resources.spaceship1;
                    imageArray[1] = Properties.Resources.spaceship2;
                    imageArray[2] = Properties.Resources.spaceship3;
                    imageArray[3] = Properties.Resources.spaceship4;
                    break;
                case enumShipType.Star:
                    imageArray[0] = Properties.Resources.star1;
                    imageArray[1] = Properties.Resources.star2;
                    imageArray[2] = Properties.Resources.star3;
                    imageArray[3] = Properties.Resources.star4;
                    break;
            }
        }
       
            
    }
}
