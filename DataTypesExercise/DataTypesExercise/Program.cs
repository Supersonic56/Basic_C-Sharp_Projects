using System;

namespace StudentReport
{
    class Report
    {
        static void Main(string[] args)
        {
            // Display introductory message
            Console.WriteLine("Academy of Learning Career College \nStudent Daily Report.");

            // Prompt for and read the name of the student
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            // Prompt for and read the course the student is on
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            // Prompt for and read the page number
            Console.WriteLine("What page number?");
            int yourPage = Convert.ToInt32(Console.ReadLine());

            // Prompt for and read if the student needs help
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool NeedHelpBool = bool.Parse(needHelp);

            // Prompt for and read any positive experiences to share
            Console.WriteLine("Were there any positive experiences you’d like to share?");
            string yourExperience = Console.ReadLine();

            // Prompt for and read any other feedback
            Console.WriteLine("Is there any other feedback you’d like to provide?");
            string yourFeedback = Console.ReadLine();

            // Prompt for and read the number of hours the student studied today
            Console.WriteLine("How many hours did you study today?");
            string StudyHoursToday = Console.ReadLine();
            int yourHoursNr = Convert.ToInt32(StudyHoursToday);

            // Display closing message
            Console.WriteLine("Thank you for your answers.\nAn instructor will respond shortly. Have a great day!");

            // Wait for user input before exiting
            Console.ReadLine();
        }
    }
}
