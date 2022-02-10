using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Class1
    {
        public void RandomMethod(int num1)// method that doesn't return anything but has a math operation going on
        {
            int dividNumber = num1 / 2;
            Console.WriteLine(dividNumber);
        }
        public void Methodless() // method with no parameters
        {
            Console.WriteLine("This is a method with no parameters");
        }
        public void RandomMethod(string sentence) // overload method of our first method
        {
            Console.WriteLine(sentence);
        }
    }
    public static class StaticClass // this is a static class( a class that hasn't been instantiated yet and we will then just call in our Main()
    {
        public static void Sentence()
        {
            Console.WriteLine("\nHello World!");
        }
    }
}
