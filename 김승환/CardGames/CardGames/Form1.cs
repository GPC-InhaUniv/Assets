using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGames
{
    public partial class Form1 : Form
    {
        Deck deck1;
        Deck deck2;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void RedrawDeck(int DeckNumber)
        {
            if (DeckNumber == 1)
            {
                listBoxDeck1.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                {
                    listBoxDeck1.Items.Add(cardName);
                }
                labelDeck1.Text = "Deck #1 (" + deck1.Count + " cards)";
            }
            if (DeckNumber == 2)
            {
                listBoxDeck2.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                {
                    listBoxDeck2.Items.Add(cardName);
                }
                labelDeck2.Text = "Deck #2 (" + deck2.Count + " cards)";
            }
        }

        private void ResetDeck(int num)
        {
            if(num == 1)
            {
                int range = random.Next(1, 5);
                deck1 = new Deck(new Card[] { });
                for (int i = 0; i < range; i++)
                {
                    deck1.Add(new Card((Card.Suit)random.Next(0, 3), (Card.Value)random.Next(1, 12)));
                }
                deck1.Sort();
            }
            if(num == 2)
            {
                deck2 = new Deck();
            }
        }

        private void buttonResetDeck1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void buttonResetDeck2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void buttonShuffleDeck1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void buttonShuffleDeck2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void buttonMoveToDeck2_Click(object sender, EventArgs e)
        {
            if(listBoxDeck1.SelectedIndex >= 0)
            {
                if(deck1.Count > 0)
                {
                    deck2.Add(deck1.Deal(listBoxDeck1.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void buttonMoveToDeck1_Click(object sender, EventArgs e)
        {
            if (listBoxDeck2.SelectedIndex >= 0)
            {
                if (deck2.Count > 0)
                {
                    deck1.Add(deck2.Deal(listBoxDeck2.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }
    }
}
