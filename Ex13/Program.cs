using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21
{
    class Program
    {
        class tp_no
        {
            public string dino;
            public tp_no prox, ant;
        }

        static void inserir(ref tp_no item1, string dino)
        {
            tp_no no = new tp_no();
            no.dino = dino;
            if (item1 != null) {
                no.prox = item1;
                item1.ant = no;
            }
            item1 = no;
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

        static void consultar(tp_no item1, string dinoToSearch, ref tp_no ant2, ref tp_no atual)
        {
            ant2 = null;
            atual = item1;
            while (atual != null && atual.dino != dinoToSearch)
            {
                ant2 = atual;
                atual = atual.prox;
            }
        }

        static void excluir(ref tp_no item1)
        {
            string dinoToSearch;
            char yesno;
            tp_no atual, ant2;
            ant2 = atual = null;
            
            Console.WriteLine("Desculpe você é o meteoro? Mas ok. Dinossauro para procurar: ");
            dinoToSearch = Console.ReadLine();
            
            consultar(item1, dinoToSearch, ref ant2, ref atual);
            
            if (atual != null)
            {
                Console.WriteLine("Dinossauro encontrado. Tem certeza disso? (S/N)");
                yesno = char.Parse(Console.ReadLine());

                if (yesno == 'S' || yesno == 's')
                {
                    if (atual == item1)
                    {
                        item1 = atual.prox;
                        atual.prox = null;
                    }
                    else if (atual.prox == null)
                    {
                        ant2.prox = null;
                    }
                    else
                    {
                        ant2.prox = atual.prox;
                        atual.prox = null;
                    }

                    Console.WriteLine("Ok, " + char.ToUpper(dinoToSearch[0]) + dinoToSearch.Substring(1).ToLower() + " extinto. Conseguiu. ¬¬\"");
                }
                else
                {
                    Console.WriteLine("Parabéns por tirar a mão do teclado e botar na consciência. Dinossauro não extinto.");
                }
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
            int op = 0;

            Console.WriteLine("\nQuantos dinossauros deseja cadastrar?");
            int max = int.Parse(Console.ReadLine());

            for (int i = 0, j = 1; i < max; i++, j++) {
                Console.WriteLine("\n" + j + "º dinossauro: ");
                dino = Console.ReadLine();

                inserir(ref item1, dino);
            }

            Console.Write("\nDinossauros cadastrados: \n");
            exibir(item1);

            Console.WriteLine("\nDeseja excluir algum dinossauro? (S/N)");
            char yesno = char.Parse(Console.ReadLine());

            if (yesno == 's' || yesno == 'S')
            {
                excluir(ref item1);

                Console.Write("\nDinossauros restantes: \n");
                exibir(item1);

                Console.WriteLine("\nNão gosto que pensem em extinguir meus dinossauros");
                Console.WriteLine("Isso é muito triste, estou encerrando o programa. Na próxima, melhore.");
            }
            else
            {
                Console.WriteLine("Obrigado. Término da execução do programa (pressione Enter para sair)...");
                Console.ReadKey();
            }
        }
    }
}