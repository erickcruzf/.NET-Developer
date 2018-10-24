using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 51480),
                new ContaCorrente(342, 52480),
                new ContaCorrente(340, 53480),
                new ContaCorrente(339, 54480),
                null,
                null,
                new ContaCorrente(290, 55480),
                new ContaCorrente(289, 50480)
            };

            // contas.Sort(); ~~> Chama a implementação dada em IComparable

            // contas.Sort(new ComparadorContaCorrentePorAgencia());

            var contasNaoNulas = contas.Where(conta => contas != null);

            IOrderedEnumerable<ContaCorrente> contasOrdenadas =
                contasNaoNulas.OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");                              
            }

            Console.ReadLine();
        }

        static void TestaSort()
        {
            var nomes = new List<string>()
            {
                "Igor", "Erick", "Caio", "Luiz", "Roger"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadLine();






            var idades = new List<int>();

            idades.Add(5);
            idades.Add(1);
            idades.Add(2);
            idades.Add(3);
            idades.Add(4);
            // idades.AddRange(new int[] { 1, 2, 3, 9 });

            // ListExtensoes.AdicionarVarios(idades, 1, 2, 3, 4, 5, 6, 7);

            // Método Extendido.

            idades.AdicionarVarios(1, 2, 3, 9);

            idades.Sort();

            // idades.Remove(1);

            var idadeSoma = 0;
            for (int i = 0; i < idades.Count; i++)
            {
                int idadeAtual = idades[i];
                idadeSoma += idadeAtual;
                Console.WriteLine(idades[i]);
            }
            // Console.WriteLine(idadeSoma);







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
            foreach (int numero in numeros)
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
