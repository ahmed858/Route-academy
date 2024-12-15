using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05_Assignment
{
    internal class Q04
    {
        static int SumOfDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        public static void solve()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"The sum of the digits of the number {number} is: {SumOfDigits(number)}");
        }
    }
}
