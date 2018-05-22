using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Invaders
{
    class Bug : Invader
    { 
        private Point location;
        public override Point Location { get { return location; } set { location = value; } }

        public override ShipType InvaderType { get; set; }

        public override int Score { get { return (int)InvaderType; } }

        private InvaderModel model;
        public override Rectangle Area { get { return new Rectangle(location, model.Image.Size); } }

        public Bug(Point location, InvaderModel model, Rectangle boundaries) : base(boundaries)
        {
            InvaderType = ShipType.Bug;
            this.location = location;
            this.model = model;
        }

        public override void Draw(Graphics g, int animationCell)
        {
            model.Draw(g, InvaderType, animationCell, location);
        }

        public override void Move(Direction direction)
        {
            model.Move(direction, location);
        }
    }
}
