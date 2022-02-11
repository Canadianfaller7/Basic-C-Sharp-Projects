using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // we instantiate the Employee class and make it an object
            employee.firstName = "Sample"; // assign value to property
            employee.lastName = "Student"; // assign value
            employee.SayName(); // call method within the class

            IQuittable quit = new Employee(); // this is the use of polymorphism we made an object by calling the IQuittable class and making it equal to the Employee class
            quit.Quit(); // we then call the Interface method here

            Console.ReadLine(); // display sayName method
        }
    }
}
