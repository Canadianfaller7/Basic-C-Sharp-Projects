using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // this is to instantiate our class into an object

            employee.firstName = "Sample"; // we then access our classes properties and set a value to it (property name: firstName)
            employee.lastName = "Student"; // same thing as above but for lastName
            employee.sayName(); // here we call the method of our class

            Console.ReadLine();
        }
    }
}
