using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_block_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int> { 10, 20, 30, 40 };

            // Ask the user for a number to divide each number in the list by
            Console.Write("Enter a number to divide by: ");
            string input = Console.ReadLine();

            try
            {
                // Parse the user input as an integer
                int divisor = int.Parse(input);

                // Loop through each integer in the list
                foreach (int number in numbers)
                {
                    // Divide the integer by the user-entered number and display the result
                    int result = number / divisor;
                    Console.WriteLine($"{number} divided by {divisor} is {result}");
                    Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                // Handle format exceptions specifically
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                // Handle all other exceptions
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                // Code in this block will always be executed regardless of whether an exception occurred or not
                Console.WriteLine("The try/catch block has completed.");
                Console.ReadLine();
            }

            // Print a message to let the user know the program has emerged from the try/catch block
            Console.WriteLine("Program execution continued.");
            Console.ReadLine();
        }
    }
}

/*
 * Perform these actions and create a console app that includes the following:
1. Create a list of integers. Ask the user for a number to divide each number
in the list by. Write a loop that takes each integer in the list, divides it by
the number the user entered, and displays the result to the screen.
2. Run the code, entering in non-zero numbers as the user. Look at the
displayed results.
3. Run the code again, entering in zero as the number to divide by. Note any
error messages you get.
4. Run the code once again, entering in a string as the number to divide by.
Note any error messages you get.
5. Now put the loop in a try/catch block. Below and outside of the try/catch
block, make the program print a message to the display to let you know
the program has emerged from the try/catch block and continued on with
program execution. In the catch block, display the error message to the
screen. Then try various combinations of user input: valid numbers, zero
and a string. Ensure the proper error messages display on the screen, and
that the code after the try/catch block gets executed.
6. Add comments to each line or block of your code to explain what it does
exactly, so that another developer could read and understand your code.
*/