using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvadersGame
{
    class Game
    {
        private int score = 0;
        private int livesLeft = 2;
        private int wave = 0;
        private int framesSkipped = 0;
        private int animationCell = 0;

        private Rectangle boundaries;       // 사각형의 위치와 크기를 나타내는 네 정수 저장
        private Random random;

        private Direction invaderDirection;
        private List<Invader> invaders;         // invader형의 리스트 선언

        private PlayerShip playerShip;
        private List<Shot> playerShots;
        private List<Shot> invaderShots;

        private Stars stars;

        private Point scoreLocation;       // Point, PointF 구조체. 2차원 평면의 좌표 정의
        private Point livesLocation;
        private Point waveLocation;

        Font messageFont = new Font(FontFamily.GenericMonospace, 50, FontStyle.Bold);        // Font클래스. 글꼴,크기,스타일 정의. messageFont 객체 생성
        Font statsFont = new Font(FontFamily.GenericMonospace, 15);                          // FontStyle 열거형 사용, FontFamily 크기 지정                 

        public event EventHandler GameOver;        // 게임오버 이벤트핸들러 선언

        public Game(Random random, Rectangle boundaries)
        {
            this.boundaries = boundaries;
            this.random = random;
            stars = new Stars(random, boundaries);
            scoreLocation = new Point((boundaries.Left + 5), (boundaries.Top + 5));
            livesLocation = new Point((boundaries.Right - 120), (boundaries.Top + 5));
            waveLocation = new Point((boundaries.Left + 5), (boundaries.Top + 25));
            playerShip = new PlayerShip(boundaries,
                new Point((boundaries.Width / 2), (boundaries.Height - 50)));
            playerShots = new List<Shot>();
            invaderShots = new List<Shot>();
            invaders = new List<Invader>();

            invaders.Add(new Invader(ShipType.Bug, new Point(100, 100), 100));         // ShipType으로 Point에 invader객체를 생성해서 invaders 리스트에 추가
            invaders.Add(new Invader(ShipType.Satellite, new Point(100, 160), 100));
            invaders.Add(new Invader(ShipType.Saucer, new Point(100, 220), 100));
            invaders.Add(new Invader(ShipType.Spaceship, new Point(100, 280), 100));
            invaders.Add(new Invader(ShipType.Star, new Point(100, 340), 100));

            NextWave();         // NextWave메소드 호출. 다음단계로
        }

        public void FireShot()
        {
            throw new NotImplementedException();
        }

        public void Go()
        {
            throw new NotImplementedException();
        }

        public void MovePlayer(Direction direction, bool gameOver)         // 플레이어 움직이는 메소드. 방향과 게임오버여부 매개변수 사용
        {
            if (!gameOver)
            {
                playerShip.Move(direction);
            }
        }

        public void Draw(Graphics g, bool gameOver)        // 그리는 메소드
        {
            stars.Draw(g, animationCell);
            foreach (Invader invader in invaders)           // 인베이더 리스트 그리기
                invader.Draw(g, animationCell);
            playerShip.Draw(g, animationCell);
            foreach (Shot shot in playerShots)
                shot.Draw(g, animationCell);
            foreach (Shot shot in invaderShots)
                shot.Draw(g, animationCell);

            g.DrawString(("Score: " + score.ToString()),            // 글씨 그리기
                statsFont, Brushes.DimGray, scoreLocation);
            g.DrawString(("Lives: " + livesLeft.ToString()),
                statsFont, Brushes.DimGray, livesLocation);
            g.DrawString(("Wave: " + wave.ToString()),
                statsFont, Brushes.DimGray, waveLocation);
            if (gameOver)
            {
                g.DrawString("GAME OVER", messageFont, Brushes.Red,
                    (boundaries.Width / 4), boundaries.Height / 3);
            }
        }

        public void NextWave()        // 다음단계 메소드 
        {
            List<Invader> invaders = new List<Invader>();
        }
    }
}
