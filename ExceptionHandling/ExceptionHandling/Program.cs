using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nPick a second number.");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int num3 = num1 / num2;
                Console.WriteLine($"\n{num1} divided by {num2} equals {num3}");
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("\nPlease put in a whole number.");
                return;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nPlease don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
