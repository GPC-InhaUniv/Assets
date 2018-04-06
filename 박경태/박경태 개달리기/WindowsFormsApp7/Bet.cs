using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    class Bet
    {
        public int Amount; // 베팅한 금액
        public int DogNumber; // 배팅한 개의 번호
        public Guy Bettor; // 배팅한 사람에 해당하는 Guy 객체

        public string GetDescription()
        {
            // 만약 Amount가 0이면 배팅하지 않는다는 문자열을 반환해주고
            // 아니면 몇번 개에게 얼마를 배팅했다고 문자열을 반환해준다.
            string Label;

            if (Amount == 0)
            {
                Label = "배팅 안함";
            }
            else
            {
                Label = DogNumber + "번 개한테 " + Amount + "달러를 배팅했습니다.";
            }

            return Label;
        }

        // 우승한 개를 맞춘 사람에게 가지고 있는 금액에 배팅금액을 더해주고
        // 그렇지 못한 사람에게는 가지고 있는 돈에서 배팅금액만큼을 빼준다.
        public int PayOut(int WinnerDog)
        {
            if (WinnerDog == DogNumber)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
