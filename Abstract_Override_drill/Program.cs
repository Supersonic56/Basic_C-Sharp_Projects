using System;

//Polymorphism Assignment
namespace Abstract_Override_drill
{
    // The main program inherits from the Employee class
    class Program : Employee
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with firstName "Sample" and lastName "Student"
            Employee employee = new Employee { FirstName = "Sample", LastName = "Student" };
            //Call the superclass method SayName() on the Employee object
            employee.SayName();
            employee.Quit();
            Console.ReadLine();

            // Use polymorphism to create an object of type IQuittable and call the Quit() method on it
            IQuittable quittableEmployee = new Employee();
            quittableEmployee.Quit();

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