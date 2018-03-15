using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    public class Player
    {
        private string name;
        public string Name { get => name; }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.cards = new Deck(new Card[] { });
            textBoxOnForm.Text += Name + " has just joined the game\r\n";
        }

        public List<Card.Value> PullOutBooks()
        {
            List<Card.Value> Books = new List<Card.Value>();
            for(int i = 1; i<= 13; i++)
            {
                Card.Value value = (Card.Value)i;
                int howMany = 0;
                for(int card = 0; card < cards.Count; card++)
                {
                    if(cards.Peek(card).value == value)
                    {
                        howMany++;
                    }
                }
                if(howMany == 4)
                {
                    Books.Add(value);
                    cards.PullOutValues(value);
                }
            }

            return Books;
        }

        public Card.Value GetRandomValue()
        {
            Card.Value value;
            value = cards.Peek(random.Next(cards.Count)).value;

            return value;
        }

        public Deck DoYouHaveAny(Card.Value value)
        {
            Deck deck = cards.PullOutValues(value);

            textBoxOnForm.Text += Name + "has" + deck.Count + " of " + Card.Plural(value) + "\r\n";

            return deck;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            Card.Value randomValue = GetRandomValue();

            AskForACard(players, myIndex, stock, randomValue);
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Card.Value value)
        {
            int obtainedCard = 0;

            textBoxOnForm.Text += Name + " asks if anyone has a " + value + "\r\n";

            for(int i = 0; i < players.Count; i++)
            {
                if(i != myIndex)
                {
                    Player player = players[i];
                    Deck CardsGiven = player.DoYouHaveAny(value);
                    obtainedCard += CardsGiven.Count;
                    while(CardsGiven.Count > 0)
                    {
                        cards.Add(CardsGiven.Deal());
                    }
                }
            }

            if(obtainedCard == 0)
            {
                textBoxOnForm.Text += "Go Fish\r\n";
               textBoxOnForm.Text += Name + " must draw from the stock.\r\n";
                cards.Add(stock.Deal());
            }
        }

        public int CardCount { get => cards.Count; }
        public void TakeCard(Card card) { cards.Add(card); }
        public string[] GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
    }
}
