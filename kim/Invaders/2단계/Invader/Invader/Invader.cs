using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Invader
{
    class Invader
    {
        private const int HorizontalInterval = 50;
        private const int VerticalInterval = 40;
        public Point Location;
        public Type InvaderType;
        public Rectangle Area;
       
        protected int score;
      
        private Bitmap image;
        public Invader(Point location)
        {
            this.Location = location;
            
            Area.Location = location;  
        }

        public virtual void Draw(Graphics g,int animationCell)
        {
            image = InvaderImage(animationCell);
            g.DrawImage(image, Location);
            Area = new Rectangle(Location, image.Size);
        }
        private Bitmap InvaderImage(int animationCell)
        {
            Bitmap bitmap;
            switch(animationCell)
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

        public void Move(Direction direction)
        {
            switch(direction)
            {
                case Direction.Right:
                    this.Location.X += HorizontalInterval;
                    break;
                case Direction.Left:
                    this.Location.X -= HorizontalInterval;
                    break;
            }
        }

        public void MoveDown()
        {
            this.Location.Y += VerticalInterval;
        }
        
    }
}
