using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03_assignment
{
    internal class Q08
    {
        //Q06.solve();
        public static void solve()
        {
            int number;
            string[] input = Console.ReadLine().Split(' ');

            int.TryParse(input[0], out number);

            for (int i = 2; i <= number; i++)
            {
                if(i%2==0)
                Console.WriteLine(i );
            }


        }
    }
}
