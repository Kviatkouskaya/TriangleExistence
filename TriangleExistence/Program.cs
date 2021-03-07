using System;

namespace TriangleExistence
{
    public class Triangle
    {
        private int First { get; }
        private int Second { get; }
        private int Third { get; }
        public Triangle(int a, int b, int c)
        {
            First = a;
            Second = b;
            Third = c;
        }
        public bool TriangleCheck()
        {
            if ((First + Second > Third) &&
                (Second + Third > First) &&
                (Third + First > Second))
            {
                return true;
            }
            return false;
        }
        public int TrianglePerimeter()
        {
            int perimetr = First + Second + Third;
            return perimetr;
        }
        public double GeronSquare()
        {
            double halfP = TrianglePerimeter() / 2;
            double square = Math.Sqrt(halfP * (halfP - First) *
                                     (halfP - Second) * (halfP - Third));
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
        private static int[] ParseLine(string line)
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
            Triangle myTriangle = new Triangle(numbers[0], numbers[1], numbers[2]);
            Console.WriteLine();
            Console.WriteLine($"Triangle exists: { myTriangle.TriangleCheck()}");
            Console.WriteLine($"Perimeter is: {myTriangle.TrianglePerimeter()}");
            Console.WriteLine($"Square is: {myTriangle.GeronSquare():F2}");
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
