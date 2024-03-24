using System;
using System.Globalization;

namespace TiposBasicosDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // SByte -> nativo do .net e necessita do using System
            sbyte x = 100;

            Console.WriteLine(x);

            byte n1 = 255;
            n1++; // Overflow

            Console.WriteLine(n1);

            long n2 = 2147483648L; // Ao utilzar o tipo long é recomendável colocar o "L" no final p/ representar
            Console.WriteLine(n2);

            bool completo = false;
            Console.WriteLine(completo);

            char genero = 'F';
            Console.WriteLine(genero);

            char letra = '\u0041'; // Caractere unicode
            Console.WriteLine(letra);

            float n3 = 4.5f; // "f" no final p/ representar o tipo float
            Console.WriteLine(n3);

            double n4 = 4.56541;
            Console.WriteLine(n4.ToString("F2", CultureInfo.InvariantCulture)); // ToString serve para delimitar as casa decimais, CultureInfo.InvariantCulture -> Para formatação com ponto

            string nome = "Eduardo"; // A cadeia do tipo primitivo é imutável (segurança, simplicidade, thread safe)
            Console.WriteLine(nome);

            // O tipo object é genérico

            // tipoPrimitivo .MinValue or .Maxvalue p/ valores minímos e máximos de cada tipo

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a R${2:F2}", nome, n3, n2);
            Console.WriteLine($"{nome} tem {n3} anos e tem saldo igual a R${n2:F2}");
            Console.WriteLine(nome + " tem " + n3 + " anos e tem saldo igual a R$" + n2.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
