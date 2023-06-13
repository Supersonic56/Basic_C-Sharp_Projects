using System;

namespace Abstract_Override_drill
{
    // Abstract class Person
    public abstract class Person
    {
        // Properties for first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method SayName
        public abstract void SayName();
    }
}
/*
Create an abstract class called Person with two properties: string firstName and string lastName.
Give it the method SayName().
Create another class called Employee and have it inherit from the Person class.
Implement the SayName() method inside of the Employee class.
Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”. Call the SayName() method on the object.

*/






