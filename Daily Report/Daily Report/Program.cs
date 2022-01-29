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
            Console.WriteLine("The Tech Academy.\n\nStudent Daily Report.\n\n");
            Console.WriteLine("What is your name?\n");
            string name = Console.ReadLine().ToUpper();
            Console.WriteLine();
            Console.WriteLine("What course are you on?\n");
            string course = Console.ReadLine().ToUpper();
            Console.WriteLine();
            Console.WriteLine("What page number?\n");
            string pgNum = Console.ReadLine();
            int num = Convert.ToInt32(pgNum);
            Console.WriteLine();
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"\n");
            string yOrn = Console.ReadLine();
            bool answer = Convert.ToBoolean(yOrn);
            Console.WriteLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("How man hours did you study today?");
            string hours = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hours);
            Console.WriteLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
