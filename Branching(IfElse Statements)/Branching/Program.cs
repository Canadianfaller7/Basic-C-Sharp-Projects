using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 7;
            //int num2 = 14;

            //string result = num1 > num2 ? "Num1 is greater than Numb2" : "Numb 2 is greater than Numb1"; //Here we are using Ternary Operator
            //// that means when we use the '?' and ':' depending on the result of our is num1 > num2, one of the two following strings will print.
            //// if the statement is true, the left string will print, but if false the right statement will print.
            //Console.WriteLine(result);
            //Console.ReadLine();

            //int currentTemp = 80;
            //int roomTemp = 70;

            //string comparisonResult = currentTemp == roomTemp ? "It is room temp." : "It is not room temp."; // this is ternary operator
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            //} 

            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature");
            //}

            /* This gets user input about their name and what their current temp is and will compare it to the roomTemp var and will print a statement
             based on what number the user put in(These are if else, else if statement(conditional statements)*/

            //int roomTemp = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");

            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp.");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("It is colder than room temp.");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhh.... something went wrong.");
            //}


            /* this is a ternary operator to get users fav number and then based on what they typed if it is equal to our hard coded number one of the
             following 2 statements will print (Ternary operators are more commonly used if there is going to be an if else, else if section)*/
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string results = favNum == 12 ? "You have an awesome favorite number!" : "You do not have an awesome favorite number.";
            Console.WriteLine(results);

            Console.ReadLine();
        }   
    }
}
