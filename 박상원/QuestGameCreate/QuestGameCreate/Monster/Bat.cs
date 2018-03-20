using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuestGameCreate.Monster
{
    class Bat : Model.Enemy
    {
        public Bat(Controller.Game game,Point location)
            : base(game,location,6) // 박쥐의 hp 초기값 6을 베이스 클래스 생성자에 넘겨줘야 함.
        {
            // 생성자 코드 따로 작성할 필요 없음 베이스 클래스에서 처리해줌.
        }

        public override void Move(Random random)
        {
            // 여기에 코드를 넣어주세요.
            // throw new NotImplementedException();
            
            if(HP>=1)
            {
                if(0== random.Next(0,2))
                {

                }
            }
        }
    }
}
