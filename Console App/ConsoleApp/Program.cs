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

            string[] txtArray = { "Here is a random sentence. Here is the text you wrote:", "Black", "I love coding.", "Have a wonderful day!" }; // a string array of random text
            Console.WriteLine("Please input some text tha you would like to add to the end of the sentences I have created created:\n");
            string usrInput = Console.ReadLine(); // save user input

            foreach (string txt in txtArray) // iterate through the array 
            {
                Console.WriteLine(txt + " " + usrInput); // add the users text at the end of each string inside the array and display it
            }

            // PART 2 & 3 OF ASSIGNMENT

            int num1 = 0;
            int num2 = 0;

            while (num1 < 10) // while loop that as long as the num1 var is less than 10 add 1 to num1 then stop at 9
            {
                Console.WriteLine(num1);
                num1++;
            }

            while (num2 <= 25) // while loop that says add 1 to num2 until it equals 25 and then stop
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
