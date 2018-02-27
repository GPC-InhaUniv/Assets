using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlimeRace
{
    class Guy
    {
        public string name;   //사람이름
        public Bet MyBet;     //배팅 내역을 저장할 Bet 인스턴스
        public int cash;      //지금 가지고 있는 현금 액수
        public RadioButton MyRadioButton; // 사람 선택을 위한 라디오 버튼
        public Label MyLabel; // 베팅 내역 및 이름을 보여줄 레이블

        public Guy(string name, Bet mybet, int cash, RadioButton myradiobutton, Label mylabel)  
        //객체 생성을 위한 생성자
        {
            this.name = name;
            this.MyBet = mybet;
            this.cash = cash;
            this.MyRadioButton = myradiobutton;
            this.MyLabel = mylabel;
        }

        public void UpdateLabels()     //레이블에 베팅 내역을 표시하고 라디오 버튼에 붙일 레이블에는
                                       //현재 현금 보유액을 표시해 줍니다.
        {
            if (MyBet == null)         //베팅을 하지 않았을 경우
                MyLabel.Text = "이걸 안걸어? 인생 한방 가즈아~!";
            else                       //베팅을 하였을 경우
            {
                String result = "";    //베팅 내역을 저장 할 변수;
                result = MyBet.GetDescription();  //베팅 내역을 불러옴
                MyLabel.Text = result; //레이블에다가 베팅 내역을 표시
            }
            MyRadioButton.Text = name + " (가진돈 : " + cash + "Won)";  
            //라디오 버튼에 이름 및 가진돈 표시
        }

        public void ClearBet()         //판이 끝나고 베팅 내역 초기화
        {
            MyBet = null;
        }
        public bool PlaceBet(int amount, int slime)  //베팅을 했을 때 처리하는 부분
        {
            if (cash - amount >= 0)    //베팅 금액이 가진 금액보다 많지 않을 경우 
            {
                MyBet = new Bet()      //베팅내역을 위한 새로운 객체 생성 
                { amount = amount, slime = slime, Bettor = this };
                return true;           //베팅 성공 결과 리턴
            }
            else                       //베팅 금액이 가진 금액보다 많을 경우 
            {
                MessageBox.Show("돈이 충분하지 않습니다.","베팅실패");  
                return false;          //베팅 실패 결과 리턴
            }         

        } 
        public void Collect(int Winner,int eventNum)     //베팅 결과를 처리하는 부분
        {
            int result = 0;         //결과 값을 받을 변수
            if (MyBet != null)
                result = MyBet.PayOut(Winner, eventNum); //계산 시키는 메소드 실행 후 결과값 가져옴
            cash += result;         //결과 값을 더함
            if (cash < 0)           //캐쉬가 -로 될 경우 0으로 설정
                cash = 0;
            
        }
    }
}
