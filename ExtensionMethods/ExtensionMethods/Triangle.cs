using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Triangle : IShape
    {
        public Triangle(Point a, Point b, Point c)
        {
            Points = new[]{ a, b, c };
        }
        public Point[] Points { get; private set; };
    }
}
