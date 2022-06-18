using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios02a06
{
    internal class Program
    {
        static int Potenc(int base1, int expoente) // Potência.
        {
            if (expoente == 0)
                return 1;

            else
                return base1 * Potenc(base1, expoente - 1);
        }
        static void Cubo(int base2, int numero) // Cubo.
        {
            if (base2 <= numero)
            {
                Console.WriteLine(base2 * base2 * base2);
                Cubo(base2 + 1, numero);
            }
        }
        static int MDC(int num0, int num1) // MDC.
        {
            if (num0 == num1)
                return num0;
            else if (num0 < num1)
                return MDC(num1, num0);
            else
                return MDC(num0 - num1, num1);
        }
        static int FibRec(int n) // Fibonacci Recursiva.
        {
            if (n == 0 || n == 1)
                return n;
            else
                return FibRec(n - 1) + FibRec(n - 2);
        }
     
        static void FibIter(int fim) // Fibonacci Iterativa.
        {
            Console.Write("Resultado Fibonacci Iterativa de {0}: ", fim);
            int num1, num2, soma, indice;
            num2 = 1;
            soma = 0;
            for (indice = 1; indice <= fim; indice++)
            {
                Console.Write("{0}, ", soma);
                num1 = num2;
                num2 = soma;
                soma = num1 + num2;
            }
            Console.Write("{0}.", soma);
            
        }
        static void Bin(int x) // Binário.
        {
            if (x != 0)
            {
                Bin(x / 2);
                Console.Write(x % 2);
            }
        }
        static void Main(string[] args)
        {
            int op = 635213565;
            
            while ((op >= 2 && op <= 8) || op == 635213565)
            {
                if (op == 635213565)
                {
                    Console.WriteLine("\n" +
                    "-------------------------------------\n" +
                    "- Exercícios 02 a 06 – Recursividde -\n" +
                    "-------------------------------------\n");
                    op = 2;
                }

                Console.WriteLine("\n" +
                "--------------- MENU ----------------\n" +
                "2. Exercício 2: Potência.\n" +
                "3. Exercício 3: Cubo.\n" +
                "4. Exercício 4: MDC.\n" +
                "5. Exercício 5a: Fibonacci Recursiva.\n" +
                "6. Exercício 5b: Fibonacci Iterativa.\n" +
                "7. Exercício 6: Binário.\n" +
                "8. Sair.\n" +
                "------ Digite a opção desejada ------");

                op = int.Parse(Console.ReadLine());
                if (op == 2)
                {
                    int base1, expoente;
                    Console.Write("Digite a base: ");
                    base1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o expoente: ");
                    expoente = int.Parse(Console.ReadLine());

                    int resultado = Potenc(base1, expoente);

                    Console.Write("Resultado de {0} elevado a {1}: {2}.", base1, expoente, resultado);
                }
                else if (op == 3)
                {
                    int numero;               
                    Console.Write("Digite um número: ");
                    numero = int.Parse(Console.ReadLine());

                    Cubo(1, numero);
                }
                else if (op == 4)
                {
                    int num0, num1;
                    Console.Write("Digite o primeiro número: ");
                    num0 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    num1 = int.Parse(Console.ReadLine());
                    int resultado = MDC(num0, num1);
                    Console.Write("O MDC de {0} e {1} é: {2}.", num0, num1, resultado);
                }
                else if (op == 5)
                {
                    int nFR;
                    Console.Write("Digite um número: ");
                    nFR = int.Parse(Console.ReadLine());

                    int resultado = FibRec(nFR);
                    Console.Write("Resultado Fibonacci Recursiva de {0}: {1}.", nFR, resultado);
                }
                else if (op == 6)
                {
                    int nFI;
                    Console.Write("Digite um número: ");
                    nFI = int.Parse(Console.ReadLine());
                    FibIter(nFI);
                }
                else if (op == 7)
                {
                    int nBin;
                    Console.Write("Digite um número: ");
                    nBin = int.Parse(Console.ReadLine());
                    
                    Console.Write("O binário de {0} é: ", nBin);
                    Bin(nBin);
                    Console.Write(".");
                }
                else if (op == 8)
                {
                    Console.WriteLine("Término da execuçao do programa.");
                    op = 9;
                }
            }
        }
    }
}