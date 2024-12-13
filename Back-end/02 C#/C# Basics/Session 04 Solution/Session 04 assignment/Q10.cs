using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04_assignment
{
    internal class Q10
    {
        public static void solve()
        {
            //Given a list of space separated words, reverse the order of the words.

            string[] arr = Console.ReadLine().Split(' '); ;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write (arr[i]+' ');
            }
        }
    }
}
