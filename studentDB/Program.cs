using System;
using System.Data.Entity;
using System.Linq;

namespace studentDB
{
    public class Student
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
    }

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                // Create and save a new Student
                Console.Write("Enter last name for a new Student: ");
                var name = Console.ReadLine();
                Console.Write("Enter first name for a new Student: ");
                var firstname = Console.ReadLine();

                var student = new Student { LastName = name, FirstName = firstname };
                db.Students.Add(student);
                db.SaveChanges();

                // Display all Students from the database
                var query = from s in db.Students
                            orderby s.LastName
                            select s;

                Console.WriteLine("All students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine("Name: " + item.LastName + ", " + item.FirstName);
                }

               

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}