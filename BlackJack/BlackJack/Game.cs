using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    // generic class for most card games we made this with these methods so we can use it for multiple games that can inherit the methods from this class
    public abstract class Game // abstract classes are here to lock our class because we will never make an instance of the class meaning it will never be made an object
    {
        public List<Player> Players { get; set; } // method of list of players who might play in the game
        public string Name { get; set; } // metho for the name of the game we will play
        public string Dealer { get; set; } // method for a dealer cause most card games have a dealer

        public abstract void Play(); // abstract method contain no implementation and can only be made inside a abstract class, these state that any class
        // inheriting the class Game must also have this method
        public virtual void ListPlayers()
            // virtual means that this method gets inhertited by an inheriting class but has the ability to override it, it can be implemented but can be overwritten
        {
            foreach (Player player in Players) //loop through players and display their names on screen
            {
                Console.WriteLine(player);
            }
        }
    }
}
