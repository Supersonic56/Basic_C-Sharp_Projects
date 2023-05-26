using System;


namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            //The user is for the package weight
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("What is the package weight?");
            float weight = float.Parse(Console.ReadLine()); // Read user input as float

            if (weight <= 50)
            {
                Console.WriteLine();
            }
            else
            {   // If the weight exceeds 50, display an error message and terminate the program
                Console.WriteLine("Package too heavy to be shipped via Package Express. The program will close now. Have a good day.");
                Console.ReadLine();
                return;
            }

            //The user is prompted for the package width, height and length
                Console.WriteLine("What is the package width?");
                float width = float.Parse(Console.ReadLine()); // Read user input as float


            Console.WriteLine("What is the package height?");
                float height = float.Parse(Console.ReadLine()); // Read user input as float


            Console.WriteLine("What is the package length?");
                float length = float.Parse(Console.ReadLine()); // Read user input as float


            float total_dimension = width + height + length; // Calculate the total dimensions
            float quote = (width * height * length * weight) / 100; // Calculate the quote
            decimal quote_decimal = (decimal)quote; // Convert the quote to decimal

            // Convert the decimal quote to a string with two decimal places
            string Two_Decimal_Places = quote_decimal.ToString("0.00");

            if (total_dimension <= 50)
            {
                // If the total dimension is within the limit, display the estimated total with two decimal places
                Console.WriteLine("Your estimated total for shipping this package is: $ " + Two_Decimal_Places);
                Console.ReadLine();
            }
            else
            {
                // If the total dimension exceeds the limit, display an error message and terminate the program
                Console.WriteLine("Package too big to be shipped via Package Express. The program will close now. Have a good day.");
                Console.ReadLine();
                return;
            }

        }
    }
}
