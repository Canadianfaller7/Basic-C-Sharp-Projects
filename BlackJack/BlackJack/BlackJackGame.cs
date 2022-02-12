using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class BlackJackGame : Game, IWalkAway
    {
        public override void Play() // override is how you can apply the abstract method to a class that is inheriting from the abstract class
        {
            throw new NotImplementedException(); // this will just throw an erorr for right now until we actually define the method
        }
        public override void ListPlayers() // this is using the ListPlayers but we are overriding what it says and putting in our own stuff
        {
            Console.WriteLine("Black Jack Players:\n");
            base.ListPlayers();
        }
        public void WalkAway(Player player) // to use the interface method, it has to be put in the same way as it was made
        {
            throw new NotImplementedException(); // we will define this later
        }
    }   
}
