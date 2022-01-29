using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pgNum = 0;
            bool yOrn = true;
            int hours = 0;
            Console.WriteLine("The Tech Academy.\n\nStudent Daily Report.\n\n");
            Console.WriteLine("What is your name?\n");
            Console.ReadLine().ToUpper();
            Console.WriteLine();
            Console.WriteLine("What course are you on?\n");
            Console.ReadLine().ToUpper();
            Console.WriteLine();
            Console.WriteLine("What page number?\n");
            pgNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"\n");
            yOrn = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.\n");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("How man hours did you study today?");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
