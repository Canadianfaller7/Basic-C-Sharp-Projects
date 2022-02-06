using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // PART 1 OF ASSIGNMENT

            string[] txtArray = { "Hello there! Today we are going to iterate through some code.", "What do you like to do?", "We will get some user input and add it to our array.", "Have a wonderful day!" };
            Console.WriteLine("Please input some text tha you would like to add to the end of my sentence I created:\n");
            string usrInput = Console.ReadLine();

            foreach (string txt in txtArray)
            {
                Console.WriteLine(txt + " " + usrInput);
            }

            // PART 2 & 3 OF ASSIGNMENT

            int num1 = 0;
            int num2 = 0;

            while (num1 < 10)
            {
                Console.WriteLine(num1);
                num1++;
            }

            while (num2 <= 25)
            {
                Console.WriteLine(num2);
                num2++;
            }

            // PART 4 OF ASSIGNMENT-------------

            List<string> colorList = new List<string>() { "blue", "white", "red", "green", "purple", "yellow", "orange", "black", "teal", "maroon", "gold", "pink", "brown" };

            bool isGuessed = false;
            while (!isGuessed)
            {
                Console.WriteLine("\nPut in your favorite color to see if it is on the list of colors:\n");
                string usrColor = Console.ReadLine();
                bool colorFound = false;

                // get index from colorList

                int index = colorList.FindIndex(a => a.Contains(usrColor));

                // loop through colorList for usrColor

                for (int c = 0; c < colorList.Count; c++)
                {
                    if (colorList[c] == usrColor)
                    {
                        Console.WriteLine("\nThe index of the color you chose is: " + colorList.FindIndex(a => a.Contains(usrColor)) + ", It is apart of our list!\n");
                        colorFound = true;
                        isGuessed = true;
                    }
                }
                // Tells user item isn't found
                if (!colorFound) { Console.WriteLine("\nSorry this color is not apart of our list."); }
            }

            // PART 5 OF ASSIGNEMENT

            List<string> carBrands = new List<string>() { "bmw", "chevy", "ford", "audi", "vw", "honda", "toyota", "mercedes", "subaru", "porsche", "ferrari", "lamborghini", "bugati", "mcLaren", "ford", "chevy", "toyota" };

            bool isRight = false;
            while (!isRight)
            {
                Console.WriteLine("\nPut in your favorite car brand:\n");
                string usrCarBrand = Console.ReadLine();
                bool carBrandFound = false;

                // loop through colorList for usrColor

                for (int c = 0; c < carBrands.Count; c++)
                {
                    if (carBrands[c] == usrCarBrand)
                    {
                        Console.WriteLine("\nThe brand of car you chose is at index:" + c + ", It is apart of our list!\n");
                        carBrandFound = true;
                        isRight = true;
                    }
                }
                // Tells user item isn't found
                if (!carBrandFound) { Console.WriteLine("\nSorry this color is not apart of our list."); }

            }
                // PART 6 OF ASSIGNMENT

            List<string> weatherList = new List<string>() { "sunny", "rainy", "snowy", "windy", "foggy", "sunny", "wet", "rainy", "wet", "icy" };
            List<string> newWeatherList = new List<string>();

            foreach (string weather in weatherList)
            {
                if (newWeatherList.Contains(weather))
                {
                    Console.WriteLine($"\n{weather}: has already appeared in the list.\n");
                }
                else
                {
                    newWeatherList.Add(weather);
                    Console.WriteLine($"\n{weather}: has not appeared in the list.\n");
                }
            }
            Console.WriteLine("List of weather types with no duplicates: {0}", string.Join(", ", newWeatherList));


            Console.ReadLine();
        }
    }
}
