using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05_Assignment
{
    internal class Q07
    {
        static int Factorial(int number)
        {
            int result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        public static void solve()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Factorial of {number} is: {Factorial(number)}");
        }
    }
}
