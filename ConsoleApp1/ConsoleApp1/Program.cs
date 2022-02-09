using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /* Here I am going to run a try/catch block to catch any errors the user might put in. Then we ask the user for a number and then
             save it. Then I make a int var and save it to the method inside my class and pass in the user number as my argument for 
            the paramater that is required to be put in. Then I print a statement to the console saying that the users number plus whatever
            method is being used equals (x)*/
            try
            {
                Console.WriteLine("What number would you want to use for our math operations? :\n");
                int usrNumb = Convert.ToInt32(Console.ReadLine());

                int addResult = MathOperations.addNumber(usrNumb);
                Console.WriteLine($"\nYour number {usrNumb} + 22 equals: {addResult}");

                int multiplyResult = MathOperations.multiplyNumber(usrNumb);
                Console.WriteLine($"\nYour number {usrNumb} multiplied by 9 equals: {multiplyResult}");

                decimal divideResult = MathOperations.divideNumber(usrNumb); // we use a decimal to get a decimal number but also so user can't divide by 0
                Console.WriteLine($"\nYour number {usrNumb} divided by 2 equals: {divideResult}");
            }
            catch (FormatException ex) // these are the errors we will print to the console of something happens that shouldn't have-------------------
            {
                Console.WriteLine("\nPlease put in a whole number.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nPlease don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}");

            }
            Console.ReadLine();
        }
    }
}
