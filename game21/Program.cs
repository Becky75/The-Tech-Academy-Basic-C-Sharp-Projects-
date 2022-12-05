using System;
using System.Collections.Generic;


namespace game21
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
             Console.ReadLine();


        }
    }
}
