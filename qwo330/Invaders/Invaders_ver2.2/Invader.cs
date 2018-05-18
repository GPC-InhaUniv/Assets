using System.Drawing;

namespace Invaders
{
    public enum ShipType
    {   // name = score
        Bug = 50,
        Saucer = 40,
        Satellite = 30,
        Spaceship = 20,
        Star = 10
    }

    enum Col // y
    {
        First = -140,
        Second = -70,
        Third = 0,
        Forth = 70,
        Fifth = 140
    }

    enum InvaderRow // x
    {
        Bug = 50,
        Saucer = 110,
        Satellite = 170,
        Spaceship = 230,
        Star = 290
    }

    class Invader
    {
        private static Invader _instance;
        public static Invader GetInstance(Rectangle boundaries)
        {
           if (_instance == null)
               _instance = new Invader(boundaries);
           return _instance;
        }

        //private Point location;
        public virtual Point Location { get; set; }

        //private Rectangle area;
        public virtual Rectangle Area { get; set; }

        public virtual ShipType InvaderType { get; set; }

        public virtual int Score { get; }

        InvaderModel model;


        public Invader(Rectangle boundaries)
        {
            model = new InvaderModel(boundaries);
        }

        public virtual void Draw(Graphics g, int animationCell) { }
        public virtual void Move(Direction direction) { }

        public Invader InvaderFactory(ShipType invaderType, int num)
        {
            //invaders.Add(new Invader(ShipType.Bug, new Point(boundaries.Width / 2 + (int)Col.First, (int)InvaderRow.Bug), boundaries));
            Col col = (Col)(num * 70 - 140);
            int x = 50 + 60 * (((int)(invaderType) / 10) - 1); // 10 ~ 50 // 50, 110, 170, 230, 290 (+60)
            switch (invaderType)
            {
                case ShipType.Bug:
                    return new Bug(new Point(x, model.boundaries.Width / 2 + (int)col), model, model.boundaries);
                case ShipType.Saucer:
                    return new Saucer(new Point(x, model.boundaries.Width / 2 + (int)col), model, model.boundaries);
                case ShipType.Satellite:
                    return new Satellite(new Point(x, model.boundaries.Width / 2 + (int)col), model, model.boundaries);
                case ShipType.Spaceship:
                    return new Spaceship(new Point(x, model.boundaries.Width / 2 + (int)col), model, model.boundaries);
                case ShipType.Star:
                    return new StarInvader(new Point(x, model.boundaries.Width / 2 + (int)col), model, model.boundaries);
                default: return null;
            }
        }
    }
}
