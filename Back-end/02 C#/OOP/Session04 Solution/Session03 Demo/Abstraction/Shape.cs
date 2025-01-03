using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03_Demo.Abstraction
{
    // abstract Class: is a class contains partial implementation to another class 
    // U can not create object [Instance] from abstract class [it is not fully implemented]
    abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        // abstract Method
        public abstract decimal CalcArea();
    }
}
