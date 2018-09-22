using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 20;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
                mensagemAdicional = "João está acompanhado!";
            else
                mensagemAdicional = "João não está acompanhado.";

            if (idadeJoao >= 18 && acompanhado)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }

            Console.ReadLine();
        }
    }
}
