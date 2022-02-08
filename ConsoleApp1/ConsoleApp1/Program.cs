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
            try
            {
                Console.WriteLine("What number would you want to use for our math operations? :\n");
                int usrNumb = Convert.ToInt32(Console.ReadLine());

                int addResult = MathOperations.addNumber(usrNumb);
                Console.WriteLine($"\nYour number {usrNumb} + 22 equals: {addResult}");

                int multiplyResult = MathOperations.multiplyNumber(usrNumb);
                Console.WriteLine($"\nYour number {usrNumb} multiplied by 9 equals: {multiplyResult}");

                decimal divideResult = MathOperations.divideNumber(usrNumb);
                Console.WriteLine($"\nYour number {usrNumb} divided by 2 equals: {divideResult}");
            }
            catch (FormatException ex)
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
