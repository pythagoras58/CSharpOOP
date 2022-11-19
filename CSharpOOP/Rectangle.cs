using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Rectangle : Polygon
    {
        double length = 323.23;
        double breadth = 2322.32;
        public override double area()
        {
            //throw new NotImplementedException();
            return (length*breadth);
        }
    }
}
