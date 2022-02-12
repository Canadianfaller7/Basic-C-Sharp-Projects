using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        
        /* this is how you make a class, you make it public so it can be accessed anywhere else in the program,
        assign it a value of string with it's name and then having the get set is to get the property and set the property of the class(the property
        is the Suite and Face)*/
        public Suit Suit { get; set; } 
        public Face Face { get; set; }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
