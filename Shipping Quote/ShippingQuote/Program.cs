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
            Console.WriteLine("Welcome to Package Expess! Please follow the instructions below.\n");
            Console.WriteLine("Please enter the package weight:\n");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());

            string tooHeavyOrNot = pkgWeight > 50 ? "Package is too heavy to be shipped via Package Express. Have a good day." : "\nPlease Enter the package width:\n";
            Console.WriteLine(tooHeavyOrNot);
            int pkgWidth = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nPlease enter package height:\n");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter package length:\n");
            int pkgLength = Convert.ToInt32(Console.ReadLine());
            
            if (pkgWidth + pkgHeight + pkgLength > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package EXpress.");
            }
            else
            {
                double total = (pkgHeight * pkgWidth * pkgLength * pkgWeight) / 100;
                Console.WriteLine("\nYour estimated total for shipping this package is: $" + total + ".00");
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
