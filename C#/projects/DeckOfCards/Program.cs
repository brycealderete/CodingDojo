using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck BrycesDeck=new Deck();
            Console.WriteLine(BrycesDeck.cards[6].StringVal);
            Console.WriteLine(BrycesDeck.cards[6].Suit);
            Console.WriteLine(BrycesDeck.cards[6].Val);

        }
    }
}
