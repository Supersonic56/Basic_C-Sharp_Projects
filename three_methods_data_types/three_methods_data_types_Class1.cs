using System;

namespace three_methods_data_types_Class1
{
    public class MathOperations2
    {
        // Method that takes in an integer and returns the result of a math operation
        public int DoMath(int num)
        {
            return num + 5;
        }

        // Method that takes in a decimal and returns the result of a math operation
        public int DoMath(decimal num)
        {
            return (int)(num * 2);
        }

        // Method that takes in a string, converts it to an integer if possible,
        // and returns the result of a math operation
        public int DoMath(string str)
        {
            int num;
            if (int.TryParse(str, out num))
            {
                return num - 3;
            }
            else
            {
                return 0;
            }
        }
    }
}
