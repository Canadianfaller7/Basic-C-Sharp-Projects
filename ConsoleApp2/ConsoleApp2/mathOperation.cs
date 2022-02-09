using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class mathOperation // this is my class I made
    {
        public static int mathOperations(int number) // this is a method called mathOperations and will return an int and takes a paramater of int
        {
            return number * 12; // this is saying return a number multiplied by 12
        }
        public static decimal mathOperations(decimal number1) // method with return type decimal and paramater of decimal
        {
            return number1 / 2; // return a number divided by 2
        }
        public static string mathOperations(double number2) // method with return type string and parameter of double
        {
            return Convert.ToString(number2 + 55); // return a number + 55( all numbers shown will be given by the user)
        }

    }
}
