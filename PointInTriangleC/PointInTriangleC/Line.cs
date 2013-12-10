using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTriangleC
{
    public class Line
    {
        public Point PointX { set; get; }
        public Point PointY { set; get; }

        public Line(Point x, Point y)
        {
            PointX = x;
            PointY = y;
        }

        //public static Line operator +(Line c1, Line c2)
        //{
        //    return new Complex(c1.GetLength() + c2.GetLength, c1.imaginary + c2.imaginary);
        //}

        public double GetLength()
        {
            double ret = 0;

            double x = (PointY.x - PointX.x);
            double y = (PointY.y - PointX.y);

            x = Math.Pow(x,2);
            y = Math.Pow(y,2);
            ret = Math.Sqrt(x + y);

            return ret;
        }
    }
}
