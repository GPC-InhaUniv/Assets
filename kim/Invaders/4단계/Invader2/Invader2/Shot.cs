using System.Drawing;
namespace Invader2
{
    class Shot
    {
        private const int MoveInterval = 20;

        private Point location;
        public Point Location { get { return location; }}
        private Direction direction;
        private Rectangle boundaries;
        private int animationCell;
        private Game game;
        public Shot(Point location, Direction direction, Rectangle boundaries, Game game)
        {
            this.location = location;
            this.direction = direction;
            this.boundaries = boundaries;
            this.game = game;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(game.ImageStorage.ShotImage(animationCell), location);
        }
        public bool Move(int animationCell)
        {
            this.animationCell = animationCell;
            switch(direction)
            {
                case Direction.Up:
                    location.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    location.Y += MoveInterval;
                    break;
            }
            if(location.Y <boundaries.Top || location.Y > boundaries.Bottom)
            {
                return false;

            }
            return true;
        }

    }
}

