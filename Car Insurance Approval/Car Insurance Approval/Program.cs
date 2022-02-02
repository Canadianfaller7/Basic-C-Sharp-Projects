using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Approval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age? :\n");
            int age = Convert.ToInt32(Console.ReadLine()); // we ask person their age and then save it to an int var

            Console.WriteLine("\nHave you ever had a DUI? True or False :\n");
            bool dui = Convert.ToBoolean(Console.ReadLine()); // we ask if the user has had a dui and save their answer into a bool var

            Console.WriteLine("\nHow many speeding tickets do you have?\n");
            int tickets = Convert.ToInt32(Console.ReadLine()); // we ask user how many tickets they have and save it into an int var

            Console.WriteLine("\nQualified?\n");
            bool passedOrNot = (age >= 15 && dui == false && tickets <= 3);
            /* here we use boolean logic to check and make sure the age is 15yr old or older, user has no dui's and their tickets are 3 or less*/
            Console.WriteLine(passedOrNot); // then we print the result here
            Console.ReadLine(); // this displays it unil a key is hit
        }
    }
}
