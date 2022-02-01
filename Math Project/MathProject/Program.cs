using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // here we get usr input and then multiply it by 50 and return the result with some text so the user knows what is going on
            Console.WriteLine("Give me a number between 1-100: \n");
            int usrNum = Convert.ToInt32(Console.ReadLine());
            int num1 = usrNum * 50;
            Console.WriteLine("\nYour number multiplied by 50 is :" + num1);

            // this line asks for another number from usr and then adds it to 25
            Console.WriteLine("\nGive me another number: \n");
            int usrNum2 = Convert.ToInt32(Console.ReadLine());
            int num2 = usrNum2 + 25;
            Console.WriteLine("\nYour number plus by 25 is : " + num2);

            // this one will take the usr number and divide it by a decimal number and we use double to make sure it can handle the returned result
            Console.WriteLine("\nGive me another number: \n");
            int usrNum3= Convert.ToInt32(Console.ReadLine());
            double num3= usrNum3/ 12.5;
            Console.WriteLine("\nYour number divided by 12.5 is : " + num3);

            // this will take the number the usr put in and then tell us if it is greater than 50 or not by printing true or false
            Console.WriteLine("\nGive me another number: \n");
            int usrNum4 = Convert.ToInt32(Console.ReadLine());
            bool num4= usrNum4 > 50;
            Console.WriteLine("\nIs your number greater than 50? : " + num4);

            // this line will take the usr number and then divide it by 7 and then whatever the remainder is it will print to the console.
            Console.WriteLine("\nGive me another number: \n");
            int usrNum5 = Convert.ToInt32(Console.ReadLine());
            int num5 = usrNum5 % 7;
            Console.WriteLine("\nThe remainder of your number divided by 7 is : " + num5);
            // after the program is done hit enter to exit.
            Console.ReadLine();
        }
    }
}
