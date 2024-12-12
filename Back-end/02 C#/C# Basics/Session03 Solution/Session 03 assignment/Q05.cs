using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03_assignment
{
    internal class Q05
    {
        public static void solve()
        {
            char ch;
            char.TryParse(Console.ReadLine(), out ch);
            string vowels = "aeiou";
            Console.WriteLine(vowels.Contains(ch)?"vowels": "consonant");
        }
    }
}
