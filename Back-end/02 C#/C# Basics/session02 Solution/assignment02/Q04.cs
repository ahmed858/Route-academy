using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment02
{
    public  class Q04
    {
        //Write C# program that Extract a substring from a given string.
        public  static void solve()
        {
            Console.WriteLine("please enter word");
            String str = Console.ReadLine();
            Console.WriteLine("first two letters: "+str.Substring(1,2));
        }
    }
}
