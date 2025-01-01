using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03_Demo
{
    // concreate class fully impelemented class
    internal class Rectangle : Shape
    {

        public override decimal perimeter { 
            get { return (Dim01 + Dim02) * 2; } 
        }

        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
}
