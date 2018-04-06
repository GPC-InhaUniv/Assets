using System;
using System.Collections.Generic;
using System.Drawing;

namespace Invader
{
    public class Game
    {
        private int score = 0;
        private int liveLeft = 2;
        private int wave = 0;
        private int framesSkipped = 0;

        private Rectangle boundaries;
        private Random random;

        private List<Invader> invaders;
        private Direction invaderDirevtion;

        public PlayerShip playership;

        public enum Direction
        {
            Left,
            Right,
            Up,
            Down,
        }

        public void FireShot()
        {
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        //비행기가 Go에서 죽을때마다 이미지가 찌그러지는 걸 나타내기 위해 리사이즈를 만들어는 봤으나

        public void Go()
        {
            if (playership.Alive)
            {
            }
            else
            {
                //player = resizeImage(player, new Size(54, 20));
                //playership에 draw된 이미지를 코드로 어떻게 가져와야 할지 모르겠어...
            }
            //침입자들이 쏜 총알은 위로 발사, 침입자들이 쏜 총알은 아래로 발사... List<Shot>객체를 갖고 Ractangle 밖으로 벗어나면 사라지게 해야겠지만 어떻게 코드를 쓰지..

            //Invader의 Move()함수를 호출해서 침입자들의 위치 파악, 총 발사 여부 확인후 Shot객체 List에 추가해야 할텐데..

            //플레이어가 쏜 Shot 객체가 침입자에게 맞았을 때 List에서 삭제되도록 해야겠지...
            //플레이어가 침입자 Shot에 맞았을 때는 alive false처리하고.. 남은 체력 계산해서 다 잃으면 Gameover이벤트발생하고 종료되게 만들어야 할텐데 코드를 어떻게 쓰는지 ...
        }

        public void MovePlayer(Direction direction)
        {
        }

        public void Draw(Graphics g)
        {
            //PlayerShip.Draw();
        }

        public void Twinkle()
        {
        }

        public event EventHandler GameOver;
    }
}