using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTriangleC
{
    public class Point
    {
        public double x{set;get;}
        public double y { set; get; }

        public Point(double xValue, double yValue)
        {
            x = xValue;
            y = yValue;
        }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public override string ToString()
        {
            return "X=" + Math.Round(x, 1) + " Y=" + Math.Round(y, 1) + " ;"; ;
        }
    }
}
