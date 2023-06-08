using System;

namespace Method_Class_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(); // Instantiate the class

            myClass.MyMethod(5, 10); // Call the method in the class, passing in two numbers

            myClass.MyMethod(num1: 3, num2: 6); // Call the method in the class, specifying the parameters by name
        }
    }
}
