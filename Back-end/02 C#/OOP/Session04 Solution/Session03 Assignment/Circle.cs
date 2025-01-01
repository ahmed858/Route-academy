using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03_Assignment
{
    internal class Circle : ICircle
    {
        public decimal Radius { get; set; }
        const double PI = 3.14;
        public decimal Area { get => Radius * Radius * (decimal)PI; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius: {Radius}\nArea: {Area}");
        }
    }
}
