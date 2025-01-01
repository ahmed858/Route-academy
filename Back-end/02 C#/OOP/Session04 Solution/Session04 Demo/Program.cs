using Session03_Demo.Oprator_Overloading;
using System.Security.Cryptography;

namespace Session03_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex C1 = new Complex() { Real = 1, Imag = 4 };
            Complex C2 = new Complex() { Real = 1, Imag = 4 };

            Complex C3;
            #region Binary Oprators

            C3 = C1 + C2;



            //Console.WriteLine(C3.Real);
            //Console.WriteLine(C3.Imag);

            #endregion
            #region  Unary Operator
            C3 = ++C1;
            C3 = C1--; // its ok

            #endregion

            #region Relational Opertor
            if (C1 > C2) Console.WriteLine("C1 is Greater Than C2");
            else Console.WriteLine("C2 is Greater Than C1");
            #endregion

            #region Custing Operators

            int y = (int)C1;
            Console.WriteLine(y);

            string x = C1;

            Console.WriteLine(x);

            RealNumber realNumber = C1;
            Console.WriteLine(realNumber.X); ;

            #endregion


            #region Abstraction

            // Abstract Class - Abstract Method - Abstract Property 

            #endregion
        }
    }
}
