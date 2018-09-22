using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            double fatorRendimento = 0.0036;
            int contadorMes = 1;
            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * fatorRendimento;
                if (contadorMes != 1)
                {
                    Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido.ToString("C2"));
                }
                else
	            {
                    Console.WriteLine("Após " + contadorMes + " mês, você terá R$" + valorInvestido.ToString("C2"));
                }
                contadorMes++;
            }

            valorInvestido = valorInvestido + valorInvestido * fatorRendimento;

            Console.WriteLine("Após 1 mês, você terá R$" + valorInvestido.ToString("C2"));

            valorInvestido = valorInvestido + valorInvestido * fatorRendimento;

            Console.WriteLine("Após 2 meses, você terá R$" + valorInvestido.ToString("C2"));

            Console.ReadLine();
        }
    }
}
