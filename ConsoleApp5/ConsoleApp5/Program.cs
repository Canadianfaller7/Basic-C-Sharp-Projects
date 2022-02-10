using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 randomClass = new Class1(); // here we instantiated our class1 by making it into an object called randomClass

            string randomSentence = "\nThis is the same method as the one with no paramter but we have now overloaded it with a parameter"; // this is for our overload method

            randomClass.Methodless(); // this calls our method with no paramters and prints out a message only
            randomClass.RandomMethod(randomSentence); // this is an overload method of our RandomMethod that takes in a string parameter instead of an int

            Console.WriteLine("\nGive me a number:\n"); // this is for the original randomMethod method we originally made that has the int
            int usrNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n{usrNumber} divided by 2 equals:\n"); // inside our method we have a math operation going on and we tell the user what is happening
            randomClass.RandomMethod(usrNumber); // this is how we use our method from our class 

            StaticClass.Sentence(); // this is our StaticClass with our sentence inside and will be displayed to our screen. 
            // this is how we can access our class without instantiating it

            Console.ReadLine();
        }
    }
}
