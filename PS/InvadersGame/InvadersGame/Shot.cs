﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InvadersGame
{
    class Shot
    {
        private const int moveInterval = 20;
        private const int width = 5;
        private const int height = 15;

        public Point Location { get; private set; }

        private Direction direction;
        private Rectangle boundaries;

        public Shot(Point location, Direction direction, Rectangle boundaries)
        {
            this.Location = location;
            this.direction = direction;
            this.boundaries = boundaries;
        }

        public bool Move()
        {
            Point newLocation;
            if (direction == Direction.Down)
            {
                newLocation = new Point(Location.X, (Location.Y + moveInterval));
            }
            else
            {
                newLocation = new Point(Location.X, (Location.Y - moveInterval));
            }
            if ((newLocation.Y < boundaries.Height) && (newLocation.Y > 0))
            {
                Location = newLocation;
                return true;
            }
            else
                return false;
        }

        public void Draw(Graphics g, int animationCell)
        {
            
        }
    }
}
