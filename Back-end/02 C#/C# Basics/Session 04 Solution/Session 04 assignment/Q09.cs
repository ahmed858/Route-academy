using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04_assignment
{
    internal class Q09
    {
        /*   Consider an Array of Integer values with size N, having values as    
    in this Example
   7 0 0 0 0 5 6 7 5 0  7 5 3


   write a program find the longest distance between Two equal cells.In this example.The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2 (cell 2 and cell 3).

   In the example above, the longest distance is between the first 7 and the
   10th 7, with a distance of 8 cells, i.e. the number of cells between the 1st
   And the 10th 7s.*/

        public static void solve()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] leftIdx = new int[100000];
            Array.Fill(leftIdx,-1);
            int[]rightIdx = new int[100000];
            Array.Fill(rightIdx, -1);

            int j = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++, j--)
            {
                if (leftIdx[arr[i]] == -1)
                {
                    leftIdx[arr[i]] = i;
                }

                if (rightIdx[arr[j]] == -1)
                {
                    rightIdx[arr[j]] = j;
                }
            }

            int maxDistance = -5;
            int LIdx = -1;
            int RIdx = -1;
            int number = 0;
            for(int i=0; i < leftIdx.Length; i++)
            {
                if (leftIdx[i] != -1) {
                    int dist = rightIdx[i] - leftIdx[i]-1 ;
                    if ( dist> maxDistance) {
                        maxDistance = dist;
                        number = i;
                        LIdx = leftIdx[i];
                        RIdx = rightIdx[i];
                    }
                }

            }
            Console.WriteLine($"the max distance is {maxDistance} between {LIdx + 1}th {number} and {RIdx + 1}th {number}");
        }
    }
}
