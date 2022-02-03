using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Spencer";
            //string quote = "The man said, \"Hello\", Spencer. \nHello on a new line.\n\tHello on a tab.\nHello on a new line with a backslash \\";
            //string fileName = @"C:\Users\canad";

            //bool trueOrfalse = name.Contains("s");
            //trueOrfalse = name.EndsWith("q");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            /* here I am concatenating these variables with more stirng to build a sentence and then printing to final code */
            string name = "Terran";
            string description = name + ", is my best friend and is the one who helped me get into coding";
            string hobbies = description + ".\nWe both love skating, coding, playing chess, and building gameboys together.\n";
            Console.WriteLine(hobbies);

        
            /* here we are using the stringBuilder class to build a paragraph about myself without having to create multiple variables like
             above and waste space in memory.*/
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Spencer, ");
            sb.Append("I am a junior software engineer.");
            sb.Append("\nI love to code, skateboard, modify gameboys, and hangout with my wife and our dogs.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
