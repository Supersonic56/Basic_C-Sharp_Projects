using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their age
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();

            try
            {
                // Parse the user's input as an integer
                int age = int.Parse(input);

                // Check if the age is zero or negative
                if (age <= 0)
                {
                    throw new ArgumentException("Age must be a positive number.");
                }

                // Calculate the year the user was born
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;

                // Display the year the user was born
                Console.WriteLine("You were born in the year: " + birthYear);
            }
            catch (ArgumentException ex)
            {
                // Handle ArgumentExceptions (e.g. if the age is zero or negative)
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                // Handle FormatExceptions (e.g. when the format of an argument is invalid)
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                // Handle all other exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}

/*
In this example, we have a C# console application that asks the user for their age and then calculates and displays the year they were born. We use a `try` block to contain the code that might cause an exception and two `catch` blocks to handle different types of exceptions.

The first `catch` block handles `ArgumentExceptions`, which are thrown if the user enters an age that is zero or negative.In this case, we display an error message to the user.

The second `catch` block handles all other exceptions.In this case, we display a general error message to the user.

Throughout the code, we have added comments to explain what each line or block of code does.
*/