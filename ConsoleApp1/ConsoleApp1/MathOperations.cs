using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MathOperations // here is the class I made
    {
        /* this is a method that will return an int and the method is called addNumber and takes a paramater of 1 int. I then have an int
         var inside equal to 22 and then I make another var that takes whatever number the user will put in and add it to the num var and then
        I will return the result of the 2 numbers added together*/
        public static int addNumber(int number1) 
        {
            int num = 22;
            int addNumbers = number1 + num;
            return addNumbers;
        }
        public static int multiplyNumber(int number2) // same as above but will multiply the numbers
        {
            
            int num = 9;
            int multiplyNumbers = number2 * num;
            return multiplyNumbers;
        }
        public static decimal divideNumber(decimal number3) // same as above but divide the numbers. Made it a float to get decimals  and not just zero
        {
            int num = 2;
            decimal divideNumbers = num / number3;
            return divideNumbers;
        }
    }
}
