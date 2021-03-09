using System;

namespace TriangleExistence
{
    public class Triangle
    {
        private readonly int first;
        private readonly int second;
        private readonly int third;
        public Triangle(int []numbers)
        {
            first = numbers[0];
            second = numbers[1];
            third = numbers[2];
        }
        public bool ExistTriangle()
        {
            return first + second > third;
        }
        public int CalculatePerimeter()
        {
            return first + second + third;
        }
        public double CalculateGeronSquare()
        {
            double halfP = CalculatePerimeter() / 2;
            double square = Math.Sqrt(halfP * (halfP - first) *
                                     (halfP - second) * (halfP - third));
            return square;
        }
    }
    public class Program
    {
        public static string EnterTriangleSides()
        {
            Console.WriteLine("Enter triangle sides: ");
            return Console.ReadLine();
        }
        public static int[] ParseLine(string line)
        {
            try
            {
                string[] numbersString = line.Split(',');
                int[] numbersInt = Array.ConvertAll(numbersString, int.Parse);
                return numbersInt;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        private static void OutPut(int[] numbers)
        {
            Triangle myTriangle = new Triangle(numbers);
            Console.WriteLine();
            Console.WriteLine($"Triangle exists: { myTriangle.ExistTriangle()}");
            Console.WriteLine($"Perimeter is: {myTriangle.CalculatePerimeter()}");
            Console.WriteLine($"Square is: {myTriangle.CalculateGeronSquare():F2}");
        }
        static void Main()
        {
            string line = EnterTriangleSides();
            int[] numbers = ParseLine(line);
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
