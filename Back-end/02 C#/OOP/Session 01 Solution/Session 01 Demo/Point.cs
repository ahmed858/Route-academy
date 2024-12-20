using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01_Demo
{
    internal class Point
    {
        public int x;
        public int y;
        //--------------------
        //Constructor is special function
        //1- same struct name 
        //2- has no return 

        // by default at struct , Compiler will generate pramterless Constructor

        public Point()
        {
            x = 0; 
            y = 0;
        }
        public Point(int _x,int _y)
        {
            x = _x;
            y = _y;
        }
        public override string ToString()
        {
            return $"the x= {x}, y= {y}";
        }
    }
}
