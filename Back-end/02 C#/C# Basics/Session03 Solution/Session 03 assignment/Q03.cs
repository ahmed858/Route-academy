using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03_assignment
{
    internal class Q03
    {
        public static void solve()
        {
            int x, y, z;
            string[] input  = Console.ReadLine().Split(' ');

            int.TryParse(input[0], out x);
            int.TryParse(input[1], out y);
            int.TryParse(input[2], out z);

            if (x >= y)
            {
                Console.WriteLine(int.Max(x, z));
                Console.WriteLine(int.Min(y, z));
            }
            else
            {
                Console.WriteLine(int.Max(y, z));
                Console.WriteLine(int.Min(x, z));

            }
        }
    }
}
