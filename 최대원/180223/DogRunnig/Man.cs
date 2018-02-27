using System;
using System.Windows.Forms;

namespace DogRunnig
{
    public class Man
    {
        public string Name; //배팅맨 이름
        public Bet Mybet; //배팅 정보 객체
        public int Money; //보유 금액

        public RadioButton RadioButton;
        public Label Label;

        //베팅 현황 업데이트
        public void update()
        {
            RadioButton.Text = Name + "의 보유 금액 : " + Money + "원";
        }

        //베팅하는 함수
        //돈이 부족하면 false
        public bool PlaceBat(int money, int dog)
        {
            if (Money >= money)
            { 
                return true;
            }
            else return false;

        }

        //베팅내역 초기화
        public void CleanBat()
        {
            Mybet.Man = null;
        }

        //상금 땄을때 처리
        public void Collect(int win)
        {
            Money += Mybet.PayOut(win);
        }
    }
}