using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03_assignment
{
    internal class Q16
    {
        public static void solve()
        {
            
            // if you want take int 
            int number = int.Parse(Console.ReadLine());
            string binaryNumber ="";
            while (number > 0)
            {
                binaryNumber +=  (number%2).ToString() ;
                number /= 2;
            }
            Console.WriteLine(binaryNumber);
        }
    }
}
