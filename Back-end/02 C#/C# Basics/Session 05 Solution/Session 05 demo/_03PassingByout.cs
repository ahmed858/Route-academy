using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05_demo
{
    internal class _03PassingByout
    {
        public static void SumMul(in int x,in int y, out int sum,out int mul)
        {
            sum = x + y;
            mul = x * y;
        }
        public static void explain()
        {
            int x=5,y=7,sum,mul;
            SumMul(in x, in y, out sum, out mul);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(sum);
            Console.WriteLine(mul);

            Console.WriteLine("========================================");


        }
    }
}
