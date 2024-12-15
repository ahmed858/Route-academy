using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05_Assignment
{
    internal class Q08
    {
        static string ChangeChar(string input, int position, char newChar)
        {       

            char[] chars = input.ToCharArray();
            chars[position] = newChar;
            return new string(chars);
        }

        public static void solve()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter the position to modify (0-based): ");
            int position = int.Parse(Console.ReadLine());

            Console.Write("Enter the new character: ");
            char newChar = Console.ReadLine()[0];

            string result = ChangeChar(input, position, newChar);

            Console.WriteLine($"Modified string: {result}");
        }
    }

}
