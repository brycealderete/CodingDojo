using System.Collections.Generic;
using System;
namespace DeckOfCards
{
    public class Player
    {
        public string Name{get; set;}
        public List<Card> Hand;


        public Player (){}
        public Player(string name)
        {
            Name=name;
        }
        public Card Draw(Deck deck,Player player)
        {
            Card dealtcard=deck.Deal();
            Hand.Add(dealtcard);
            return dealtcard;

        }
        public Card Discard(int index)
        {
            if (Hand[index]==null)
            {
                return null;
            }
            Hand.RemoveAt(index);
            return Hand[index];
        }
    }
}