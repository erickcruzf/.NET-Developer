using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CaluculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                if (contadorMes != 1)
                {
                    Console.WriteLine("Após " + contadorMes + " meses, você terá RS$" + valorInvestido.ToString("c2"));
                }
                else
                {
                    Console.WriteLine("Após " + contadorMes + " mês, você terá RS$" + valorInvestido.ToString("c2"));
                }
            }

            Console.ReadLine();
        }
    }
}
