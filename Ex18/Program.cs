using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    class Program
    {
        class tp_no // Classe principal que terá ponteiro, prox, dados etc.
        {
            public string nome, sexo;
            public int idade;
            public tp_no prox;
        }

        static void inserir(ref tp_no t, string nome, int idade, string sexo)
        {
            tp_no no = new tp_no(); // Instanciar a classe principal como variável "no".
            no.nome = nome;
            no.idade = idade;
            no.sexo = sexo;
            if (t != null)
                no.prox = t;
            t = no;
        }

        static void excluir(ref tp_no t)
        {
            string n; // Variável que receberá o nome a ser pesquisado.
            char yesno; // Variável de string única (char) para confirmar (ou não) a exclusão.
            tp_no atual, ant; // Variáveis declaradas como tp_no para tbm poderem ter ponteiros (prox).
            ant = atual = null;
            
            Console.WriteLine("Nome para procurar: ");
            n = Console.ReadLine();
            
            consultar(t, n, ref ant, ref atual); // Chama a função que procura o nome.
            
            if (atual != null)
            {
                Console.WriteLine("Nome encontrado. Deseja realmente excluir? (S/N)");
                yesno = char.Parse(Console.ReadLine());

                if (yesno == 'S' || yesno == 's') // Condição para exclusão (ou não) do registro.
                {
                    if (atual == t)
                    {
                        t = atual.prox;
                        atual.prox = null;
                    }
                    else if (atual.prox == null)
                    {
                        ant.prox = null;
                    }
                    else
                    {
                        ant.prox = atual.prox;
                        atual.prox = null;
                    }

                    Console.WriteLine("Registro de " + n + " excluído.");
                }
                else
                {
                    Console.WriteLine("Registro não excluído.");
                }
            }
            else
            {
                Console.WriteLine("Nome não encontrado.");
            }
        }

        static void alterar(tp_no t)
        {
            string n; // Variável que receberá o nome a ser pesquisado.
            tp_no atual, ant; // Variáveis declaradas como tp_no para tbm poderem ter ponteiros (prox).
            ant = atual = null;

            Console.WriteLine("Nome para procurar: ");
            n = Console.ReadLine();
            
            consultar(t, n, ref ant, ref atual);

            if (atual != null)
            {
                Console.WriteLine("Dados atuais" +
                    "\nNome" + atual.nome +
                    "\nIdade" + atual.idade +
                    "\nSexo" + atual.sexo + ".");
                
                Console.WriteLine("\nNovos dados:");

                Console.WriteLine("Nome");
                atual.nome = Console.ReadLine();

                Console.WriteLine("Idade");
                atual.idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Sexo");
                atual.sexo = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Não encontrado.");
            }
        }

        static void consultar(tp_no t, string n, ref tp_no ant, ref tp_no atual)
        {
            ant = null;
            atual = t;
            while (atual != null && atual.nome != n)
            {
                ant = atual;
                atual = atual.prox;
            }
        }

        static void exibir(tp_no t)
        {
            tp_no mostrar = t;
            int i = 1;
            while (mostrar != null)
            {
                Console.WriteLine("\nRegistro " + i + ":" +
                    "\nNome: " + mostrar.nome + "." +
                    "\nIdade: " + mostrar.idade + "." +
                    "\nSexo: " + mostrar.sexo + ".");
                
                mostrar = mostrar.prox;
                i++;
            }
        }        
        
        static void Main(string[] args)
        {
            tp_no topo = null;
            int op = 0, idade, qtde;
            string nome, sexo;

            while (op != 5)
            {
                Console.WriteLine("\nPressione Enter para prosseguir...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("\n" +
                "---- MENU PRINCIPAL ----");
            
                Console.WriteLine("\nDigite a opção desejada:" +
                    "\n1. Cadastrar." + // inserir()
                    "\n2. Alterar." +   // a
                    "\n3. Exibir." +   // excluir()
                    "\n4. Excluir." +    // consultar()
                    "\n5. Sair." +
                    "\n");
                op = int.Parse(Console.ReadLine());
                
                if (op == 1)
                {
                    Console.WriteLine("\nQuantos nomes deseja cadastrar?");
                    qtde = int.Parse(Console.ReadLine());

                    while (qtde > 0)
                    {
                        //Console.Clear();

                        Console.WriteLine("\nNome: ");
                        nome = Console.ReadLine();

                        Console.WriteLine("Idade: ");
                        idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Sexo (M/F): ");
                        sexo = Console.ReadLine();

                        inserir(ref topo, nome, idade, sexo);
                        qtde--;
                        
                        //Console.Clear();
                    }
                }
                
                else if (op == 2)
                {
                    alterar(topo);
                }
                
                else if (op == 3)
                {
                    exibir(topo);

                }
                
                else if (op == 4)
                {
                    excluir(ref topo);
                }

                else
                {
                    // Console.WriteLine("\nOpção inválida. Por favor digite um número de 1 a 5.");
                    Console.WriteLine("Término da execução do programa.");
                    Console.WriteLine("Pressione Enter para sair...");
                    Console.ReadKey();
                }
            }
        }
    }
}