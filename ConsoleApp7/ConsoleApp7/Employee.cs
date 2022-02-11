using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Employee : Person
    {
        public override void SayName() // implementing the method from our abstract class and telling it what to do when used
        {
           string fullName = firstName + " " + lastName; // made a var to combine both the first and last name properties
           Console.WriteLine(fullName); // having it be written to the console
        }
    }
}
