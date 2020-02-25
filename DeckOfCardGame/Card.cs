using System;

namespace DeckOfCardGame
{
    internal class Card 
    {
        int rank;
        Deck.Suit suit;

        public Card(int rank, Deck.Suit suite)
        {
            this.rank = rank;
            this.suit = suite;
        }
        /// <summary> Card Output format </summary>
        public override string ToString()
        {
            return "Card{" + "value=" + rank +", suite=" + suit +'}';
        }
    }
}