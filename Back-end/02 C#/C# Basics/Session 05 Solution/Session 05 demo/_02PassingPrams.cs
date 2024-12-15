using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05_demo
{

    internal class _02PassingPrams
    {
        #region  Value Type prameter

    
        // class member function (static )
        // object member function (OOP)
        public static void Swap (int X,int Y)
        {
            int temp = X; 
            X = Y;
            Y = temp;

        }
        public static void SwapWithRef(ref int X,ref int Y)
        {
            int temp = X;
            X = Y;
            Y = temp;

        }

        public static void explain()
        {
            Console.WriteLine("Pass prams by value (value types )");
            int A = 3;
            int B = 4;
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine("After swap");
            Swap(A, B);
            Console.WriteLine(A);
            Console.WriteLine(B);
            // not working because passing by value
            //Stack frame concept
            // function stack frame isolated to main stack frame 

            SwapWithRef(ref A, ref B);
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine("============================================");

        }
        #endregion

        #region  Reference Type prameter

        public static void passArrayByValue(int[] arr) {
            long sum = 0;
            arr = new int[]{ 100, 32, 43 };
            
        }
        public static void passArrayByRef(ref int[] arr)
        {
            long sum = 0;
            arr = new int[] { 100, 32, 43 };

        }
        public static void explain2()
        {
            int[] Numbers = new int[] { 1, 2, 3 };
            passArrayByValue(Numbers);
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i] + " ");
            }//1 2 3

            passArrayByRef(ref Numbers);
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i] + " ");
            }//100 32 





        }
        #endregion
    }
}
