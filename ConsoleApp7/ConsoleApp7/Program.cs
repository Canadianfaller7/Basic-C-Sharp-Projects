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
            Console.ReadLine(); // display sayName method
        }
    }
}
