using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03_assignment
{
    internal class Q12
    {
        public static void solve()
        {
            int number1, number2;
            string operatortion;
            string[] input = Console.ReadLine().Split(' ');

            int.TryParse(input[0], out number1);
            operatortion = input[1];
            int.TryParse(input[2], out number2);

            long res = operatortion switch
            {
                "+" => number1 + number2,
                "-" => number1 - number2,
                "*" => number1 * number2,
                "/" => number2 != 0 ? number1 / number2 : throw new DivideByZeroException(),

                _ => throw new InvalidOperationException("Invalid operation")
            };

            Console.WriteLine(res);
        }

    }
}
