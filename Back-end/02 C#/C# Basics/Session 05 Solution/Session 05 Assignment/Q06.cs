using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05_Assignment
{
    internal class Q06
    {
        static void MinMaxArray(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];

            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
        }

        public static void solve()
        {
            int[] numbers = { 5, 3, 9, 1, 6 };
            MinMaxArray(numbers, out int min, out int max);

            Console.WriteLine($"Minimum: {min}, Maximum: {max}");
        }
    }
}
