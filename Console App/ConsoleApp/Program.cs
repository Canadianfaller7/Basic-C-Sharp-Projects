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


            // list of colors
            List<string> colorList = new List<string>() { "blue", "white", "red", "green", "purple", "yellow", "orange", "black", "teal", "maroon", "gold", "pink", "brown" };

            // make this false so we can go through our while loop first
            bool isGuessed = false;
            while (!isGuessed)
            {
                Console.WriteLine("\nPut in your favorite color to see if it is on the list of colors:\n");
                string usrColor = Console.ReadLine(); // get users answer and save it in a var
                bool colorFound = false; // make another bool to check all colors

                // get index from colorList

                int index = colorList.FindIndex(a => a.Contains(usrColor)); // this will get the index of the value user put in

                // loop through colorList for usrColor

                for (int c = 0; c < colorList.Count; c++)
                {
                    if (colorList[c] == usrColor)
                    {
                        Console.WriteLine("\nThe index of the color you chose is: " + colorList.FindIndex(a => a.Contains(usrColor)) + ", It is apart of our list!\n"); // telling user we found their fav color at index whatever
                        colorFound = true; // now this is true, loop will stop
                        isGuessed = true; // same as above
                    }
                }
                // Tells user item isn't found
                if (!colorFound) { Console.WriteLine("\nSorry this color is not apart of our list."); }
            }

            // PART 5 OF ASSIGNEMENT

            List<string> carBrands = new List<string>() { "bmw", "chevy", "ford", "audi", "vw", "honda", "toyota", "mercedes", "subaru", "porsche", "ferrari", "lamborghini", "bugati", "mcLaren", "ford", "chevy", "toyota" };

            bool isRight = false; // same concept as above, have this as false to go through loop first
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
                        Console.WriteLine("\nThe brand of car you chose is at index:" + c + ", It is apart of our list!\n"); // this is how we tell the person we found their car, and this line will print twice if there are duplicates and tell us the indexes(indicies of them)
                        carBrandFound = true;
                        isRight = true;
                    }
                }
                // Tells user item isn't found
                if (!carBrandFound) { Console.WriteLine("\nSorry this color is not apart of our list."); }

            }
                // PART 6 OF ASSIGNMENT

            List<string> weatherList = new List<string>() { "sunny", "rainy", "snowy", "windy", "foggy", "sunny", "wet", "rainy", "wet", "icy" };
            List<string> newWeatherList = new List<string>(); // this will be used during the loop to store new info

            foreach (string weather in weatherList)
            {
                if (newWeatherList.Contains(weather))
                {
                    Console.WriteLine($"\n{weather}: has already appeared in the list.\n"); // this says if the blank list contains anything from the weatherList then print this
                }
                else
                {
                    newWeatherList.Add(weather); // if nothing is in the newList then add the items from the other list with no duplicates
                    Console.WriteLine($"\n{weather}: has not appeared in the list.\n"); // tells people nothing from our first list has appeared in the new list yet
                }
            }
            Console.WriteLine("List of weather types with no duplicates: {0}", string.Join(", ", newWeatherList)); // show the new list and will get rid of any duplicates that are in the first list


            Console.ReadLine();
        }
    }
}
