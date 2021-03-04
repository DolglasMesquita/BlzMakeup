using System;
using BlzMakeup.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlzMakeup.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }
        IEnumerable<Produto> Destaques { get; }
        Produto GetProdutoById(int produtoId);
    }
}
