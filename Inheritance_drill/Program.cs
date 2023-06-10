using System;

namespace Inheritance_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiated and initialized an Employee object with 
            //the first name "Sample" and the last name "Student"
            Employee emp1 = new Employee() {FirstName = "Sample", LastName = "Student" };
            //Called the superclass method SayName() on the Employee object
            emp1.SayName();
            Console.ReadLine();
        }
    }
}