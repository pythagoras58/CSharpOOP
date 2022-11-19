using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Triangle : Polygon
    {
        double length;
        double breadth;

        public Triangle(double l, double b)
        {
            length = l;
            breadth = b;
        }

        public override double area()
        {
            //throw new NotImplementedException();
            return ((length * breadth) / 2);
        }
    }
}
