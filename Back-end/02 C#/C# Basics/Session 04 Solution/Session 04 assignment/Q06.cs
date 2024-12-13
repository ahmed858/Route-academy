using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04_assignment
{
    internal class Q06
    {
        public static void solve()
        {
            /*
             * Write a program in C# Sharp to count the frequency of each element of an array.
            
            */

            int[] freq = new int[100000];
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

            foreach (var item in arr)
            {
                freq[item]++;
            }
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    Console.WriteLine($"{i} Element frequented {freq[i]} Times");
                }
            }
        }
    }
}
