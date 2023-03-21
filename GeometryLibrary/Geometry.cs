using System;

namespace GeometryLibrary
{
    public class Geometry
    {
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CalculateTriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        
        public static bool IsRightTriangle(double a, double b, double c)
        {
            return a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b;
        }
    }
}