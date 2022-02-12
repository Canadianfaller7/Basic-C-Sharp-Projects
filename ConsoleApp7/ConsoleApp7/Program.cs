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
            Employee employee1 = new Employee(); // we instantiate the Employee class and make it an object
            employee1.firstName = "Sample"; // assign value to property
            employee1.lastName = "Student"; // assign value
            employee1.Id = 1234;
            employee1.SayName(); // call method within the class

            Employee employee2 = new Employee(); // we instantiate the Employee class and make it an object
            employee2.firstName = "Student"; // assign value to property
            employee2.lastName = "Sample"; // assign value
            employee2.Id = 1235;
            employee2.SayName(); // call method within the class

            IQuittable quit = new Employee(); // this is the use of polymorphism we made an object by calling the IQuittable class and making it equal to the Employee class
            quit.Quit(); // we then call the Interface method here

            Console.WriteLine("\nAre these employees the same?\n");
            Console.WriteLine(employee1 == employee2); // comparing the two employee's to see if they are the same or not.(we didn't need to do employee1.Id because we already did that in our class so here we can just write it the way it is)

            Console.ReadLine(); // display sayName method
        }
    }
}
