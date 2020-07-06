using System.Collections.Generic;
using System;
namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> cards;
        string[] stringVal={"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
        string[] suits ={"Heart","Diamond","Spade","Club"};
        public Deck()
        {
            cards= new List<Card>();
            {
            
                foreach (string suit in suits)
                {
                    int val=1;
                    foreach (string stringval in stringVal)
                    {
                        Card newcard=new Card(stringval,suit,val);
                        cards.Add(newcard);
                        val+=1;
                    }

                }
            }
        }
        public Card Deal()
        {
            Card yourcard=cards[0];
            cards.RemoveAt(0);

            return yourcard;
        }
        public void Reset()
        {

            cards.Clear();
                foreach (string suit in suits)
                {
                    int val=1;
                    foreach (string stringval in stringVal)
                    {
                        Card newcard=new Card(stringval,suit,val);
                        cards.Add(newcard);
                        val+=1;
                    }

                }
        }
        public void Shuffle()
        {
            Random rand=new Random();
            for(int i=0;i<cards.Count;i++)
            {
                int newindex=rand.Next(cards.Count);
                Card temp=cards[i];
                cards[i]=cards[newindex];
                cards[newindex]=temp;
            }
        }
        
    }
}