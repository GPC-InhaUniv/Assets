using System;
using System.Collections.Generic;
using System.Drawing;


namespace HeadFirst_Invader
{
    class Game
    {
        private int score = 0;
        public int Score { get { return score; } }

        private int currentStage = 1;
        public int CurrentStage { get { return currentStage; } }

        private int liveLeft = 2;
        public int LiveLeft { get { return liveLeft; } }

        private int nextInvadeLine = 5;

        private int framesSkipped = 0;
        public int FramesSkipped { get { return framesSkipped; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }
        private Random random;

        private Direction invaderDirection;
        private List<Invader> invaders;

        private Player player;
        public Player Player { get { return player; } }

        private List<Shot> playerShots;
        private List<Shot> invaderShots;

        private int playerCurrentShotCount = 0;
        private int playerMaxShotCount = 2;
        private int invaderCurrentShotCount = 0;

        private List<Items> itemlist;

        private Stars star;
        private PlayerHp playerhp;

        private List<Invader> invaderScoreLabelList;
        public List<Invader> InvaderScoreLabelList { get { return invaderScoreLabelList; } }

        public bool ShockWave = false;
        public bool KillInvader = false;



        public Game(Rectangle windowSize)
        {
            boundaries = new Rectangle(0, 0, windowSize.Width, windowSize.Height);

            invaderDirection = Direction.Left;

            framesSkipped = 5;

            invaders = new List<Invader>();
            random = new Random();
            player = new Player(this);
            playerhp = new PlayerHp(this);
            invaderScoreLabelList = new List<Invader>();
            itemlist = new List<Items>();


            playerShots = new List<Shot>();
            invaderShots = new List<Shot>();

            star = new Stars(random, boundaries);


            //팩토리 메소드 패턴 이용
            MakeInvaders();

            playerShots.Add(new Shot(player.GetType(), this));
            playerShots.Add(new Shot(player.GetType(), this));

            invaderShots.Add(new Shot(typeof(InvaderType), this));

            itemlist.Add(new Items(ItemType.HpPortion, this));
            itemlist.Add(new Items(ItemType.BulletPortion, this));

        }


        //팩토리 메서드 패턴 인베이더 생성
        public void MakeInvaders()
        {
            for (int i = 0; i < 5; i++)
            {
                invaders.Add(InvaderFactory.MakeInvader(InvaderType.Star));
            }
            for (int i = 0; i < 5; i++)
            {
                invaders.Add(InvaderFactory.MakeInvader(InvaderType.Saucer));
            }
            for (int i = 0; i < 5; i++)
            {
                invaders.Add(InvaderFactory.MakeInvader(InvaderType.Spaceship));
            }
            for (int i = 0; i < 5; i++)
            {
                invaders.Add(InvaderFactory.MakeInvader(InvaderType.Bug));

            }
            for (int i = 0; i < 5; i++)
            {

                invaders.Add(InvaderFactory.MakeInvader(InvaderType.Satellite));
            }
        }
        //인베이더 생성 끝


        public void Draw(Graphics g)
        {
            //플레이어 그리기
            if (player.Alive)
            {
                player.Draw(g);
                for (int i = 0; i < playerShots.Count; i++)
                {
                    if (playerShots[i].Alive)
                        playerShots[i].Draw(g);
                }
                playerhp.Draw(g);
            }
            //인베이더 그리기
            for (int i = 0; i < invaders.Count; i++)
            {
                if (invaders[i].Alive)
                    invaders[i].Draw(g);

            }

            //인베이더 총알그리기
            for (int i = 0; i < invaderShots.Count; i++)
            {
                if (invaderShots[i].Alive)
                    invaderShots[i].Draw(g);
            }

            //아이템 드롭시 아이템 그리기
            for (int i = 0; i < itemlist.Count; i++)
            {
                if (itemlist[i].Alive)
                    itemlist[i].Draw(g);
            }

            star.Draw(g);
        }



        public void MovePlayer(Direction direction)
        {
            if (player.Alive)
                player.Move(direction);
        }

        public void PlayerAndInvaderCollisionCheck()
        {
            //플레이어와 인베이더 충돌 처리 설정
            for (int i = 0; i < invaders.Count; i++)
            {
                if (invaders[i].Alive)
                {
                    if ((invaders[i].GetPoint().X <= player.GetPoint().X + 30) && (invaders[i].GetPoint().X >= player.GetPoint().X - 30) &&
                        (invaders[i].GetPoint().Y <= player.GetPoint().Y + 30) && (invaders[i].GetPoint().Y >= player.GetPoint().Y - 30))
                    {
                        liveLeft--;
                        ShockWave = true;
                        player.AttackByInvader();

                        invaders[i].Alive = false;


                    }
                }
            }
            //플레이어와 인베이더 충돌 처리 끝
        }

        public void PlayerBulletCollisionCheck()
        {

            //미사일 충돌 이벤트
            for (int i = 0; i < playerShots.Count; i++)
            {
                if (playerShots[i].Alive)
                {
                    playerShots[i].Move(Direction.Up);
                    if (playerShots[i].CheckBulletPosition())
                    {
                        playerShots[i].Alive = false;
                        playerCurrentShotCount--;
                        if (playerCurrentShotCount < 0)
                            playerCurrentShotCount = 0;
                    }

                    for (int j = 0; j < invaders.Count; j++)
                    {
                        if (invaders[j].Alive)
                        {
                            if (playerShots[i].CollisionInvader(invaders[j]))
                            {

                                invaders[j].Alive = false;
                                invaders[j].ShowInvaderScore = true;
                                playerShots[i].Alive = false;
                                playerCurrentShotCount--;
                                if (playerCurrentShotCount < 0)
                                    playerCurrentShotCount = 0;

                                invaderScoreLabelList.Add(invaders[j]);  //인베이더 점수 시스템 저장 리스트

                                KillInvader = true;             //타격 시 invader 사망 bool 값 true

                                if (itemlist[0].Alive == false)
                                {
                                    int randomnumber = random.Next(0, 10);
                                    if (randomnumber < 1)
                                    {
                                        itemlist[0].DropItem(invaders[j].Location);
                                    }
                                }
                                else if (itemlist[1].Alive == false)
                                {
                                    int randomnumber = random.Next(0, 10);
                                    if (randomnumber < 2)
                                    {
                                        itemlist[1].DropItem(invaders[j].Location);
                                    }
                                }

                                score += invaders[j].Score;
                            }
                        }
                    }
                }
            }
            ///미사일 충돌 이벤트 종료           
        }

        public void InvaderBulletCollsionCheck()
        {
            //몬스터 총알과 캐릭터  충돌 이벤트
            for (int i = 0; i < invaderShots.Count; i++)
            {
                if (invaderShots[i].Alive == true)
                {
                    invaderShots[i].Move(Direction.Down);
                    if (invaderShots[i].CheckBulletPosition())
                    {
                        invaderShots[i].Alive = false;
                        invaderCurrentShotCount--;

                        if (invaderCurrentShotCount < 0)
                            invaderCurrentShotCount = 0;
                    }
                }
            }

            for (int i = 0; i < invaderShots.Count; i++)
            {
                if (invaderShots[i].Alive == true)
                {
                    if (player.Alive && invaderShots[i].CollisionPlayer(player))
                    {
                        invaderCurrentShotCount--;
                        invaderShots[i].Alive = false;
                        if (invaderCurrentShotCount < 0)
                            invaderCurrentShotCount = 0;

                        ShockWave = true;
                        liveLeft--;
                        player.AttackByInvader();


                    }
                }
            }
            //몬스터와 캐릭터 미사일 충돌 이벤트 종료
        }

        public void Go()
        {
            PlayerAndInvaderCollisionCheck();

            PlayerBulletCollisionCheck();

            InvaderBulletCollsionCheck();

            PlayerItemCollsionCheck();
        }

        public void PlayerItemCollsionCheck()
        {
            for (int i = 0; i < itemlist.Count; i++)
            {
                if (itemlist[i].Alive)
                {
                    itemlist[i].GetItem(player);
                }
            }
        }

        //애니메이션 설정
        public void MoveNextImage()
        {
            for (int i = 0; i < invaders.Count; i++)
            {
                if (invaders[i].Alive)
                {
                    invaders[i].CurrentImagePostion++;
                    if (invaders[i].CurrentImagePostion >= 4)
                        invaders[i].CurrentImagePostion = 0;

                }
            }
        }
        //애니메이션 설정 끝


        //인베이더 움직임 설정
        public void MoveInvaders()
        {
            //몬스터 이동
            for (int i = 0; i < invaders.Count; i++)
            {
                if (invaders[i].Alive)
                    invaders[i].Move(invaderDirection);
            }
            for (int i = 0; i < invaders.Count; i++)
            {
                if (invaderDirection == Direction.Left && invaders[i].Location.X <= boundaries.Left)
                {
                    invaderDirection = Direction.Down;
                    break;
                }
                else if (invaderDirection == Direction.Down && invaders[i].Location.X <= boundaries.Left)
                {
                    invaderDirection = Direction.Right;
                    break;
                }

                else if (invaderDirection == Direction.Right && invaders[i].Location.X >= boundaries.Right - 50)
                {
                    invaderDirection = Direction.Down;
                    break;
                }
                else if (invaderDirection == Direction.Down && invaders[i].Location.X >= boundaries.Right - 50)

                {
                    invaderDirection = Direction.Left;
                    break;
                }
            }

        }

        //인베이더 움직임 설정 끝

        public void MoveItems()
        {
            for (int i = 0; i < itemlist.Count; i++)
            {
                if (itemlist[i].Alive)
                    itemlist[i].Move(Direction.Down);
            }
        }


        //플레이어 총알 발사 설정
        public void PlayerShot(Point playerLocation)
        {
            if (playerCurrentShotCount < playerMaxShotCount && playerShots[playerCurrentShotCount].Alive == false)
            {
                playerShots[playerCurrentShotCount].SetBulletLocation(player.Location);
                playerShots[playerCurrentShotCount].Alive = true;
                playerCurrentShotCount++;
            }
        }
        //플레이어 총알 발사 설정 끝

        //반짝반짝 별
        public void Twinkle()
        {
            star.AddandDelete(random, boundaries);

        }

        //인베이더 총알 발사 이벤트
        public void InvaderShot()
        {
            if (invaderCurrentShotCount >= invaderShots.Count)
                return;

            if (invaderCurrentShotCount < Shot.MaxInvaderBullet && invaderShots[invaderCurrentShotCount].Alive == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (invaders[i].Alive)
                    {
                        if (random.Next(0, 3) > 1)
                        {
                            invaderShots[invaderCurrentShotCount].SetBulletLocation(invaders[i].Location);
                            invaderShots[invaderCurrentShotCount].Alive = true;
                            invaderCurrentShotCount++;
                        }
                        if (invaderCurrentShotCount >= invaderShots.Count)
                        {
                            invaderCurrentShotCount--;
                            return;
                        }
                    }

                    else if (invaders[i + nextInvadeLine].Alive)
                    {
                        if (random.Next(0, 3) > 1)
                        {
                            invaderShots[invaderCurrentShotCount].SetBulletLocation(invaders[i + nextInvadeLine].Location);
                            invaderShots[invaderCurrentShotCount].Alive = true;
                            invaderCurrentShotCount++;
                            // return;
                        }
                        if (invaderCurrentShotCount >= invaderShots.Count)
                        {
                            invaderCurrentShotCount--;
                            return;
                        }

                    }

                    else if (invaders[i + nextInvadeLine * 2].Alive)
                    {
                        if (random.Next(0, 3) > 1)
                        {
                            invaderShots[invaderCurrentShotCount].SetBulletLocation(invaders[i + nextInvadeLine * 2].Location);
                            invaderShots[invaderCurrentShotCount].Alive = true;
                            invaderCurrentShotCount++;
                            //  return;
                        }
                        if (invaderCurrentShotCount >= invaderShots.Count)
                        {
                            invaderCurrentShotCount--;
                            return;
                        }

                    }
                    else if (invaders[i + nextInvadeLine * 3].Alive)
                    {
                        if (random.Next(0, 3) > 1)
                        {
                            invaderShots[invaderCurrentShotCount].SetBulletLocation(invaders[i + nextInvadeLine * 3].Location);
                            invaderShots[invaderCurrentShotCount].Alive = true;
                            invaderCurrentShotCount++;
                            // return;
                        }
                        if (invaderCurrentShotCount >= invaderShots.Count)
                        {
                            invaderCurrentShotCount--;
                            return;
                        }

                    }

                    else if (invaders[i + nextInvadeLine * 4].Alive)
                    {
                        if (random.Next(0, 3) > 1)
                        {
                            invaderShots[invaderCurrentShotCount].SetBulletLocation(invaders[i + nextInvadeLine * 4].Location);
                            invaderShots[invaderCurrentShotCount].Alive = true;
                            invaderCurrentShotCount++;
                            //   return;
                        }
                        if (invaderCurrentShotCount >= invaderShots.Count)
                        {
                            invaderCurrentShotCount--;
                            return;
                        }

                    }

                }

            }
        }
        //인베이더 총알 발사 이벤트 종료

