using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();

            idades.Adicionar(5);
            idades.AdicionarVarios(1, 3, 4);

            int idadeSoma = 0;
            for (int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
                idadeSoma += idadeAtual;
            }
            Console.WriteLine(idadeSoma);







            Console.ReadLine();
                                                                              

            Console.WriteLine(SomarVarios(1, 2, 3, 5, 56465, 45));

            Console.ReadLine();
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.AdicionarVarios(16, 17, 23, 20, 32);
            listaDeIdades.Adicionar("qualquer texto");

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];

                Console.WriteLine($"Idade no indice {i}: {idade}");
            }

            Console.ReadLine();
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach(int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(111, 1111111);

            lista.Adicionar(contaDoGui);
            lista.Adicionar(new ContaCorrente(874, 5754095));
            lista.Adicionar(new ContaCorrente(874, 5754096));
            lista.Adicionar(new ContaCorrente(874, 5754097));
            lista.Adicionar(new ContaCorrente(874, 5754095));
            lista.Adicionar(new ContaCorrente(874, 5754096));
            lista.Adicionar(new ContaCorrente(874, 5754097));
            lista.Adicionar(new ContaCorrente(874, 5754095));
            lista.Adicionar(new ContaCorrente(874, 5754096));
            lista.Adicionar(new ContaCorrente(874, 5754097));

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5754095),
                new ContaCorrente(874, 5754096)
            };

            lista.AdicionarVarios(contas);
            lista.AdicionarVarios
            (
                contaDoGui,
                new ContaCorrente(874, 5754095),
                new ContaCorrente(874, 5754096)
            );

            //lista.EscreverListaNaTela();

            //lista.Remover(contaDoGui);

            //lista.EscreverListaNaTela();

            for (int i = 0; i < lista.Tamanho; i++)
            {

                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 46348302),
                new ContaCorrente(874, 46344504),
                new ContaCorrente(874, 46348303)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice + 1} Ag: {contaAtual.Agencia} Número: {contaAtual.Numero}");
            }

            Console.ReadLine();
        }

        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 5 posições!

            int[] idades = new int[6];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 21;
            idades[5] = 60;

            int media = 0;

            for (int indice = 0; indice < idades.Length; indice++)
            {
                media += idades[indice];
            }
            media /= idades.Length;

            Console.WriteLine(idades.Length);

            Console.WriteLine($"Média de idades: {media}");

            Console.ReadLine();
        }
    }
}
