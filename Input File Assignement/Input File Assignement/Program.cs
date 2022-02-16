using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_File_Assignement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number:\n");
            string usrNum = Console.ReadLine();
            File.WriteAllText(@"D:\GitHub\Basic-C-Sharp-Projects\Input File Assignement\log.txt", usrNum);
            Console.WriteLine("\nHere is the number that we saved:\n" + File.ReadAllText(@"D:\GitHub\Basic-C-Sharp-Projects\Input File Assignement\log.txt"));
            Console.ReadLine();
        }
    }
}
