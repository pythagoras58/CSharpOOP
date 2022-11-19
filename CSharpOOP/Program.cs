﻿using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars("Lambi", "Toyota", 23432343.432m);


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