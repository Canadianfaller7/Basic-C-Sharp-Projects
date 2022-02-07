using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = new List<decimal>() { 22, 26, 48, 64, 102, 222, 224, 216, 400, 1200 }; // this is our list or random numbers
            try // we put all this code in a try/catch block to say try to run the main code, but if there is an error, catch it and display an error message
            {
                Console.WriteLine("Input a number to divide by each number inside my list:\n");
                int usrNum = Convert.ToInt32(Console.ReadLine()); // we store the users input as an int(whole number)

                foreach (decimal i in numbers) // here I am making i a decimal so we can get a decimal if user inputs a number that won't show whole numbers
                {
                    decimal divideI = i / usrNum; // make this a decimal to get decimals. Take our i after being iterated and divide it by the users number
                    Console.WriteLine($"\n{i} divided by {usrNum} equals: {divideI}"); // print to the console what is happening
                }
            }
            catch (FormatException) // this is an error for if the user puts in a decimal number or a string format answer
            {
                Console.WriteLine("\nPlease input a whole number.");
            }
            catch (DivideByZeroException) // this is an error for if the user tries to divide by 0
            {
                Console.WriteLine("\nPlease do not divide by zero");
            }
            catch (Exception ex) // this is an error for anything else that might happen.
            {
                Console.WriteLine(ex.Message);
            }
            // this tells us that we have ran through the try/catch block and now exited it and will now end the program
            Console.WriteLine("\nThe code has now ran through the try/catch and has now exited the try/catch block."); 
            Console.ReadLine();
        }
    }
}
