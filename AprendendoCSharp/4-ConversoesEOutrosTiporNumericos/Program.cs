using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiporNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double teste = 30.1;

            Console.WriteLine((int)teste);

            double salario = 1200.50;

            int salarioEmInteiro = (int)salario;

            long idade = 1300000000000000000;

            Console.WriteLine(idade);

            int idade3 = 2147483647;

            Console.WriteLine(idade3);

            short idade2 = 32767;

            Console.WriteLine(idade2);

            float idade4 = 1.50f;

            Console.WriteLine(idade4);

            Console.WriteLine(salarioEmInteiro);

            Console.WriteLine("Pressione enter para continuar.");

            Console.ReadLine();
        }
    }
}
