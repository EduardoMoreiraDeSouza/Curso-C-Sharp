using System;
using System.Globalization;

namespace EstruturaRepetitivaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = PedirNumero();

            while (numero > 0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine($"A raiz quadrada de {numero} é: " + raiz.ToString("F3", CultureInfo.InvariantCulture));

                numero = PedirNumero();
            }

            Console.WriteLine("Número negativo!");
        }

        static double PedirNumero()
        {
            Console.WriteLine("\n\nDigite um número: ");
            return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }
}
