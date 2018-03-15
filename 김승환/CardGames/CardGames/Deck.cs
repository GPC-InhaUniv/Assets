using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    public class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for(int suit = 0; suit <= 3; suit++)
            {
                for(int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card((Card.Suit)suit, (Card.Value)value));
                }
            }
        }

        public Deck(Card[] initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count
        {
            get
            {
                return cards.Count;
            }
        }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card cardToDeal = cards[index];
            cards.RemoveAt(index);
            return cardToDeal;
        }

        public void Shuffle()
        {
            List<Card> shuffledCard = new List<Card>();
            while(cards.Count > 0)
            {
                int newCardIndex = random.Next(cards.Count);
                shuffledCard.Add(cards[newCardIndex]);
                cards.RemoveAt(newCardIndex);
            }
            cards = shuffledCard;
        }

        public string[] GetCardNames()
        {
            string[] cardName = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
            {
                cardName[i] = cards[i].Name;
            }

            return cardName;
        }

        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit());
        }
    }
}
