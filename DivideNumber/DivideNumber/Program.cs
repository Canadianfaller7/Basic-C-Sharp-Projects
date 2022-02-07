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
            List<float> numbers = new List<float>() { 22, 26, 48, 64, 102, 222, 224, 216, 400, 1200 }; // this is our list or random numbers
            try // we put all this code in a try/catch block to say try to run the main code, but if there is an error, catch it and display an error message
            {
                Console.WriteLine("Input a number to divide by each number inside my list:\n");
                int usrNum = Convert.ToInt32(Console.ReadLine()); // we store the users input as an int(whole number)

                foreach (float i in numbers) // here I am making i a float so we can get a decimal if user inputs a number that won't show whole numbers
                {
                    float divideI = i / usrNum; // make this a float to get decimals. Take our i after being iterated and divide it by the users number
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
            finally // this will print after an error has been caught and will then move to the next part of our program
            {
                Console.WriteLine("\nThe code ran and caught an error.");
                Console.ReadLine();
            }
            // this tells us that we have ran through the try/catch block and now exited it and will now end the program
            Console.WriteLine("\nThe code has now ran through the try/catch and has now exited the try/catch block."); 
            Console.ReadLine();
        }
    }
}