        //벽에 닿았을시 게임 종료
        public bool InvadersArrivePlayer()
        {
            for (int i = 0; i < invaders.Count; i++)
            {
                if (invaders[i].Alive)
                {
                    if (invaders[i].Location.Y >= player.Location.Y)
                    {
                        liveLeft = 0;
                        return true;
                    }
                }
            }
            return false;
        }

        //벽 닿을시 게임종료 끝


        //invader를 모두 해치울시 stage up 새로운 인베이더 출몰
        public bool KillAllInvdares()
        {
            for (int i = 0; i < invaders.Count; i++)
            {
                if (invaders[i].Alive)
                    return false;
            }
            framesSkipped += currentStage * 5;
            return true;
        }
        //인베이더 검사 종료

        //reset invaders and player function

        public void ResetInvaderAndPlayerPosition()
        {
            currentStage++;
            playerCurrentShotCount = 0;
            invaderCurrentShotCount = 0;

            for (int i = 0; i < playerShots.Count; i++)
            {
                playerShots[i].Alive = false;
            }

            for (int i = 0; i < invaderShots.Count; i++)
            {
                invaderShots[i].Alive = false;
            }
            player.ResetPlayerPosition();

            Point starpos = new Point(200, 250);
            Point spacepos = new Point(200, 100);
            Point saucerpos = new Point(200, 200);
            Point satellitepos = new Point(200, 50);
            Point bugpos = new Point(200, 150);

            int interval = 100;

            for (int i = 0; i < 5; i++)
            {
                invaders[i].Alive = true;
                invaders[i].ResetInvaderPosition(starpos);
                starpos.X += interval;
            }
            for (int i = 5; i < 10; i++)
            {
                invaders[i].Alive = true;
                invaders[i].ResetInvaderPosition(saucerpos);
                saucerpos.X += interval;
            }
            for (int i = 10; i < 15; i++)
            {
                invaders[i].Alive = true;
                invaders[i].ResetInvaderPosition(bugpos);
                bugpos.X += interval;
            }
            for (int i = 15; i < 20; i++)
            {
                invaders[i].Alive = true;
                invaders[i].ResetInvaderPosition(spacepos);
                spacepos.X += interval;
            }
            for (int i = 20; i < 25; i++)
            {
                invaders[i].Alive = true;
                invaders[i].ResetInvaderPosition(satellitepos);
                satellitepos.X += interval;
            }
            invaderShots.Add(new Shot(typeof(InvaderType), this));
            invaderShots.Add(new Shot(typeof(InvaderType), this));
        }

#if DEBUG
        public void AddBullet()
        {
            invaderShots.Add(new Shot(typeof(InvaderType), this));
        }
#endif

        public void GetHpItem()
        {
            if (liveLeft < 3)
                liveLeft++;
        }

        public void GetBulletItem()
        {
            playerMaxShotCount++;
            if (playerMaxShotCount >= 5)
                playerMaxShotCount = 4;
            playerShots.Add(new Shot(player.GetType(), this));

        }
    }
}

