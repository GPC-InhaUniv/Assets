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
    abstract class Enemy : Mover
    {
        private int hp;
        public int Hp
        {
            get { return hp; }
        }
        private const int NearPlayerDistance = 75;

        public string enemyName
        {
            get; set;
        }
        public PictureBox enemyimage
        {
            get { return imageLocation; }
            set { imageLocation = value; }
        }

        public Point Location
        {
            get { return imageLocation.Location; }
            set { imageLocation.Location = value; }
        }

        public bool Dead {
            get {
                if (hp <= 0) { return true; }
                else return false;
            }
        }

        public Enemy(Game game, int hp, PictureBox imageLocation, string name) : base(game, imageLocation)
        {
            this.hp = hp;
            enemyName = name;
            this.imageLocation = imageLocation;
        }

        public abstract void Move();

        public void Hit(int maxDamage, Random random)
        {
            hp -= random.Next(1, maxDamage);
        }

        protected bool NearPlayer()
        {
            return (NearBy(game.PlayerLocation, NearPlayerDistance));
        }

        protected Direction FindPlayerDiretion(Point playerPos)
        {
            Direction ToMove;
            if (playerPos.X > Location.X + moveInterval) { ToMove = Direction.Right; }
            else if (playerPos.X < Location.X - moveInterval) { ToMove = Direction.Left; }
            else if (playerPos.Y > Location.Y + moveInterval) { ToMove = Direction.Down; }
            else { ToMove = Direction.Up; }
            return ToMove;
        }

    }
}
