using System;

namespace OperadoresComparativo
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 
             * < Menor que
             * > Maior que
             * <= Menor ou Igual que
             * >= Maior ou Igual que
             * == Igual que
             * != Diferente que
             * 
             * */

            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;

            Console.WriteLine(c1);
            Console.WriteLine(c2);

        }
    }
}
