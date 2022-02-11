﻿using System;
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

        /* this is a method specific to this class, we aren't returning anything and that is why we have void, but it is accessable from anywhere
         in the program because of the public and it has a parameter of int times =1 which is an option parameter of how many times we might
        want to have the cards shuffled. We then do a for loop to go through the cards and actually get them shuffled*/
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> tempList = new List<Card>(); // make a tempList to hold our new cards that will be shuffled
                Random random = new Random(); // call the shuffle class from the c# library

                while (Cards.Count > 0) // do a while loop saying while cards(52) is not greater than 0 do the following insid
                {
                    int randomIndex = random.Next(0, Cards.Count); // this will make a random index to grab a card
                    tempList.Add(Cards[randomIndex]);// then we add the random card to our tempList
                    Cards.RemoveAt(randomIndex); // this is a function of the list method and this method will add the card to our new list and
                                                      // then it will remove the card added to the tempList from our deck var until no cards are left
                }
                this.Cards = tempList; // we then assign our deck.cards to the new tempList holding the shuffled cards
                // the 'this' is refereing to itself so when you do this.Cards we are just refering to the Cards class itself.
            }
        }
    }
}
