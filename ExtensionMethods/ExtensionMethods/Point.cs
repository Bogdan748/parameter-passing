using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Point : ITranslatetableObject , IRotatableObject
    {
        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }
        public double X { get; private set; }
        public double Y { get; private set; }

        public void Translate(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public void Rotate(double angleDegrees)
        {
            double angleRadians = (Math.PI / 180) * angleDegrees;

            // see: https://en.wikipedia.org/wiki/Rotation_matrix
            double originalX = X;
            double originalY = Y;

            X = originalX * Math.Cos(angleRadians) - originalY * Math.Sin(angleRadians);
            Y = originalX * Math.Sin(angleRadians) + originalY * Math.Cos(angleRadians);
        }
    }
}
