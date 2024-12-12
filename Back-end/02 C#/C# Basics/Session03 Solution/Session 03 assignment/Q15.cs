using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03_assignment
{
    internal class Q15
    {

        public static void solve()
        {
            string[] input = Console.ReadLine().Split(' ');
            int s, e;
            int.TryParse(input[0], out s);
            int.TryParse(input[1], out e);

            for(int i = s;i<=e; i++)
            {
                if (IsPrime(i)) Console.WriteLine(i);
            }

        }
        private static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
