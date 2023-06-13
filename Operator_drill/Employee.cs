using System;

namespace Operator_drill
{
    //Create an Employee class with Id, FirstName and LastName properties
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // Overload the "==" operator to compare two Employee objects by their Id property
        public static bool operator == (Employee e1, Employee e2)
        {
            return e1.Id == e2.Id;
        }

        // Overload the "!=" operator
        // to compare two Employee objects by their Id property
        public static bool operator != (Employee e1, Employee e2)
        {
            return e1.Id != e2.Id;
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