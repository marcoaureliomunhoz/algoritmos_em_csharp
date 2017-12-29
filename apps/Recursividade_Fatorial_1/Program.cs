using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade_Fatorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 5, 4, 3, 2, 1, 0 };

            foreach (var n in vetor)
            {
                int f = Fatorial(n);
                Console.WriteLine($"Fatorial de {n} = {f}");
            }

            Console.ReadKey();
        }

        static int Fatorial(int n)
        {
            //caso trivial
            if (n <= 1) return 1;

            //caso geral onde o problema pode ser dividido em um problema menor até se chegar num caso trivial
            int resultado = Fatorial(n - 1);

            //processando o resultado obtido
            return n * resultado;
        }
    }
}
