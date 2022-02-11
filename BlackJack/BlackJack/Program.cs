using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program // this is our main class called Program
    {
        static void Main(string[] args) // this is our main method(function inside the class and when called will do the stuff we put inside it)
        {


            Deck deck = new Deck(); // this is our object made from our Deck class called deck and should already have 52 cards in it from our loop
                                    // inside the class we made

            deck.Shuffle(4); // this is easy to read, it uses the object we made above and access the method to shuffle the cards and we pass a parameter of 4 to shuffle cards 4 times

            foreach (Card card in deck.Cards) // now we will iterate though  through our classes to get all of our cards
            {
                Console.WriteLine(card.Face + " of " + card.Suit); // this will print each card for each suit but not shuffled
            }

            Console.WriteLine(deck.Cards.Count); // this is to assure us that we have 52 cards. 
            Console.ReadLine();
        }
    }
}
