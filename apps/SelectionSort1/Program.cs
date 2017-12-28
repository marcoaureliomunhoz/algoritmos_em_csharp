using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort1
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

        static void SelectionSort(int[] vetor)
        {
            ImprimirVetor("0 : ", vetor);

            int i = 0;
            int j = 0;
            int aux = 0;
            int passo = 0;
            int comparacoes = 0;
            int subComparacoes = 0;
            int totalComparacoes = 0;
            int movimentacoes = 0;
            int totalMovimentacoes = 0;

            do
            {
                movimentacoes = 0;
                comparacoes = 0;
                passo++;
                for (i = 0; i < vetor.Length - 1; i++)
                {
                    subComparacoes = 0;
                    j = i + 1;
                    if (j < vetor.Length) subComparacoes++;
                    while (j < vetor.Length && vetor[j] > vetor[i])
                    {                        
                        j++;
                        if (j < vetor.Length) subComparacoes++;
                    }
                    if (j < vetor.Length && vetor[j] < vetor[i])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[i];
                        vetor[i] = aux;
                        movimentacoes++;
                    }
                    totalMovimentacoes += movimentacoes;
                    comparacoes += subComparacoes;
                    //Console.WriteLine($"    Sub comparações: {subComparacoes}");
                }
                totalComparacoes += comparacoes;
                ImprimirVetor($"{passo} : ", vetor);
                Console.WriteLine($"    Comparações: {comparacoes}");
            } while (movimentacoes > 1);

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
            SelectionSort(new int[] { 4, 7, 2, 9, 1, 6, 5, 3, 8 });

            Console.WriteLine("** Vetor já ordenado - melhor caso **");
            SelectionSort(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            Console.WriteLine("** Vetor ordenado decrescente - pior caso **");
            SelectionSort(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 });

            Console.ReadKey();
        }
    }
}
