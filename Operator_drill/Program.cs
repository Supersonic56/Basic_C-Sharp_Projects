using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_drill
{
    class Program : Employee
    {
        static void Main(string[] args)
        {
            //instantiate two objects of the Employee class
            //and assign values to their properties
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Wick" };
            Employee employee2 = new Employee { Id = 2, FirstName = "Joe", LastName = "Black" };

            // Compare the two Employee objects using the overloaded "==" and "!=" operators
            Console.WriteLine(employee1 == employee2); //False
            Console.WriteLine(employee1 != employee2); //True

            Console.ReadKey();
        }
    }
}

/*
Perform these actions and create a console app that includes the following:

Create an Employee class with Id, FirstName and LastName properties. 
In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property. 
Remember that comparison operators must be overloaded in pairs. 

In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their properties. 
Then compare the two Employee objects using the newly overloaded operators and display the results.
Add comments 
*/