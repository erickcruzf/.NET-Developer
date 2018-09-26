using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            // CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("922.423.242-12");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("234.123.244-92");
            roberta.Nome = "Roberta";

            GerenteDeConta camila = new GerenteDeConta("429.239.932-13");
            camila.Nome = "Camila";

            Auxiliar igor = new Auxiliar("230.032.003-30");
            igor.Nome = "Igor";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(igor);

            Console.WriteLine("Total de Bonificações do mês: R$" + gerenciadorBonificacao.GetTotalBonificacao());
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("234.123.244-92");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            sistemaInterno.Logar(roberta, "123");

            GerenteDeConta camila = new GerenteDeConta("429.239.932-13");
            camila.Nome = "Camila";
            camila.Senha = "234";

            sistemaInterno.Logar(camila, "234");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");
        }
    }
}
