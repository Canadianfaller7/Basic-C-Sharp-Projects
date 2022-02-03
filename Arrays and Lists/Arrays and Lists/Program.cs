using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
        // here is a lengthy way to make an array
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 20;
        numArray[4] = 200;

        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; // here is the short easier way to make an array

        int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 }; // here is an even shorter and easier way to make an array
        numArray2[5] = 650; // this changes the 600 above to 650

        Console.WriteLine(numArray2[3]);

        // here we will deal with lists

        List<int> intList = new List<int>(); // this is a way to make lists
        intList.Add(5); // here we add things to the list
        intList.Add(2); 
        intList.Add(10);
        intList.Remove(10); // here we remove something from our list

        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("Spencer");
        stringList.Add("Kristel");
        stringList.Remove("Hello");

        Console.WriteLine(stringList[1]);

        Console.WriteLine(intList[0]);

        Console.ReadLine();
        }
    }

