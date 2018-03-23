using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest
{
    enum MinionActive
    {
        제자리,
        위쪽이동,
        아래쪽이동,
        왼쪽이동,
        오른쪽이동,
        공격,
    }
    abstract class Minion : Mover
    {
        protected int minionHpPoint;
        public int MinionHpPoint { get { return minionHpPoint; } }
        protected String name;
        protected MinionActive way;
        public String Name { get { return name; } }
        protected Minion(Point location,Game game, int minionHpPoint) : base(game,location)
        {
            this.minionHpPoint = minionHpPoint;
        }

        public abstract void Move(Random random);

        public void MinionHit(int maxDamage, Random random)
        {
            minionHpPoint -= random.Next(1, maxDamage);
        }

        protected void targetPlayerMove(Random random)
        {
            if (location.Y > game.PlayerLocation.Y + 5)           //위쪽으로 이동
            {
                way = MinionActive.위쪽이동;                                          //방향 출력을 위함(위)
                location.Y -= movement;
                if (location.Y < game.Boundaries.Top)
                    location.Y = game.Boundaries.Top;
            }
            else if (location.Y < game.PlayerLocation.Y - 5)      //아래쪽으로 이동
            {
                way = MinionActive.아래쪽이동;                                          //방향 출력을 위함(아래)
                location.Y += movement;
                if (location.Y > game.Boundaries.Bottom)
                    location.Y = game.Boundaries.Bottom;
            }
            else if (location.X > game.PlayerLocation.X + 5)     //왼쪽으로 이동
            {
                way = MinionActive.왼쪽이동;                                          //방향 출력을 위함(왼쪽)
                location.X -= movement;
                if (location.X < game.Boundaries.Left)
                    location.X = game.Boundaries.Left;
            }
            else                                               //오른쪽으로 이동
            {
                way = MinionActive.오른쪽이동;                                          //방향 출력을 위함(오른쪽)
                location.X += movement;
                if (location.X > game.Boundaries.Right)
                    location.X = game.Boundaries.Right;
            }
            if (NearBy(game.PlayerLocation, 30) == true)
            {
                game.MinionAttack(3, random);
                way = MinionActive.공격;
            }
        }

        public override string ToString()
        {
            switch (way)
            {
                case MinionActive.제자리:
                    return name + "이 제자리에 머물렀다..";
                case MinionActive.위쪽이동:
                    return name + "이 위쪽으로 "+ movement +"만큼 이동하였다.";

                case MinionActive.아래쪽이동:
                    return name + "이 아래쪽으로 " + movement + "만큼 이동하였다."; 

                case MinionActive.왼쪽이동:
                    return name + "이 왼쪽으로 " + movement + "만큼 이동하였다."; 

                case MinionActive.오른쪽이동:
                    return name + "이 오른쪽으로 " + movement + "만큼 이동하였다.";
                default :
                    return name + "이 플레이어를 공격하였다.!";
            }

        }




    }
}
