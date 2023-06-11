using System;

namespace Abstract_Override_drill
{
    class PersonX
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with firstName "Sample" and lastName "Student"
            Employee employee = new Employee { firstName = "Sample", lastName = "Student" };

            // Call the SayName method on the object
            employee.SayName();

            Console.ReadLine();
        }
    }
}

