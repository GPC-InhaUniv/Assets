using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hfcs_Lab2_QuestGame
{
    class Bat : Enemy
    {
        public Bat(PictureBox imageLocation, Game game, int hp, int moveInterval, string name) : base(game, hp, imageLocation, name)
        {
            this.moveInterval = moveInterval;
            enemyName = name;
        }
        private int maxDamage = 2;
        

        public override void Move()
        {
            Point MovePos = Location;
            switch (FindPlayerDiretion(game.PlayerLocation))
            {
                case Direction.Up:
                    if (Location.Y - moveInterval > game.Boundaries.Top) { MovePos.Y -= moveInterval; }
                    break;
                case Direction.Down:
                    if (MovePos.Y + moveInterval < game.Boundaries.Bottom) { MovePos.Y += moveInterval; }
                    break;
                case Direction.Left:
                    if (MovePos.X - moveInterval > game.Boundaries.Left) { MovePos.X -= moveInterval; }
                    break;
                case Direction.Right:
                    if (MovePos.X + moveInterval < game.Boundaries.Right) { MovePos.X += moveInterval; }
                    break;
            }
            Location = MovePos;

            imageLocation.Location = Location;

            if(NearBy(game.PlayerLocation, 10))
            {
                game.HitPlayer(maxDamage, game.random);
            }
        }
    }
}
