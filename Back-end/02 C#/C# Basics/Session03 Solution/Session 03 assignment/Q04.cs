using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03_assignment
{
    internal class Q04
    {
        public static void solve()
        {
            int number;
            int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine((number % 2 == 0 ) ? $"even" : $"odd");
        }
    }
}
