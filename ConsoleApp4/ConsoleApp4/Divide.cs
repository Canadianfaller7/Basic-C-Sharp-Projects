using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Divide // this is our class
    {
        public void getNumber(int num1, int num2) // we do void because we aren't returning the parameters
        {
            int divideNumbers = num1 / 2; // take first parameter and divide by 2
            Console.WriteLine(divideNumbers); // display our math operation to screen
            Console.WriteLine(num2); // display second parameter to screen only
        }
    }
}
