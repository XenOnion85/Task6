using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLine
{
    class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point()
        {}
        public void Show()
        {
            Console.WriteLine("Точка с координатами: ({0}, {1})", x, y);
        }
        public double Dlina(Point p)
        {
            double D1 = Math.Sqrt((this.x - p.x) * (this.x - p.x) + (this.y - p.y) * (this.y - p.y));
            return D1;
        }
        public override string ToString()
        {
            string ss = x + " ; " + y;
            return ss;
        }
    }
}
