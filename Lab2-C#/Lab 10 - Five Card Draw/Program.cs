using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10___Five_Card_Draw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            FiveCardDraw fiveCardDraw = new FiveCardDraw();
            fiveCardDraw.PlayRound();
            //DeckOfCards myDeck = new DeckOfCards();
            //myDeck.Shuffle();
            Console.ReadLine();

            // cycle through deck
            /*foreach(Card card in myDeck.Deck)
            {
                Console.WriteLine(card.ToString());
            }

            Console.ReadLine();*/
        }

    }
}
