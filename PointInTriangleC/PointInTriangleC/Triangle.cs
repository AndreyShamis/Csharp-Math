using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTriangleC
{
    public class Triangle
    {
        public Line LineX { set; get; }
        public Line LineY { set; get; }
        public Line LineZ { set; get; }

        public Point PointX { set; get; }
        public Point PointY { set; get; }
        public Point PointZ { set; get; }

        public Triangle(Point x, Point y, Point z)
        {
            PointX = x;
            PointY = y;
            PointZ = z;

            LineX = new Line(PointX,PointY);
            LineY = new Line(PointY, PointZ);
            LineZ = new Line(PointX, PointZ);
        }

        public bool isPointInside(Point p)
        {
            Triangle a = new Triangle(PointX, PointY, p);
            Triangle b = new Triangle(PointY, PointZ, p);
            Triangle c = new Triangle(PointX, PointZ, p);
//            Console.WriteLine("A len " + a.GetSheteah().ToString() +" B len " + b.GetSheteah().ToString() +" C len " + c.GetSheteah().ToString());

            if (a.GetSheteah() + b.GetSheteah() + c.GetSheteah() == this.GetSheteah())
                return true;
            return false;
        }

        public Triangle(Line x, Line y, Line z)
        {
            LineX = x;
            LineY = y;
            LineZ = z;
        }

        public double GetSheteah()
        {
            double ret = 0;
            double perimeter;

            perimeter = (LineX.GetLength() + LineY.GetLength() + LineZ.GetLength()) / 2;
            ret = Math.Sqrt(perimeter * (perimeter - LineX.GetLength()) * (perimeter - LineY.GetLength()) * (perimeter - LineZ.GetLength()));
            return ret;
        }

        public override string ToString()
        {
            return  " A: " + PointX.ToString() +
                    " B: " + PointY.ToString() +
                    " C: " + PointZ.ToString() +
                    "[[ |AB|:" + LineX.GetLength() +
                    " |BC|:" + LineY.GetLength() +
                    " |AC|:" + LineZ.GetLength() + "]]";
        }

        public Line GetBiggestLine()
        {
            if (LineX.GetLength() > LineY.GetLength() && LineX.GetLength() > LineZ.GetLength())
                return LineX;
            else if(LineY.GetLength() > LineX.GetLength() && LineY.GetLength() > LineZ.GetLength())
                return LineY;
            else 
                return LineZ;
        }
    }
}
