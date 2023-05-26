using System;

namespace Do_While_Case_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number from 0 to 3: ");
            int num = Convert.ToInt32(Console.ReadLine()); // Read user input
            bool Guessed = num == 1; // Check if the initial guess is correct

            do
            {
                // The switch statement handles different cases based on the user's input (num)
                switch (num)
                {
                    case 0:
                    case 2:
                    case 3:
                        // Inform the user that their guess is close
                        Console.WriteLine("Close. Try again!");
                        Console.WriteLine("Guess the number: ");
                        num = Convert.ToInt32(Console.ReadLine()); // Assign the new input to the 'num' variable
                        break;
                    case 1:
                        // Inform the user that they guessed correctly
                        Console.WriteLine("Congrats! You guessed it!");
                        Guessed = true;
                        break;
                    default:
                        // Inform the user that their input is not a num
                        Console.WriteLine("It is not a number between 0 and 3. Give it another try!");
                        num = Convert.ToInt32(Console.ReadLine()); // Assign the new input to the 'num' variable
                        break;
                }
            }
            while (!Guessed); // Repeat the loop until the correct guess is made
            Console.Read();
        }
    }
}
