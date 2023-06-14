using System;
using System.Collections.Generic;
using System.Linq;


namespace Lambda_Expression_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Create a list of at least 10 employees
            var employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 4, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 5, FirstName = "Bob", LastName = "Smith" },
                new Employee { Id = 6, FirstName = "Sue", LastName = "Johnson" },
                new Employee { Id = 7, FirstName = "Tom", LastName = "Jones" },
                new Employee { Id = 8, FirstName = "Tim", LastName = "Cook" },
                new Employee { Id = 9, FirstName = "Steve", LastName = "Jobs" },
                new Employee { Id = 10, FirstName = "Bill", LastName = "Gates" }
            };

            //// Create a new list of all employees with the first name “Joe” using a foreach loop
            var joes1 = new List<Employee>();
            foreach(var employee in employees)
            {
                if(employee.FirstName == "Joe")
                {
                    joes1.Add(employee);
                    
                }
            }

            // Perform the same action again,
            // but this time with a lambda expression
            var joes2 = employees.Where(e => e.FirstName == "Joe").ToList();

            // Make a list of all employees with an Id number greater than 5 using a lambda expression
            var IdSixPlus = employees.Where(e => e.Id > 5).ToList();

            // Print the lists to the console
            Console.WriteLine("Employees with first name Joe (using foreach loop): ");
            foreach (var employee in joes1)
            {
                Console.WriteLine($"Id: {employee.Id}, First Name: {employee.FirstName}, Last Name: {employee.LastName}");
            }

            Console.WriteLine("\nEmployees with first name Joe (using lambda expression):");
            foreach (var employee in joes2)
            {
                Console.WriteLine($"Id: {employee.Id}, First Name: {employee.FirstName}, Last Name: {employee.LastName}");
            }

            Console.WriteLine("\nEmployees with Id greater than 5:");
            foreach (var employee in IdSixPlus)
            {
                Console.WriteLine($"Id: {employee.Id}, First Name: {employee.FirstName}, Last Name: {employee.LastName}");
            }
            Console.ReadKey();
        }
    }
}
