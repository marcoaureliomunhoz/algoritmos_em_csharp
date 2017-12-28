using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort1
{
    class Program
    {
        static void ImprimirVetor(string sobre, int[] vetor)
        {
            string aux = "";
            for (int i = 0; i < vetor.Length; i++)
            {
                aux += (aux.Length > 0 ? " | " : "") + vetor[i].ToString();
            }
            Console.WriteLine(sobre + "[ " + aux + " ]");
        }

        static void InsertionSort(int[] vetor)
        {
            ImprimirVetor("0 : ", vetor);

            int i = 0;
            int j = 0;
            int aux = 0;
            int passo = 0;
            int comparacoes = 0;
            int totalComparacoes = 0;
            int movimentacoes = 0;
            int totalMovimentacoes = 0;

            for (i = 1; i < vetor.Length; i++)
            {
                comparacoes = 0;
                movimentacoes = 0;
                passo++;
                j = i - 1;
                aux = vetor[i];
                if (j >= 0) comparacoes++;
                while (j >= 0 && aux < vetor[j])
                {
                    movimentacoes++;
                    vetor[j + 1] = vetor[j];
                    j--;
                    if (j >= 0) comparacoes++;
                }                
                if (aux < vetor[j + 1])
                {
                    movimentacoes++;
                    vetor[j + 1] = aux;
                }
                ImprimirVetor($"{passo} : ", vetor);
                totalComparacoes += comparacoes;
                totalMovimentacoes += movimentacoes;
            }

            Console.WriteLine("");
            Console.WriteLine("-- Resumo --");
            Console.WriteLine($"Nro de elementos  (n)  : {vetor.Length}");
            Console.WriteLine($"Qtde de passos    (p)  : {passo}");
            Console.WriteLine($"Comparações       (C)  : {totalComparacoes}");
            Console.WriteLine($"Movimentações     (M)  : {totalMovimentacoes}");
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("** Vetor desordenado - caso médio **");
            InsertionSort(new int[] { 4, 7, 2, 9, 1, 6, 5, 3, 8 });

            Console.WriteLine("** Vetor já ordenado - melhor caso **");
            InsertionSort(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            Console.WriteLine("** Vetor ordenado decrescente - pior caso **");
            InsertionSort(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 });

            Console.ReadKey();
        }
    }
}
