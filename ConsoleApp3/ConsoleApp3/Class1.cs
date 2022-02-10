using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class1
    {
        public int Number(int number1, int number2 = 7) // this is my method taking 2 int parameters but the second one is optional
            // so if a second parameter isn't entered it will have a default value of 7
        {
            return number1 + number2;
        }
    }
}
