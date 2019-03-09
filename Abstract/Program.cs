using System;

namespace Abstract
{
    abstract class Shapes
    {
        public int Nrsides { get; set; }
        public int sizeLength { get; set; }


        abstract public double Area();

        public int Parameter()
        {
            return sizeLength * Nrsides;
        }

    }
    class Square : Shapes
    {
        public Square(int sides, int size)
        {
            Nrsides = sides;
            sizeLength = size;
        }
        public override double Area()
        {
            return sizeLength * Nrsides;
        }
    }
    class Triangle : Shapes
    {
        public Triangle(int sides, int size)
        {
            Nrsides = sides;
            sizeLength = size;
        }
        public override double Area()
        {
            return Math.Pow(sizeLength,2) * Math.Sqrt(3) / 4;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(3, 4);
            Console.WriteLine(square.Area());
            var tri = new Triangle(3, 8);
            Console.WriteLine(tri.Area());

            Console.Read();
        }

    }
}
