using System;

namespace optional_parameter_drill
{
    public class MathOp
    {   
        public int DoMathOp(int firstNumber, int secondNumber = 0)
        {
            return firstNumber + secondNumber;;
        }
    }
}
