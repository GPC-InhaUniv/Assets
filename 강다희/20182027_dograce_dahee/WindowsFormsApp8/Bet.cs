using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    internal class Bet
    {
        public int Amount; //배팅한 금액
        public int Dognum; //배팅한 개의 번호
        public Guy Bettor; //배팅한 사람에 해당하는 guy 객체 (Joe, Bob, Al)

        public string GetDescription()
        {
            //누가 얼만큼 어떤 개에게 걸었는지 나타내는 문자열 반환 : 배팅한사람이름(Bettor) +"는"+ 개번호(Dognum) + "에" + 건금액(Amount) + "을 걸었다." 라는 코드를 넣어야 할 거 같..음..
            //0이면 배팅을 하지 않았다는 내용의 문자열 반환 : 배팅하기 버튼을 눌렀는데, 금액(amount)가 0일 경우 배팅 불가 메시지가 노출되도록 코드를 짜야하..나?

            return string.Empty; //위의 두 주석에 대한 return값이 두 개가 나와야 할 거 같은데 어떤식으로 넣어야 할지 모르겠음. 메소드가 string이니까 일단 오류가 나지 않게 공백을 넣어줌.
        }

        public int PayOut(int Winner)
        {
            //우승한 개의 번호 매개변수로 전달 : 각 개의 객체 dognum에 1,2,3,4의 번호를 매겨준다는 건지. 잘 모르겠음.
            //배팅한 개가 우승했으면 배팅 액수 반환 : 우승 했을 때, 원래 갖고 있던 Cash값은 건들지 않고 Amount 값만 더해주는 식을..어떻게 넣지?
            //배팅한 개가 우승하지 못했을 경우 배팅 액수 -로 소멸시켜 반환 : 선택한 번호가 아닐 경우, 원래 갖고 있던 Cash 값에서 Amount(배팅한 금액)을 빼주는 식을 ......

            return 0; //위의 두 주석에 대한 return값이 여기도 두 개가 나와야 할 거 같은데 하나는 +, 하나는 - 되는 ...값이 들어갈 거 같은데 어떻게 써야할지 모르겠음..
        }
    }
}