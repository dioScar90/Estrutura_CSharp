using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19
{
    class Program
    {
        class tp_no
        {
            public int num;
            public tp_no prox;
        }

        static void inserir(ref tp_no item1, int[] numeros)
        {
            int i = 0;
            inserirRecursiva(ref item1, numeros, i);
        }

        static void inserirRecursiva(ref tp_no item1, int[] numeros, int i)
        {
            tp_no no = new tp_no();

            if (i < numeros.Length)
            {                
                if (item1 != null)
                    no.prox = item1;
                no.num = numeros[i];                
                item1 = no;
                inserirRecursiva(ref item1, numeros, ++i);
            }            
        }

        static void exibir(tp_no item1, int[] numeros)
        {
            tp_no mostrar = item1;
            int i = numeros.Length;
            while (mostrar != null)
            {
                Console.WriteLine(i + "º número: " + mostrar.num + ".");
                mostrar = mostrar.prox;
                i--;
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("\nQuantos números deseja cadastrar?");
            int max = int.Parse(Console.ReadLine());

            int[] numeros = new int[max];
            int maior = 0, menor = 0, totalMedia = 0, media;

            for (int i = 0, j = 0; i < max; i++)
            {
                Console.WriteLine("\n{0}º número: ", ++j);
                numeros[i] = int.Parse(Console.ReadLine());

                maior = i > 0 && numeros[i] > maior ? maior = numeros[i] : maior = numeros[i];
                menor = i > 0 && numeros[i] < menor ? menor = numeros[i] : menor = numeros[i];
                
                totalMedia += numeros[i];
            }

            media = totalMedia / numeros.Length;

            tp_no item1 = null;
            int op = 0;

            inserir(ref item1, numeros);

            while (op != 5)
            {
                Console.WriteLine("\nPressione Enter para prosseguir...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("\n" +
                    "\n------- MENU PRINCIPAL -------" +
                    "\nDigite a opção desejada:" +
                    "\n1. Exibir o maior número." +
                    "\n2. Exibir o menor número." +
                    "\n3. Exibir a média dos números." +
                    "\n4. Exibir todos os números." +
                    "\n5. Sair." +
                    "\n");
                op = int.Parse(Console.ReadLine());
                
                if (op == 1)
                {
                    Console.WriteLine("Maior número: {0}.", maior);
                }
                
                else if (op == 2)
                {
                    Console.WriteLine("Menor número: {0}.", menor);
                }
                
                else if (op == 3)
                {
                    Console.WriteLine("Média: {0}.", media);
                }
                
                else if (op == 4)
                {
                    Console.Write("\nNúmeros do vetor: ");
                    for (int k = 0; k < max; k++)
                    {
                        Console.Write(numeros[k]);
                        if (k < max-1)
                        {
                            Console.Write(", ");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }

                    Console.WriteLine("\nNúmeros da lista encadeada (em ordem decrescente):");
                    exibir(item1, numeros);
                }

                else
                {
                    Console.WriteLine("Término da execução do programa (pressione Enter para sair)...");
                    Console.ReadKey();
                }
            }
        }
    }
}