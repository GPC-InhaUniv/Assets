using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGame
{
    public partial class Form1 : Form
    {
        public Guy[] guys;
        public Greyhound[] dogs;
        public Bet[] bets;


        public Form1()
        {
            InitializeComponent();
           
            //배열 선언
            guys = new Guy[3] ;
            dogs = new Greyhound[4];
             

            //배열 초기화
            guys[0] = new Guy() {Name= "Joe", Cash = 50, MyBet = null, Buttons= JoeButton, Labels = JoeLabel };
            guys[1] = new Guy() { Name = "Bob", Cash = 70, MyBet = null, Buttons = BobButton, Labels = BobLabel };
            guys[2] = new Guy() { Name = "AI", Cash = 45, MyBet = null, Buttons = AiButton, Labels = AiLabel };

            dogs[0] = new Greyhound() {StartingPosition = 40, MyPictureBox = PBox0, RacetrackLength = 739 };
            dogs[1] = new Greyhound() {StartingPosition = 40, MyPictureBox = PBox1, RacetrackLength = 739 };
            dogs[2] = new Greyhound() {StartingPosition = 40, MyPictureBox = PBox2, RacetrackLength = 739 };
            dogs[3] = new Greyhound() {StartingPosition = 40, MyPictureBox = PBox3, RacetrackLength = 739 };

            //while (!= ) //우승자가 없으면
            //{
            //    for () //경주견별로 순환문을 돌려 우승한 경주견이 없는지 확인
            //    {

            //    }
            //    //한 단계식 전진시킴
            //}

            //if () //내가 건 경주견이 우승했으면
            //{
            //    return Amount;
            //}
            //else  //내가 건 경주견이 졌으면
            //{
            //    return Amount;
            //}
        }
    }
}
