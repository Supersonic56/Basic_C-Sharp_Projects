using System;

namespace optional_parameter_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOp mathOp = new MathOp();

            // Ask the user to input two numbers
            Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number (optional):");
            string secondNumberInput = Console.ReadLine();

            Console.WriteLine("The sum of your number(s) is:");

            int secondNumber = 0;
            bool isSecondNumberValid = int.TryParse(secondNumberInput, out secondNumber);

            // Call the method in the class, passing in the one or two numbers entered.
            if (isSecondNumberValid)
            {
                Console.WriteLine(mathOp.DoMathOp(firstNumber, secondNumber));
            }
            else
            {
                Console.WriteLine(mathOp.DoMathOp(firstNumber));
            }

            // Wait for user input before closing the console app.
            Console.ReadKey();
        }
    }
}

