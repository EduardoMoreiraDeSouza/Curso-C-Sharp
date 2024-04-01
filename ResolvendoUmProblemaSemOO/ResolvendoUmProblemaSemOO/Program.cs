using System;
using System.Runtime.CompilerServices;
using System.Globalization;

namespace ResolvendoUmProblemaSemOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X:");
            Console.Write("a: ");
            double xa = double.Parse(Console.ReadLine());

            Console.Write("b: ");
            double xb = double.Parse(Console.ReadLine());

            Console.Write("c: ");
            double xc = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\nEntre com as medidas do triângulo Y:");
            Console.Write("a: ");
            double ya = double.Parse(Console.ReadLine());

            Console.Write("b: ");
            double yb = double.Parse(Console.ReadLine());

            Console.Write("c: ");
            double yc = double.Parse(Console.ReadLine());

            double areaX = Area(xa, xb, xc);
            double areaY = Area(ya, yb, yc);

            Console.WriteLine("\n\nA área do triângulo X é: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A área do triângulo Y é: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            string maiorArea = areaX < areaY ? "X" : "Y";

            Console.WriteLine($"\nA Maior área é do triângulo: {maiorArea}" );

        }

        static double Area(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }
    }
}

