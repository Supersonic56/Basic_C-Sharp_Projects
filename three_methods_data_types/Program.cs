using System;
using three_methods_data_types_Class1;

namespace three_methods_data_types
{
    public class MathOperations
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOperations2 mathOps = new MathOperations2();

            // Call the first method and display the result
            int result1 = mathOps.DoMath(3);
            Console.WriteLine(result1);
            Console.ReadLine();

            // Call the second method and display the result
            int result2 = mathOps.DoMath(3.5m);
            Console.WriteLine(result2);
            Console.ReadLine();

            // Call the third method and display the result
            int result3 = mathOps.DoMath("4");
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}
