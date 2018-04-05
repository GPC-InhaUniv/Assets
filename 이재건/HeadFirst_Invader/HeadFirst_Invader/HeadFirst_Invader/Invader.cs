using System.Collections.Generic;
using System.Drawing;

namespace HeadFirst_Invader
{
    class Invader : Objects
    {
        private const int HorizontalInterval = 10;
        private const int VerticalInterval = 20;

        private InvaderType invaderType;
        public InvaderType InvdaerType { get { return invaderType; } }

        private int score;
        public int Score { get { return score; } }

        public Rectangle CollsionRect { get { return collisionRect; } }
        public Point Location { get { return location; } }
        public bool ShowInvaderScore = true;


        private const int MaxAnimationCount = 4;

        public int CurrentImagePostion = 0;
        List<Image> InvaderImageList;

      

        public Invader(InvaderType invaderType, Point location, int score)
        {
            this.invaderType = invaderType;
            this.location = location;
            this.score = score;

            InvaderImageList = new List<Image>();

            size.Width = 50;
            size.Height = 50;
            collisionRect.Width = 50;
            collisionRect.Height = 50;

            string path = "";
            if (invaderType == InvaderType.Star)
            {
                for (int i = 0; i < MaxAnimationCount; i++)
                {
                    path = @"images\star" + (i + 1) + ".png";
                    InvaderImageList.Add(Image.FromFile(path));
                }

            }
            else if (invaderType == InvaderType.Spaceship)
            {
                for (int i = 0; i < MaxAnimationCount; i++)
                {
                    path = @"images\spaceship" + (i + 1) + ".png";
                    InvaderImageList.Add(Image.FromFile(path));
                }
            }
            else if (invaderType == InvaderType.Saucer)
            {

                for (int i = 0; i < MaxAnimationCount; i++)
                {
                    path = @"images\flyingsaucer" + (i + 1) + ".png";
                    InvaderImageList.Add(Image.FromFile(path));
                }
            }
            else if (invaderType == InvaderType.Bug)
            {
                for (int i = 0; i < MaxAnimationCount; i++)
                {
                    path = @"images\bug" + (i + 1) + ".png";
                    InvaderImageList.Add(Image.FromFile(path));
                }
            }
            else if (invaderType == InvaderType.Satellite)
            {
                for (int i = 0; i < MaxAnimationCount; i++)
                {
                    path = @"images\satellite" + (i + 1) + ".png";
                    InvaderImageList.Add(Image.FromFile(path));
                }
            }

        }



        public override void Draw(Graphics g)
        {
            g.DrawImage(InvaderImageList[CurrentImagePostion], location);
//#if DEBUG
//            g.DrawRectangle(pen, location.X, location.Y, size.Width, size.Height);
//#endif
        }

        public override void Move(Direction direction)
        {
            if (direction == Direction.Left)
            {
                 location.X -= HorizontalInterval;
            }
            else if (direction == Direction.Down)
            {
                location.Y += VerticalInterval;
            }
            else if (direction == Direction.Right)
            {
                 location.X += HorizontalInterval;
            }
           
        }

        public void ResetInvaderPosition(Point location)
        {
            this.location = location;
        }

     
    }
}
