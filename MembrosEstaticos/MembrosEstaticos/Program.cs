using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Circuferência: " + Calculadora.Circuferencia(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Calculadora.Volume(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
