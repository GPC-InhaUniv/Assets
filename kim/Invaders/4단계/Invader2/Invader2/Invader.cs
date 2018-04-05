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
        
        private Game game;
        private int score;
        public int Score { get { return score; } }

        public Invader(Point location,InvaderType type ,Game game)
        {
            this.location = location;
            this.type = type;
            this.game = game;
            Area = new Rectangle(Location, game.ImageStorage.InvaderImage(0, Type).Size);
            MatchingScore();
        }

        public void Draw(Graphics g, int animationCell)
        {   
            g.DrawImage(game.ImageStorage.InvaderImage(animationCell, Type), Location);
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
