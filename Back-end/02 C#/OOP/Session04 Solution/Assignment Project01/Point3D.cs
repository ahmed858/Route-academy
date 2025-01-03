using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Project01
{
    internal class Point3D:IComparable,ICloneable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D (double _x, double _y, double _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }
        public Point3D() : this(0, 0, 0)
        {

        }
        public Point3D (Point3D p)
        {
            this.X = p.X;
            this.Y = p.Y;
                this.Z = p.Z;
            
            
        }
         
        public static bool operator== (Point3D left, Point3D right)
        {
            return (left.X==right.Y && left.Z==right.Z && left.Y==right.Y);
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            return !(left.X==right.Y && left.Z==right.Z && left.Y==right.Y);

        }
        public override string ToString()
        {
            return $"Point Coordinate ({X},{Y},{Z})";
        }

        public int CompareTo(object? obj)
        {
            Point3D p = obj as Point3D;

            if (this.X > p.X)
                return 1;
            else if (this.X < p.X) 
                return -1;
            else
            {
                if (this.Y > p.Y)
                    return 1;
                else if (this.Y < p.Y)
                    return -1;
                else
                    return 0;
                
            }
        }

        public object Clone()
        {
            return new Point3D(this);
        }
    }
}
