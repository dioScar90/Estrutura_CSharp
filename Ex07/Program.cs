using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{

    // Enquanto não fim de frase
    // 	Enquanto não fim de palavra
    // 		Empilha caractere na pilha
    // 		Incrementa o passo
    // 	Fim enquanto
    // 	
    // 	Enquanto pilha não vazia
    // 		Remove um caractere da pilha
    // 		Concatena o caractere removido na nova frase
    // 	Fim enquanto
    // 	
    // 	Concatena espaço vazio na nova frase
    // 	Incrementa o passo
    // Fim enquanto

    public class Program
    {
        const int MAX = 20;
        static void Insere(char[] p, ref int t, char n)
        {
            p[t] = n;
            t++;
        }
        static char Remove(char[] p, ref int t)
        {
            t--;
            return (p[t]);
        }
        static bool EstaVazia(int t)
        {
            if (t == 0)
                return true;
            else
                return false;
        }
        static bool EstaCheia(int t)
        {
            if (t == MAX)
                return true;
            else
                return false;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("\n" +
            "--------------------------------------\n" +
            "---- Programa para inverter nomes ----\n" +
            "--------------------------------------\n");

            char[] pilha = new char[MAX];
            int topo = 0;
			int i= 0;
            Console.WriteLine("Escreva seu nome completo (por favor use somente letras e espaços):");
            string nome = Console.ReadLine();
            string invert = "";
            int tam = nome.Length;

            while (i < tam)
            {
                if (nome[i] != ' ')
                {
                    Insere(pilha, ref topo, nome[i]);
					i++;
                }
                else if(nome[i] == ' ')
                {
					while (!EstaVazia(topo))
                    {
                        char c = Remove(pilha, ref topo);
                        invert += c;
                    }
                    invert += ' ';
                    i++;
				}
            }

            if (i == tam)
            {
                while(!EstaVazia(topo))
                {
                    char c = Remove(pilha, ref topo);
                    invert += c;
                }
                i++;
            }

			Console.WriteLine("\nO nome \"{0}\" invertido é: {1}.", nome, invert);
        }
    }
}