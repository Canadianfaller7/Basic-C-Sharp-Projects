using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Person // this is a class
    {
        public string  firstName { get; set; } // these are properties all people have
        public string lastName { get; set; } // same as above

        public void sayName() // method to combine both the first and last name of a person and then display it to the console
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Name: {fullName}");
        }
    }
}
