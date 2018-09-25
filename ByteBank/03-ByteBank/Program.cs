using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDoJoao = new ContaCorrente();
            contaDoJoao.titular = "Gabriela";
            contaDoJoao.agencia = 863;
            contaDoJoao.numero = 863452;

            Console.WriteLine(contaDaGabriela == contaDoJoao); //False comaparação de referência

            Console.WriteLine(5 == 5); //True comparação de valor

            contaDaGabriela = contaDoJoao;
            contaDaGabriela.saldo += 300;

            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDoJoao.saldo);

            if (contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }

            Console.ReadLine();
        }
    }
}