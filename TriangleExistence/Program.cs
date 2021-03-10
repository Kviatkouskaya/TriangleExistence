using System;
using System.Linq;

namespace TriangleExistence
{
    public class Triangle
    {
        private readonly double[] numbers = new double[3];

        public Triangle(double a, double b, double c)
        {
            numbers[0] = a;
            numbers[1] = b;
            numbers[2] = c;
        }
        public bool ExistTriangle()
        {
            return numbers[0] + numbers[1] > numbers[2] &&
                   numbers[1] + numbers[2] > numbers[0] &&
                   numbers[2] + numbers[0] > numbers[1];
        }
        public double CalculatePerimeter()
        {
            return numbers.Sum();
        }
        public double CalculateGeronSquare()
        {
            double halfP = CalculatePerimeter() / 2;
            double square = halfP;
            foreach (var item in numbers)
            {
                square *= halfP - item;
            }
            return Math.Sqrt(square);
        }
    }
    public class Program
    {
        public static string EnterTriangleSides()
        {
            Console.WriteLine("Enter triangle sides: ");
            return Console.ReadLine();
        }
        public static double[] ParseLine(string line)
        {
            try
            {
                string[] numbersString = line.Split(',');
                double[] numbers = Array.ConvertAll(numbersString, double.Parse);
                return numbers;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        private static void OutPut(double[] numbers)
        {
            Triangle myTriangle = new Triangle(numbers[0], numbers[1], numbers[2]);
            Console.WriteLine();
            Console.WriteLine($"Triangle exists: { myTriangle.ExistTriangle()}");
            Console.WriteLine($"Perimeter is: {myTriangle.CalculatePerimeter()}");
            Console.WriteLine($"Square is: {myTriangle.CalculateGeronSquare():F2}");
        }
        static void Main()
        {
            string line = EnterTriangleSides();
            double[] numbers = ParseLine(line);
            if (numbers.Length == 0)
            {
                Console.WriteLine("You didn't enter numbers");
            }
            else if (numbers.Length != 3)
            {
                Console.WriteLine("Enter three numbers");
            }
            else
            {
                OutPut(numbers);
            }
        }
    }
}
