using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01._4
{
    class Figure
    {
        Point[] points;
        public Figure(Point one, Point two, Point third)
        {
            points = new Point[3];
            points[0] = one;
            points[1] = two;
            points[2] = third;
        }

        public Figure(Point one, Point two, Point third, Point four)
        {
            points = new Point[4];
            points[0] = one;
            points[1] = two;
            points[2] = third;
            points[3] = four;
        }

        public Figure(Point one, Point two, Point third, Point four, Point five)
        {
            points = new Point[5];
            points[0] = one;
            points[1] = two;
            points[2] = third;
            points[3] = four;
            points[4] = five;
        }

        private double CalculateSide(Point one, Point two) => Math.Sqrt(Math.Pow(two.X - one.X, 2) +
                                                                Math.Pow(two.Y - one.Y, 2));

        public double CaclulatePerimiter()
        {
            double result = 0;
            for(int i = 0, j = 1; i < points.Length; i++,j++)
            {
                Point p1 = points[i];
                Point p2 = points[j % points.Length];
                result += CalculateSide(p1, p2);
            }
            return Math.Round(result, 2);
        }

        public string GetFigureName()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var point in points)
            {
                sb.Append(point.Name);
            }
            return sb.ToString();
        }

    }
}
