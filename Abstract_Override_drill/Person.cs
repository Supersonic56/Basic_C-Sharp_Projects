using System;

namespace Abstract_Override_drill
{
    // Abstract class Person
    public abstract class Person
    {
        // Properties for first and last name
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Abstract method SayName
        public abstract void SayName();
    }

    // Class Employee that inherits from Person
    public class Employee : Person
    {
        // Implementation of SayName method
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}






