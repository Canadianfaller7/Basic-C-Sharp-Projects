using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name?");
            var username = Console.ReadLine();
            Console.WriteLine($"\nHello {username}!");
        }
    }
}
 