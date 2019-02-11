using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
    public class CarrosselViewModel
    { 
        public IList<Produto> Produtos { get; set; }

        public CarrosselViewModel()
        {
        }
        public CarrosselViewModel(IList<Produto> produtos)
        {
            this.Produtos = produtos;
        }
    }
}
