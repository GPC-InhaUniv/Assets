using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Invaders
{
    enum Direction
    {
        Right,
        Left,
        Up,
        Down
    }

    enum ShipType
    {   // name = score
        Bug = 50,       
        Saucer = 40,    
        Satellite = 30, 
        Spaceship = 20, 
        Star = 10       
    }

    enum Col // y
    {
        First = 250,
        Second = 320,
        Third = 390,
        Forth = 460,
        Fifth = 520
    }

    enum InvaderRow // x
    {
        Bug = 90,       
        Saucer = 150,    
        Satellite = 210, 
        Spaceship = 270, 
        Star = 330       
    }

    class Game
    {
        private const int MaxShot = 3;
        private const int MaxWave = 10;

        //public int Score = 0;
        private int score = 0;
        public int Score {
            get { return score; }
            private set { score = value; } }

        private int livesLeft = 2;
        public int LivesLeft { get { return livesLeft; } private set { if(livesLeft > 0) livesLeft = value; } }

        private int wave = 0;
        public int Wave { get { return wave; } private set { wave = value; } }

        private int framesSkipped = 0;
        private bool lineChange = false;

        private Rectangle boundaries;
        private Random random;

        private Direction invaderDirection;
        private Direction prevDirection;
        private List<Invader> invaders;

        private PlayerShip playerShip;
        private CircleQueue playerShots;
        private CircleQueue invaderShots;

        private Stars stars;

        public event EventHandler GameOver;

        public void Draw(Graphics g, int animationCell)
        {
            playerShip.Draw(g);

            for (int i = 0; i < invaders.Count; i++)
                invaders[i].Draw(g, animationCell);

            for (int i = playerShots.Front; i != playerShots.Rear; i++, i %= playerShots.Size)
                playerShots.GetData(i).Draw(g);
            for (int i = invaderShots.Front; i != invaderShots.Rear; i++, i %= invaderShots.Size)
                invaderShots.GetData(i).Draw(g);

            Twinkle();
        }

        public void MovePlayer(Direction direction)
        {
            //if (playerShip.Alive)
                playerShip.Move(direction);
        }

        // 플레이어의 x,y 좌표 정보
        public void FireShot()
        {
            playerShots.Push(playerShip.Location);
        }

        public void Go()
        {
            InvaderMove();
            ShotCtrl();
            CollideCheck();     
        }

        private void InvaderMove()
        {
            /* ===========  동작 처리  =============== */
            var enemies = from invader in invaders
                          where invader.Location.X <= 10
                          || invader.Location.X >= boundaries.Width
                          select invader;
          
            if (lineChange)
            {
                lineChange = false;
                invaderDirection = (prevDirection == Direction.Left) ? Direction.Right : Direction.Left;
            }
            // 라인을 바꿔야할 때
            else if (enemies.Count() != 0)
            {
                lineChange = true;
                prevDirection = invaderDirection;
                invaderDirection = Direction.Down;
            }

            for (int i = 0; i < invaders.Count; i++)
                invaders[i].Move(invaderDirection);
        }

        private void ShotCtrl()
        {
            /* ===========  Shot 처리  =============== */
            var invaderCols = from invader in invaders
                              group invader by invader.Location.X
                              into invaderCol
                              orderby invaderCol.Key descending
                              select invaderCol;

            int select = random.Next(invaderCols.Count());
            if(invaderCols.Count() != 0)
                 ReturnFire(invaderCols.ElementAt(select).Last(), random);

            // 나중에 CircleQueue에 함수로 구현할 것
            for (int i = playerShots.Front; i != playerShots.Rear; i++, i %= playerShots.Size)
                if (!playerShots.GetData(i).Move()) playerShots.Pop();

            for (int i = invaderShots.Front; i != invaderShots.Rear; i++, i %= invaderShots.Size)
                if (!invaderShots.GetData(i).Move()) invaderShots.Pop();
        }

        private void CollideCheck()
        {
            /* =========== 충돌 처리  =============== */
            for (int i = 0; i < invaders.Count; i++)
            {
                Invader invader = invaders[i];
                for (int j = playerShots.Front; j != playerShots.Rear; j++, j %= playerShots.Size)
                {
                    Shot shot = playerShots.GetData(j);
                    if (invader.Area.Contains(shot.Location))
                    {
                        playerShots.Pop();
                        Score += invader.Score;
                        invaders.Remove(invader);
                        break;
                    }
                }
            }
            if (invaders.Count == 0) NextWave();

            // 플레이어 충돌 처리
            for (int i = invaderShots.Front; i != invaderShots.Rear; i++, i %= invaderShots.Size)
                if (playerShip.Area.Contains(invaderShots.GetData(i).Location))
                {
                    LivesLeft -= 1;
                    invaderShots.Pop();
                }

            var arrivedInvaders = from invader in invaders
                                  where invader.Location.Y >= 500
                                  select invader;

            //if (arrivedInvaders.Count() != 0) GameOver;
        }

        private bool ReturnFire(Invader attacker, Random random)
        {
            if (invaderShots.IsFull()) return false;
            if(random.Next(2) == 0)invaderShots.Push(attacker.Location);
            return true;
        }

        public Game(Rectangle boundaries, Random random)
        {
            this.boundaries = boundaries;
            this.random = random;

            playerShots = new CircleQueue(MaxShot);
            invaderShots = new CircleQueue(MaxWave);

            playerShip = new PlayerShip(new Point(360, 500), boundaries);
            invaders = new List<Invader>();
            CreateInvaders();

            // 미사일 미리 생성해서 숨겨두기
            for (int i = 0; i <= MaxShot; i++)
                playerShots.Insert(new Shot(new Point(-100, -100), Direction.Up, boundaries));
            playerShots.Reset(); // rear를 다시 front 위치로

            for (int i = 0; i <= MaxWave + 3; i++)
                invaderShots.Insert(new Shot(new Point(-100, -100), Direction.Down, boundaries));
            invaderShots.Reset();
        }

        private void CreateInvaders()
        {
            invaders.Add(new Invader(ShipType.Bug, new Point((int)Col.First, (int)InvaderRow.Bug), boundaries));
            invaders.Add(new Invader(ShipType.Bug, new Point((int)Col.Second, (int)InvaderRow.Bug), boundaries));
            invaders.Add(new Invader(ShipType.Bug, new Point((int)Col.Third, (int)InvaderRow.Bug), boundaries));
            invaders.Add(new Invader(ShipType.Bug, new Point((int)Col.Forth, (int)InvaderRow.Bug), boundaries));
            invaders.Add(new Invader(ShipType.Bug, new Point((int)Col.Fifth, (int)InvaderRow.Bug), boundaries));

            invaders.Add(new Invader(ShipType.Saucer, new Point((int)Col.First, (int)InvaderRow.Saucer), boundaries));
            invaders.Add(new Invader(ShipType.Saucer, new Point((int)Col.Second, (int)InvaderRow.Saucer), boundaries));
            invaders.Add(new Invader(ShipType.Saucer, new Point((int)Col.Third, (int)InvaderRow.Saucer), boundaries));
            invaders.Add(new Invader(ShipType.Saucer, new Point((int)Col.Forth, (int)InvaderRow.Saucer), boundaries));
            invaders.Add(new Invader(ShipType.Saucer, new Point((int)Col.Fifth, (int)InvaderRow.Saucer), boundaries));

            invaders.Add(new Invader(ShipType.Satellite, new Point((int)Col.First, (int)InvaderRow.Satellite), boundaries));
            invaders.Add(new Invader(ShipType.Satellite, new Point((int)Col.Second, (int)InvaderRow.Satellite), boundaries));
            invaders.Add(new Invader(ShipType.Satellite, new Point((int)Col.Third, (int)InvaderRow.Satellite), boundaries));
            invaders.Add(new Invader(ShipType.Satellite, new Point((int)Col.Forth, (int)InvaderRow.Satellite), boundaries));
            invaders.Add(new Invader(ShipType.Satellite, new Point((int)Col.Fifth, (int)InvaderRow.Satellite), boundaries));

            invaders.Add(new Invader(ShipType.Spaceship, new Point((int)Col.First, (int)InvaderRow.Spaceship), boundaries));
            invaders.Add(new Invader(ShipType.Spaceship, new Point((int)Col.Second, (int)InvaderRow.Spaceship), boundaries));
            invaders.Add(new Invader(ShipType.Spaceship, new Point((int)Col.Third, (int)InvaderRow.Spaceship), boundaries));
            invaders.Add(new Invader(ShipType.Spaceship, new Point((int)Col.Forth, (int)InvaderRow.Spaceship), boundaries));
            invaders.Add(new Invader(ShipType.Spaceship, new Point((int)Col.Fifth, (int)InvaderRow.Spaceship), boundaries));

            invaders.Add(new Invader(ShipType.Star, new Point((int)Col.First, (int)InvaderRow.Star), boundaries));
            invaders.Add(new Invader(ShipType.Star, new Point((int)Col.Second, (int)InvaderRow.Star), boundaries));
            invaders.Add(new Invader(ShipType.Star, new Point((int)Col.Third, (int)InvaderRow.Star), boundaries));
            invaders.Add(new Invader(ShipType.Star, new Point((int)Col.Forth, (int)InvaderRow.Star), boundaries));
            invaders.Add(new Invader(ShipType.Star, new Point((int)Col.Fifth, (int)InvaderRow.Star), boundaries));
        }

        public void NextWave()
        {
            Wave++;
            CreateInvaders();
            invaderShots.ModifySize(Wave + 3);
        }

        public void Twinkle()
        {

        }
    }
}
