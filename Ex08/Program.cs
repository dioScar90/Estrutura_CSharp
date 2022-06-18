using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    public class Program
    {
        const int MAX = 20;

        static void Insere(int[] q, ref int f, int v)
        {
            q[f] = v;
            f++;
        }

        static int Remove(int[] q, ref int i)
        {
            return (q[i++]);
        }


        static bool EstaVazia(int i, int f)
        {
            if (i == f)
                return true;
            else
                return false;
        }

        static bool EstaCheia(int f)
        {
            if (f == MAX)
                return true;
            else
                return false;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("\n" +
            "---------------------------------------\n" +
            "---- Programa para inserir números ----\n" +
            "---------------------------------------\n");

            int[] fila = new int[MAX];
            int inicio = 0, fim = 0, num = 0, a = 0;

            Console.WriteLine("Insira alguns números ou \"0\" para parar:");
            string aux = Console.ReadLine();
            num = int.Parse(aux);
            int maior = num, menor = num;

            while (num != 0)
            {
                if (!EstaCheia(fim))
                {
                    if (num > maior)
                    {
                        maior = num;
                    }
                    else if (num < menor)
                    {
                        menor = num;
                    }

                    Insere(fila, ref fim, num);
                    a++;
                }
                string aux1 = Console.ReadLine();
                num = int.Parse(aux1);
            }
            if (num == 0)
            {
                Console.WriteLine("Obrigado.");
            }

            int aux2 = 0, soma = 0;
            float media = 0;

            Console.Write("\nNúmeros informados: ");
            while (a > 0)
            {
                aux2 = Remove(fila, ref inicio);
                Console.Write(aux2);
                soma += aux2;
                a--;
                if (a > 0)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write(".");
                }
            }

            media = soma / fim;

            Console.WriteLine("\nMédia aritmética: {0}.", media);
            Console.WriteLine("Maior número: {0}.", maior);
            Console.WriteLine("Menor número: {0}.", menor);

            Console.WriteLine("\nTérmino da execução do programa........\n");
        }
    }
}