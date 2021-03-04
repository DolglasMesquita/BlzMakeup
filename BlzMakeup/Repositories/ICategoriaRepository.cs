using System;
using BlzMakeup.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlzMakeup.Repositories
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
