using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    // [null][null][null][null][null]
    //  ^ _proximaPosicao
    // [cont][null][null][null][null]
    //        ^ _proximaPosicao
    // [cont][cont][null][null][null](...)

    public class ListaDeObject
    {
        private object[] _itens;
        private int _proximaPosicao;

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }

        public ListaDeObject(int capacidadeInicial = 5)
        {
            _itens = new object[capacidadeInicial];
            _proximaPosicao = 0;
        }


        public void Adicionar(object item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            // Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }


        public void AdicionarVarios(params object[] itens)
        {
            foreach (object item in itens)
            {
                Adicionar(item);
            }
        }

        public void Remover(object item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                object itemAtual = _itens[i];

                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            // Quero remover o 0x02

            // [0x01] [0x02] [0x03] [null]
            //                       ^ _proximaPosicao
            //



            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {

                _itens[i] = _itens[i + 1];
            }


            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void EscreverListaNaTela()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                object conta = _itens[i];
            }
        }

        public object GetItemIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];

        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            // Console.WriteLine("Aumentando a capacidade da lista!");

            object[] novoArray = new object[novoTamanho];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
                // Console.WriteLine(".");
            }

            _itens = novoArray;
        }

        public object this[int indice]
        {
            get
            {
                return GetItemIndice(indice);
            }
        }
    }
}
