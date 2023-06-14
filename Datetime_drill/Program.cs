using System;

namespace Datetime_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            DateTime now = DateTime.Now;
            Console.WriteLine($"The current date and time is: {now}");

            // Ask the user for a number
            Console.Write("Please enter a number of hours: ");
            int hours = int.Parse(Console.ReadLine());

            // Calculate the time it will be in X hours
            DateTime futureTime = now.AddHours(hours);

            // Print the future time to the console
            Console.WriteLine($"In {hours} hours, it will be: {futureTime}");
        }
    }
}



