using System;
using System.Runtime.CompilerServices;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ResolvendoUmProblemaComOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double areaX = AreaTriangulos("X");
            double areaY = AreaTriangulos("Y");

            MaiorAreaDoisTriangulos(areaX, areaY);
            
        }

        static double AreaTriangulos(string nomeTriangulo)
        {
            double a, b, c, area;

            Triangulo x;

            x = new Triangulo();

            Console.WriteLine($"Entre com as medidas do triângulo {nomeTriangulo}:");
            Console.Write("valor de A: ");
            x.A = double.Parse(Console.ReadLine());

            Console.Write("Valor de B: ");
            x.B = double.Parse(Console.ReadLine());

            Console.Write("Valor de C: ");
            x.C = double.Parse(Console.ReadLine());

            area = x.Area();

            Console.WriteLine("\n");
            Console.WriteLine($"A área do triângulo {nomeTriangulo} é: " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("\n");

            return area;
           
        }

        static void MaiorAreaDoisTriangulos(double x, double y)
        {
            string maiorArea;

            if (x > y)
                maiorArea = "X";
            else if (y > x)
                maiorArea = "Y";
            else 
                maiorArea = "Empate";

            
            if (maiorArea == "Empate")
                Console.WriteLine("Os dois triângulos tem a área igual!");
            else 
                Console.WriteLine($"O triângulo com a maior área é o: {maiorArea}");
        }

    }
}

