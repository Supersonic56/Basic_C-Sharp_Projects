using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three_methods
{
    public class Three_methods
    {
        // Method to calculate strength increase
        public static int Strength(int strong)
        {
            int weights = strong + 5;
            return weights;
        }

        // Method to calculate recovery rate
        public static int Recovery(int tired)
        {
            int sleep = 10;
            int food = 10;
            int relax = 10;
            int recovered = (sleep + food + relax - tired);
            return recovered;
        }

        // Method to calculate performance score
        public static int Athleticism(int athletic)
        {
            int power = 10;
            int endurance = 8;
            int sickness = 5;
            int performance = (power + endurance + athletic - sickness);
            return performance;

        }
    }
}