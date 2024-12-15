using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05_demo
{

    internal class _04functionParams
    {
        public static int sumArray(params int[] arr)
        {
            int sum = 0;
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };
        int total = sumArray(1,2,3,4);
    }
}
