using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Program
    {
        static void Main(string[] args)
        {
            try // we try to run this code inside and make sure there are no errors
            {
                Console.WriteLine("Enter the current day of the week:\n"); // ask user for current day of week
                string usrAnswer = Console.ReadLine(); // save answer to var
                DaysOfTheWeek days; // create enum

                if (Enum.TryParse<DaysOfTheWeek>(usrAnswer, out days)) // parsing through our enum to see if the user answer equals anything in here
                {
                    Console.WriteLine("\nGood job. Today is " + usrAnswer); // if answer is one of the items in enum then print this
                }
                else // else create our catch and print what is inside it
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nPlease enter an actual day of the week.");
            }
            Console.ReadLine();

        }
        public enum DaysOfTheWeek // this is our enum that is sorta like a class, but makes it so a user has to put in exactly what is in here or throw an error
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
