using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* here we have the user input the weight of the package the want to ship and save it to an int var*/
            Console.WriteLine("Welcome to Package Expess! Please follow the instructions below.\n");
            Console.WriteLine("Please enter the package weight:\n");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());

            /* here we take the int var and see if it is greater than 50 by doing a Ternary operator which is the '?' and ':', 
            if so print the left statement. If 50 or less print right statement and move on in program */
            string tooHeavyOrNot = pkgWeight > 50 ? "Package is too heavy to be shipped via Package Express. Have a good day." : "\nPlease Enter the package width:\n";
            Console.WriteLine(tooHeavyOrNot);
            int pkgWidth = Convert.ToInt32(Console.ReadLine()); // store user input of package width to this int var
            
            Console.WriteLine("\nPlease enter package height:\n");
            int pkgHeight = Convert.ToInt32(Console.ReadLine()); // get the height

            Console.WriteLine("\nPlease enter package length:\n");
            int pkgLength = Convert.ToInt32(Console.ReadLine()); // get the length
            
            if (pkgWidth + pkgHeight + pkgLength > 50) // if else statement(condition statement) saying if the width, height and length added are more than 50 print the statement below
            {
                Console.WriteLine("Package is too big to be shipped via Package EXpress.");
            }
            else // else take the total height, width, and length multiplied together and then multiply that by the weight of the package and take that number and divide by 100 for the total estimated shipping cost of the entire package
            {
                int total = (pkgHeight * pkgWidth * pkgLength * pkgWeight) / 100;
                Console.WriteLine("\nYour estimated total for shipping this package is: $" + total + ".00\n\nThank you!");
                Console.ReadLine(); // show the writeLine statement on screen
            }

            Console.ReadLine(); // exit program
        }
    }
}
