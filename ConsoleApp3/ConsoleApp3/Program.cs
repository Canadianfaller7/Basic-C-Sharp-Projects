using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please provide me with 2 numbers.\n\nGive me your first number:\n"); // ask user to give first number
            int usrNum1 = Convert.ToInt32(Console.ReadLine());// save first number
            Console.WriteLine("\nFor number 2 this is optional to provide or not: If you don't have a second number put 0.\n"); // ask for 2nd number and tell user it is only optional
            int usrNum2 = Convert.ToInt32(Console.ReadLine()); // save second number
            Console.WriteLine("\nThank you for giving us numbers!\n\nWe will now go ahead and add them together.\n");

            if (usrNum2 == 0) // if user didn't have a second number they could put 0 and then the code below would run
            {
                Console.WriteLine("If you did not enter a second number, don't worry we have provided one for you!\n");
                int addNum = Class1.Number(usrNum1); // this is running our method from our class with just 1 parameter taken and using the second as the default value of 7
                Console.WriteLine("\nYour number {0} + 7 equals: {1}\n", usrNum1, addNum);
            }
            else // else if user added a second number of their choosing run this code
            {
                int addNumbers = Class1.Number(usrNum1, usrNum2); // changes the second parameter from our method from 7 to whatever the user typed in
                Console.WriteLine($"Your first number {usrNum1} + your second number {usrNum2} equals: {addNumbers}");
            }
            Console.ReadLine();
        }
    }
}
