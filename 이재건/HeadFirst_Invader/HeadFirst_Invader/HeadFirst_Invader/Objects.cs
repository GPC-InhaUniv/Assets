using System.Drawing;

namespace HeadFirst_Invader
{
    abstract class Objects
    {
        protected Point location;
        protected Rectangle collisionRect;
        protected Size size;
        protected Pen pen = new Pen(Color.Blue);

        public bool Alive = true;
      
        
        abstract public void Draw(Graphics g);
        abstract public void Move(Direction direction);


        public Point GetPoint()
        {
            return this.location;
        }
    }
}
