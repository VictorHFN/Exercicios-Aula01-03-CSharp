using System;
using System.ComponentModel;

namespace Aula3
{
    class Progam
    {
        static void Main(string[] args)
        {

            int[,] mat = new int[5, 5];
            int i, j, soma = 0;

            Console.WriteLine("Informe 9 numeros para matriz: ");

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Informe o valor do indice " + i + " , " + j);
                    mat[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("A matriz informada é: ");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        soma += mat[i, j];
                    }
                }
            }
            Console.WriteLine("A soma dos elementos na diagonal principal é: " + soma);
        }




        static void Main(string[] args)
        {
            int[] Vet = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe um valor");
                Vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                if (Vet[i] / 2 == 0)
                {
                    Console.WriteLine("Valor Par" + Vet[i]);
                }
                else
                {
                    Console.WriteLine("Valor impar" + Vet[i]);
                }
            }
        }


        static void Sain(string[] args)
        {
            int[] Vet = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Informe o primeiro valor");
                Vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 19; i >= 0; i--)
            {
                Console.WriteLine(Vet[i]);
            }
        }
    }
}