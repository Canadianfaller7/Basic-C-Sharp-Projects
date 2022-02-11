using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public abstract class Person // made this so it can never be instantiated and become an object
    {
        public string firstName { get; set; } // property of class
        public string lastName { get; set; } // another property

        public abstract void SayName(); // made this an abstract method stating whatever class inherits the Person class must have this method as well
    }
}
