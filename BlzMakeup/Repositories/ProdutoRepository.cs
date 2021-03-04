using BlzMakeup.Context;
using BlzMakeup.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlzMakeup.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
       private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> Produtos => _context.Produtos.Include(c => c.Categoria);

        public IEnumerable<Produto> Destaques => _context.Produtos.Where(p => p.Destaque).Include(c => c.Categoria);

        public Produto GetProdutoById(int produtoId)
        {
            return _context.Produtos.FirstOrDefault( p => p.Id == produtoId);
        }
    }
}
