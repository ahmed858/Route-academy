using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05_Assignment
{
    internal class Q01
    {
        static void ChangeByValue(int value)
        {
            value = 10; // Changes only the local copy
        }

        static void ChangeByReference(ref int value)
        {
            value = 10; // Changes the actual variable
        }

        public static void solve()
        {
            int number = 5;

            Console.WriteLine("Original number: " + number);

            ChangeByValue(number);
            Console.WriteLine("After ChangeByValue: " + number); // Remains unchanged

            ChangeByReference(ref number);
            Console.WriteLine("After ChangeByReference: " + number); // Changes to 10
        }
    }
}
