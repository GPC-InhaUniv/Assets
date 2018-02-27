using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Bet
    {
        public int iAmount; // 배팅된 총 금액
        public int iDog; // 배팅된 dog의 숫자
        public Players C_Bettor; // 배팅한 플레이어

        //public Bet()
        //{
           
        //}

        public string GetDescription()
        {
            C_Bettor = new Players();

            if (iAmount == 0)
            {
                return C_Bettor.strName + " hasn't placed a bet";
            }
            else
                return C_Bettor.strName + " bets " + iAmount + " a dog " + iDog;
        }

        public int PayOut(int iWinnerDogNumber)
        {
            if(iDog == iWinnerDogNumber)
            {
                return iAmount;
            }
            else
                return iAmount -= iAmount;
        }
    }
}









