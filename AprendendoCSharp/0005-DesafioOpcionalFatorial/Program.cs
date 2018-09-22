using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00005_DesafioOpcionalFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Exercício 0005");

            int fatorial = 1;
            for (int numero = 1; numero <= 10; numero++)
            {
                fatorial *= numero;
                Console.WriteLine("O fatorial de " + numero + " é (" + (int)(numero-1) + "!) * " + numero + " = " + fatorial + ".");
            }

            Console.ReadLine();
        }
    }
}
