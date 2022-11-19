using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // classes
            Cars cars = new Cars("Lambi", "Toyota", 23432343.432m);
            Console.WriteLine(cars.Name);

            // inheritance
            Rectangle rectangle = new Rectangle(2, 3);
            Triangle triangle = new Triangle(2,3);
           

            Polygon[] shapes = new Polygon[2];
            shapes[0] = rectangle;
            shapes[1] = triangle;

            foreach(Polygon p in shapes)
            {
                Console.WriteLine("AREA -> " + p.area());
            }

        }
    }

    class Cars
    {
        public string name;
        public string brand;
        public decimal price;

        public Cars(string n, string b, decimal p)
        {
            name = n;
            brand = b;
            price = p;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    

}
