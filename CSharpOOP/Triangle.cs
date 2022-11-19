using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Triangle : Polygon
    {
        double length = 23.23;
        double breadth = 21231.2;
        public override double area()
        {
            //throw new NotImplementedException();
            return ((length * breadth) / 2);
        }
    }
}
