using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
    // ViewModel criada para retirar o código que não seja de exibição da página cshtml, e não precisar ser gravada no banco de dados como tabela do banco.
    public class CarrinhoViewModel
    {
        public CarrinhoViewModel(IList<ItemPedido> itens)
        {
            Itens = itens;
        }

        public IList<ItemPedido> Itens { get; }

        public decimal Total => Itens.Sum(i => i.Quantidade * i.PrecoUnitario);
    }
}
