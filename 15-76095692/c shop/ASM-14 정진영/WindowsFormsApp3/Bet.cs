using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Bet
    {
        public int Amount;//배팅한 금액
        public int Dog;//베팅한개의 번화
        public Guy Bettor;//베팅한 사람에 해당되는 Guy객체 아직 빨간불이니 만들러가주자

        /*인스턴스 예재.
        public CoOrds(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        */
        public Bet(int Amount, int Dog, Guy Bettor)
        {
            this.Amount = Amount;
            this.Dog = Dog;
            this.Bettor = Bettor;
        }
        //인스턴스를 만들었으니까 가이로 가봦
        

        public string GetDescription()
        {
            //누가 얼만큼을 어떤 개한테 걸었는지 나타내는 문자열을 반환한다.
            //("Joe Bets 8 on dog#4")
            //베팅금액이 0이면 베팅을 하지 않았다는 내용의 문자열을 반환한다
            //("Joe hasn't placed a bet")
            string textBoxstring = "";

            if (Amount > 0)
            {
                textBoxstring = Bettor.Name+" bets "+Amount+" on dog #"+ Dog;
            }
            else
            {
                textBoxstring = Bettor.Name+"hasn't placed any bets";
            }
            return textBoxstring;
        }

        public int PayOut(int Winner)
        {
            //우승한개의 번호가 매개변수로 전달됩니다.
            //배팅한 개가 우승했으면 베팅 액수를 반환한다.
            //우승하지 못했다면 베팅 액수에 마이너스를 붙여서 반환한다.
            if (Dog == Winner)
            {
                return Amount+Amount;
            }
            return 0;
        }
    }
}
