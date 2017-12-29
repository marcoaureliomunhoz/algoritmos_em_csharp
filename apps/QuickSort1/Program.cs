using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort1
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Arranjo1();
            Arranjo2();

            Console.ReadKey();
        }

        static void Arranjo1()
        {
            Console.WriteLine("--Arranjo1--");

            Console.WriteLine("** Vetor desordenado - caso médio **");
            int[] vetor1 = { 25, 8, 57, 30, 48, 7, 12, 92, 33, 40 };
            ImprimirVetor("0: ", vetor1);
            QuickSort(vetor1, 0, vetor1.Length - 1);
            ImprimirVetor("1: ", vetor1);

            Console.WriteLine("");

            Console.WriteLine("** Vetor já ordenado - melhor caso **");
            int[] vetor2 = { 7, 8, 12, 25, 30, 33, 40, 48, 57, 92 };
            ImprimirVetor("0: ", vetor2);
            QuickSort(vetor2, 0, vetor2.Length - 1);
            ImprimirVetor("1: ", vetor2);

            Console.WriteLine("");

            Console.WriteLine("** Vetor ordenado decrescente - pior caso **");
            int[] vetor3 = { 92, 57, 48, 40, 33, 30, 25, 12, 8, 7 };
            ImprimirVetor("0: ", vetor3);
            QuickSort(vetor3, 0, vetor3.Length - 1);
            ImprimirVetor("1: ", vetor3);

            Console.WriteLine("");
        }

        static void Arranjo2()
        {
            Console.WriteLine("--Arranjo1--");

            Console.WriteLine("** Vetor desordenado - caso médio **");
            int[] vetor1 = { 7, 8, 7, 9, 1, 6, 10, 15, 6, 30, 100 };
            ImprimirVetor("0: ", vetor1);
            QuickSort(vetor1, 0, vetor1.Length - 1);
            ImprimirVetor("1: ", vetor1);

            Console.WriteLine("");

            Console.WriteLine("** Vetor já ordenado - melhor caso **");
            int[] vetor2 = { 1, 6, 6, 7, 7, 8, 9, 10, 15, 30, 100 };
            ImprimirVetor("0: ", vetor2);
            QuickSort(vetor2, 0, vetor2.Length - 1);
            ImprimirVetor("1: ", vetor2);

            Console.WriteLine("");

            Console.WriteLine("** Vetor ordenado decrescente - pior caso **");
            int[] vetor3 = { 100, 30, 15, 10, 9, 8, 7, 7, 6, 6, 1 };
            ImprimirVetor("0: ", vetor3);
            QuickSort(vetor3, 0, vetor3.Length - 1);
            ImprimirVetor("1: ", vetor3);

            Console.WriteLine("");
        }

        static void QuickSort(int[] vetor, int esq, int dir)
        {
            if (esq < dir)
            {
                int x = esq;
                int i = esq + 1;
                int j = dir;
                while (i <= j)
                {
                    while (vetor[i] <= vetor[x] && i < dir) i++;
                    while (vetor[j] >= vetor[x] && j > esq) j--;
                    if (i <= j)
                    {
                        Trocar(vetor, i, j);
                        if (i < j) j--;
                        i++;
                    }
                }
                Trocar(vetor, x, j);
                QuickSort(vetor, esq, j - 1);
                QuickSort(vetor, j + 1, dir);
            }
        }

        static void Trocar(int[] vetor, int p1, int p2)
        {
            int aux = vetor[p2];
            vetor[p2] = vetor[p1];
            vetor[p1] = aux;
        }

        static void ImprimirVetor(string sobre, int[] vetor)
        {
            string aux = "";
            for (int i = 0; i < vetor.Length; i++)
            {
                aux += (aux.Length > 0 ? " | " : "") + vetor[i].ToString();
            }
            Console.WriteLine(sobre + "[ " + aux + " ]");
        }
    }
}
