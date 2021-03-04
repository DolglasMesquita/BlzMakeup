using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlzMakeup.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string DescricaoCurta { get; set; }

        [StringLength(400)]
        public string DescricaoDetalhada { get; set; }

        [Column(TypeName="decimal(18,2")]
        public decimal Preco { get; set; }

        [StringLength(200)]
        public string ImagemUrl { get; set; }

        [StringLength(200)]
        public string ImagemThumbnailUrl { get; set; } 
        public bool Destaque { get; set; }
        public bool Estoque { get; set; }

        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
