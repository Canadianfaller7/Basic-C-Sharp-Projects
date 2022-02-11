using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Game // generic class for most card games we made this with these methods so we can use it for multiple games that can inherit the methods from this class
    {
        public List<string> Players { get; set; } // method of list of players who might play in the game
        public string Name { get; set; } // metho for the name of the game we will play
        public string Dealer { get; set; } // method for a dealer cause most card games have a dealer

        public void ListPlayers() // basic method to loop through players and display their names on screen
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
