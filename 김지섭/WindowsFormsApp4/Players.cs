using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp4
{
    class Players
    {
        public string strName; // 플레이어 이름
        public Bet C_MyBet; // 배팅을 가지는 Bet 클래스의 인스턴스
        public int iCash; // 가지고 있는 현금

        public RadioButton radioButton;
        public Label MyLabel;


        //public Players()
        //{
        //    C_MyBet = new Bet();
        //}

        public void UpdateLabels()
        {
            MyLabel.Text = C_MyBet.GetDescription();
            radioButton.Text = MyLabel.Text;
        }

        public void ClearBet()
        {
            C_MyBet.iAmount = 0;

        }

        public bool PlaceBet(int iAmount, int iDog)
        {
            C_MyBet = new Bet();

            iCash = iAmount;
            C_MyBet.iAmount = iCash;
            C_MyBet.iDog = iDog;

            if (iCash > C_MyBet.iAmount)
            {
                UpdateLabels();



                return true;
            }

            else
                return false;

        }

        public void Collect(int iWinner)
        {
            iCash += C_MyBet.PayOut(iWinner);
            
        }






    }
}
