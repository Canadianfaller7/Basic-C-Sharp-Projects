using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Divide divide = new Divide(); // here we instantiate our class we made and make it into an object

            divide.getNumber(7, 12); // we then call the class here passing in 2 numbers for the parameters
            divide.getNumber(num1: 64, num2: 22); // this is the same, but here we are specifying the parameters by name and then giving a value

            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}
