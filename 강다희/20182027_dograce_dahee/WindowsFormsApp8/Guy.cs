using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //아래 RadioButton, Label 같은 경우 폼시스템 형식이므로 system을 사용할 수 있게 써줘야 함.

namespace WindowsFormsApp8
{
    internal class Guy
    {
        public string Name; // 사람 이름 "Joe, Bob, Al"
        public Bet MyBet; // 배팅 내역 저장
        public int Cash; // 갖고 있는 돈

        public RadioButton MyRadioButton; //라디오 버튼
        public Label MyLabel; // 레이블

        public void UpdateLabels()
        {
            MyLabel.Text = Name + "은" + Cash + "원을 걸었다.";
            //레이블에 배팅 내역 표시 : 사람이름(Name) + 갖고 있는 돈(Cash)를 이용해 코드를 짜야하는 거 같은데.. 출력이 안됨.
            //라디오 버튼에 붙일 레이블에 현재 현금 보유액 표시 : 라디오 버튼 우측에 있는 레이블에 대한 내용을 짜야할 거 같은데, 각 이름별로 금액을 지급해줘야하나..
        }

        public void ClearBet()
        {
            //내 bet을 리셋함으로서 bet이 zero가 되게 코드를 작성 : 경주가 끝난 후 배팅에 올려놓은 돈을 다시 0으로 만들어주는 코드인 거 같은데.. 0값이 안 써짐.. MyBet = 0; 이 아닌 거 같음..
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            //새로 배팅을 하고, 배팅 내역 MyBet 필드에 저장하기 (배팅한 내용 bet인스턴스로 표현) : 각 개들의 번호와, 결승점에 도착한 순위를 저장하는 코드를..짜야 할 거 같은데 모르겠음.
            return true; //배팅에 필요한만큼 현금을 보유하고 있으면 true를 반환 : 필요한 만큼 현금을 보유하고 있지 않을경우 false와 함께 메시지가 뜨도록 코드를 짜야할 거 같음..
        }

        public void Collect(int Winner)
        {
            //배팅 결과 처리 : MyBet를 이용해 배팅 내역을 저장한 것을 불러와 맞춘 사람에게 배팅한 만큼의 금액에 + 배팅한 금액(cash + cash ?)을 지급해주는 코드가 필요할 거 같음.
        }
    }
}