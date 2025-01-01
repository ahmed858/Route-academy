using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03_Assignment
{
    internal class Rectangle : IRectangle
    {
        public decimal Width {  get; set; }
        public decimal Length {  get; set; }
        public decimal Area { get => Width * Length;  }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Width: {Width}\nLength: {Length}");
        }
    }
}
