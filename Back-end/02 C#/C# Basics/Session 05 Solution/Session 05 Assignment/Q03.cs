using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05_Assignment
{
    internal class Q03
    {
        static (int Sum, int Difference) Calculate(int a, int b, int c, int d)
        {
            int sum = a + b + c + d;
            int difference = (a + b) - (c + d);
            return (sum, difference);
        }

        public static void solve()
        {

            Console.WriteLine("Enter 4 numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            var result = Calculate(num1, num2, num3, num4);

            Console.WriteLine($"Sum: {result.Sum}, Difference: {result.Difference}");
        }
    }
}
