using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            float num2 = 17f; // remember that for a float it needs the f after the number
            int total = num1 + (Int32)num2; // we then have to convert our float to an int to drop off the decimal point. Num will round down
            Console.WriteLine(total);
            

            int difference = (Int32)num2 - num1;
            Console.WriteLine(difference);

            int multi = num1 * (Int32)num2;
            Console.WriteLine(multi);
              
            float division = num2 / num1;
            Console.WriteLine(division);

            int remainder = (Int32)num2 % num1;
            Console.WriteLine(remainder);

            int num3 = 9;
            int num4 = 26;

            int remainder2 = num4 % num3; // these will divide the two numbers and then print out the remainder to the console
            Console.WriteLine(remainder2);

            string txt = "Terran and I have been best friends for ";
            int yrs = 4;
            Console.WriteLine(txt + yrs + " years now.");
            Console.ReadLine();
        }
    }
}
