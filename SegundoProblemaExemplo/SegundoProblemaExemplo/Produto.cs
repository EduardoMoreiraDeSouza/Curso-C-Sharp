using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SegundoProblemaExemplo
{
    internal class Produto
    {

        private string Nome;
        private double Preco;
        private int Quantidade;

        public double ValorTotalEstoque()
        {
            return this.GetPreco() * this.GetQuantidade();
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.SetQuantidade(GetQuantidade() + quantidade);
        }

        public void RemoverProdutos(int quantidade)
        {
            this.SetQuantidade(GetQuantidade() - quantidade);
        }

        public int GetQuantidade()
        {
            return Quantidade;
        }

        private void SetQuantidade (int quantidade)
        {
            Quantidade = quantidade;
        }

        public void SetNome (string nome)
        {
            Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetPreco (double preco)
        {
            Preco = preco;
        }

        public double GetPreco ()
        {
            return Preco;
        }

        public void ExibirDadoDoProduto()
        {
            Console.WriteLine($"Dados atualizados: {this.GetNome()}, {this.formatarPreco(this.GetPreco())}, {this.GetQuantidade()} unidades, Total: {formatarPreco(this.ValorTotalEstoque())}");
        }

        public string formatarPreco(double valor)
        {
            return "$ " + valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
