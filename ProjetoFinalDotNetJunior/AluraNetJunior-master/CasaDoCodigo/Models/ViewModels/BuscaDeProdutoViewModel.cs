using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
    public class BuscaDeProdutoViewModel
    {
        public string Pesquisa { get; set; }
        public IList<Produto> Produtos { get; set; }

        public BuscaDeProdutoViewModel()
        {
        }
        public BuscaDeProdutoViewModel(string pesquisa, IList<Produto> produtos)
        {
            this.Pesquisa = pesquisa;
            this.Produtos = produtos;
        }
    }
}
