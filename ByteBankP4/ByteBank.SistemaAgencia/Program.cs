using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2018, 12, 10);

            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(70); //dataFimPagamento - dataCorrente;



            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);

            Console.WriteLine("Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca) + ".");

            Console.ReadLine();
        }
    }
}
