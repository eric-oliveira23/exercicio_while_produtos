using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            double total=0, valor;
            string resp="S";
            while (resp == "S")
            {
                Console.WriteLine("Digite o valor do produto");
                 valor = double.Parse(Console.ReadLine());

                total += valor;

                Console.WriteLine("Deseja inserir um novo produto?");
                resp = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("O valor total da compra é " + total);
            Console.ReadKey();
        }    
    }
}
