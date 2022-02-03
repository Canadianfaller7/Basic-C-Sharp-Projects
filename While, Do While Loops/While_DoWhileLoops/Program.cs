using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_DoWhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 7; // we are saying the user needs to guess the number  12 to get the answer right

            do /* this is a do while loop with a switch statement inside it. It basically lets us run the app and if the user guesses
                the number on the first try that it will still print out the statement and then end the program versus if we do just a regulary
                while loop and they guess it on the first try, nothing will happen.*/
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("you guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 77:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("you guessed the number 7. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed); // this is the while loop that lets the user keep guessing without the program ending after the first guess

            Console.WriteLine("\nGuess the day of the week by entering a number between 1-7 :\n");
            int day = Convert.ToInt32(Console.ReadLine());
            bool dayGuessed = false;

            while (!dayGuessed)
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("\nSunday is what you guessed. Try again.");
                        Console.WriteLine("\nEnter another number: ");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("\nMonday is what you guessed. Try again.");
                        Console.WriteLine("\nEnter another number: ");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("\nTuesday is what you guessed. Try again.");
                        Console.WriteLine("\nEnter another number: ");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("\nWednesday is what you guessed. Try again.");
                        Console.WriteLine("\nEnter another number: ");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("\nThursday is what you guessed. Try again.");
                        Console.WriteLine("\nEnter another number: ");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("\nFriday is what you guessed. This is correct!");
                        dayGuessed = true;
                        break;
                    case 7:
                        Console.WriteLine("\nSaturday is what you guessed. Try again.");
                        Console.WriteLine("\nEnter another number: ");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("\nYou didn't enter a number, please try again.");
                        Console.WriteLine("\nEnter another number: ");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            
            Console.ReadLine();
        }
    }
}
