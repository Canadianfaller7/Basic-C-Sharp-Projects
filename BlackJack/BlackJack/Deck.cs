using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck // this is our class and inside of it we have an insturctor(method)
    {
        public Deck() // this is our constructor( a method being called as soon as the object has been created) 
        {
            Cards = new List<Card>(); // the constructor will instaciate its property card as an empty list of cards
            List<string> Suits = new List<string>() // this is our list of suits in the card
            { 
                "Clubs", "Hearts", "Diamonds", "Spades"
            };
            List<string> Faces = new List<string>() // this is our list of the values of the card(their faces)
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", 
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            // the way this loop will techincally work is it will take two for example and loop through it 4 times to get a face of 2 for each suit and then move on to the next number and do the same thing.
            foreach (string face in Faces) // now we will make a nested foreach loop which will make a new card. We will loop through each face 4 times
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); // first we create a new card
                    card.Suit = suit; // then we make 4 suits 
                    card.Face = face; // assign a face each card in the 4 suits
                    Cards.Add(card); // then we add the cards from "card" once they have all been iterated through
                }

            }

                
        }
        public List<Card> Cards { get; set; }
    }
}
