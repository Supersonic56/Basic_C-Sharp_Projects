using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Chaining_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Rectangle object using the first constructor
            Rectangle rect1 = new Rectangle();

            // Create a new Rectangle object using the second constructor
            Rectangle rect2 = new Rectangle(10, 20);

            // Create a new Rectangle object using the third constructor
            Rectangle rect3 = new Rectangle(30);

            // Use the GetArea method to calculate the area of each rectangle
            int area1 = rect1.GetArea();
            int area2 = rect2.GetArea();
            int area3 = rect3.GetArea();

            // Print the areas of the rectangles
            Console.WriteLine("Area of rect1: " + area1);
            Console.WriteLine("Area of rect2: " + area2);
            Console.WriteLine("Area of rect3: " + area3);
        }
    }
}
