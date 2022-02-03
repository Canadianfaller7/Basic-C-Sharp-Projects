using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisionOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine(difference);
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 17; // this will round the number
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0; // this will give a decimal
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2; // again this is how we get the remainder of something printed and let us know if its odd or even
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5; // bool will tell us if the statment is true or false
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 70;

            //bool isWarm = currentTemp == roomTemp;
            //Console.WriteLine(isWarm);

            /* this is a switch statement, kinda like an if else statement. Here we get user to input a number and whatever number that gets
             put in between 1-7 will print out a day associated with that number. If they don't do a number they get told to try again and the 
            program will end*/
            Console.WriteLine("Please enter a number of 1-7 to print a day of the week:\n");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("\nSunday");
                    break;
                case 2:
                    Console.WriteLine("\nMonday");
                    break;
                case 3:
                    Console.WriteLine("\nTuesday");
                    break;
                case 4:
                    Console.WriteLine("\nWednesday");
                    break;
                case 5:
                    Console.WriteLine("\nThursday");
                    break;
                case 6:
                    Console.WriteLine("\nFriday");
                    break;
                case 7:
                    Console.WriteLine("\nSaturday");
                    break;
                default:
                    Console.WriteLine("\nYou didn't enter a number, please try again.");
                    break;
            }


            Console.ReadLine();


        }
    }
}
