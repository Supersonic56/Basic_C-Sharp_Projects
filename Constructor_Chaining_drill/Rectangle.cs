using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Chaining_drill
{
    class Rectangle
    {
        private int width;
        private int height;

         // This is the first constructor.
         // It takes no arguments and sets default values for width and height.
        public Rectangle() : this(0,0)
        {
            // This constructor is empty because all the work is done by the second constructor.
        }
        // This is the second constructor. It takes two arguments and sets the values for width and height.
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        // This is the third constructor. It takes one argument and sets the value for width. The value for height is set to a default value by calling the second constructor.
        public Rectangle(int width) : this(width, 0)
        {
            // This constructor is empty because all the work is done by the second constructor.
        }

        // Method to calculate the area of the rectangle
        public int GetArea()
        {
            return width * height;
        }
    }
}
