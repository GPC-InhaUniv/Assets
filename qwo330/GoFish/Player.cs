using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            this.cards = new Deck(new Card[] { });
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            textBoxOnForm.Text = name + " has just joined the game" + Environment.NewLine;
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for(int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).Value == value)
                    {
                        howMany++;
                    }
                }
                if (howMany == 4)
                {
                    books.Add(value);
                    for (int card = cards.Count - 1; card >= 0; card--)
                    {
                        cards.Deal(card);
                    }
                }
            }
            return books;
        }

        public Values GetRandomValue()
        {
            // 플레이어가 가진 카드값 중 하나를 무작위로 가져오는 메소드
            return cards.Peek(random.Next(cards.Count)).Value;
        }

        public Deck DoYouHaveAny(Values value)
        {
            /* 
             * 다른 플레이어가 특정 값의 카드가 있는지 물어볼 때 쓰는 메소드
             * Deck.PullOutValues() 메소드로 해당 카드를 뺀다.
             * 텍스트 상자에 "NAME has 3 sixes" 같은 식으로 텍스트 추가
             * 단, 복수 표현을 위해 Card.Plural() 메소드 사용
            */
            Deck hasCards = cards.PullOutValues(value);
            textBoxOnForm.Text += name + " has " + hasCards.Count + " " + Card.Plural(value) + Environment.NewLine;
            return hasCards;
        }

        public void AskForAcard(List<Player> players, int myIndex, Deck stock)
        {
            // GetRandomValue()로 가지고 있는 카드 중에서 한 값을 무작위로 고르고 
            // 아래의 AskForACard()로 상대방의 카드를 요구
            Values randomValue = GetRandomValue();
            AskForACard(players, myIndex, stock, randomValue);

        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            /* 다른 플레이어에게 카드를 요구하는 메소드
             * 텍스트 상자에 "NAME asks if anyone has a Queen" 과 같은 텍스트 추가.
             * 각 플레이어에게 DoYouHaveAny() 메소드로 그 값을 갖는 카드 요청하고
             * 해당 카드들을 플레이어가 가진 카드에 추가. 
             * 추가된 카드가 없으면 스톡에서 한장을 가져오고 "Name had to draw from the stock" 같은 텍스트 추가
             */
            textBoxOnForm.Text += name + " asks if anyone has a " + value.ToString() + "\r\n";
            int totalCardsGiven = 0;
//            List<Card> getCards = new List<Card>();
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Deck CardsGiven = players[i].DoYouHaveAny(value);
                    totalCardsGiven += CardsGiven.Count;

                    while (CardsGiven.Count > 0)
                        cards.Add(CardsGiven.Deal());
                }
            }
            if(totalCardsGiven == 0)
            {
                textBoxOnForm.Text += name + " must draw from the stock." + Environment.NewLine;
                cards.Add(stock.Deal());
            }
        }

        public int cardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
    }
}
