using System;

namespace TriangleExistence
{
    class Triangle
    {
        public int first, second, third;
        public Triangle(int a, int b, int c)
        {
            first = a;
            second = b;
            third = c;
        }
        public string TriangleCheck()
        {
            if ((first + second > third) &&
                (second + third > first) &&
                (third + first > second))
            {
                return "Triangle exists";
            }
            return "Triangle doesn't exist";
        }
        public int TrianglePerimeter()
        {
            int perimetr = first + second + third;
            return perimetr;
        }
        public double GeronSquare()
        {
            double halfP = TrianglePerimeter() / 2;
            double square = Math.Sqrt(halfP * (halfP - first) *
                                     (halfP - second) * (halfP - third));
            return Math.Round(square, 2);
        }
    }
    class Program
    {
        private static Triangle EnterTriangleSides()
        {
            Console.WriteLine();
            Console.WriteLine("Enter triangle sides: ");
            string line = Console.ReadLine();
            string[] numbersString = line.Split(',');
            return new Triangle(int.Parse(numbersString[0]),
                                int.Parse(numbersString[1]),
                                int.Parse(numbersString[2]));
        }
        private static void OutPut(Triangle myTriangle)
        {
            Console.WriteLine(myTriangle.TriangleCheck());
            Console.WriteLine($"Perimeter is: {myTriangle.TrianglePerimeter()}");
            Console.WriteLine($"Square is: {myTriangle.GeronSquare()}");
        }
        static void Main()
        {
            Triangle myTriangle = EnterTriangleSides();
            OutPut(myTriangle);
        }
    }
}
