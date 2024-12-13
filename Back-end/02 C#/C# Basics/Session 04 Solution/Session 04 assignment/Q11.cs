using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
namespace Session_04_assignment
{
    internal class Q11
    {
        public static void solve()
        {
            //Write a program to create two multidimensional arrays of same size.Accept value from user and store them in first array.
            //Now copy all the elements of first array on second array and print second array.

            // Taking the dimensions of the array from the user
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns:");
            int cols = int.Parse(Console.ReadLine());

            // Declare and initialize the first and second arrays
            int[,] firstArray = new int[rows, cols];
            int[,] secondArray = new int[rows, cols];

            // Accept values for the first array from the user
            Console.WriteLine($"Enter the elements of the first array ({rows}x{cols}):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    firstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Copy elements from the first array to the second array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    secondArray[i, j] = firstArray[i, j];
                }
            }

            // Print the second array
            Console.WriteLine("\nElements of the second array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(secondArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
