using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment02
{
    public  class Q02
    {
        /*
         * Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 

         */
        public static void solve()
        {
            String str = "21sa";
            int num = Convert.ToInt32(str);//error:System.FormatException: 'The input string '21sa' was not in a correct format.'

        }

    }
}
