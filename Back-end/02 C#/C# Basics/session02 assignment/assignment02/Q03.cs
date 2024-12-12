using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment02
{
    public  class Q03
    {
        public static void solve()
        {
            float number1 = 0.1f;
            float number2 = 0.2f;

            
            float addition = number1 + number2;
            float subtraction = number1 - number2;
            float multiplication = number1 * number2;
            float division = number1 / number2;

            
            Console.WriteLine("Number1: " + number1);
            Console.WriteLine("Number2: " + number2);
            Console.WriteLine("Addition: " + addition.ToString("F10"));
            Console.WriteLine("Subtraction: " + subtraction.ToString("F10"));
            Console.WriteLine("Multiplication: " + multiplication.ToString("F10"));
            Console.WriteLine("Division: " + division.ToString("F10"));
            /*Floating-point numbers may not be represented precisely in binary, which can lead to rounding errors.*/
        }

    }
}
