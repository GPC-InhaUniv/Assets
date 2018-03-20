using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuestGameCreate.Model
{
    abstract class Weapon : Util.Mover
    {
        protected Controller.Game game;
        private bool pickedUp;

        // 플레이어가 주운 무기의 pickedUp 값은 true가 되며
        // 그 무기는 화면에 표시되면 안됩니다.
        // 폼에서 그 사실을 알아낼 수 있으려면 공개된 읽기 전용 속성이 필요.

        public bool PickedUp { get { return pickedUp; } }
        private Point location;
        public Point Location { get { return location; } }

        // 생성자에서 game 필드와 location 필드를 설정하고
        // pickeUp 값을 false로 설정합니다.(처음 생성될 당시에는 바닥에 놓여있어야 하기 때문입니다.)

        public Weapon(Controller.Game game, Point location)
            :base(game,location)
        {
            this.game = game;
            this.location = location;
            pickedUp = false;
        }

        public void PickedUpWeapon()
        {
            pickedUp = true;
        }

        public abstract string Name { get; }

        // 무기마다 사정거리와 공격 유형이 다르므로 무기마다 Attack() 메소드 구현법이 다릅니다.
        public abstract void Attack(Util.Mover.Direction direction, Random random);

       /* protected bool DamegeEnemy(Util.Mover.Direction direction, int radius, int damege, Random random)
        {
            Point target = game.PlayerLocation;
            for(int distance=0; distance<radius; distance++)
            {
                foreach(Enemy enemy in game.Enemies)
                {
                    if(Util.Mover.Nearby(enemy.Location,target,game.Boundaries))
                    {
                        enemy.EnemyDamege(damege, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }*/
    }
}
