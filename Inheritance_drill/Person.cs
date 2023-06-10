using System;

namespace Inheritance_drill
{
    public class Person
    {
            //Created a class called Person and give it two properties, each of data type string
            public string FirstName { get; set; }
            public string LastName { get; set; }
            
            //Gave the class a void method that takes no parameters and simply writes
            //the person full name to the console in the given format
            public void SayName()
                
                {
                Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
                }

        
    }
}
