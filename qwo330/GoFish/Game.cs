using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public string Text;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));

            foreach (string player in opponentNames)
                players.Add(new Player(player, random, textBoxOnForm));
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            // 게임이 시작되는 부분으로 시작될 때 한번만 실행, 스톡 카드를 섞고, 
            //플레이어당 5장의 카드를 나눠주고,
            //foreach문으로 각 플레이어의 pulloutbooks() 호출
            stock.Shuffle();
            for(int i = 0; i < 5; i++)
                foreach(Player p in players)
                    p.TakeCard(stock.Deal());
                //for(int playerNum = 0; playerNum < players.Count; playerNum++)
                //    players[playerNum].TakeCard(stock.Deal());
            foreach (Player p in players) PullOutBooks(p);
        }
        public bool PlayOneRound(int selectedPlayerCard)
        {
            // ask 한 카드를 다른 플레이어가 가지고 있는지 check
            Values cardToAskFor = players[0].Peek(selectedPlayerCard).Value;

            for(int i = 0; i < players.Count; i++)
            {
                if (i == 0) players[0].AskForACard(players, 0, stock, cardToAskFor);
                else players[i].AskForAcard(players, i, stock);

                if (PullOutBooks(players[i]))
                {
                    textBoxOnForm.Text += players[i].Name + " drew a new hand" + Environment.NewLine;
                    int card = 1;
                    while(card <= 5 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }
                players[0].SortHand();
                if(stock.Count == 0)
                {
                    textBoxOnForm.Text = "The stock is out of cards. Game over!\r\n";
                    return true;
                }
            }
            return false;
        }

        public bool PullOutBooks(Player player)
        {
            // 완성된 book을 뽑아낸다. 플레이어가 가진 카드가 다 떨어지면 true,
            // 그렇지 않으면 false를 반환, book은 딕셔너리에 저장
            IEnumerable<Values> booksPulled = player.PullOutBooks();

            foreach (Values value in booksPulled)
                books.Add(value, player);

            if (player.cardCount == 0)  return true;
            return false;
        }

        public string DescribeBooks()
        {
            string whoHasWhichBooks = "";
            foreach (Values value in books.Keys)
            {
                whoHasWhichBooks += books[value].Name + " has a book of " + Card.Plural(value) + Environment.NewLine;
            }
            return whoHasWhichBooks;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();

            foreach (Values value in books.Keys)
            {
                string name = books[value].Name;
                if (winners.ContainsKey(name)) winners[name]++;
                else winners.Add(name, 1);
            }

            int mostBooks = 0;

            foreach (string name in winners.Keys)
            {
                if (winners[name] > mostBooks) mostBooks = winners[name];
            }

            bool tie = false;
            string winnerList = "";

            foreach(string name in winners.Keys)
                if (winners[name] == mostBooks)
                {
                    if (!String.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " and ";
                        tie = true;
                    }
                    winnerList += name;
                }
            winnerList += " with " + mostBooks + " books";
            if (tie) return "A tie between " + winnerList;
            else return winnerList;
        }

        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }
       
        public string DescribePlayerHands()
        {
            string description = "";
            for(int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " has " + players[i].cardCount;
                if (players[i].cardCount == 1)
                    description += " card." + Environment.NewLine;
                else
                    description += " cards." + Environment.NewLine;
            }
            description += "The stock has " + stock.Count + " cards left.";
            return description;
        }
    }
}
