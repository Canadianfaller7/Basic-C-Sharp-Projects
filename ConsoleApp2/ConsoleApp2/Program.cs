using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            try // try to run everthing inside here
            {
                Console.WriteLine("Give us a number that we can use for our math operations:\n"); // ask user for a number
                string usrNumber = Console.ReadLine();// save number as a string

                int multiplyResult = mathOperation.mathOperations(Convert.ToInt32(usrNumber)); // go into our class pass in usrNumber as the parameter or here (argument) and convert it from a string to an int
                decimal divideResult = mathOperation.mathOperations(Convert.ToDecimal(usrNumber)); // same thing but convert from a string to a decimal


                string addResult = mathOperation.mathOperations(Convert.ToDouble(usrNumber)); // keep the entire thing as a string but for the usrNumber we will convert to a double so we get a return type of an integer

                Console.WriteLine("\nYour number {0} multiplied by 12 equals: {1}", usrNumber, multiplyResult); // using wild cards here to pass in information

                Console.WriteLine($"\nYour number {usrNumber} divided by 2 equals: {divideResult}");// same thing here just different way to pass in the info

                Console.WriteLine($"\nYour number {usrNumber} + 55 equals: {addResult}");
            }
            catch (Exception ex) // catch any other errors and throw a message
            {
                Console.WriteLine($"\n{ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
