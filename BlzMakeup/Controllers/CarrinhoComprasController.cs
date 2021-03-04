using BlzMakeup.Models;
using BlzMakeup.Repositories;
using BlzMakeup.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlzMakeup.Controllers
{
    public class CarrinhoComprasController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoComprasController(IProdutoRepository produtoRepository, CarrinhoCompra carrinhoCompra)
        {
            _produtoRepository = produtoRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        [Authorize]
        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoComprasItens = itens;

            var carrinhoCompraViewModel = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal(),
            };

            return View(carrinhoCompraViewModel);
        }

        public RedirectToActionResult AdicionarItemNoCarrinhoCompra(int id)
        {

            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.Id == id);

            if (produtoSelecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(produtoSelecionado, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult AumentarQuantidadeItem(int id)
        {
            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.Id == id);
            _carrinhoCompra.AumentarQuantidade(produtoSelecionado);

            return RedirectToAction("Index");
        }

        public RedirectToActionResult DiminuirQuantidadeItem(int id)
        {
            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.Id == id);
            _carrinhoCompra.DiminuirQuantidade(produtoSelecionado);

            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemDoCarrinhoCompra(int id)
        {
            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.Id == id);

            if (produtoSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(produtoSelecionado);
            }

            return RedirectToAction("Index");
        }
    }
}
