using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercício 1. Obs.: O exercício pedia para que os dados fosses guardados em 'letras'.
            
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou:" + frase);
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            string[] vet = Console.ReadLine().Split(' ');

            string a = vet[0];
            string b = vet[1];
            string c = vet[2];
            
            // Exercício 2.
            
            int numero = int.Parse(Console.ReadLine());
            char caractere = char.Parse(Console.ReadLine());
            double numeroDouble = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] informacoes = Console.ReadLine().Split(' ');

            string nome = informacoes[0];
            char sexo = char.Parse(informacoes[1]);
            int idade = int.Parse(informacoes[2]);
            double altura = double.Parse(informacoes[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"\n\nNúmero Inteiro: {numero}\nCaractere: {caractere}\nNúmero Double: {numeroDouble}\nNome: {nome}, Sexo: {sexo}, Idade: {idade}, Altura: {altura}");

        }
    }
}
