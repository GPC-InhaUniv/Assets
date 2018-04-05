using System;
using System.Collections.Generic;
using System.Drawing;
namespace HeadFirst_Invader
{
    class Player : Objects
    {
        private List<Image> playerImageList;
        private int currentImageCount = 0;

        public Point Location { get { return location; } }

        Game game;

        public Player(Game game)
        {
            playerImageList = new List<Image>();

            string path = @"images\player0.png";
            playerImageList.Add(Image.FromFile(path));
            path = @"images\player1.png";
            playerImageList.Add(Image.FromFile(path));
            path = @"images\player2.png";
            playerImageList.Add(Image.FromFile(path));

            location.X = 500;
            location.Y = 500;
            size.Width = 55;
            size.Height = 50;

            if (playerImageList.Count == 0)
            {
                Console.WriteLine("플레이어 이미지 로드 실패");
                return;
            }
            this.game = game;

        }

        public override void Draw(Graphics g)
        {

            g.DrawImage(playerImageList[currentImageCount], location);
            //#if DEBUG
            //            g.DrawRectangle(pen, location.X, location.Y, size.Width, size.Height);
            //#endif

        }

        public override void Move(Direction direction)
        {
            if (direction == Direction.Left)
            {

                if (location.X <= game.Boundaries.Left)
                    location.X = location.X;
                else
                {
                    location.X -= 10;
                }
            }
            else
            {
                if (location.X >= game.Boundaries.Right - size.Width)
                    location.X = location.X;
                else
                {
                    location.X += 10;
                }
            }
            //#if DEBUG
            //            if (direction == Direction.Up)
            //            {
            //                location.Y -= 10;
            //            }
            //#endif
        }

        public void AttackByInvader()
        {
            currentImageCount += 1;
            if (currentImageCount >= 3)
                currentImageCount = 2;
        }

        public void GetHp()
        {
            currentImageCount--;
            if (currentImageCount < 0)
                currentImageCount = 0;
        }

        public void ResetPlayerPosition()
        {
            location.X = 500;
            location.Y = 500;
        }
    }
}
