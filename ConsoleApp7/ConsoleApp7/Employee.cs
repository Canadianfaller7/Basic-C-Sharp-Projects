using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Employee : Person, IQuittable // now we inherit everything from Person and Iquittable class
    {
        public int Id { get; set; }
        public override void SayName() // implementing the method from our abstract class and telling it what to do when used
        {
           string empInfo = $"Employee Id: {Id}, Name: {firstName} {lastName}\n"; // made a var to combine both the first and last name properties
           Console.WriteLine(empInfo); // having it be written to the console
        }
        public void Quit() // implementing the Quit method from our interface class
        {
            Console.WriteLine("I don't want to work today and just want to code"); // passing in this info to be written to console when method is called.
        }
        public  static bool operator == (Employee employee1, Employee employee2) // here we are overloadig the == operator and passing in 2 parameters of employee's
        {
            if (employee1.Id == employee2.Id) // we then say if their Id's are equal to return true
            {
                return true;
            }
            else
            {
                return false; // if not return false
            }
        }
        public static bool operator != (Employee employee1, Employee employee2) // we need to overloaded the not equal operator as well to satisfy the override of the == operator
        { 
            return !(employee1 == employee2);  
        }
    }
}
