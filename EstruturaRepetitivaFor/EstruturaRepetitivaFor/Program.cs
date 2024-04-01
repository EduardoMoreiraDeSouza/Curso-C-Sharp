using System;

namespace EstruturaRepetitivaFor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos números inteiros você vai digitar? ");
            int quantidade = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1;  i <= quantidade; i++)
            {
                if (i > quantidade)
                    Console.WriteLine($"Valor #{i}: ");
                else
                    Console.Write($"Valor #{i}: ");
                
                soma += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nA soma dos valores é {soma}!");

        }
    }  
}
