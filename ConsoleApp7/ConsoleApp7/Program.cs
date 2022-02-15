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
            Employee employee = new Employee();
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
            quit.Quit(); // we then call the Interface method here and print out the statement inside this method.

            Console.WriteLine("\nAre these employees the same?\n");
            Console.WriteLine(employee1 == employee2); // comparing the two employee's to see if they are the same or not.(we didn't need to do employee1.Id because we already did that in our class so here we can just write it the way it is)



            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, firstName = "Joe", lastName = "Student"},
                new Employee() { Id = 2, firstName = "Aiden", lastName = "Grant"},
                new Employee() { Id = 3, firstName = "Joe", lastName = "Adam"},
                new Employee() { Id = 4, firstName = "Bill", lastName = "Student"},
                new Employee() { Id = 5, firstName = "Randy", lastName = "Couch"},
                new Employee() { Id = 6, firstName = "Abby", lastName = "Jason"},
                new Employee() { Id = 7, firstName = "Mewtwo", lastName = "Eevee"},
                new Employee() { Id = 8, firstName = "Jack", lastName = "Frost"},
                new Employee() { Id = 9, firstName = "Chris", lastName = "Medium"},
                new Employee() { Id = 10, firstName = "Jane", lastName = "Doe"},
            };
            List<Employee> joeList = new List<Employee>(); // we will add all employees with the name joe to this ist

            foreach (Employee emp in employees) // we do that by iterating through our employees list to get all their info
            {
                if (emp.firstName == "Joe") // if name equals joe
                {
                    joeList.Add(emp); // ad them to the joeList list
                }
            }
            foreach (Employee joeEmployee in joeList) // iterate through joeList
            {
                string empInfo = $"\nId:{joeEmployee.Id}, {joeEmployee.firstName} {joeEmployee.lastName}"; // add info from joe list here
                Console.WriteLine(empInfo); // print string above
            }
            List<Employee> employeeLambdaList = employees.Where(x => x.Id > 5).ToList(); // here we make a new list using the lambda expression. we are sying make this list of all employees with an id higher then 5

            foreach(Employee employeeLambda in employeeLambdaList) // then we do the same as above, iterate through list to get info
            {
                string empLambdaInfo = $"\nId:{employeeLambda.Id}, {employeeLambda.firstName} {employeeLambda.lastName}"; // save info here
                Console.WriteLine(empLambdaInfo); // print the info
            }
            
            Console.ReadLine(); // display sayName method
        }
    }
}
