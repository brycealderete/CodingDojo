using System;
namespace DeckOfCards
{
    public class Card
    {
        public string StringVal {set; get;}
        public string Suit {set; get;}
        public int Val {set; get;}
        
        public Card (){}
        public Card (string stringVal,string suit,int val)
        {
            StringVal=stringVal;
            Suit=suit;
            Val=val;
        }
    }
}