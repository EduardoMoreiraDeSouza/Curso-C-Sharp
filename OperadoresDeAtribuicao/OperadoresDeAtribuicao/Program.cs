using System;

namespace OperadoresDeAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;

            Console.WriteLine($"{a} += 10 = {a += 10}");
            Console.WriteLine($"{a} -= 10 = {a -= 10}");
            Console.WriteLine($"{a} *= 10 = {a *= 10}");
            Console.WriteLine($"{a} /= 10 = {a /= 10}");
            Console.WriteLine($"{a} %= 10 = {a %= 10}");
        }
    }
}
