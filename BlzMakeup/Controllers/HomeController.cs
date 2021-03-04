using BlzMakeup.Models;
using BlzMakeup.Repositories;
using BlzMakeup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlzMakeup.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public HomeController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Destaques = _produtoRepository.Destaques,
                Todos = _produtoRepository.Produtos
            };  

            return View(homeViewModel);
        }

        public ViewResult AccessDenied()
        {
            return View();
        }

    }
}
