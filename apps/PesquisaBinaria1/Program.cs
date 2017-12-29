using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaBinaria1
{
    class Program
    {
        static void Main(string[] args)
        {
            //vetor com 13 posições
            int[] vetor = { 4, 4, 8, 12, 16, 22, 22, 30, 33, 40, 50, 55, 60 };

            Console.WriteLine($"A posição do valor 55 é {GetPosicaoPorBuscaBinaria1(55, vetor, 0, vetor.Length-1)}");
            Console.WriteLine($"A posição do valor 4 é {GetPosicaoPorBuscaBinaria1(4, vetor, 0, vetor.Length-1)}");
            Console.WriteLine($"A posição do valor 60 é {GetPosicaoPorBuscaBinaria1(60, vetor, 0, vetor.Length-1)}");
            Console.WriteLine($"A posição do valor 3 é {GetPosicaoPorBuscaBinaria1(3, vetor, 0, vetor.Length-1)}");
            Console.WriteLine($"A posição do valor 100 é {GetPosicaoPorBuscaBinaria1(100, vetor, 0, vetor.Length-1)}");

            Console.ReadKey();
        }

        static int GetPosicaoPorBuscaBinaria1(int v, int[] vetor, int i, int f)
        {
            if (i > f) return -1;

            int m = (i + f) / 2;
            if (v == vetor[m])
            {
                return m;
            }
            else if (v > vetor[m])
            {
                return GetPosicaoPorBuscaBinaria1(v, vetor, m + 1, f);
            }
            else
            {
                return GetPosicaoPorBuscaBinaria1(v, vetor, i, m - 1);
            }
        }
    }
}
