using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04_assignment
{
    internal class Q04
    {
        public static void Solve()
        {
            Console.Write("Enter the size of the array: ");
            int size;

            // Read and validate input
            int.TryParse(Console.ReadLine(), out size);
           

            int[] array = new int[size];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                int.TryParse(Console.ReadLine(), out array[i]);
                
            }

            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            Console.WriteLine( sum);
        }

    }
}
