using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entendo o Equals(object)

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "548.233.942-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "548.233.942-03";
            carlos_2.Profissao = "Designer";

            ContaCorrente teste = new ContaCorrente(454, 4848426);

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais.");
            }
            else
            {
                Console.WriteLine("Não são iguais.");
            }

            Console.ReadLine();

            // Analisando Console.WriteLine("Olá, mundo");

            //""Olá, mundo" é uma string
            //WriteLine é um método público estático
            // Console é uma classe pública

            //public static void WriteLine(string argumento)
            //{
            // implementação
            //}

            // Analisando Console.WriteLine(123);

            //public static void WriteLine(int argumento)
            //{
            // implementação
            //}

            // Analisando Console.WriteLine(10.5);

            //public static void WriteLine(double argumento)
            //{
            // implementação
            //}

            // Analisando Console.WriteLine(true);

            //public static void WriteLine(bool argumento)
            //{
            // implementação
            //}

            ContaCorrente conta = new ContaCorrente(456, 687876);
            Console.WriteLine($"Resultado: {conta}");
            string contaToString = conta.ToString();
            Console.WriteLine(contaToString);

            Console.ReadLine();





            // Testanto expressões regulares.
            string padrao =
"[0-9]{4,5}(-?| )[0-9]{4}";
            string textoDeTeste = "Meu nome é Erick, me ligue 4434 4034";
            Console.WriteLine(Regex.Match(textoDeTeste, padrao));
            Console.ReadLine();
                                                                              
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceBytebank = urlTeste.IndexOf("https://www.bytebank.com/");

            bool isBytebank = urlTeste.StartsWith("https://www.bytebank.com");

            //Console.WriteLine(urlTeste.Contains("bytebank"));
            //Console.WriteLine(urlTeste.EndsWith("https://www.bytebank.com"));
            Console.WriteLine(isBytebank);
            Console.WriteLine(isBytebank);
            Console.ReadLine();








            //moedaOrigem=real&moedaDestino=dolar
            //
            // ---------

            string urlParametros = "https://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valorDestino = extratorDeValores.GetValor("moedaDestino");
            string valorOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Conversão de " + valorOrigem + " para " + valorDestino + ".");

            Console.WriteLine(extratorDeValores.GetValor("Valor"));

            Console.ReadLine();

            // Testando ToLower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(termoBusca.ToUpper());
            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca.ToUpper()));

            // Testando Replace

            termoBusca = termoBusca.Replace("r", "R");
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace("a", "A");
            Console.WriteLine(termoBusca);
            Console.ReadLine();                                   
                                   
            //string urlParametros = "https://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            //ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            //string valorDestino = extratorDeValores.GetValor("moedaDestino");
            //string valorOrigem = extratorDeValores.GetValor("moedaOrigem");
            //Console.WriteLine("Conversão de " + valorOrigem + " para " + valorDestino + ".");

            //Console.WriteLine(extratorDeValores.GetValor("valor"));

            //Console.ReadLine();


            // Testando método Remove
            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf("&");
            Console.WriteLine(testeRemocao.Remove(indiceEComercial));
            Console.ReadLine();
            
            // <nome>=<valor>
            
            string palavra = "moedaDestino=real";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string " + nomeArgumento.Length);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();







            // Testando o IsNullOrEmpty
            string textoVazio = null;

            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.ReadLine();

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(null);

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf("?") + 1;

            Console.WriteLine(url);

            string argumentos = url.Substring(indiceInterrogacao);

            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }
}
