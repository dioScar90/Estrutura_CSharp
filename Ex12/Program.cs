using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
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
        }
    }
}