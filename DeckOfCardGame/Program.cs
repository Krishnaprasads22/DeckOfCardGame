using System;

namespace DeckOfCardGame
{
    class Program
    {
        public static Deck PlayingDeck { get; private set; } = new Deck();

        static void Main(string[] args)
        {
            while (PlayingDeck.GetCount() > 0)
            {
                Console.WriteLine("Cards in hand is " + PlayingDeck.GetCount());
                //To check if random number is getting generated each time it's shuffled
                Console.WriteLine("Next Card in hand is " + PlayingDeck.ShowFirstCard());
                Console.WriteLine("Enter Option \n 1. Play a card\n 2. Shuffle card \n 3. Restart Game ");
                var userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 1)
                {
                    Console.WriteLine(PlayingDeck.GetFirstCard());
                }
                else if (userChoice == 2)
                {
                    PlayingDeck.Shuffle();
                }
                else
                {
                    //Reset the playing deck with a new deck
                    PlayingDeck = new Deck();
                }
            }
        } 
    }
}
