using BlzMakeup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlzMakeup.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Produto> Destaques { get; set; }

        public IEnumerable<Produto> Todos { get; set; }
    }
}
