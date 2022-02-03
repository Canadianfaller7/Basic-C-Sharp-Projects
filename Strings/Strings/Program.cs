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

            //string name = "Terran";
            //name = "Joe";

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Spencer, ");
            sb.Append("I am a junior software engineer.");
            sb.Append("\nI love to code, skateboard, modify gameboys, and hangout with my wife and our dogs.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
