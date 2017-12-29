using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade_Fibonacci_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            FibonacciIterativo1(vetor1);
            ImprimirVetor("Iterativo: ", vetor1);

            int[] vetor2 = new int[10];
            FibonacciRecursivo1(vetor2);
            ImprimirVetor("Recursivo: ", vetor2);

            Console.WriteLine("");
            Console.WriteLine("Iterativo:");
            Console.WriteLine($"- Posição 1 => {FibonacciIterativo2(1)}"); //1
            Console.WriteLine($"- Posição 2 => {FibonacciIterativo2(2)}"); //1
            Console.WriteLine($"- Posição 3 => {FibonacciIterativo2(3)}"); //2
            Console.WriteLine($"- Posição 4 => {FibonacciIterativo2(4)}"); //3
            Console.WriteLine($"- Posição 5 => {FibonacciIterativo2(5)}"); //5
            Console.WriteLine($"- Posição 6 => {FibonacciIterativo2(6)}"); //8

            Console.WriteLine("");
            Console.WriteLine("Recursivo:");
            Console.WriteLine($"- Posição 1 => {FibonacciRecursivo2(1)}"); //1
            Console.WriteLine($"- Posição 2 => {FibonacciRecursivo2(2)}"); //1
            Console.WriteLine($"- Posição 3 => {FibonacciRecursivo2(3)}"); //2
            Console.WriteLine($"- Posição 4 => {FibonacciRecursivo2(4)}"); //3
            Console.WriteLine($"- Posição 5 => {FibonacciRecursivo2(5)}"); //5
            Console.WriteLine($"- Posição 6 => {FibonacciRecursivo2(6)}"); //8

            Console.ReadKey();
        }

        static void FibonacciIterativo1(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (i <= 1)
                {
                    vetor[i] = 1;
                }
                else
                {
                    vetor[i] = vetor[i - 1] + vetor[i - 2];
                }
            }
        }

        //Fn = Fn_1 + Fn_2

        static int FibonacciIterativo2(int nroElemento)
        {
            int fn = 1;
            int fn_1 = 0;
            int fn_2 = 0;
            for (int n = 1; n < nroElemento; n++)
            {
                if (n == 1)
                {
                    fn_1 = 1;
                    fn_2 = 0;
                    fn = fn_1 + fn_2;
                    fn_2 = fn_1;
                    fn_1 = fn;
                }
                else
                {
                    fn = fn_1 + fn_2;
                    fn_2 = fn_1;
                    fn_1 = fn;
                }
            }
            return fn;
        }

        static void FibonacciRecursivo1(int[] vetor, int i = 0)
        {
            if (i >= vetor.Length) return;

            if (i <= 1)
            {
                vetor[i] = 1;
            }
            else
            {
                vetor[i] = vetor[i - 1] + vetor[i - 2];
            }

            FibonacciRecursivo1(vetor, i + 1);
        }

        static int FibonacciRecursivo2(int n)
        {
            //caso trivial
            if (n == 1 || n == 2) return 1;

            //caso geral => subproblemas
            int r1 = FibonacciRecursivo2(n - 1);
            int r2 = FibonacciRecursivo2(n - 2);

            //processa os retornos dos subproblemas
            return r1 + r2;

            //ou simplesmente
            //return FibonacciRecursivo2(n - 1) + FibonacciRecursivo2(n - 2);
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
