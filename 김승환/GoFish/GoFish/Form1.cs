using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Game game;

        private void buttonGameStart_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxMyName.Text))
            {
                MessageBox.Show("이름을 적어주세요", "아직 게임을 시작할 수 없습니다");
                return;
            }
            game = new Game(textBoxMyName.Text, new string[] { "철구", "홍구" }, textBoxGameProgress);
            buttonGameStart.Enabled = false;
            textBoxMyName.Enabled = false;
            buttonAskCard.Enabled = true;
            UpdateForm();
        }

        private void UpdateForm()
        {
            listBoxYourHand.Items.Clear();
            foreach(string cardName in game.GetPlayerCardNames())
            {
                listBoxYourHand.Items.Add(cardName);
            }
            textBoxBooks.Text = game.DescribeBooks();
            textBoxGameProgress.Text += game.DescribePlayerHands();
            textBoxGameProgress.SelectionStart = textBoxGameProgress.Text.Length;
            textBoxGameProgress.ScrollToCaret();
        }

        private void buttonAskCard_Click(object sender, EventArgs e)
        {
            textBoxGameProgress.Text = "";
            if(listBoxYourHand.SelectedIndex < 0)
            {
                MessageBox.Show("카드를 선택해 주세요");
                return;
            }
            if(game.PlayOneRound(listBoxYourHand.SelectedIndex))
            {
                textBoxGameProgress.Text += "우승자는 " + game.GetWinnerName();
                textBoxBooks.Text = game.DescribeBooks();
                buttonAskCard.Enabled = false;
            }
            else
            {
                UpdateForm();
            }
        }
    }
}
