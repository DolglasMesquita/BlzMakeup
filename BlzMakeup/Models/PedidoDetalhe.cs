using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlzMakeup.Models
{
    public class PedidoDetalhe
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual Pedido Pedido { get; set; } 
    }
}
