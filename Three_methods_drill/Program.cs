using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three_methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to the Gainzzz-meter!");

            // Prompt user for recovery rate
            Console.WriteLine("How much recovered you feel after the workout (range: 1-10)?");
            int tired = Convert.ToInt32(Console.ReadLine());

            // Calculate and display recovery rate
            int regeneration = Three_methods.Recovery(tired);
            Console.WriteLine("Your recovery rate from the workout is: " + regeneration + " and the higher number in the range of 25-34 the better");

            // Prompt user for strength
            Console.WriteLine("Now let's talk your strength training");
            Console.WriteLine("How heavy have you been lifting at the last sesion (range: 1-10)?");
            int strong = Convert.ToInt32(Console.ReadLine());

            // Calculate and display strength increase
            int weights = Three_methods.Strength(strong);
            Console.WriteLine("Your strength will increase by the next session by: " + " plus " + weights + " on the scale from 5 to 15 and the higher the better");

            // Prompt user for athleticism
            Console.WriteLine("Now let's talk your strength training");
            Console.WriteLine("How athletic are you feeling today (range: 1-10)");
            int athletic = Convert.ToInt32(Console.ReadLine());

            // Calculate and display performance score
            int impact = Three_methods.Athleticism(athletic);
            Console.WriteLine("your performance score today is: " + impact + " and the higher number in the range of 24 - 34 the better");

            // Wait for user input before closing
            Console.ReadLine();
        }
    }
}