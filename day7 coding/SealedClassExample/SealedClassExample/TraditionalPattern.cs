using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    internal class TraditionalPattern
    {
    }
    public class Shape
    {
        public const float PI = 3.14f;
    }
    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    public class Rectangle : Shape
    {
        public double Length { get; }
        public double Breadth { get; }

        public Rectangle(double length,double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
    }
}
