using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estrutura Simples

            if (4 < 5)
                Console.WriteLine("4 é menor que 5");

            // Estrutura Composta
            
            Console.WriteLine("Entre com um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("Par!");
            else
                Console.WriteLine("Impar!");

            // Encadeamentos
            
            Console.WriteLine("Entre com a hora atual: ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
                Console.WriteLine("Bom Dia!");
            else if (hora < 18)
                Console.WriteLine("Boa tarde!");
            else 
                Console.WriteLine("Boa noite!");

        }
    }
}
