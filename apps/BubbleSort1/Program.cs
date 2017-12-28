using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort1
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

        static void BubbleSort(int[] vetor)
        {
            ImprimirVetor("0 : ", vetor);

            int i = 0;
            int aux = 0;
            int passo = 0;
            int comparacoes = 0;
            int totalComparacoes = 0;
            int movimentacoes = 0;
            int totalMovimentacoes = 0;
            do
            {
                comparacoes = 0;
                movimentacoes = 0;
                passo++;
                for (i = 0; i < vetor.Length - 1; i++)
                {                    
                    comparacoes++;
                    if (vetor[i + 1] < vetor[i])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = aux;
                        movimentacoes++;
                    }
                }
                ImprimirVetor($"{passo} : ", vetor);
                Console.WriteLine($"    Comparações: {comparacoes}");
                totalComparacoes += comparacoes;
                totalMovimentacoes += movimentacoes;
            } while (movimentacoes > 1);

            Console.WriteLine("");
            Console.WriteLine("-- Resumo --");
            Console.WriteLine($"Nro de elementos  (n)  : {vetor.Length}");
            Console.WriteLine($"Qtde de passos    (p)  : {passo}");                    
            Console.WriteLine($"Comparações       (C)  : {totalComparacoes} = (n-1)*p = {vetor.Length-1}*{passo}");
            Console.WriteLine($"Movimentações     (M)  : {totalMovimentacoes}");            
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("** Vetor desordenado - caso médio **");
            //precisa de p passos e de (n-1)*p comparações
            BubbleSort(new int[] { 4, 7, 2, 9, 1, 6, 5, 3, 8 });

            Console.WriteLine("** Vetor já ordenado - melhor caso **");
            //precisa de pelo menos 1 passo e pelo menos (n-1)*1 comparações
            BubbleSort(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            Console.WriteLine("** Vetor ordenado decrescente - pior caso **");
            //precisa de n-1 passos e de (n-1)*(n-1) comparações
            BubbleSort(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 });

            Console.ReadKey();
        }
    }
}
