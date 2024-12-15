using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05_demo
{
    internal class _01JudgedArray
    {
       public static void explain()
        {
            #region Judged array
            //Judged array => One D Array of arrays with different types
            int[][] numbers = new int[3][];
            numbers[0] = new int[] { 1, 2, 3 };
            numbers[1] = new int[] { 4, 5 };
            numbers[2] = new int[] { 6 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write(numbers[i][j] + " ");

                }
                Console.WriteLine();    
            }
            #endregion
        }
    }
}
