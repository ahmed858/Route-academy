using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03_assignment
{
    internal class Q07
    {
        public static void solve()
        {
            int number;
            string[] input = Console.ReadLine().Split(' ');

            int.TryParse(input[0], out number);
            
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i*number);
            }
        }
    }
}
