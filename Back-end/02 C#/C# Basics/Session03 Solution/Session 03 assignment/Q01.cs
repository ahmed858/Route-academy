using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_03_assignment
{
    internal class Q01
    {
        public static void solve()
        {
            int number;
            int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine((number % 3 == 0 && number % 4 == 0) ? $"Yes number {number} can divided by 3 and 4" : $"No number {number} can not  divided by 3 and 4");
        }
    }

}
