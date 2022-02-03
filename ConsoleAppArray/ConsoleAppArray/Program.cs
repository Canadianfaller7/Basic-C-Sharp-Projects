using System;
using System.Collections.Generic;

namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* here we make a new string array and then we ask the user to give us a number of 0-3 to reach into the array and print
             the arrays value based on the number the user gave*/
            string[] randomArray = { "Hello there!", "How are you today?", "I love coding!", "This is a random sentence!" };
            Console.WriteLine("Give me a number between 0-3 to print something:\n");
            int usrNum1 = Convert.ToInt32(Console.ReadLine()); // we convert their answer to an int from a string
            /* I then run an if statement to make sure that the number the user gave isn't out of our index and there is actually something to
             be printed or they will get told the value doesn't exist and then move onto the next question*/
            if (usrNum1 > 3)
            {
                Console.WriteLine("\nSorry this value doesn't exist.");
            }
            else
            {
                Console.WriteLine(randomArray[usrNum1]);
            }

            // this is the same thing as above, but this will print a number
            int[] numArray = { 1, 44, 77, 7, 25, 2340, 530, 233, 6856, 400, 5, 9 };
            Console.WriteLine("\nGive me a number between 0-11 to print out a new number:\n");
            int usrNum2 = Convert.ToInt32(Console.ReadLine());

            if (usrNum2 > 11)
            {
                Console.WriteLine("\nSorry this value doesn't exist.");
            }
            else
            {
                Console.WriteLine(numArray[usrNum2]);
            }

            // this is basically the same as above, but here we are making a list.
            List<string> list = new List<string>(); // this is how you make a string list (list) is the var name where we will add our values
            list.Add("Here is the first string in the list"); // this is how you add values to the list
            list.Add("Here is the second string in the list");
            list.Add("Coding is the best thing ever!");
            list.Add("Skateboarding is also the best thing ever!");

            Console.WriteLine("\nGive me another number to get a string from the list I created:\n");
            int usrNum3 = Convert.ToInt32(Console.ReadLine());

            if (usrNum3 > 3)
            {
                Console.WriteLine("\nSorry this value doesn't exist");
            }
            else
            {
                Console.WriteLine(list[usrNum3]);
            }

            Console.ReadLine();
        }
    }
}
