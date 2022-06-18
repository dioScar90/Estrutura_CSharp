using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22
{
    class Program
    {
        // 22) Implemente a lógica de uma lista encadeada com o conceito de fila, ou seja,
        // insira os nós no fim da lista e remova-os do início da lista.
        // ************************** Utilize duas variáveis (inicio e fim) para controlar os acessos a lista. **************************
        class tp_no
        {
            public string dino;
            public tp_no prox;
        }

        static void inserir(ref tp_no item1, string dino, ref int f)
        {
            tp_no no = new tp_no();
            no.dino = dino;
            if (item1 != null) {
                no.prox = item1;
            }
            item1 = no;
            f++;
        }

        static void exibir(tp_no item1)
        {
            tp_no mostrar = item1;
            
            while (mostrar != null)
            {
                Console.WriteLine("– " + char.ToUpper(mostrar.dino[0]) + mostrar.dino.Substring(1).ToLower() + ".");
                
                mostrar = mostrar.prox;
            }
        }

        static void consultar(tp_no item1, ref tp_no ant, ref tp_no atual, int f)
        {
            ant = null;
            atual = item1;
            
            // while (atual.prox != null)
            // {
            //     ant = atual;
            //     atual = atual.prox;
            // }
            for (int i = 1; i < f; i++)
            {
                ant = atual;
                atual = atual.prox;
            }
        }

        static void excluir(ref tp_no item1, ref int i, int f)
        {
            tp_no atual, ant;
            ant = atual = null;
            
            consultar(item1, ref ant, ref atual, f);
            
            if (atual != null && atual.prox == null)
            {
                ant.prox = null;
                i++;
            }
            
            else
            {
                Console.WriteLine("Dinossauro não encontrado.");
            }
        }
        
        static void Main(string[] args)
        {
            tp_no item1 = null;
            string dino;
            int inicio = 0, fim = 0;

            Console.WriteLine("\nQuantos dinossauros deseja cadastrar?");
            int max = int.Parse(Console.ReadLine());

            if (max > 0)
            {
                for (int i = 0, j = 1; i < max; i++, j++) {
                    Console.WriteLine("\n" + j + "º dinossauro: ");
                    dino = Console.ReadLine();

                    inserir(ref item1, dino, ref fim);
                }

                Console.Write("\nDinossauros cadastrados: \n");
                exibir(item1);

                Console.WriteLine("\nDeseja excluir um dinossauro? (S/N)");
                char yesno = char.Parse(Console.ReadLine());

                if (yesno == 's' || yesno == 'S')
                {
                    excluir(ref item1, ref inicio, fim);

                    Console.WriteLine("\nDinossauro mais antigo excluído:");
                    Console.WriteLine("\nDinossauros restantes:");
                    exibir(item1);

                    Console.WriteLine("\nTérmino da execução do programa (pressione Enter para sair)...");
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("\nTérmino da execução do programa (pressione Enter para sair)...");
                    Console.ReadKey();
                }
            }

            else
            {
                Console.WriteLine("\nAí você me quebra né meu parceiro..." +
                    "\nComece novamente e digite um número maior que 0." +
                    "\n" +
                    "\nTérmino da execução do programa.");
            }
        }
    }
}