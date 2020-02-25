using System;

namespace DeckOfCardGame
{
    internal static class DeckOperation
    {
        public static void Shuffle(this Deck deck)
        {
            Random rand = new Random();
            for (int i = 0; i < deck.GetCount() - 1; i++)
            {
                //swap random cards in the deck
                int randCard = rand.Next(deck.GetCount() - 1);
                deck = Swap(deck, i, randCard);
            }
            //return cardDeck;
        }

        public static Deck Swap(Deck deck, int firstCard, int secondCard)
        {
            Card tmp = deck.cardDeck[firstCard];
            deck.cardDeck[firstCard] = deck.cardDeck[secondCard];
            deck.cardDeck[secondCard] = tmp;
            return deck;
        }
    }
}
