using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 96, 34, 2, 17, 23, 16, 56, 43 };
            //int[] vetor = { 96, 34 };
            Console.WriteLine("I: " + VetorToString(vetor));
            MergeSort(vetor);
            Console.WriteLine("F: " + VetorToString(vetor));
            Console.ReadKey();
        }

        static void MergeSort(int[] vetor)
        {
            string svetor = VetorToString(vetor);
            //Console.WriteLine(svetor);
            if (vetor.Length > 1)
            {
                //separação
                int tams = vetor.Length / 2;
                int[] subv1 = new int[tams];
                int[] subv2 = new int[tams];
                for (int i = 0; i < tams; i++)
                {
                    subv1[i] = vetor[i];
                    subv2[i] = vetor[i + tams];
                }
                string ssubv1 = VetorToString(subv1);
                string ssubv2 = VetorToString(subv2);                                
                if (subv1.Length > 1)
                {
                    Console.WriteLine(ssubv1);
                    MergeSort(subv1);
                }
                if (subv2.Length > 1)
                {
                    Console.WriteLine(ssubv2);
                    MergeSort(subv2);
                }
                ssubv1 = VetorToString(subv1);
                ssubv2 = VetorToString(subv2);
                Console.WriteLine(ssubv1);
                Console.WriteLine(ssubv2);
                //merge (junção)
                int a = 0;
                int b = 0;
                int x = 0;
                while (x < vetor.Length)
                {
                    if (b >= tams || (a < tams && subv1[a]<=subv2[b]))
                    {
                        vetor[x] = subv1[a];
                        a++;
                    }
                    else
                    {
                        vetor[x] = subv2[b];
                        b++;
                    }
                    x++;
                    svetor = VetorToString(vetor);
                }
                Console.WriteLine(svetor);
            }
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

        static string VetorToString(int[] vetor)
        {
            string aux = "";
            for (int i = 0; i < vetor.Length; i++)
            {
                aux += (aux.Length > 0 ? " | " : "") + vetor[i].ToString();
            }
            return "[ " + aux + " ]";
        }


    }
}
