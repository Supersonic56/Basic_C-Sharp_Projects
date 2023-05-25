using System;

namespace Boolean_Logic_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for user's age
            Console.WriteLine("Car Insurance Application");
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Prompt for DUI history
            Console.WriteLine("Have you ever had a DUI? Yes or No?");
            string answer = Console.ReadLine().ToLower();
            bool dui = answer == "yes";

            // Prompt for number of speeding tickets
            Console.WriteLine("How many speeding tickets do you have? Write as a number");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Check if the person is qualified for insurance
            bool qualified = (age > 15) && !dui && (tickets <= 3);

            // Display the result
            Console.WriteLine("Are you qualified for the insurance?");
            Console.WriteLine(qualified);

            // Wait for user input before exiting
            Console.ReadLine();
        }
    }
}
