using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04_assignment
{
    internal class Q03
    {
        public static void solve()
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Identity Matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(i == j ? "1 " : "0 ");
                }
                Console.WriteLine();
            }
        }
    }
}
