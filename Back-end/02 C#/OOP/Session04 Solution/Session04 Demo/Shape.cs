using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03_Demo
{
    // 1- Is A partial Implementation for other class

    internal abstract class Shape
    {
        public decimal Dim01{ get; set; }
        public decimal Dim02{ get; set; }
        public abstract decimal perimeter{ get;  }
        // Abstract Method
        public abstract decimal CalcArea();

    }
}
