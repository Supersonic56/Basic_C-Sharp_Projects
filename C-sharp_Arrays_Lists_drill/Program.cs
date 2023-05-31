using System;
using System.Collections.Generic;

namespace C_sharp_Arrays_Lists_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] numArray = new int[5];
            numArray[0] = 2;
            numArray[1] = 4;
            numArray[2] = 6;
            numArray[3] = 8;
            numArray[4] = 10;*/

            //int[] numArray1 = new int[] { 3, 5, 7, 9, 11 };

            //int[] numArray2 = {17, 56, 88, 96, 156};

            /*
             List<string> colors = new List<string>() {"blue", "marron", "orange", "pink" };
                 foreach (string color in colors)
                 {
                     if (color == "blue")
                     {
                     Console.WriteLine(color);
                     Console.ReadLine();
                     }
                 }

            //Console.WriteLine(numArray2[1]);
            //Console.ReadLine();
            
             */
            //1. Created a one-dimensional Array of strings. Asked the user to select an index
            // of the Array and then display the string at that index on the screen.
            /*
             string[] myArray = new string[5] { "he", "she", "they", "them", "ours" };

             Console.WriteLine("Please enter an index (0-4): ");
             int index = Convert.ToInt32(Console.ReadLine());

             if (index < myArray.Length)
             {
                 Console.WriteLine("The string at index " + index + " is: " + myArray[index]);
                 Console.ReadLine();

             }
             else
             {
                 //3. Add in a message that displays when the user selects an index that
                 //doesn’t exist.
                 Console.WriteLine("Invalid index.");
                 Console.ReadLine();
             }
             */

            //2. Created a one-dimensional Array of integers. Asked the user to select an
            //index of the Array and then display the integer at that index on the screen.
            /*
             int[] myArray = new int[5] { 1, 2, 3, 4, 5 };

             Console.WriteLine("Please enter an index (0-4): ");
             int index = Convert.ToInt32(Console.ReadLine());

             if (index >= 0 && index < myArray.Length)
             {
                 Console.WriteLine("The integer at index " + index + " is: " + myArray[index]);
                 Console.ReadLine();
             }
             else
             {
                 //3. Add in a message that displays when the user selects an index that
                 //doesn’t exist.
                 Console.WriteLine("Invalid index.");
                 Console.ReadLine();
             }
            */




            /*
            4. Create a list of strings. Ask the user to select an index of the list and then
            display the content at that index on the screen.
*/
            List<string> myList = new List<string> { "he", "she", "they", "them", "ours" };

            Console.WriteLine("Please enter an index (0-4): ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index < myList.Count)
            {
                Console.WriteLine("The string at index " + index + " is: " + myList[index]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid index.");
                Console.ReadLine();
            }

        }
    }
}

