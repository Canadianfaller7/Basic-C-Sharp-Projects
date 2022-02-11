using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Employee : Person, IQuittable // now we inherit everything from Person and Iquittable class
    {
        public override void SayName() // implementing the method from our abstract class and telling it what to do when used
        {
           string fullName = firstName + " " + lastName; // made a var to combine both the first and last name properties
           Console.WriteLine(fullName); // having it be written to the console
        }
        public void Quit() // implementing the Quit method from our interface class
        {
            Console.WriteLine("I don't want to work today and just want to code"); // passing in this info to be written to console when method is called.
        }
    }
}
