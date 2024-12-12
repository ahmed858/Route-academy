using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03_assignment
{
    internal class Q06
    {
        public static void solve()
        {
            int s, e;
            string[] input = Console.ReadLine().Split(' ');

            int.TryParse(input[0], out s);
            int.TryParse(input[1], out e);
            for (int i = s; i <= e; i++)
            {
                Console.WriteLine(i );
            }
        }
    }
}
