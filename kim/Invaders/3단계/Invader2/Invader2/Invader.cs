using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Invader2
{
    public enum InvaderType 
    {
        Star,
        SpaceShip,
        Saucer,
        Bug,
        Satellite,
    }
    class Invader
    {
        private const int HorizontalInterval = 50;
        private const int VerticalInterval = 40;

        private Point location;
        public Point Location { get { return location; } }
        private InvaderType type;
        public InvaderType Type { get { return type; } }
        public Rectangle Area;
        //private Bitmap Image;
        private Game game;
        public int AttackFlag=0;
        private int score;
        public int Score { get { return score; } }

        public Invader(Point Location,InvaderType Type ,Game Game,int AttackFlag)
        {
            location = Location;
            type = Type;
            game = Game;
            this.AttackFlag = AttackFlag;
           
            //Image = game.ImageStorage.InvaderImage(0, Type);
            //Area = new Rectangle(this.Location, Image.Size);
            Area = new Rectangle(this.Location, game.ImageStorage.InvaderImage(0, Type).Size);
            MatchingScore();
        }

        public void Draw(Graphics g, int AnimationChell)
        {
            //Image = game.ImageStorage.InvaderImage(AnimationChell, this.Type);
            g.DrawImage(game.ImageStorage.InvaderImage(AnimationChell, Type), Location);
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Right:
                    location.X += HorizontalInterval;

                    break;
                case Direction.Left:
                    location.X -= HorizontalInterval;
                    break;
            }
            Area.Location = Location;
        }

        public void MoveDown()
        {
            location.Y += VerticalInterval;
            Area.Location = Location;
        }

        public int  First(int min)
        {
            if (location.Y > min)
                return location.Y;
            else
                return min;
        }

        private void MatchingScore()
        {
            switch(type)
            {
                case InvaderType.Star:
                    score = 10;
                    break;
                case InvaderType.SpaceShip:
                    score = 20;
                    break;
                case InvaderType.Saucer:
                    score = 30;
                    break;
                case InvaderType.Bug:
                    score = 40;
                    break;
                case InvaderType.Satellite:
                    score = 50;
                    break;
            }
        }
      
    }
}
