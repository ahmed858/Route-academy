using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04_assignment
{
    internal class Q08
    {
        //Write a program in C# Sharp to find the second largest element in an ar
        public static void solve()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(arr);
            Console.WriteLine($"Second max: {arr[arr.Length - 2]}");
        }
    }
}
