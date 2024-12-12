using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04_assignment
{
    internal class Q05
    {
        public static void solve()
        {
            Console.WriteLine("Enter the  first array :");
            string input1 = Console.ReadLine();
            int[] arr1 = Array.ConvertAll(input1.Split(' '), int.Parse);

            
            Console.WriteLine("Enter  the second array :");
            string input2 = Console.ReadLine();
            int[] arr2 = Array.ConvertAll(input2.Split(' '), int.Parse);

            // Merge and sort the arrays
            int[] mergedArray = Merge(arr1, arr2);

            
            Console.WriteLine("Merged and Sorted Array: ");
            foreach (int num in mergedArray)
            {
                Console.Write(num + " ");
            }

        }
        int md;
        static int[]  Merge(int[] arr1,int []arr2)
        {
            int size = arr1.Length + arr2.Length;
            int[]sortedArr = new int[size];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                {
                    sortedArr[k] = arr1[i++];
                    
                }
                else
                {
                    sortedArr[k] = arr2[j++];
                    
                }
                k++;
            }

            while (i < arr1.Length)
                sortedArr[k++]  = arr1[i++];

            while (2 < arr2.Length)
                sortedArr[k++] = arr2[j++];
        return sortedArr;
        }
    }
}
