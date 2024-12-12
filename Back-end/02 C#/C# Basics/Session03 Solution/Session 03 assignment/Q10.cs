using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03_assignment
{
    internal class Q10
    {
        public static void solve()
        {
            long number, power;
            long res = 1;
            string[] input = Console.ReadLine().Split(' ');

            int total = 0;
            foreach( string s in input)
            {
                total += int.Parse(s);
            }
            double average = total/5.0;

            double percentage = (total / (5 * 100.0)) * 100;
            Console.WriteLine("total marks " +total);
            Console.WriteLine("average marks " + average);
            Console.WriteLine("Percentage   " + percentage);

        }
    }
}
