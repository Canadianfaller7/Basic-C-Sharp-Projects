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
            
            Console.WriteLine("The Tech Academy.\n\nStudent Daily Report.\n\nWhat is your name?\n");
            string usrName = Console.ReadLine();
            
            Console.WriteLine("What course are you on?\n");
            string courseName = Console.ReadLine();
           
            Console.WriteLine("What page number?\n");
            int pgNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Do you need help with anything? Please answer \"yes\" or \"no\"\n");
            bool yOrn = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.\n");
            string feedback = Console.ReadLine();
            
            Console.WriteLine("How man hours did you study today?\n");
            int hours = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
            

        }
    }
}
