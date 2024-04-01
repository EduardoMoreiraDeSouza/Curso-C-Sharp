using System;

namespace DebuggingComVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números inteiros: ");
            Console.WriteLine("Número 1: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Número 2: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Número 3: ");
            int numero3 = int.Parse(Console.ReadLine());

            double resultado = Maior(numero1, numero2, numero3);

            Console.WriteLine($"O maior é o número {resultado}");

        }

        static int Maior(int numero1, int numero2, int numero3)
        {
            if (numero1 > numero2 && numero1 > numero3)
                return numero1;

            else if (numero2 > numero3)
                return numero2;

            else
                return numero3;

        }
    }
}
