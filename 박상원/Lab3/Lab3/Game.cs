using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Game
    {
        PlayerShip playerShip;
        Stars star;
        List<Shot> playerShot;

        public Rectangle boundaries;
        private PlayerShip.Direction direction;

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries; // Game 에 boundaries 값을 받아와 저장하기 위함
            playerShip = new PlayerShip(this,new Point(boundaries.Left+370,boundaries.Top+700));
            star = new Stars();
            playerShot = new List<Shot>();
            //playerShot.Add(new Shot(playerShip.Location, playerShotDirection, boundaries));
        }

        public void Draw(Graphics g)
        {
            star.Draw(g);
            foreach(Shot shot in playerShot) // 삭제되기 전까지 화면에 플레이어 총알 표시
            {
                shot.PlayerShotDraw(g);
            }
            playerShip.Draw(g);
        }

        public void MovePlayer(PlayerShip.Direction direction)
        {
            playerShip.Move(direction);
        }

        public void FireShot()
        {
            playerShot.Add(new Shot(new Point(playerShip.Location.X+22,playerShip.Location.Y-20), PlayerShip.Direction.Up, boundaries)); // 플레이어 총알 장전
        }

        public void Go()
        {
            for(int i=0; i<playerShot.Count; i++)
            {
                if (playerShot[i].Move(PlayerShip.Direction.Up) == true)
                    playerShot[i].Move(PlayerShip.Direction.Up);
                else if (playerShot[i].Move(PlayerShip.Direction.Up) == false)
                    playerShot.RemoveAt(i);
            }
        }
    }
}
