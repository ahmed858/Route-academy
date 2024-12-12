using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04_assignment
{
    internal class Q01
    {
        public  void Solve()
        {

            Point[] Points = {new Point(), new Point(), new Point() };
            
            
            string[] input = Console.ReadLine().Split(" ");

            Points[0].X = int.Parse(input[0]);
            Points[0].Y = int.Parse(input[1]);

            input = Console.ReadLine().Split(" ");

            Points[1].X = int.Parse(input[0]);
            Points[1].Y = int.Parse(input[1]);

            input = Console.ReadLine().Split(" ");

            Points[2].X = int.Parse(input[0]);
            Points[2].Y = int.Parse(input[1]);


            if (checkStraight(Points))
            
                Console.WriteLine("yes the points are in the straight  line");

            else
                Console.WriteLine("no the points are not in the straight  line");

        }
        bool checkStraight(Point[] Points)
        {
            return (Points[0].Y - Points[1].Y) * (Points[2].X - Points[1].X) ==
                (Points[0].X - Points[1].X) * (Points[2].Y - Points[1].Y);

            //return (getSlope(Points[0], Points[1]) == getSlope(Points[1], Points[2]));
        }

        //double getSlope(Point p1, Point p2)
        //{
        //    return Math.Abs(p2.Y - p1.Y) * 1f / Math.Abs(p2.X - p1.X) * 1f;
        //}

    }
}
