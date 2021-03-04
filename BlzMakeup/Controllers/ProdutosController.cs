using BlzMakeup.Models;
using BlzMakeup.Repositories;
using BlzMakeup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlzMakeup.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public ProdutosController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult List(string categoria)
        {
            IEnumerable<Produto> produtos;
            string categoriaAtual = string.Empty;

            var categorias = _categoriaRepository.Categorias;

            if (string.IsNullOrEmpty(categoria))
            {
                produtos = _produtoRepository.Produtos.OrderBy(p => p.Id);
            }
            else
            {


                produtos = _produtoRepository.Produtos.Where(p => p.Categoria.CategoriaNome.ToLower().Equals(categoria.ToLower())).OrderBy(p => p.Nome);

                categoriaAtual = categoria;

            }


            var produtosListViewModel = new ProdutosListViewModel
            {
                Produtos = produtos,
                CategoriaAtual = categoria
            };

            return View(produtosListViewModel);
        }

        public IActionResult Details(int id)
        {
            var produto = _produtoRepository.Produtos.FirstOrDefault(p => p.Id == id);

            if (produto == null)
            {
                return View("~/Views/Shared/Error.cshtml");
            }

            return View(produto);
        }

        public IActionResult Search(string searchString)
        {
            IEnumerable<Produto> produtos;
            string _categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(searchString))
            {
                produtos = _produtoRepository.Produtos.OrderBy(p => p.Id);
            }
            else
            {
                produtos = _produtoRepository.Produtos.Where(p => p.Nome.ToLower().Contains(searchString.ToLower()));
            }

            return View("~/Views/Produtos/List.cshtml", new ProdutosListViewModel { Produtos=produtos, CategoriaAtual="Todos os Produtos"});
        }

    }
}
