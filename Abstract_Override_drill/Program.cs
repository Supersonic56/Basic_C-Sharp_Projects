using System;

namespace Abstract_Override_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with firstName "Sample" and lastName "Student"
            Employee employee = new Employee { FirstName = "Sample", LastName = "Student" };
            //Call the superclass method SayName() on the Employee object
            employee.SayName();
            Console.ReadLine();
        }
    } 
}


/*
Create an abstract class called Person with two properties: string firstName and string lastName.
Give it the method SayName().
Create another class called Employee and have it inherit from the Person class.
Implement the SayName() method inside of the Employee class.
Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”. Call the SayName() method on the object.

*/