using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 9080908;
            contaDaGabriela.saldo = 80.924;

            Console.WriteLine("Conta: " + contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Numero: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo.ToString("c2"));

            Console.WriteLine("Processando. . . Aguarde um instante. . .");
            contaDaGabriela.saldo += 200;

            Console.WriteLine("Novo saldo: " + contaDaGabriela.saldo.ToString("c2"));

            Console.ReadLine();
        }
    }
}
