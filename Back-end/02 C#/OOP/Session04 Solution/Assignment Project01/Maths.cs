using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Project01
{
    internal class Maths
    {
        // Add method
        public static double Add(double a, double b)
        {
            return a + b;
        }

        // Subtract method
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiply method
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Divide method
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }
    }
}
