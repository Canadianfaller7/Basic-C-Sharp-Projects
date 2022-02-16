using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string myName= "Spencer."; // this is a constant var of my Name and it cannot be changed ever
      
            var numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7}; // here we are using the var keyword to do a shortcut version of list

            for (int i = 0; i < numberList.Count; i++) // iterate to list and then print our list to console
            {
                Console.WriteLine(numberList[i]);
            }

            Program newPerson = new Program("Terran"); // here I instantiate the constructor and pass in a name but not a number because I want to use the default number as the fav number

            Console.WriteLine($"\nHello, my name is {myName}"); // writing a sentence using my const var
            Console.WriteLine($"\nHello my name is {newPerson.Name} and my favorite number is: {newPerson.Number}"); // writing a sentence using the object we made from our constructor

            Console.ReadLine();

        }
        public Program(string name) : this(name, 12) // here I am chaining two constructors together ( this one and the one below)
        {
        }
        public Program(string name, int number)
        {
            Name = name;
            Number = number;
        }
        public string Name { get; set; }
        public int Number { get; set; }
    }
}
