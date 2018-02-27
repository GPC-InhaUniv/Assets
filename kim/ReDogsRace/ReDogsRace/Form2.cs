using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReDogsRace
{
    public partial class Form2 : Form
    {
       
        Form1 frm1;
        int Money = 0;
        public Form2()
        {
          //  Form1 forms = new Form1();
            InitializeComponent();
            
        }
        public Form2(Form1 _form)
        {
            InitializeComponent();
            frm1 = _form;
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChargeCashBox();
          
            
        }

        void ChargeCashBox()
        {
            /*TextBox의 Text값은 string이므로 변환이 필요하다. 하지만 리턴되어 
           * 계산되는 값은 Int형이어야 하는데 숫자가 아닌 문자들이 int형으로 변환되면 에러가 발생.
           * 이러한 에러를 try문에서 잡아서 catch문을 실행시킨다.
           * 
           * Convert.ToInt32(string) : 숫자의 지정된 문자열 표현을 해당하는 32비트 부호 있는 정수로 변환합니다.
           * 
          */
            try
            {

                Money = Convert.ToInt32(AccountBox.Text);
                if (Money >= 0)
                {
                    frm1.ChargeCash(Money);
                }
                else
                    MessageBox.Show("Error : 충전 금액이 잘못되었습니다. 양수만 입력해 주세요");

                //현재 폼 닫기
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error : 충전 금액이 잘못되었습니다. 숫자만 입력해 주세요");
                this.Close();
            }
        }
        
    }
}
