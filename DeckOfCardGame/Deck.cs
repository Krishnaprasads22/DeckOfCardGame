using System;
using System.Collections.Generic;

namespace DeckOfCardGame
{
    class Deck
    {
        private Card[] cards;
        public enum Suit
        {
            Spades,
            Hearts,
            Clubs,
            Diamonds
        }

        internal int GetCount()
        {
            return cardDeck.Count;
        }

        internal List<Card> cardDeck;

        public Deck()
        {
            this.cardDeck = new List<Card>();
            for (int value = 1; value <= 13; value++)
            {
                foreach (var suit in (Suit[])Enum.GetValues(typeof(Suit)))
                {
                    cardDeck.Add(new Card(value, suit));
                }
            }
            this.Shuffle();
        }


        public override String ToString()
        {
            return "Deck{" +
                    "cardDeck=" + cardDeck +
                    '}';
        }
        
        public Card GetFirstCard()
        {
            Card lastcard = cardDeck[0];
            cardDeck.RemoveAt(0);
            return lastcard;
        }
        
        internal Card ShowFirstCard()
        {
            Card lastcard = cardDeck[0];
            return lastcard;
        }
    }
}
