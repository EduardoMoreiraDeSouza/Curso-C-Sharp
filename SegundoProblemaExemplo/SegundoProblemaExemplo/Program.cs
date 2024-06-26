using System;
using System.Globalization;

namespace SegundoProblemaExemplo 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Produto produto = new Produto();

            Console.Write("Nome: ");
            produto.SetNome(Console.ReadLine());

            Console.Write("Preço: $");
            produto.SetPreco(double.Parse(Console.ReadLine()));

            Console.Write("Quantidade: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

            produto.ExibirDadoDoProduto();

            Console.Write("\nDigite o número de prosutos a serem adicionados ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

            produto.ExibirDadoDoProduto();

            Console.Write("\nDigite o número de prosutos a serem removidos do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));

            produto.ExibirDadoDoProduto();
        }
    }
}
