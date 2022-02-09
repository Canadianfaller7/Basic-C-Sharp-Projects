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
            int timesShuffled = 0; // var with a default value of 0

            /* here we now change the above var to equal our new method from below and pass deck in as an argument and now we will have
            shuffled cards. We are passing in the timesShuffled here to keep count of the 'times: 4' we had actually shuffled the deck */
            deck = Shuffle(deck, out timesShuffled, times: 4); // we can change the times to whatever we want

            foreach (Card card in deck.Cards) // now we will iterate though  through our classes to get all of our cards
            {
                Console.WriteLine(card.Face + " of " + card.Suit); // this will print each card for each suit but not shuffled
            }

            Console.WriteLine(deck.Cards.Count); // this is to assure us that we have 52 cards.
            Console.WriteLine("Times shuffled {0}", timesShuffled); // this is to verify the deck was shuffled 4 times
            Console.ReadLine();
        }

        /* this is a method(a function) that will return Deck with parameter of Deck called deck, we put static here because we haven't made an 
         object yet of the class and so we need to put it infront. This method has also another paramater of int times to give a default
        amount of times we will shuffle the deck which will be optional. We also then use an out parameter which will throw back to the 
        variable once the method is done and we make it timesShuffled*/
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)  {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> tempList = new List<Card>(); // make a tempList to hold our new cards that will be shuffled
                Random random = new Random(); // call the shuffle class from the c# library

                while (deck.Cards.Count > 0) // do a while loop saying while cards(52) is not greater than 0 do the following insid
                {
                    int randomIndex = random.Next(0, deck.Cards.Count); // this will make a random index to grab a card
                    tempList.Add(deck.Cards[randomIndex]);// then we add the random card to our tempList
                    deck.Cards.RemoveAt(randomIndex); // this is a function of the list method and this method will add the card to our new list and
                                                      // then it will remove the card added to the tempList from our deck var until no cards are left
                }
                deck.Cards = tempList; // we then assign our deck.cards to the new tempList holding the shuffled cards
            }
            return deck; // we then return deck
        }
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
