using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuestGameCreate.Model
{
    abstract class Enemy : Util.Mover
    {
        private const int NearPlayerDistance = 25; // 가까운 플레이어 거리
        private int hp;
        public int HP { get { return hp; } }

        public bool Dead // 몬스터 사망 여부
        {
            get
            {
                if (hp <= 0)
                    return true;
                else
                    return false;
            }
        }

        public Enemy(Controller.Game game, Point location,int hp) // 몬스터의 Game 클래스에서 호출되어야 하고 좌표를 받아야하고 hp 초기값도 받아온다.
            :base(game,location)
        {
            this.hp = hp;
        }

        public abstract void Move(Random random); // 이 메소드는 서브 클래스에서 구현한다.

        public void EnemyDamege(int maxDamege, Random random) // 몬스터가 입는 랜덤 대미지
        {
            hp -= random.Next(1, maxDamege);
        }

        // Enemy 클래스는 Mover  클래스의 Nearby() 메소드를 물려받는데
        // 이 메소드로 플레이어가 근처에 있는지 확인합니다.

        protected bool NearPlayer() 
        {
            return (Nearby(game.PlayerLocation, NearPlayerDistance));
        }

        // FindPlayerDirection() 메소드에 플레이어의 위치를
        // 집어넣어주면 베이스 클래스의 location 필드로 그 적을
        // 기준으로 한 플레이어의 방향을 파악한 다음 어느 쪽으로 가야
        // 플레이어한테 가까이 갈 수 있는지 알려주는 Direction enum 값을 반환합니다.

        protected Direction FindPlayerDirection(Point playerLocation) 
        {
            Direction EnemyDirectionMove;

            if (playerLocation.X > location.X + 10)
                EnemyDirectionMove = Direction.RIGHT;
            else if (playerLocation.X < location.X - 10)
                EnemyDirectionMove = Direction.LEFT;
            else if (playerLocation.Y > location.Y + 10)
                EnemyDirectionMove = Direction.UP;
            else
                EnemyDirectionMove = Direction.DOWN;
            return EnemyDirectionMove;
        }
    }
}
