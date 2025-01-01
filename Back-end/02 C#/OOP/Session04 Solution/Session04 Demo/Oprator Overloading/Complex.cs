using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03_Demo.Oprator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = Left?.Real ?? 0 + Right?.Real ?? 0,
                Imag = Left?.Imag ?? 0 + Right?.Imag ?? 0
            };
        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = Left?.Real ?? 0 - Right?.Real ?? 0,
                Imag = Left?.Imag ?? 0 - Right?.Imag ?? 0
            };
        }



        // Unaray
        public static Complex operator ++(Complex c)
        {
            return new Complex()
            {
                Real = c?.Real ?? 0 + 1,
                Imag = c?.Imag ?? 0 + 1
            };
        }
        public static Complex operator --(Complex c)
        {
            return new Complex()
            {
                Real = c?.Real ?? 0 - 1,
                Imag = c?.Imag ?? 0 - 1
            };
        }

        // relational opertor 
        public static bool operator >(Complex Left,Complex Right)
        {
            if (Left?.Real != Right?.Real) {
                return Left.Imag > Right.Imag;
            }
            else
            {
                return Left.Real > Right.Real;
            }
        }
        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left?.Real != Right?.Real)
            {
                return Left.Imag < Right.Imag;
            }
            else
            {
                return Left.Real < Right.Real;
            }
        }

        // Casting operators

        // explcit casting
        public static explicit operator int (Complex c)
        {
            return c?.Real ?? 0;
        }

        public static implicit operator string   (Complex c)
        {
            return c?.ToString() ?? string.Empty;
        }

        public static implicit operator RealNumber (Complex c)
        {
            return new RealNumber { X = c?.Real ?? 0 };
        }
    }
}
