using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRunnig
{
    public class Bet
    {
        public int Amount; //베팅한 금액
        public int dog; //베팅한 개의 번호
        public Man Man; //베팅한 놈

        //누가 얼만큼 개에게 걸었는지 알려줌
        public string GetDescription()
        {
            if (Amount == 0)
            {
                return Man.Name + "님은 배팅이 불가능합니다.";
            }
            else return Man.Name + "님이 " + Man.Mybet.dog + "번 개에게 " + Man.Mybet.Amount + "원을 걸었습니다.";
        }

        //경기 종료 후 베팅 처리
        //우승한 개의 번호가 매개변수로 전달
        //지정된 개가 이겼으면 상금 액수를 리턴
        //졌으면 마이너스 값으로 리턴
        public int PayOut(int winner)
        {
            if (dog == winner) return Amount;
            else return -Amount;
        }
    }
}
