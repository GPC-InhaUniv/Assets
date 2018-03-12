using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceproblem
{
    class BirthdayParty : Party //비용을 계산하고 장식비를 처리하고 케이크에 들어갈 메시지 글자 수를 확인하는 일을 해야할 것 입니다.
    {
        public int CakeSize;
        
        private void CaluculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }

        private string cakeWrithing = "";
        public string CakeWrithing
        {
            get { return this.cakeWrithing; }
            set
            {
                int maxLength;
                if (CakeSize == 8)
                    maxLength = 16;
                else
                    maxLength = 40;
                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters for a" + CakeSize + "inch cake");
                    if (maxLength > this.cakeWrithing.Length)
                        maxLength = this.cakeWrithing.Length;
                    this.cakeWrithing = cakeWrithing.Substring(0, maxLength);
                }
                else
                    this.cakeWrithing = value;
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)//벌스데이 객체가 초기화시 참가자 수, 장식품 종류, 케이크에 써놓을 글자를 알아야함 
            :base (numberOfPeople,fancyDecorations)
        {//CalculateCost()가 호출될 때 올바른 케이크 비용으로 시작할 수 있음
            CaluculateCakeSize(); // 이 생성자는 케이크에 쓸 글자를 설정하기 위해 set 접근자를 호출, 이 경우 매개변수가 너무길기 때문에 먼저 케이크의 크기를 계산해야 함
            this.CakeWrithing = cakeWriting; // 케이크에 쓸 문구를 저장할 문자열 속성
            CalculateCostOfDecorations(fancyDecorations); //속성들을 설정한 뒤 계산을 수행합니다.
        }

        public override decimal CalculateCost()
        {
            decimal CakeCost;
           
            if (CakeSize == 8)
            {
                CakeCost = 40M + CakeWrithing.Length * 0.25M; //헬씨 옵션 대신 케이크 가격을 추가하는 점을 빼면
            }
            { // calculatecost메소드는 dinnerpatry에서 총비용을 계산하는 메소드와 거의 똑같음
                CakeCost = 75M + CakeWrithing.Length * 0.25M;
                return base.CalculateCost() + CakeCost;//베이스클래에서의 값 즉 12명이 넘은가에 대한 값에다가 케이크값을 더하는겁니다.
            }
      
        }

        private int numberOfPeople;
        public override int NumberOfPeople
        { // 케이크에 들어갈 문구와 관련된 문제를 해결하는데 cakewring set 접근자 뿐만아니라
            get {return numberOfPeople;} //numberofpeople set 접근자에서도 해야할 일 있다.
            set
            {
                numberOfPeople = value;
                CaluculateCakeSize();
                this.CakeWrithing = cakeWrithing; //파티참가자수가 달라질 때마다 cakewrithing set 접근자를 호출해줘야하죠
            } // 사람수가 달라지면 우선 케이크 크기를 다시 계산한 다음 cakewriting set 접근자를 다시 호출해서 케이크에 들어갈 문구
            //길이를 조정해 주게 됩니다. 만약 사람 수가 열 명이었고, 케이크에 들어갈 문구가 36글자였다면, 사람 수가 4명으로 줄 때 
            //케이크가 작아지면서 문구도 잘릴 수 있습니다.
        }
    }
}
