using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0004_DesafioOpcionalMultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 0004");
            for (int multiplo = 0; multiplo < 100; multiplo += 3)
            {
                Console.WriteLine(multiplo);
            }
            Console.ReadLine();
        }
    }
}
