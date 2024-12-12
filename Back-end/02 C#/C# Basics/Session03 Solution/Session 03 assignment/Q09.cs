using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_03_assignment
{
    internal class Q09
    {
        public static void solve()
        {
            long number,power;
            long res=1;
            string[] input = Console.ReadLine().Split(' ');

            long.TryParse(input[0], out number);
            long.TryParse(input[1], out power);

            for (int i = 1; i <= power; i++)
            {
                res *= number ;
            }
            Console.WriteLine(res);


        }
    }
}

