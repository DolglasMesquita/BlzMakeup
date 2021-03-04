
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlzMakeup.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Display(Name = "Nome categoria")]
        [Required(ErrorMessage = "Insira um nome para categoria")]
        public string CategoriaNome { get; set; }

        public List<Produto> Produto { get; set;  }

    }
}
