using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25
{
    class Program
    {
        class tp_no
        {
            public tp_no esq;
            public int valor;
            public tp_no dir;
        }

        static void Insere(ref tp_no r, int x)
        {
            if (r == null)
            {
                r = new tp_no();
                r.valor = x;
            }
            else if (x < r.valor)
                Insere(ref r.esq, x);
            else
                Insere(ref r.dir, x);
        }

        static tp_no Busca(tp_no r, int x)
        {
            if (r == null)
                return null;
            else if (x == r.valor)
                return r;
            else if (x < r.valor)
                return Busca(r.esq, x);
            else
                return Busca(r.dir, x);
        }

        static tp_no RetornaMaior(ref tp_no r)
        {
            if (r.dir == null)
            {
                tp_no p = r;
                r = r.esq;
                return p;
            }
            else
                return RetornaMaior(ref r.dir);
        }

        static tp_no Remove(ref tp_no r, int x)
        {
            if (r == null)
                return null;     
            else if (x == r.valor)
            {       
                tp_no p = r;
                if (r.esq == null)
                    r = r.dir;
                else if (r.dir == null)
                    r = r.esq;
                else
                {
                    p = RetornaMaior(ref r.esq);
                    r.valor = p.valor;
                }
                return p;
            }
            else if (x < r.valor)
                return Remove(ref r.esq, x);
            else
                return Remove(ref r.dir, x);
        }

        static void EmOrdem(tp_no r)
        {
            if (r != null)
            {
                EmOrdem(r.esq);
                Console.WriteLine(r.valor);
                EmOrdem(r.dir);
            }
        }

        static void PreOrdem(tp_no r)
        {
            if (r != null)
            {
                Console.WriteLine(r.valor);
                PreOrdem(r.esq);
                PreOrdem(r.dir);
            }
        }

        static void PosOrdem(tp_no r)
        {
            if (r != null)
            {
                PosOrdem(r.esq);
                PosOrdem(r.dir);
                Console.WriteLine(r.valor);
            }
        }

        static void Main(string[] args)
        {
            tp_no raiz = null;
            int op = 0, num = 0;

            while (op != 5)
            {
                if (op != 0) // Para não aparecer na 1ª inicialização.
                {
                    Console.WriteLine("\nPressione Enter para prosseguir...");
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine("\n" +
                "---- MENU PRINCIPAL ----");
            
                Console.WriteLine("\nDigite a opção desejada:" +
                    "\n1. Inserir." +
                    "\n2. Pesquisar." +
                    "\n3. Remover." +
                    "\n4. Exibir." +
                    "\n5. Sair." +
                    "\n");
                op = int.Parse(Console.ReadLine());
                
                if (op == 1)
                {
                    Console.WriteLine("Digite um número:");
                    num = int.Parse(Console.ReadLine());
                    
                    Insere(ref raiz, num);                    
                }
                
                else if (op == 2)
                {
                    Console.WriteLine("Digite qual número deseja pesquisar:");
                    num = int.Parse(Console.ReadLine());
                    
                    tp_no toSearch = Busca(raiz, num);
                    
                    if (toSearch == null)
                    {
                        Console.WriteLine("Número não encontrado.");
                    }
                    else
                    {
                        Console.WriteLine("Número " + num + " encontrado.");
                    }
                }
                
                else if (op == 3)
                {
                    Console.WriteLine("Digite qual número deseja pesquisar:");
                    num = int.Parse(Console.ReadLine());
                    
                    tp_no toSearch = Busca(raiz, num); // Fazer 1º a busca para ver se existe.
                    
                    if (toSearch == null) // Se não existe...
                    {
                        Console.WriteLine("Número não encontrado.");
                    }
                    else // Se existe...
                    {
                        Console.WriteLine("Número encontrado. Deseja realmente excluir " + num + "? (S/N)");
                        char yesno = char.Parse(Console.ReadLine());

                        if (yesno == 'S' || yesno == 's')
                        {
                            tp_no toRemove = Remove(ref raiz, num); // Chama função para remover.

                            if (toRemove == null) // Se não encontrado...
                            {
                                Console.WriteLine("Número não excluído");
                            }
                            else // Se encontrado...
                            {
                                Console.WriteLine("Número " + num + " excluído.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número não excluído.");
                        }
                    }

                }
                
                else if (op == 4)
                {
                    if (raiz == null) // Caso ainda não haja árvore...
                    {
                        Console.WriteLine("Não será possível exibir pois ainda não existe uma árvore.");
                    }
                    else // Caso haja árvore...
                    {
                        Console.WriteLine("Digite a opção desejada:" +
                            "\n1. Exibir em ordem." +
                            "\n2. Exibir em pré-ordem." +
                            "\n3. Exibir em pós-ordem.");
                        int toShow = int.Parse(Console.ReadLine());

                        if (toShow == 1)
                        {
                            Console.WriteLine();
                            EmOrdem(raiz);
                        }
                        else if (toShow == 2)
                        {
                            Console.WriteLine();
                            PreOrdem(raiz);
                        }
                        else if (toShow == 3)
                        {
                            Console.WriteLine();
                            PosOrdem(raiz);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida.");
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Término da execução do programa.");
                    Console.WriteLine("Pressione Enter para sair...");
                    Console.ReadKey();
                }
            }
        }
    }
}