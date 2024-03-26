using System;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("\nQuantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com o preço de um produto: R$");
            double precoProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEscreva seu último nome, idade e altura (mesma linha): ");
            string[] dados = Console.ReadLine().Split(", ");

            string ultimoNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2]);

            Console.WriteLine($"\n\nSeu nome completo é: {nome}\nSua casa tem {quartos} quartos\nO preço do produto é R$"+ precoProduto.ToString("F2", CultureInfo.InvariantCulture) + $"\nSeu último nome é {ultimoNome}\nSua idade: "+ idade.ToString("F2", CultureInfo.InvariantCulture) + " anos\nSua altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
