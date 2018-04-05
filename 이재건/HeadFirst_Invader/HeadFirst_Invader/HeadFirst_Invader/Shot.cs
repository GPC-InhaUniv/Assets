using System;
using System.Drawing;

namespace HeadFirst_Invader
{
    class Shot:Objects
    {
    

        private Brush bulletColor;
        public static int MaxInvaderBullet = 1;
      
        Game game;
        Type type;

        public Shot(Type t,Game game)
        {
            size.Width = 10;
            size.Height = 10;
            type = t;
            if(t==typeof(InvaderType))
            {
                bulletColor = new SolidBrush(Color.Red);
                MaxInvaderBullet++;
            }
            else if(t==typeof(Player))
            {
               
                bulletColor = new SolidBrush(Color.Yellow);

            }
           
            this.game = game;
            Alive = false;
        }

        public void SetBulletLocation(Point p)
        {
            this.location = p;
            this.location.X += 20;
        }



        public bool CheckBulletPosition()
        {
            if (type == typeof(Player))
            {
                if (this.location.Y <= game.Boundaries.Top)
                {
                    return true;
                }
            }
            else
            {
               if(this.location.Y >= game.Boundaries.Bottom)
                    return true;
            }
            return false;
        }

        public bool CollisionInvader(Invader invader)
        {
            if ((this.location.X <= invader.Location.X + collisionRect.Width+25&&this.location.X>=invader.Location.X-collisionRect.Width-10)
                &&(this.location.Y<=invader.Location.Y+collisionRect.Height&&this.location.Y>=invader.Location.Y-collisionRect.Height))
                return true;

            return false;
        }

        public bool CollisionPlayer(Player player)
        {
            if((location.X<=player.Location.X+collisionRect.Width+35&&this.location.X>=player.Location.X-collisionRect.Width-5)
                &&(this.location.Y<=player.Location.Y+collisionRect.Height&&this.location.Y>=player.Location.Y-collisionRect.Height))
                    return true;

            return false;
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(bulletColor,location.X,location.Y,size.Width,size.Height);
        }

        public override void Move(Direction direction)
        {
            if (this.Alive)
            {
                if (direction == Direction.Up)
                {
                    this.location.Y -= 10;
                }
                else if (direction == Direction.Down)
                {
                    this.location.Y += 5;
                }
         
            }
        }
    }
}
