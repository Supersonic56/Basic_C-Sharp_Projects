using System;

namespace Anon_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display introductory message
            Console.WriteLine("Anonymous Income Comparison Program");

            //print “Person 1” and “Person 2” to the screen
            //and take an input from the user: Hourly Rate, Hours worked per week
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your Hourly Rate?");
            float Number = float.Parse(Console.ReadLine());
            Console.WriteLine("How many hours of work per week?");
            float Hours = float.Parse(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your Hourly Rate?");
            float Number2 = float.Parse(Console.ReadLine());
            Console.WriteLine("How many hours of work per week?");
            float Hours2 = float.Parse(Console.ReadLine());

            //print to the screen “Annual salary of Person 1:” and write the exact salary below it.
            Console.WriteLine("Annual salary of Person 1: " + Environment.NewLine + Number);
            Console.ReadLine();

            //print to the screen “Annual salary of Person 2:” and write the exact salary below it.
            Console.WriteLine("Annual salary of Person 2: " + Environment.NewLine + Number2);
            Console.ReadLine();

            //print to the screen “Person 1 makes more money than Person 2”
            //and write the true or false value of this statement below it. 

            bool Income = Number > Number2;
            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.WriteLine(Income);
            Console.ReadLine();




        }
    }
}
