using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04_assignment
{
    internal class Q07
    {
        //Write a program in C# Sharp to find maximum and minimum element in an array

        public static void solve()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(arr);
            Console.WriteLine($"min: {arr[0]}, max: {arr[arr.Length - 1]}");
        }
    }
}
