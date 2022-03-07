using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(
                new Point(10, 10),
                new Point(20, 30),
                new Point(100, 250)
                );

            t.Rotate(10);
        }

        static void RotateShape(IShape s, double angle)
        {
            foreach (Point p in s.Points)
            {
                p.Rotate(angle);
            }
        }
    }
}
