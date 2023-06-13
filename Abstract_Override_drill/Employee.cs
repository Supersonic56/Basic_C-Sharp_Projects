using System;

//Polymorphism Assignment
namespace Abstract_Override_drill
{
    // Create the Employee class and have it inherit from the Person class
    public class Employee : Person, IQuittable
    {
    
    public int Id { get; set; }
        //Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        // The Employee class inherits the IQuittable interface and implements the Quit() method
        public void Quit()
        {
            Console.WriteLine("The employee has quit");
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

/*
Perform these actions and create a console app that includes the following:
Create an interface called IQuittable and have it define a void method called Quit().
Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
Use polymorphism to create an object of type IQuittable and call the Quit() method on it. 
Hint: an object can be of an interface type if it implements that specific interface.

 */