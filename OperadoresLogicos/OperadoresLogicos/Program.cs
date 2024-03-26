using System;

namespace OperadoresLogicos
{
    class Program
    {

        /*
         * 
         * && -> E
         * || -> OU
         * ! -> NÃO
         * Precedência -> ! > && > ||
         * 
         * */

        static void Main(string[] args)
        {

            bool condicao1 = 2 > 3 && 4 != 5; // true
            bool condicao2 = 2 > 3 || 4 != 5; // true
            bool condicao3 = !(2 > 3) && 4 != 5; // true

            Console.WriteLine(condicao1);
            Console.WriteLine(condicao2);
            Console.WriteLine(condicao3);

        }
    }
}
