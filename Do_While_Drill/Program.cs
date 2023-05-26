using System;

namespace Do_While_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite season: ");
            string season = Console.ReadLine().ToLower(); // Read user input and convert to lowercase
            bool Guessed = season == "spring"; // Check if the initial guess is correct

            do
            {
                // The switch statement handles different cases based on the user's input (season)
                switch (season)
                {
                    case "summer":
                    case "fall":
                    case "winter":
                        // Inform the user that their guess is close
                        Console.WriteLine("Close. Try again!");
                        Console.WriteLine("Guess the season: ");
                        season = Console.ReadLine().ToLower(); // Assign the new input to the 'season' variable
                        break;
                    case "spring":
                        // Inform the user that they guessed correctly
                        Console.WriteLine("Congrats! You guessed it!");
                        Guessed = true;
                        break;
                    default:
                        // Inform the user that their input is not a season
                        Console.WriteLine("It is not a season. Give it another try!");
                        season = Console.ReadLine().ToLower(); // Assign the new input to the 'season' variable
                        break;
                }
            }
            while (!Guessed); // Repeat the loop until the correct guess is made
            Console.Read();
        }
    }
}
