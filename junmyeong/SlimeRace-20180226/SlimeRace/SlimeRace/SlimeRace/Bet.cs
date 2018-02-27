using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlimeRace
{
    class Bet
    {
        public int amount;  //베팅한 금액
        public int slime;   //베팅한 슬라임의 번호
        public Guy Bettor;  //베팅한 사람에 해당하는 Guy 객체



        public string GetDescription()          //베팅 내역을 문자열로 반환하는 부분.
        {    
            string result = Bettor.name + "님이 " + slime + "번 슬라임에게 " + amount + " Won을 걸었습니다."; //베팅 내역을 저장할 변수
            return result;                   
        }
        public int PayOut(int Winner, int eventNum)   //경기 결과에 따른 돈 계산하는 부분.
        {
            if (slime == Winner)                //베팅한 개가 우승한 경우
            {
                if (slime == 4)                 //붐슬라임이 우승한 경우
                    amount = amount * 2;        
                if (eventNum == 2)              //타르 슬라임 이벤트 일 경우
                    return amount * 2;          
                else                            //이벤트가 없을경우
                    return amount;
            }
            else                                //베팅한 개가 우승 못 한 경우
            {
                if (eventNum == 2)              //타르 슬라임 이벤트 일 경우
                    return -(amount * 2);
                else if (eventNum == 1)         //럭키 슬라임 이벤트 일 경우
                    return 0;
                else
                    return -amount;              //이벤트가 없을경우
            }
            
        }
    }
}
