using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03_assignment
{
    internal class Q14
    {
        public static void solve()
        {
            string str = new string (Console.ReadLine().ToString().Reverse().ToArray());
            
            Console.WriteLine(str);

            // if you want take int 
            int number  = int.Parse (Console.ReadLine());
            int reversedNumber = 0;
            while (number>0)
            {
                reversedNumber = reversedNumber*10 + number % 10;
                number /= 10;
            }
            Console.WriteLine(reversedNumber);
        }
    }
}
