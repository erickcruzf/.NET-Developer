using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch(Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }


            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {

            using (LeitorDeArquivo leitor = new LeitorDeArquivo("texte.txt"))
            {
 
                leitor.LerProximaLinha();
            }

            // -------------------------------------------------------

            //LeitorDeArquivo leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivo("contas1.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch(IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada");
            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finally");
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }

        private void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(456, 4578420);
                ContaCorrente conta2 = new ContaCorrente(432, 4230494);
                //conta1.Transferir(1000000000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);


                //Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.InnerException.StackTrace);
            }
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
                Console.WriteLine("Código depois do throw");
            }
        }


    }
}
