using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novos_projetos_repositorios
    {
    internal class Program
        {
        static void Main(string [] args)
            {
            Console.WriteLine("Entre com seu nome completo");
            Console.ReadLine();
            Console.WriteLine("Entre com o preço de um produto");
            Console.ReadLine();
            Console.WriteLine("Entre com seu último nome,idade e altura");
            string n = Console.ReadLine();
            string [] vet = n.Split(' ');
            string p1 = vet[0];
            int p2 = int.Parse(vet[1]);
            double p3 = double.Parse(vet [2]);
            Console.WriteLine(n);
            Console.ReadLine();
            }

        }
    }
