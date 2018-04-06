using System.Drawing;

namespace Invaders
{
    class Shot
    {
        private const int moveInterval = 20;
        private const int width = 3;
        private const int height = 15;

        private Point location;
        public Point Location { get { return location; } private set { location = new Point(value.X + 28, value.Y); } } // 28 : playerSize / 2

        private Direction direction;
        private Rectangle boundaries;

        public void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.Yellow);
            Size size = new Size(width, height);
            Rectangle bullet = new Rectangle(location, size);
            g.FillRectangle(brush, bullet);
        }

        public bool Move()
        {
            if (direction == Direction.Up)
                location.Y -= moveInterval;
            else // Direction.Down
                location.Y += moveInterval;

            // boundary 밖으로 나가면 false 리턴
            if (boundaries.Contains(location.X, location.Y))
                return true;
            return false;
        }

        // 발사한 대상(player 혹은 invader)의 x,y 좌표 정보
        public void ActivateShot(Point location)
        {
            this.Location = location;
        }

        public Shot(Point location, Direction direction, Rectangle boundaries)
        {
            this.Location = location;
            this.direction = direction;
            this.boundaries = boundaries;
        }
    }
}