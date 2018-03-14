using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    public class Game
    {
        private List<Player> players;
        private Dictionary<Card.Value, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, string[] opponentName, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach(string player in opponentName)
            {
                players.Add(new Player(player, random, textBoxOnForm));
            }
            books = new Dictionary<Card.Value, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            stock.Shuffle();
            foreach (Player player in players)
            {
                for(int i =0; i < 5; i++)
                {
                    player.TakeCard(stock.Deal(0));
                }
            }
            foreach (Player player in players)
            {
                PullOutBooks(player);
            }
        }

        public bool PlayOneRound(int selectedPlayerCard)
        {
            Card.Value cardToAskFor = players[0].Peek(selectedPlayerCard).value;
            for(int i = 0; i < players.Count; i++)
            {
                if(i == 0)
                {
                    players[0].AskForACard(players, 0, stock, cardToAskFor);
                }
                else
                {
                    players[i].AskForACard(players, i, stock);
                }
                if(PullOutBooks(players[i]))
                {
                    textBoxOnForm.Text += players[i].Name + "drew a new hand\r\n";
                    int card = 1;
                    while(card <= 5 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }
                players[0].SortHand();
                if (stock.Count == 0)
                {
                    textBoxOnForm.Text += "스톡의 카드가 다 떨어졌습니다. 게임 종료!\r\n";
                    return true;
                }
            }
            return false;
        }

        public bool PullOutBooks(Player player)
        {
            List<Card.Value> BooksPulled = player.PullOutBooks();
            foreach (Card.Value value in BooksPulled)
            {
                books.Add(value, player);
            }
            if(player.CardCount == 0)
            {
                return true;
            }
            return false;
        }
        
        public string DescribeBooks()
        {
            string whoHasWhichBooks = "";
            foreach(Card.Value value in books.Keys)
            {
                whoHasWhichBooks += books[value].Name + " has a book at " + Card.Plural(value) + "\r\n";
            }
            return whoHasWhichBooks;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach(Card.Value value in books.Keys)
            {
                string name = books[value].Name;
                if(winners.ContainsKey(name))
                {
                    winners[name]++;
                }
                else
                {
                    winners.Add(name, 1);
                }
            }

            int mostBooks = 0;
            foreach(string name in winners.Keys)
            {
                if(winners[name] > mostBooks)
                {
                    mostBooks = winners[name];
                }
            }

            bool tie = false;
            string winnerList = "";
            foreach(string name in winners.Keys)
            {
                if(winners[name] == mostBooks)
                {
                    if(!String.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " and ";
                        tie = true;
                    }
                    winnerList += name;
                }
            }
            winnerList += " with " + mostBooks + " books ";
            if(tie)
            {
                return "A tie between" + winnerList;
            }
            else
            {
                return winnerList;
            }
        }

        public string[] GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        public string DescribePlayerHands()
        {
            string description = "";
            for(int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " has " + players[i].CardCount;
                if(players[i].CardCount == 1)
                {
                    description += " card.\r\n";
                }
                else
                {
                    description += " cards.\r\n";
                }
            }
            description += "The stock has " + stock.Count + " cards left.\r\n";
            return description;
        }
    }
}
